Imports System.Net
Imports System.IO
Imports System.Threading
Imports Newtonsoft.Json
Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports FireSharp.Response

Public Class SimpleHttpServer
    Public Shared url As String
    Private server As HttpListener
    Private serverThread As Thread
    Private Running As Boolean = False
    Private sshProcess As Process ' Added for SSH process
    Dim client As IFirebaseClient
    Dim fsc As New FirebaseConfig With {
            .AuthSecret = "JEES1CTNYACYQFKfGLD3FAM0zhDHMIeVpwkMtGL2",
            .BasePath = "https://my-application-8dd80-default-rtdb.firebaseio.com/"
        }

    Public Sub StartServer()
        If Not Running Then
            server = New HttpListener()
            server.Prefixes.Add("http://127.0.0.1:8080/")
            serverThread = New Thread(AddressOf HandleRequests)
            serverThread.IsBackground = True
            Running = True
            server.Start()
            serverThread.Start()

            ' Start SSH tunnel
            StartSSHTunnel()
            initFirebase()

        End If
    End Sub

    Private Sub initFirebase()

        Try
            client = New FireSharp.FirebaseClient(fsc)
            If client Is Nothing Then
                MessageBox.Show("Failed to connect to Firebase.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error Occurred: " & ex.Message)
        End Try

    End Sub


    Public Sub StopServer()
        If Running Then
            Running = False
            server.Close()
            server = Nothing

            ' Kill SSH process if running
            If sshProcess IsNot Nothing AndAlso Not sshProcess.HasExited Then
                sshProcess.Kill()
                sshProcess.Dispose()
            End If
        End If
    End Sub

    Private Sub StartSSHTunnel()
        Try
            Dim startInfo As New ProcessStartInfo()
            startInfo.FileName = "ssh"
            startInfo.Arguments = "-R 80:127.0.0.1:8080 ssh.localhost.run"
            startInfo.RedirectStandardOutput = True
            startInfo.UseShellExecute = False
            startInfo.CreateNoWindow = True

            sshProcess = New Process()
            sshProcess.StartInfo = startInfo
            AddHandler sshProcess.OutputDataReceived, AddressOf SSHTunnelOutputHandler ' Corrected event handler
            sshProcess.Start()
            sshProcess.BeginOutputReadLine()
        Catch ex As Exception
            Console.WriteLine("Error starting SSH tunnel: " & ex.Message)
        End Try
    End Sub

    Private Sub SSHTunnelOutputHandler(sender As Object, e As DataReceivedEventArgs)
        If Not String.IsNullOrEmpty(e.Data) Then
            ' Look for the specific tunnel URL pattern
            If e.Data.Contains("tunneled with tls termination") Then
                Dim urlStart As Integer = e.Data.IndexOf("https://")
                If urlStart >= 0 Then
                    Dim urlEnd As Integer = e.Data.Length
                    Dim tunnelUrl As String = e.Data.Substring(urlStart, urlEnd - urlStart).Trim()

                    url = tunnelUrl
                    ' Show MessageBox with the URL
                    MessageBox.Show($"AccessUrl: {tunnelUrl}", "Tunnel URL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    UpdateSessionAccessUrls(tunnelUrl, "Online")
                End If
            End If
            Console.WriteLine("SSH Output: " & e.Data)
        End If
    End Sub

    Public Sub UpdateSessionAccessUrls(tunnelUrl As String, status As String)
        If client Is Nothing Then
            MessageBox.Show("Firebase client not initialized.")
            Return
        End If

        Try
            ' Get the current user's UID from My.Settings
            Dim userId As String = My.Settings.UID
            If String.IsNullOrEmpty(userId) Then
                MessageBox.Show("User ID not found in settings.")
                Return
            End If

            ' Path to user's CreatedSessions
            Dim createdSessionsPath As String = $"Users/{userId}/Sessions/CreatedSession"

            ' Fetch all CreatedSession IDs
            Dim response As FirebaseResponse = client.Get(createdSessionsPath)
            If response.StatusCode = Net.HttpStatusCode.OK Then
                ' Deserialize the response into a Dictionary (key-value pairs of session references)
                Dim createdSessions As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(response.Body)

                If createdSessions IsNot Nothing Then
                    For Each sessionEntry In createdSessions
                        Dim sessionId As String = sessionEntry.Value ' The session ID (e.g., "7a3a092f-d576-4006-9faf-817b8af37687")

                        ' Path to the specific session
                        Dim sessionPath As String = $"Sessions/{sessionId}"

                        ' Update the accessUrl field
                        Dim updateData = New With {
                            .accessUrl = tunnelUrl,
                            .status = status
                        }


                        Dim updateResponse As FirebaseResponse = client.Update(sessionPath, updateData)
                        If updateResponse.StatusCode = Net.HttpStatusCode.OK Then
                            Console.WriteLine($"Successfully updated accessUrl for session {sessionId} to {tunnelUrl}")
                        Else
                            Console.WriteLine($"Failed to update session {sessionId}. Status: {updateResponse.StatusCode}")
                        End If
                    Next
                Else
                    Console.WriteLine("No created sessions found for user " & userId)
                End If
            Else
                MessageBox.Show($"Failed to fetch CreatedSessions. Status: {response.StatusCode}")
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating sessions: " & ex.Message)
        End Try
    End Sub

    Private Sub HandleRequests()
        While Running
            Try
                Dim context As HttpListenerContext = server.GetContext()
                Dim response As HttpListenerResponse = context.Response
                Dim request As HttpListenerRequest = context.Request

                Select Case request.Url.AbsolutePath
                    Case "/"
                        SendServerInfo(response)
                    Case "/listdrives"
                        If request.HttpMethod = "GET" Then ListDrives(response) Else SendError(response, "Method not allowed", 405)
                    Case "/listfiles"
                        If request.HttpMethod = "POST" Then ListFiles(request, response) Else SendError(response, "Method not allowed", 405)
                    Case "/fileinfo"
                        If request.HttpMethod = "POST" Then FileInfo(request, response) Else SendError(response, "Method not allowed", 405)
                    Case "/download"
                        If request.HttpMethod = "POST" Then DownloadFile(request, response) Else SendError(response, "Method not allowed", 405)
                    Case "/stream" ' New streaming endpoint
                        If request.HttpMethod = "POST" Then StreamFile(request, response) Else SendError(response, "Method not allowed", 405)
                    Case Else
                        SendError(response, "Endpoint not found", 404)
                End Select
            Catch ex As Exception
                If Running Then Console.WriteLine("Error: " & ex.Message)
            End Try
        End While
    End Sub

    ' ✅ Server Information
    Private Sub SendServerInfo(response As HttpListenerResponse)
        Dim info = New With {
            .ServerName = "File System Server",
            .Version = "1.0",
            .Status = "Running"
        }
        SendJsonResponse(response, info)
    End Sub

    ' ✅ List all available drives
    Private Sub ListDrives(response As HttpListenerResponse)
        Try
            Dim drives = DriveInfo.GetDrives().Where(Function(d) d.IsReady).Select(Function(d) New With {
                .Name = d.Name,
                .Type = "Drive",
                .Path = d.Name,
                .Size = d.TotalSize,
                .AvailableSpace = d.AvailableFreeSpace
            }).ToList()
            SendJsonResponse(response, drives)
        Catch ex As Exception
            SendError(response, "Error listing drives", 500)
        End Try
    End Sub

    ' ✅ List all files and directories in a given path
    Private Sub ListFiles(request As HttpListenerRequest, response As HttpListenerResponse)
        Try
            If Not request.HasEntityBody Then
                SendError(response, "Request body is empty", 400)
                Return
            End If

            Dim reader As New StreamReader(request.InputStream)
            Dim requestBody As String = reader.ReadToEnd()
            Dim body As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(requestBody)

            If Not body.ContainsKey("Path") Then
                SendError(response, "Missing 'Path' parameter", 400)
                Return
            End If

            Dim folderPath As String = body("Path")

            If Not Directory.Exists(folderPath) Then
                SendError(response, "Directory not found", 404)
                Return
            End If

            Dim accessibleEntries As New List(Of Object)()
            For Each dirPath As String In Directory.GetDirectories(folderPath)
                Try
                    Dim dirInfo As New DirectoryInfo(dirPath)
                    accessibleEntries.Add(New With {
                        .Name = Path.GetFileName(dirPath),
                        .Type = "Directory",
                        .Path = dirPath,
                        .Size = 0,
                        .SubFolderCount = dirInfo.GetDirectories().Length,
                        .isFolder = True
                    })
                Catch ex As UnauthorizedAccessException
                    Console.WriteLine($"Skipped directory: {dirPath} - Access denied")
                End Try
            Next

            For Each filePath As String In Directory.GetFiles(folderPath)
                Try
                    Dim fileInfo As New FileInfo(filePath)
                    accessibleEntries.Add(New With {
                        .Name = Path.GetFileName(filePath),
                        .Type = "File",
                        .Path = filePath,
                        .Size = fileInfo.Length,
                        .SubFolderCount = 0,
                        .isFolder = False
                    })
                Catch ex As UnauthorizedAccessException
                    Console.WriteLine($"Skipped file: {filePath} - Access denied")
                End Try
            Next

            SendJsonResponse(response, accessibleEntries)
        Catch ex As UnauthorizedAccessException
            SendError(response, "Access to the directory is denied", 403)
        Catch ex As Exception
            SendError(response, "An error occurred while listing files", 500)
        End Try
    End Sub

    ' ✅ Get file information
    Private Sub FileInfo(request As HttpListenerRequest, response As HttpListenerResponse)
        Try
            If Not request.HasEntityBody Then
                SendError(response, "Request body is empty", 400)
                Return
            End If

            Dim reader As New StreamReader(request.InputStream)
            Dim requestBody As String = reader.ReadToEnd()
            Dim body As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(requestBody)

            If Not body.ContainsKey("FilePath") Then
                SendError(response, "Missing 'FilePath' parameter", 400)
                Return
            End If

            Dim filePath As String = body("FilePath")

            If Not File.Exists(filePath) Then
                SendError(response, "File not found", 404)
                Return
            End If

            Dim fileInfo As New FileInfo(filePath)
            Dim result = New With {
                .FileName = fileInfo.Name,
                .Size = fileInfo.Length,
                .CreationTime = fileInfo.CreationTime,
                .LastAccessTime = fileInfo.LastAccessTime,
                .Path = fileInfo.FullName
            }

            SendJsonResponse(response, result)
        Catch ex As UnauthorizedAccessException
            SendError(response, "Access to the file is denied", 403)
        Catch ex As Exception
            SendError(response, "An error occurred while retrieving file info", 500)
        End Try
    End Sub

    ' ✅ Download a file
    Private Sub DownloadFile(request As HttpListenerRequest, response As HttpListenerResponse)
        Try
            Console.WriteLine("DownloadFile: Received request")
            If Not request.HasEntityBody Then
                SendError(response, "Request body is empty", 400)
                Return
            End If

            ' Read request body
            Dim reader As New StreamReader(request.InputStream)
            Dim requestBody As String = reader.ReadToEnd()
            Console.WriteLine("DownloadFile: Request body: " & requestBody)

            ' Parse JSON
            Dim body As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(requestBody)
            Dim filePath As String = body("FilePath")
            Console.WriteLine("DownloadFile: Requested file path: " & filePath)

            ' Check file existence
            If Not File.Exists(filePath) Then
                Console.WriteLine("DownloadFile: File not found: " & filePath)
                SendError(response, "File not found", 404)
                Return
            End If

            Dim fileInfo As New FileInfo(filePath)
            Console.WriteLine("DownloadFile: File size: " & fileInfo.Length & " bytes")

            ' Set response headers
            response.StatusCode = 200
            response.ContentType = "application/octet-stream"
            response.ContentLength64 = fileInfo.Length
            response.AddHeader("Content-Disposition", "attachment; filename=""" & Path.GetFileName(filePath) & """")

            ' Send file synchronously with progress
            Console.WriteLine("DownloadFile: Sending file...")
            Dim buffer(8192 - 1) As Byte
            Dim totalBytesSent As Long = 0

            Using fs As New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read)
                Dim bytesRead As Integer
                Do
                    bytesRead = fs.Read(buffer, 0, buffer.Length)
                    If bytesRead > 0 Then
                        response.OutputStream.Write(buffer, 0, bytesRead)
                        response.OutputStream.Flush() ' Ensure bytes are sent immediately
                        totalBytesSent += bytesRead
                        Console.WriteLine("DownloadFile: Sent " & totalBytesSent & " of " & fileInfo.Length & " bytes")
                        Thread.Sleep(100) ' Small delay to simulate network conditions and ensure sync
                    End If
                Loop While bytesRead > 0
            End Using

            Console.WriteLine("DownloadFile: File sent successfully")
        Catch ex As Exception
            Console.WriteLine("DownloadFile: Error: " & ex.Message)
            SendError(response, "Server error: " & ex.Message, 500)
        Finally
            response.Close()
            Console.WriteLine("DownloadFile: Response closed")
        End Try
    End Sub


    ' ✅ Stream a file (e.g., video or audio)
    Private Sub StreamFile(request As HttpListenerRequest, response As HttpListenerResponse)
        Try
            If Not request.HasEntityBody Then
                SendError(response, "Request body is empty", 400)
                Return
            End If

            Dim reader As New StreamReader(request.InputStream)
            Dim requestBody As String = reader.ReadToEnd()
            Dim body As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(requestBody)

            If Not body.ContainsKey("FilePath") Then
                SendError(response, "Missing 'FilePath' parameter", 400)
                Return
            End If

            Dim filePath As String = body("FilePath")

            If Not File.Exists(filePath) Then
                SendError(response, "File not found", 404)
                Return
            End If

            Dim fileInfo As New FileInfo(filePath)
            Dim fileLength As Long = fileInfo.Length

            ' Determine Content-Type based on file extension
            Dim contentType As String = GetContentType(filePath)
            response.ContentType = contentType

            ' Support for HTTP Range requests
            Dim rangeHeader As String = request.Headers("Range")
            Dim startByte As Long = 0
            Dim endByte As Long = fileLength - 1
            Dim bufferSize As Integer = 1024 * 64 ' 64KB chunks

            If Not String.IsNullOrEmpty(rangeHeader) AndAlso rangeHeader.StartsWith("bytes=") Then
                ' Parse Range header (e.g., "bytes=0-1023" or "bytes=1024-")
                Dim rangeParts() As String = rangeHeader.Substring(6).Split("-"c)
                startByte = If(String.IsNullOrEmpty(rangeParts(0)), 0, Long.Parse(rangeParts(0)))
                endByte = If(String.IsNullOrEmpty(rangeParts(1)), fileLength - 1, Long.Parse(rangeParts(1)))

                If startByte < 0 OrElse endByte >= fileLength OrElse startByte > endByte Then
                    SendError(response, "Invalid range requested", 416) ' Range Not Satisfiable
                    Return
                End If

                response.StatusCode = 206 ' Partial Content
                response.AddHeader("Content-Range", $"bytes {startByte}-{endByte}/{fileLength}")
                response.AddHeader("Content-Length", (endByte - startByte + 1).ToString())
            Else
                ' No Range header: send the entire file
                response.StatusCode = 200
                response.AddHeader("Content-Length", fileLength.ToString())
            End If

            ' Common headers for streaming
            response.AddHeader("Accept-Ranges", "bytes")
            response.AddHeader("Content-Disposition", $"inline; filename={Path.GetFileName(filePath)}")

            ' Stream the file
            Using fileStream As New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read)
                If startByte > 0 Then
                    fileStream.Seek(startByte, SeekOrigin.Begin)
                End If

                Dim bytesToRead As Long = endByte - startByte + 1
                Dim buffer(bufferSize - 1) As Byte
                Dim totalBytesRead As Long = 0

                While totalBytesRead < bytesToRead
                    Dim bytesToReadThisTime As Integer = Math.Min(bufferSize, CInt(bytesToRead - totalBytesRead))
                    Dim bytesRead As Integer = fileStream.Read(buffer, 0, bytesToReadThisTime)
                    If bytesRead = 0 Then Exit While ' End of file

                    response.OutputStream.Write(buffer, 0, bytesRead)
                    totalBytesRead += bytesRead
                End While
            End Using

            response.OutputStream.Close()
        Catch ex As UnauthorizedAccessException
            SendError(response, "Access to the file is denied", 403)
        Catch ex As Exception
            SendError(response, "An error occurred while streaming the file: " & ex.Message, 500)
        End Try
    End Sub

    ' ✅ Helper: Determine Content-Type based on file extension
    Private Function GetContentType(filePath As String) As String
        Dim extension As String = Path.GetExtension(filePath).ToLower()
        Select Case extension
            Case ".mp4"
                Return "video/mp4"
            Case ".mkv"
                Return "video/x-matroska"
            Case ".avi"
                Return "video/x-msvideo"
            Case ".mp3"
                Return "audio/mpeg"
            Case ".wav"
                Return "audio/wav"
            Case ".ogg"
                Return "audio/ogg"
            Case Else
                Return "application/octet-stream" ' Fallback
        End Select
    End Function

    ' ✅ Send JSON response
    Private Sub SendJsonResponse(response As HttpListenerResponse, data As Object)
        Try
            response.ContentType = "application/json"
            Dim json As String = JsonConvert.SerializeObject(data, Formatting.Indented)
            Using writer As New StreamWriter(response.OutputStream)
                writer.Write(json)
            End Using
            response.StatusCode = 200
            response.OutputStream.Close()
        Catch ex As Exception
            Console.WriteLine("Error sending JSON response: " & ex.Message)
        End Try
    End Sub

    ' ✅ Send error response
    Private Sub SendError(response As HttpListenerResponse, message As String, statusCode As Integer)
        Try
            response.StatusCode = statusCode
            Dim errorMessage As String = "{""Error"": """ & message & """}"
            Dim buffer As Byte() = System.Text.Encoding.UTF8.GetBytes(errorMessage)
            response.ContentLength64 = buffer.Length
            response.ContentType = "application/json"
            response.OutputStream.Write(buffer, 0, buffer.Length)
            response.OutputStream.Flush()
        Catch ex As Exception
            Console.WriteLine("SendError: Error sending response: " & ex.Message)
        Finally
            response.Close()
        End Try
    End Sub
End Class