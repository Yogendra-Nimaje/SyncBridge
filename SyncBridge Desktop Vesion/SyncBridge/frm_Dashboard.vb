Imports System.IO
Imports Guna.UI2.WinForms

Public Class frm_Dashboard
    Private Sub frm_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDeviceDrives()
    End Sub

    Private Sub LoadDeviceDrives()
        Dim drives As DriveInfo() = DriveInfo.GetDrives()
        Dim columnCount As Integer = 2
        Dim rowCount As Integer = Math.Ceiling(drives.Length / columnCount)
        Dim drivePanelWidth As Integer = 450
        Dim drivePanelHeight As Integer = 300
        Dim spacing As Integer = 20

        ' Clear previous controls
        Pnl_DeviceDrives.Controls.Clear()

        ' Adjust Pnl_DeviceDrives height
        Pnl_DeviceDrives.Height = (drivePanelHeight + spacing) * rowCount + spacing

        ' Variables for overall storage calculation
        Dim totalStorage As Double = 0
        Dim usedStorage As Double = 0

        For i As Integer = 0 To drives.Length - 1
            If drives(i).IsReady Then
                Dim driveTotal As Double = drives(i).TotalSize / (1024 ^ 3) ' Convert bytes to GB
                Dim driveUsed As Double = (drives(i).TotalSize - drives(i).AvailableFreeSpace) / (1024 ^ 3)

                ' Accumulate total and used storage
                totalStorage += driveTotal
                usedStorage += driveUsed

                Dim usedPercentage As Integer = CInt((driveUsed / driveTotal) * 100)
                Dim totalSizeFormatted As String = If(driveTotal >= 1024, String.Format("{0} TB", CInt(driveTotal / 1024)), String.Format("{0} GB", CInt(driveTotal)))

                ' Drive Panel
                Dim drivePanel As New Guna2ShadowPanel With {
                    .Size = New Size(drivePanelWidth, drivePanelHeight),
                    .Location = New Point((i Mod columnCount) * (drivePanelWidth + spacing), (i \ columnCount) * (drivePanelHeight + spacing)),
                    .FillColor = Color.White,
                    .Radius = 12,
                    .ShadowColor = Color.Black
                }

                ' Drive Label
                Dim lblDriveName As New Label With {
                    .Text = "Local Disk (" + drives(i).Name + ")",
                    .Font = New Font("Segoe UI Semibold", 14, FontStyle.Bold),
                    .Location = New Point(30, 30),
                    .AutoSize = True
                }

                ' Progress Bar
                Dim progressBar As New Guna2CircleProgressBar With {
                    .Size = New Size(170, 170),
                    .Location = New Point(30, 90),
                    .ProgressThickness = 20,
                    .ProgressColor = Color.Black,
                    .ProgressColor2 = Color.Black,
                    .FillColor = Color.LightGray,
                    .Value = usedPercentage
                }

                ' Used Storage Label
                Dim lblStorageUsed As New Label With {
                    .Text = usedPercentage.ToString() & "% Used",
                    .Font = New Font("Segoe UI", 16, FontStyle.Bold),
                    .Location = New Point(250, 130),
                    .AutoSize = True
                }

                ' Total Storage Label
                Dim lblTotalStorage As New Label With {
                    .Text = "Used of " & totalSizeFormatted,
                    .Font = New Font("Segoe UI", 12),
                    .Location = New Point(250, 180),
                    .AutoSize = True
                }

                ' Add controls to panel
                drivePanel.Controls.Add(lblDriveName)
                drivePanel.Controls.Add(progressBar)
                drivePanel.Controls.Add(lblStorageUsed)
                drivePanel.Controls.Add(lblTotalStorage)

                ' Add panel to main panel
                Pnl_DeviceDrives.Controls.Add(drivePanel)
            End If
        Next

        ' Calculate overall used percentage
        Dim overallUsedPercentage As Integer = If(totalStorage > 0, CInt((usedStorage / totalStorage) * 100), 0)
        Dim totalSizeFormattedOverall As String = If(totalStorage >= 1024, String.Format("{0} TB", CInt(totalStorage / 1024)), String.Format("{0} GB", CInt(totalStorage)))

        ' Determine storage status
        Dim status As String
        If overallUsedPercentage < 50 Then
            status = "Good"
        ElseIf overallUsedPercentage < 80 Then
            status = "Moderate"
        Else
            status = "Full"
        End If

        Lbl_TotalUsage.Text = overallUsedPercentage.ToString() & "%"
        Lbl_TotalStorage.Text = "Used of " + totalSizeFormattedOverall
        Lbl_Status.Text = status
    End Sub

End Class
