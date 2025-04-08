<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuickGuidePopup
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
        PictureBox1 = New PictureBox()
        Btn_AddDevice = New Guna.UI2.WinForms.Guna2Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(357, 227)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Btn_AddDevice
        ' 
        Btn_AddDevice.Animated = True
        Btn_AddDevice.BorderRadius = 5
        Btn_AddDevice.CustomizableEdges = CustomizableEdges1
        Btn_AddDevice.DisabledState.BorderColor = Color.DarkGray
        Btn_AddDevice.DisabledState.CustomBorderColor = Color.DarkGray
        Btn_AddDevice.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Btn_AddDevice.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Btn_AddDevice.FillColor = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        Btn_AddDevice.Font = New Font("Segoe UI", 9F)
        Btn_AddDevice.ForeColor = Color.White
        Btn_AddDevice.Location = New Point(108, 257)
        Btn_AddDevice.Name = "Btn_AddDevice"
        Btn_AddDevice.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Btn_AddDevice.Size = New Size(153, 53)
        Btn_AddDevice.TabIndex = 4
        Btn_AddDevice.Text = "Got it"
        ' 
        ' QuickGuidePopup
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(381, 338)
        Controls.Add(Btn_AddDevice)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "QuickGuidePopup"
        StartPosition = FormStartPosition.CenterParent
        Text = "QuickGuidePopup"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_AddDevice As Guna.UI2.WinForms.Guna2Button
End Class
