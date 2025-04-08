Imports System.Drawing
Imports Newtonsoft.Json
Imports System.Management
Imports QRCoder


Public Class frm_AddDevice
    Private Sub frm_AddDevice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_RegenrateCode_Click(sender As Object, e As EventArgs) Handles Btn_RegenrateCode.Click
        CreateSession()
    End Sub


    Private Sub CreateSession()
        ' Generate a unique 12-digit Session ID
        Dim random As New Random()
        Dim sessionID As String = Guid.NewGuid().ToString()
        ' Get device name
        Dim deviceName As String = GetDeviceName()

        ' Create session object
        Dim session As New Dictionary(Of String, Object) From {
            {"SessionID", sessionID},
            {"OwnerUserID", "temp2"}, ' Replace with actual user ID
            {"ConnectedUserID", My.Settings.UID}, ' Replace with actual connected user ID
            {"DeviceType", "Laptop"},
            {"DeviceName", deviceName},
            {"Status", "Online"},
            {"AccessUrl", SimpleHttpServer.url},
            {"LastSyncTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}
        }

        ' Convert session object to JSON
        Dim jsonData As String = JsonConvert.SerializeObject(session, Formatting.Indented)

        ' Show QR code of the JSON
        showQR(jsonData)
    End Sub

    Private Function GetDeviceName() As String
        Try
            Dim mc As New ManagementClass("Win32_ComputerSystem")
            Dim moc As ManagementObjectCollection = mc.GetInstances()
            For Each mo As ManagementObject In moc
                Return mo("Name").ToString()
            Next
        Catch ex As Exception
            Return "Unknown"
        End Try
        Return "Unknown"
    End Function

    Private Sub showQR(data As String)
        Try
            Dim gen As New QRCodeGenerator
            Dim qr = gen.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q)
            Dim code As New QRCode(qr)
            Pic_QRCode.Image = code.GetGraphic(6)
        Catch ex As Exception
            MessageBox.Show("Error generating QR Code: " & ex.Message)
        End Try
    End Sub



End Class