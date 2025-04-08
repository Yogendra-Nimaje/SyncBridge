<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_AddDevice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Pic_QRCode = New PictureBox()
        Btn_RegenrateCode = New Guna.UI2.WinForms.Guna2Button()
        Label1 = New Label()
        CType(Pic_QRCode, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Pic_QRCode
        ' 
        Pic_QRCode.Location = New Point(442, 89)
        Pic_QRCode.Name = "Pic_QRCode"
        Pic_QRCode.Size = New Size(350, 350)
        Pic_QRCode.SizeMode = PictureBoxSizeMode.StretchImage
        Pic_QRCode.TabIndex = 0
        Pic_QRCode.TabStop = False
        ' 
        ' Btn_RegenrateCode
        ' 
        Btn_RegenrateCode.BorderRadius = 5
        Btn_RegenrateCode.CustomizableEdges = CustomizableEdges1
        Btn_RegenrateCode.DisabledState.BorderColor = Color.DarkGray
        Btn_RegenrateCode.DisabledState.CustomBorderColor = Color.DarkGray
        Btn_RegenrateCode.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Btn_RegenrateCode.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Btn_RegenrateCode.FillColor = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        Btn_RegenrateCode.Font = New Font("Segoe UI", 9.0F)
        Btn_RegenrateCode.ForeColor = Color.White
        Btn_RegenrateCode.Image = My.Resources.Resources.refresh
        Btn_RegenrateCode.ImageAlign = HorizontalAlignment.Left
        Btn_RegenrateCode.ImageOffset = New Point(10, 0)
        Btn_RegenrateCode.Location = New Point(533, 465)
        Btn_RegenrateCode.Name = "Btn_RegenrateCode"
        Btn_RegenrateCode.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Btn_RegenrateCode.Size = New Size(177, 53)
        Btn_RegenrateCode.TabIndex = 4
        Btn_RegenrateCode.Text = "Regenrate QR"
        Btn_RegenrateCode.TextAlign = HorizontalAlignment.Left
        Btn_RegenrateCode.TextOffset = New Point(10, 0)
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 8.0F)
        Label1.Location = New Point(423, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(386, 21)
        Label1.TabIndex = 5
        Label1.Text = "Scan the QR form your mobile to Connect New Device"
        ' 
        ' frm_AddDevice
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1481, 652)
        Controls.Add(Label1)
        Controls.Add(Btn_RegenrateCode)
        Controls.Add(Pic_QRCode)
        FormBorderStyle = FormBorderStyle.None
        Name = "frm_AddDevice"
        Text = "frm_AddDevice"
        CType(Pic_QRCode, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Pic_QRCode As PictureBox
    Friend WithEvents Btn_RegenrateCode As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
End Class
