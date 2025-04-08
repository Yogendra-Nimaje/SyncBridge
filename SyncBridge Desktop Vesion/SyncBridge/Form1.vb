Imports System.Drawing.Drawing2D

Public Class Form1
    Private server As SimpleHttpServer
    Private Sub Pnl_MouseHover(sender As Object, e As EventArgs) Handles Pnl_Dashboard.MouseHover, Pnl_ConnectedDevice.MouseHover, Pnl_AddDevice.MouseHover, Pnl_Profile.MouseHover, Pnl_Setting.MouseHover, Pnl_Supports.MouseHover
        Dim panel As Guna.UI2.WinForms.Guna2ShadowPanel = CType(sender, Guna.UI2.WinForms.Guna2ShadowPanel)
        panel.FillColor = Color.FromArgb(31, 41, 55)
    End Sub

    Private Sub Pnl_MouseLeave(sender As Object, e As EventArgs) Handles Pnl_Dashboard.MouseLeave, Pnl_ConnectedDevice.MouseLeave, Pnl_AddDevice.MouseLeave, Pnl_Profile.MouseLeave, Pnl_Setting.MouseLeave, Pnl_Supports.MouseLeave
        Dim panel As Guna.UI2.WinForms.Guna2ShadowPanel = CType(sender, Guna.UI2.WinForms.Guna2ShadowPanel)
        panel.FillColor = Color.Black
    End Sub

    Private Sub Pnl_Dashboard_Click(sender As Object, e As EventArgs) Handles Pnl_Dashboard.Click
        addForm(New frm_Dashboard)
    End Sub

    Private Sub Pnl_Profile_Click(sender As Object, e As EventArgs) Handles Pnl_Profile.Click
        addForm(New frm_Profile)
    End Sub

    Private Sub addForm(ByRef form As Form)
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None

        form.Width = Pnl_Container.Width - 100

        ' Height adjusts to content
        form.Height = form.Height

        ' Position with 50px padding from the left and top
        form.Location = New Point(20, 20)

        Dim radius As Integer = 10
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, radius * 2, radius * 2, 180, 90) ' Top-left corner
        path.AddArc(form.Width - (radius * 2), 0, radius * 2, radius * 2, 270, 90) ' Top-right
        path.AddArc(form.Width - (radius * 2), form.Height - (radius * 2), radius * 2, radius * 2, 0, 90) ' Bottom-right
        path.AddArc(0, form.Height - (radius * 2), radius * 2, radius * 2, 90, 90) ' Bottom-left
        path.CloseFigure()

        form.Region = New Region(path)

        ' Add form to panel
        Pnl_Container.Controls.Clear()
        Pnl_Container.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Pnl_Setting_Click(sender As Object, e As EventArgs) Handles Pnl_Setting.Click
        addForm(New frm_setting)
    End Sub

    Private Sub Pnl_AddDevice_Click(sender As Object, e As EventArgs) Handles Pnl_AddDevice.Click
        addForm(New frm_AddDevice)
    End Sub

    Private Sub Pnl_ConnectedDevice_Click(sender As Object, e As EventArgs) Handles Pnl_ConnectedDevice.Click
        addForm(frm_ConnectedDevice)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(My.Settings.UID) Then
            Dim loginForm As New frm_Login()
            If loginForm.ShowDialog() = DialogResult.OK Then
                MessageBox.Show("Welcome back! UID: " & My.Settings.UID)
                addForm(New frm_Dashboard)
                StartServer()
            Else
                ' Close the app if login failed or canceled
                Application.Exit()
            End If
        Else
            MessageBox.Show("Welcome back! UID: " & My.Settings.UID)
            addForm(New frm_Dashboard)
            StartServer()

        End If
    End Sub

    Private Sub StartServer()
        Try
            server = New SimpleHttpServer()
            server.StartServer()
            MsgBox("Server started successfully!", MsgBoxStyle.Information, "Server Status")
        Catch ex As Exception
            MsgBox("Error starting the server: " & ex.Message, MsgBoxStyle.Critical, "Server Error")
        End Try
    End Sub

    Sub StopServer()
        Try
            server.UpdateSessionAccessUrls("", "Offline")
            If server IsNot Nothing Then
                server.StopServer()
                MsgBox("Server stopped successfully!", MsgBoxStyle.Information, "Server Status")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            e.Cancel = True ' Prevent form from closing
        Else
            StopServer()
        End If
    End Sub

End Class