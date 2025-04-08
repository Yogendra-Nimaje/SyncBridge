<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConnectedDevice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        Label2 = New Label()
        Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Pnl_ConnectedDevice = New Panel()
        Label3 = New Label()
        Btn_AddDevice = New Guna.UI2.WinForms.Guna2Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Pnl_ConnectedDevice.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Guna2CircleButton1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(38, 41)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(632, 104)
        Panel1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(135, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(302, 28)
        Label2.TabIndex = 3
        Label2.Text = "Connected • Last sync 2 mins ago"
        ' 
        ' Guna2CircleButton1
        ' 
        Guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray
        Guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2CircleButton1.Font = New Font("Segoe UI", 9F)
        Guna2CircleButton1.ForeColor = Color.White
        Guna2CircleButton1.Location = New Point(116, 62)
        Guna2CircleButton1.Name = "Guna2CircleButton1"
        Guna2CircleButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CircleButton1.Size = New Size(16, 16)
        Guna2CircleButton1.TabIndex = 2
        Guna2CircleButton1.Text = "Guna2CircleButton1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(109, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 32)
        Label1.TabIndex = 1
        Label1.Text = "MacBook Pro"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.menu_dots
        PictureBox1.Location = New Point(23, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(80, 80)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Pnl_ConnectedDevice
        ' 
        Pnl_ConnectedDevice.Controls.Add(Panel1)
        Pnl_ConnectedDevice.Location = New Point(24, 110)
        Pnl_ConnectedDevice.Name = "Pnl_ConnectedDevice"
        Pnl_ConnectedDevice.Size = New Size(1270, 273)
        Pnl_ConnectedDevice.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(24, 33)
        Label3.Name = "Label3"
        Label3.Size = New Size(219, 32)
        Label3.TabIndex = 2
        Label3.Text = "Connected Device"
        ' 
        ' Btn_AddDevice
        ' 
        Btn_AddDevice.BorderRadius = 5
        Btn_AddDevice.CustomizableEdges = CustomizableEdges2
        Btn_AddDevice.DisabledState.BorderColor = Color.DarkGray
        Btn_AddDevice.DisabledState.CustomBorderColor = Color.DarkGray
        Btn_AddDevice.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Btn_AddDevice.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Btn_AddDevice.FillColor = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        Btn_AddDevice.Font = New Font("Segoe UI", 9F)
        Btn_AddDevice.ForeColor = Color.White
        Btn_AddDevice.Image = My.Resources.Resources.add
        Btn_AddDevice.ImageAlign = HorizontalAlignment.Left
        Btn_AddDevice.ImageOffset = New Point(10, 0)
        Btn_AddDevice.Location = New Point(1036, 33)
        Btn_AddDevice.Name = "Btn_AddDevice"
        Btn_AddDevice.ShadowDecoration.CustomizableEdges = CustomizableEdges3
        Btn_AddDevice.Size = New Size(166, 53)
        Btn_AddDevice.TabIndex = 3
        Btn_AddDevice.Text = "Add Device"
        Btn_AddDevice.TextAlign = HorizontalAlignment.Left
        Btn_AddDevice.TextOffset = New Point(10, 0)
        ' 
        ' frm_ConnectedDevice
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1340, 753)
        Controls.Add(Btn_AddDevice)
        Controls.Add(Label3)
        Controls.Add(Pnl_ConnectedDevice)
        Name = "frm_ConnectedDevice"
        Text = "frm_ConnectedDevice"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Pnl_ConnectedDevice.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Pnl_ConnectedDevice As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_AddDevice As Guna.UI2.WinForms.Guna2Button
End Class
