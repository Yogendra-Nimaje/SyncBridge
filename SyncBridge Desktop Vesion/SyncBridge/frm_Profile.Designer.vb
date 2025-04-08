<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Profile
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
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges21 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges22 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges23 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges24 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        pic_Profile = New PictureBox()
        btn_ChangePhoto = New Guna.UI2.WinForms.Guna2Button()
        Label2 = New Label()
        txt_FirstName = New Guna.UI2.WinForms.Guna2TextBox()
        txt_LastName = New Guna.UI2.WinForms.Guna2TextBox()
        Label3 = New Label()
        txt_Email = New Guna.UI2.WinForms.Guna2TextBox()
        Label4 = New Label()
        txt_MobileNo = New Guna.UI2.WinForms.Guna2TextBox()
        Label5 = New Label()
        btn_UpdateProfile = New Guna.UI2.WinForms.Guna2Button()
        PictureBox1 = New PictureBox()
        CType(pic_Profile, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(55, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(250, 45)
        Label1.TabIndex = 0
        Label1.Text = "Profile Settings"
        ' 
        ' pic_Profile
        ' 
        pic_Profile.Image = My.Resources.Resources.profile
        pic_Profile.Location = New Point(55, 119)
        pic_Profile.Name = "pic_Profile"
        pic_Profile.Size = New Size(130, 130)
        pic_Profile.SizeMode = PictureBoxSizeMode.StretchImage
        pic_Profile.TabIndex = 1
        pic_Profile.TabStop = False
        ' 
        ' btn_ChangePhoto
        ' 
        btn_ChangePhoto.BackColor = Color.Transparent
        btn_ChangePhoto.BorderRadius = 8
        btn_ChangePhoto.CustomizableEdges = CustomizableEdges13
        btn_ChangePhoto.DisabledState.BorderColor = Color.DarkGray
        btn_ChangePhoto.DisabledState.CustomBorderColor = Color.DarkGray
        btn_ChangePhoto.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_ChangePhoto.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_ChangePhoto.FillColor = Color.FromArgb(CByte(67), CByte(56), CByte(201))
        btn_ChangePhoto.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_ChangePhoto.ForeColor = Color.White
        btn_ChangePhoto.Location = New Point(209, 154)
        btn_ChangePhoto.Name = "btn_ChangePhoto"
        btn_ChangePhoto.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        btn_ChangePhoto.Size = New Size(209, 57)
        btn_ChangePhoto.TabIndex = 2
        btn_ChangePhoto.Text = "Change Photo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label2.Location = New Point(55, 293)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 28)
        Label2.TabIndex = 3
        Label2.Text = "First Name"
        ' 
        ' txt_FirstName
        ' 
        txt_FirstName.Animated = True
        txt_FirstName.BorderRadius = 8
        txt_FirstName.BorderThickness = 2
        txt_FirstName.CustomizableEdges = CustomizableEdges15
        txt_FirstName.DefaultText = ""
        txt_FirstName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_FirstName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_FirstName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_FirstName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_FirstName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_FirstName.Font = New Font("Segoe UI", 9F)
        txt_FirstName.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_FirstName.IconLeftSize = New Size(0, 0)
        txt_FirstName.Location = New Point(55, 335)
        txt_FirstName.Margin = New Padding(4, 5, 4, 5)
        txt_FirstName.Name = "txt_FirstName"
        txt_FirstName.PlaceholderForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(175))
        txt_FirstName.PlaceholderText = "First Name"
        txt_FirstName.SelectedText = ""
        txt_FirstName.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        txt_FirstName.Size = New Size(424, 55)
        txt_FirstName.TabIndex = 4
        txt_FirstName.TextOffset = New Point(15, 0)
        ' 
        ' txt_LastName
        ' 
        txt_LastName.Animated = True
        txt_LastName.BorderRadius = 8
        txt_LastName.BorderThickness = 2
        txt_LastName.CustomizableEdges = CustomizableEdges17
        txt_LastName.DefaultText = ""
        txt_LastName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_LastName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_LastName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_LastName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_LastName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_LastName.Font = New Font("Segoe UI", 9F)
        txt_LastName.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_LastName.IconLeftSize = New Size(0, 0)
        txt_LastName.Location = New Point(526, 335)
        txt_LastName.Margin = New Padding(4, 5, 4, 5)
        txt_LastName.Name = "txt_LastName"
        txt_LastName.PlaceholderForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(175))
        txt_LastName.PlaceholderText = "Last Name"
        txt_LastName.SelectedText = ""
        txt_LastName.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        txt_LastName.Size = New Size(424, 55)
        txt_LastName.TabIndex = 6
        txt_LastName.TextOffset = New Point(10, 0)
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label3.Location = New Point(526, 293)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 28)
        Label3.TabIndex = 5
        Label3.Text = "Last Name"
        ' 
        ' txt_Email
        ' 
        txt_Email.Animated = True
        txt_Email.BorderRadius = 8
        txt_Email.BorderThickness = 2
        txt_Email.CustomizableEdges = CustomizableEdges19
        txt_Email.DefaultText = ""
        txt_Email.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_Email.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_Email.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_Email.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_Email.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_Email.Font = New Font("Segoe UI", 9F)
        txt_Email.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_Email.IconLeftSize = New Size(0, 0)
        txt_Email.Location = New Point(526, 462)
        txt_Email.Margin = New Padding(4, 5, 4, 5)
        txt_Email.Name = "txt_Email"
        txt_Email.PlaceholderForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(175))
        txt_Email.PlaceholderText = "xyz@example.com"
        txt_Email.SelectedText = ""
        txt_Email.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        txt_Email.Size = New Size(424, 55)
        txt_Email.TabIndex = 10
        txt_Email.TextOffset = New Point(15, 0)
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label4.Location = New Point(526, 420)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 28)
        Label4.TabIndex = 9
        Label4.Text = "Email"
        ' 
        ' txt_MobileNo
        ' 
        txt_MobileNo.Animated = True
        txt_MobileNo.BorderRadius = 8
        txt_MobileNo.BorderThickness = 2
        txt_MobileNo.CustomizableEdges = CustomizableEdges21
        txt_MobileNo.DefaultText = ""
        txt_MobileNo.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_MobileNo.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_MobileNo.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_MobileNo.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_MobileNo.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_MobileNo.Font = New Font("Segoe UI", 9F)
        txt_MobileNo.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_MobileNo.IconLeftSize = New Size(0, 0)
        txt_MobileNo.Location = New Point(55, 462)
        txt_MobileNo.Margin = New Padding(4, 5, 4, 5)
        txt_MobileNo.Name = "txt_MobileNo"
        txt_MobileNo.PlaceholderForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(175))
        txt_MobileNo.PlaceholderText = "+91 98989898"
        txt_MobileNo.SelectedText = ""
        txt_MobileNo.ShadowDecoration.CustomizableEdges = CustomizableEdges22
        txt_MobileNo.Size = New Size(424, 55)
        txt_MobileNo.TabIndex = 8
        txt_MobileNo.TextOffset = New Point(15, 0)
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label5.Location = New Point(55, 420)
        Label5.Name = "Label5"
        Label5.Size = New Size(117, 28)
        Label5.TabIndex = 7
        Label5.Text = "Mobile No."
        ' 
        ' btn_UpdateProfile
        ' 
        btn_UpdateProfile.BackColor = Color.Transparent
        btn_UpdateProfile.BorderRadius = 8
        btn_UpdateProfile.CustomizableEdges = CustomizableEdges23
        btn_UpdateProfile.DisabledState.BorderColor = Color.DarkGray
        btn_UpdateProfile.DisabledState.CustomBorderColor = Color.DarkGray
        btn_UpdateProfile.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_UpdateProfile.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_UpdateProfile.FillColor = Color.FromArgb(CByte(67), CByte(56), CByte(201))
        btn_UpdateProfile.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_UpdateProfile.ForeColor = Color.White
        btn_UpdateProfile.Location = New Point(429, 564)
        btn_UpdateProfile.Name = "btn_UpdateProfile"
        btn_UpdateProfile.ShadowDecoration.CustomizableEdges = CustomizableEdges24
        btn_UpdateProfile.Size = New Size(209, 57)
        btn_UpdateProfile.TabIndex = 11
        btn_UpdateProfile.Text = "Update Profile"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logout
        PictureBox1.Location = New Point(645, 572)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(44, 42)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' frm_Profile
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1481, 652)
        Controls.Add(PictureBox1)
        Controls.Add(btn_UpdateProfile)
        Controls.Add(txt_Email)
        Controls.Add(Label4)
        Controls.Add(txt_MobileNo)
        Controls.Add(Label5)
        Controls.Add(txt_LastName)
        Controls.Add(Label3)
        Controls.Add(txt_FirstName)
        Controls.Add(Label2)
        Controls.Add(btn_ChangePhoto)
        Controls.Add(pic_Profile)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frm_Profile"
        Text = "frm_Profile"
        CType(pic_Profile, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pic_Profile As PictureBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2TextBox4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_ChangePhoto As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_FirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_LastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_Email As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_MobileNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_UpdateProfile As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
