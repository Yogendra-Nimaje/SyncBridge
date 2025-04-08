Public Class frm_ConnectedDevice
    ' Custom renderer for modern menu styling
    Private Class ModernMenuRenderer
        Inherits ToolStripProfessionalRenderer
        Public Sub New()
            MyBase.New(New ModernColorTable())
        End Sub

        Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)
            Dim item = CType(e.Item, ToolStripMenuItem)
            Dim rect = e.Item.Bounds
            If item.Selected Then
                ' Gradient hover effect
                Using brush As New Drawing2D.LinearGradientBrush(rect, Color.FromArgb(240, 240, 245), Color.FromArgb(220, 220, 230), Drawing2D.LinearGradientMode.Vertical)
                    e.Graphics.FillRectangle(brush, rect)
                End Using
            Else
                ' Normal background
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(250, 250, 252)), rect)
            End If
        End Sub

        Protected Overrides Sub OnRenderToolStripBorder(e As ToolStripRenderEventArgs)
            ' Draw a subtle border with rounded corners
            Dim rect = e.ToolStrip.ClientRectangle
            rect.Inflate(-1, -1)
            Using pen As New Pen(Color.FromArgb(200, 200, 200), 1)
                e.Graphics.DrawPath(pen, GetRoundedRect(rect, 8))
            End Using
        End Sub

        ' Helper to create rounded rectangle path
        Private Function GetRoundedRect(rect As Rectangle, radius As Integer) As Drawing2D.GraphicsPath
            Dim path As New Drawing2D.GraphicsPath()
            Dim diameter As Integer = radius * 2
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90)
            path.AddArc(rect.Width - diameter, rect.Y, diameter, diameter, 270, 90)
            path.AddArc(rect.Width - diameter, rect.Height - diameter, diameter, diameter, 0, 90)
            path.AddArc(rect.X, rect.Height - diameter, diameter, diameter, 90, 90)
            path.CloseFigure()
            Return path
        End Function
    End Class

    ' Custom color table for the renderer
    Private Class ModernColorTable
        Inherits ProfessionalColorTable
        Public Overrides ReadOnly Property SeparatorDark As Color
            Get
                Return Color.FromArgb(210, 210, 215)
            End Get
        End Property

        Public Overrides ReadOnly Property MenuItemSelected As Color
            Get
                Return Color.FromArgb(230, 230, 235)
            End Get
        End Property
    End Class

    Private Sub frm_ConnectedDevice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Pnl_ConnectedDevice
            .AutoScroll = True
            .Padding = New Padding(10)
            .Location = New Point(0, 100)
            .Size = New Size(Me.ClientSize.Width, Me.ClientSize.Height - 100)
            .Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom
        End With
        LoadConnectedDevices()
    End Sub

    Private Sub LoadConnectedDevices()
        Pnl_ConnectedDevice.Controls.Clear()

        Dim devices As New List(Of (String, String)) From {
            ("MacBook Pro", "Connected • Last sync 2 mins ago"),
            ("iPhone 13", "Connected • Last sync 5 mins ago"),
            ("Samsung Galaxy S21", "Connected • Last sync 10 mins ago"),
            ("Dell XPS 15", "Connected • Last sync 20 mins ago"),
            ("MacBook Pro", "Connected • Last sync 2 mins ago"),
            ("iPhone 13", "Connected • Last sync 5 mins ago"),
            ("Samsung Galaxy S21", "Connected • Last sync 10 mins ago"),
            ("Dell XPS 15", "Connected • Last sync 20 mins ago"),
            ("MacBook Pro", "Connected • Last sync 2 mins ago"),
            ("iPhone 13", "Connected • Last sync 5 mins ago"),
            ("Samsung Galaxy S21", "Connected • Last sync 10 mins ago"),
            ("Dell XPS 15", "Connected • Last sync 20 mins ago"),
            ("Dell XPS 15", "Connected • Last sync 20 mins ago"),
            ("Dell XPS 15", "Connected • Last sync 20 mins ago")
        }

        Dim initialOffset As Integer = 100
        Dim panelHeight As Integer = 100
        Dim totalContentHeight As Integer = (devices.Count * (panelHeight + 20))
        Dim needsScroll As Boolean = totalContentHeight > (Pnl_ConnectedDevice.ClientSize.Height - initialOffset)
        Dim yOffset As Integer = If(needsScroll, 10, initialOffset)

        For Each device In devices
            Dim panel As New Panel With {
                .Width = Pnl_ConnectedDevice.ClientSize.Width - 40,
                .Height = panelHeight,
                .Anchor = AnchorStyles.Left Or AnchorStyles.Right,
                .Padding = New Padding(10),
                .Margin = New Padding(10, 0, 10, 20),
                .BackColor = Color.White,
                .BorderStyle = BorderStyle.None,
                .Location = New Point(10, yOffset),
                .Tag = device
            }

            ' Rounded corners for panel
            Dim path As New Drawing2D.GraphicsPath()
            path.AddArc(0, 0, 16, 16, 180, 90)
            path.AddArc(panel.Width - 16, 0, 16, 16, 270, 90)
            path.AddArc(panel.Width - 16, panel.Height - 16, 16, 16, 0, 90)
            path.AddArc(0, panel.Height - 16, 16, 16, 90, 90)
            path.CloseFigure()
            panel.Region = New Region(path)

            Dim pictureBox As New PictureBox With {
                .Size = New Size(60, 60),
                .Location = New Point(30, 22),
                .BackColor = Color.Gray,
                .SizeMode = PictureBoxSizeMode.StretchImage
            }

            Dim lblName As New Label With {
                .Text = device.Item1,
                .Font = New Font("Segoe UI Semibold", 12, FontStyle.Regular),
                .Location = New Point(110, 20),
                .AutoSize = True
            }

            Dim lblStatus As New Label With {
                .Text = device.Item2,
                .Font = New Font("Segoe UI", 10, FontStyle.Regular),
                .Location = New Point(135, 55),
                .AutoSize = True,
                .ForeColor = Color.Gray
            }

            Dim statusIndicator As New Guna.UI2.WinForms.Guna2CircleButton With {
                .Size = New Size(16, 16),
                .Location = New Point(115, 62),
                .FillColor = Color.Green
            }

            Dim optionsButton As New PictureBox With {
                .Size = New Size(35, 30),
                .Location = New Point(panel.Width - 60, 35),
                .SizeMode = PictureBoxSizeMode.StretchImage,
                .Anchor = AnchorStyles.Right,
                .Cursor = Cursors.Hand,
                .Image = My.Resources.menu_dots,
                .Tag = panel
            }

            ' Create modern context menu
            Dim contextMenu As New ContextMenuStrip With {
                .Renderer = New ModernMenuRenderer(),
                .BackColor = Color.FromArgb(250, 250, 252), ' Slightly off-white for modern feel
                .Font = New Font("Segoe UI Semibold", 11), ' Bolder, larger font
                .DropShadowEnabled = True,
                .ShowImageMargin = False,
                .Width = 180, ' Increased width
                .Padding = New Padding(5) ' Adds internal spacing
            }

            ' Add menu items with custom styling
            Dim items As ToolStripItem() = {
                New ToolStripMenuItem("Rename") With {
                    .Padding = New Padding(15, 8, 15, 8), ' Increased padding for larger items
                    .ForeColor = Color.FromArgb(70, 70, 70)
                },
                New ToolStripMenuItem("Details") With {
                    .Padding = New Padding(15, 8, 15, 8),
                    .ForeColor = Color.FromArgb(70, 70, 70)
                },
                New ToolStripSeparator(),
                New ToolStripMenuItem("Disconnect") With {
                    .Padding = New Padding(15, 8, 15, 8),
                    .ForeColor = Color.FromArgb(70, 70, 70)
                },
                New ToolStripSeparator(),
                New ToolStripMenuItem("Delete") With {
                    .Padding = New Padding(15, 8, 15, 8),
                    .ForeColor = Color.FromArgb(255, 80, 80) ' Softer red
                }
            }

            ' Add hover effect to menu items
            For Each item As ToolStripMenuItem In items.OfType(Of ToolStripMenuItem)()
                AddHandler item.MouseEnter, Sub(s, e) CType(s, ToolStripMenuItem).ForeColor = Color.FromArgb(20, 20, 20)
                AddHandler item.MouseLeave, Sub(s, e)
                                                Dim menuItem = CType(s, ToolStripMenuItem)
                                                menuItem.ForeColor = If(menuItem.Text = "Delete", Color.FromArgb(255, 80, 80), Color.FromArgb(70, 70, 70))
                                            End Sub
            Next

            contextMenu.Items.AddRange(items)

            AddHandler contextMenu.ItemClicked, Sub(sender, e)
                                                    Dim menu = CType(sender, ContextMenuStrip)
                                                    Dim clickedPanel = CType(menu.Tag, Panel)
                                                    Dim deviceInfo = CType(clickedPanel.Tag, (String, String))
                                                    Select Case e.ClickedItem.Text
                                                        Case "Rename"
                                                            Dim newName As String = InputBox("Enter new device name:", "Rename Device", deviceInfo.Item1)
                                                            If Not String.IsNullOrEmpty(newName) Then
                                                                clickedPanel.Controls.OfType(Of Label)().First().Text = newName
                                                            End If
                                                        Case "Details"
                                                            MessageBox.Show($"Device: {deviceInfo.Item1}" & vbCrLf & $"Status: {deviceInfo.Item2}",
                                                                "Device Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                        Case "Disconnect"
                                                            MessageBox.Show($"Disconnecting {deviceInfo.Item1}...", "Disconnect")
                        ' Add disconnect logic here
                                                        Case "Delete"
                                                            If MessageBox.Show($"Are you sure you want to delete {deviceInfo.Item1}?",
                                                                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                                                                Pnl_ConnectedDevice.Controls.Remove(clickedPanel)
                                                                LoadConnectedDevices()
                                                            End If
                                                    End Select
                                                End Sub

            AddHandler optionsButton.Click, Sub(s, e)
                                                Dim btn = CType(s, PictureBox)
                                                Dim parentPanel = CType(btn.Tag, Panel)
                                                contextMenu.Tag = parentPanel
                                                contextMenu.Show(btn, New Point(0, btn.Height))
                                            End Sub

            panel.Controls.Add(pictureBox)
            panel.Controls.Add(lblName)
            panel.Controls.Add(lblStatus)
            panel.Controls.Add(statusIndicator)
            panel.Controls.Add(optionsButton)

            Pnl_ConnectedDevice.Controls.Add(panel)
            yOffset += panelHeight + 20
        Next

        Pnl_ConnectedDevice.AutoScrollMinSize = New Size(0, If(needsScroll, totalContentHeight + 10, totalContentHeight + initialOffset + 10))
    End Sub

    Private Sub frm_ConnectedDevice_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Pnl_ConnectedDevice.Size = New Size(Me.ClientSize.Width, Me.ClientSize.Height - 100)
        LoadConnectedDevices()

        For Each ctrl As Control In Pnl_ConnectedDevice.Controls
            If TypeOf ctrl Is Panel Then
                ctrl.Width = Pnl_ConnectedDevice.ClientSize.Width - 40
                For Each child As Control In ctrl.Controls
                    If TypeOf child Is PictureBox AndAlso child.Size.Width = 35 Then
                        child.Location = New Point(ctrl.Width - 60, child.Location.Y)
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub Btn_AddDevice_Click(sender As Object, e As EventArgs) Handles Btn_AddDevice.Click
        Dim popup As New QuickGuidePopup()
        popup.ShowDialog()
    End Sub
End Class

