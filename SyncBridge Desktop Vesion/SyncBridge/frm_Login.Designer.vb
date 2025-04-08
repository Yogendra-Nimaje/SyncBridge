<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Login
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
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        txt_Email = New Guna.UI2.WinForms.Guna2TextBox()
        txt_Password = New Guna.UI2.WinForms.Guna2TextBox()
        btn_Login = New Guna.UI2.WinForms.Guna2Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txt_Email
        ' 
        txt_Email.Animated = True
        txt_Email.BorderRadius = 5
        txt_Email.CustomizableEdges = CustomizableEdges1
        txt_Email.DefaultText = ""
        txt_Email.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_Email.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_Email.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_Email.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_Email.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_Email.Font = New Font("Segoe UI", 9F)
        txt_Email.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_Email.Location = New Point(80, 198)
        txt_Email.Margin = New Padding(4, 5, 4, 5)
        txt_Email.Name = "txt_Email"
        txt_Email.PlaceholderText = "Enter Your Email"
        txt_Email.SelectedText = ""
        txt_Email.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txt_Email.Size = New Size(318, 50)
        txt_Email.TabIndex = 0
        ' 
        ' txt_Password
        ' 
        txt_Password.Animated = True
        txt_Password.BorderRadius = 5
        txt_Password.CustomizableEdges = CustomizableEdges3
        txt_Password.DefaultText = ""
        txt_Password.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_Password.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_Password.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_Password.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_Password.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_Password.Font = New Font("Segoe UI", 9F)
        txt_Password.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_Password.Location = New Point(80, 258)
        txt_Password.Margin = New Padding(4, 5, 4, 5)
        txt_Password.Name = "txt_Password"
        txt_Password.PlaceholderText = "Enter Your Password"
        txt_Password.SelectedText = ""
        txt_Password.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txt_Password.Size = New Size(318, 50)
        txt_Password.TabIndex = 1
        ' 
        ' btn_Login
        ' 
        btn_Login.Animated = True
        btn_Login.BorderRadius = 5
        btn_Login.CustomizableEdges = CustomizableEdges5
        btn_Login.DisabledState.BorderColor = Color.DarkGray
        btn_Login.DisabledState.CustomBorderColor = Color.DarkGray
        btn_Login.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_Login.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_Login.FillColor = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        btn_Login.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Login.ForeColor = Color.White
        btn_Login.Location = New Point(137, 332)
        btn_Login.Name = "btn_Login"
        btn_Login.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btn_Login.Size = New Size(216, 53)
        btn_Login.TabIndex = 2
        btn_Login.Text = "Login"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(161, 140)
        Label1.Name = "Label1"
        Label1.Size = New Size(139, 32)
        Label1.TabIndex = 3
        Label1.Text = "Login Here"
        ' 
        ' frm_Login
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(495, 568)
        Controls.Add(Label1)
        Controls.Add(btn_Login)
        Controls.Add(txt_Password)
        Controls.Add(txt_Email)
        Name = "frm_Login"
        Text = "frm_Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_Email As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_Password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_Login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
End Class
