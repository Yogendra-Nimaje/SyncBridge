<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Dashboard
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        ProgressBar1 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Lbl_DriveName1 = New Label()
        Lbl_Storage_Used = New Label()
        Lbl_Total_Storage = New Label()
        Pnl_Drive1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Guna2ShadowPanel2 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Label4 = New Label()
        Guna2CircleProgressBar2 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Label5 = New Label()
        Label6 = New Label()
        Pnl_DeviceDrives = New Panel()
        Label10 = New Label()
        Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Lbl_Status = New Label()
        Label2 = New Label()
        Lbl_TotalUsage = New Label()
        Lbl_TotalStorage = New Label()
        Label3 = New Label()
        Pnl_Drive1.SuspendLayout()
        Guna2ShadowPanel2.SuspendLayout()
        Pnl_DeviceDrives.SuspendLayout()
        Guna2ShadowPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.FillColor = Color.FromArgb(CByte(200), CByte(213), CByte(218), CByte(223))
        ProgressBar1.FillThickness = 18
        ProgressBar1.Font = New Font("Segoe UI", 12.0F)
        ProgressBar1.ForeColor = Color.White
        ProgressBar1.Location = New Point(37, 89)
        ProgressBar1.Minimum = 0
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.ProgressColor = Color.Black
        ProgressBar1.ProgressColor2 = Color.Black
        ProgressBar1.ProgressThickness = 10
        ProgressBar1.ShadowDecoration.CustomizableEdges = CustomizableEdges3
        ProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        ProgressBar1.Size = New Size(161, 161)
        ProgressBar1.TabIndex = 0
        ProgressBar1.Text = "Guna2CircleProgressBar1"
        ' 
        ' Lbl_DriveName1
        ' 
        Lbl_DriveName1.AutoSize = True
        Lbl_DriveName1.Font = New Font("Segoe UI Semibold", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_DriveName1.Location = New Point(37, 27)
        Lbl_DriveName1.Name = "Lbl_DriveName1"
        Lbl_DriveName1.Size = New Size(195, 38)
        Lbl_DriveName1.TabIndex = 1
        Lbl_DriveName1.Text = "Local Disk (C:)"
        ' 
        ' Lbl_Storage_Used
        ' 
        Lbl_Storage_Used.AutoSize = True
        Lbl_Storage_Used.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        Lbl_Storage_Used.Location = New Point(263, 129)
        Lbl_Storage_Used.Name = "Lbl_Storage_Used"
        Lbl_Storage_Used.Size = New Size(93, 48)
        Lbl_Storage_Used.TabIndex = 2
        Lbl_Storage_Used.Text = "65%"
        ' 
        ' Lbl_Total_Storage
        ' 
        Lbl_Total_Storage.AutoSize = True
        Lbl_Total_Storage.Location = New Point(263, 177)
        Lbl_Total_Storage.Name = "Lbl_Total_Storage"
        Lbl_Total_Storage.Size = New Size(131, 25)
        Lbl_Total_Storage.TabIndex = 3
        Lbl_Total_Storage.Text = "Used of 512GB"
        ' 
        ' Pnl_Drive1
        ' 
        Pnl_Drive1.BackColor = Color.Transparent
        Pnl_Drive1.Controls.Add(Lbl_Total_Storage)
        Pnl_Drive1.Controls.Add(ProgressBar1)
        Pnl_Drive1.Controls.Add(Lbl_Storage_Used)
        Pnl_Drive1.Controls.Add(Lbl_DriveName1)
        Pnl_Drive1.FillColor = Color.White
        Pnl_Drive1.Location = New Point(3, 17)
        Pnl_Drive1.Name = "Pnl_Drive1"
        Pnl_Drive1.Radius = 12
        Pnl_Drive1.ShadowColor = Color.Black
        Pnl_Drive1.ShadowDepth = 0
        Pnl_Drive1.ShadowShift = 0
        Pnl_Drive1.Size = New Size(434, 287)
        Pnl_Drive1.TabIndex = 3
        ' 
        ' Guna2ShadowPanel2
        ' 
        Guna2ShadowPanel2.BackColor = Color.Transparent
        Guna2ShadowPanel2.Controls.Add(Label4)
        Guna2ShadowPanel2.Controls.Add(Guna2CircleProgressBar2)
        Guna2ShadowPanel2.Controls.Add(Label5)
        Guna2ShadowPanel2.Controls.Add(Label6)
        Guna2ShadowPanel2.FillColor = Color.White
        Guna2ShadowPanel2.Location = New Point(472, 17)
        Guna2ShadowPanel2.Name = "Guna2ShadowPanel2"
        Guna2ShadowPanel2.Radius = 12
        Guna2ShadowPanel2.ShadowColor = Color.Black
        Guna2ShadowPanel2.ShadowDepth = 0
        Guna2ShadowPanel2.ShadowShift = 0
        Guna2ShadowPanel2.Size = New Size(434, 287)
        Guna2ShadowPanel2.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(263, 177)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 25)
        Label4.TabIndex = 3
        Label4.Text = "Used of 512GB"
        ' 
        ' Guna2CircleProgressBar2
        ' 
        Guna2CircleProgressBar2.FillColor = Color.FromArgb(CByte(200), CByte(213), CByte(218), CByte(223))
        Guna2CircleProgressBar2.FillThickness = 18
        Guna2CircleProgressBar2.Font = New Font("Segoe UI", 12.0F)
        Guna2CircleProgressBar2.ForeColor = Color.White
        Guna2CircleProgressBar2.Location = New Point(37, 89)
        Guna2CircleProgressBar2.Minimum = 0
        Guna2CircleProgressBar2.Name = "Guna2CircleProgressBar2"
        Guna2CircleProgressBar2.ProgressColor = Color.Black
        Guna2CircleProgressBar2.ProgressColor2 = Color.Black
        Guna2CircleProgressBar2.ProgressThickness = 18
        Guna2CircleProgressBar2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2CircleProgressBar2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CircleProgressBar2.Size = New Size(161, 161)
        Guna2CircleProgressBar2.TabIndex = 0
        Guna2CircleProgressBar2.Text = "Guna2CircleProgressBar2"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        Label5.Location = New Point(263, 129)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 48)
        Label5.TabIndex = 2
        Label5.Text = "65%"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(37, 27)
        Label6.Name = "Label6"
        Label6.Size = New Size(199, 38)
        Label6.TabIndex = 1
        Label6.Text = "Local DIsk (D:)"
        ' 
        ' Pnl_DeviceDrives
        ' 
        Pnl_DeviceDrives.Controls.Add(Pnl_Drive1)
        Pnl_DeviceDrives.Controls.Add(Guna2ShadowPanel2)
        Pnl_DeviceDrives.Location = New Point(12, 64)
        Pnl_DeviceDrives.Name = "Pnl_DeviceDrives"
        Pnl_DeviceDrives.Size = New Size(925, 332)
        Pnl_DeviceDrives.TabIndex = 6
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(11, 9)
        Label10.Name = "Label10"
        Label10.Size = New Size(202, 38)
        Label10.TabIndex = 4
        Label10.Text = "Storage Usage"
        ' 
        ' Guna2ShadowPanel1
        ' 
        Guna2ShadowPanel1.BackColor = Color.Transparent
        Guna2ShadowPanel1.Controls.Add(Lbl_Status)
        Guna2ShadowPanel1.Controls.Add(Label2)
        Guna2ShadowPanel1.Controls.Add(Lbl_TotalUsage)
        Guna2ShadowPanel1.Controls.Add(Lbl_TotalStorage)
        Guna2ShadowPanel1.Controls.Add(Label3)
        Guna2ShadowPanel1.FillColor = Color.White
        Guna2ShadowPanel1.Location = New Point(954, 68)
        Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Guna2ShadowPanel1.Radius = 12
        Guna2ShadowPanel1.ShadowColor = Color.Black
        Guna2ShadowPanel1.ShadowDepth = 0
        Guna2ShadowPanel1.ShadowShift = 0
        Guna2ShadowPanel1.Size = New Size(292, 300)
        Guna2ShadowPanel1.TabIndex = 5
        ' 
        ' Lbl_Status
        ' 
        Lbl_Status.AutoSize = True
        Lbl_Status.Location = New Point(174, 210)
        Lbl_Status.Name = "Lbl_Status"
        Lbl_Status.Size = New Size(57, 25)
        Lbl_Status.TabIndex = 6
        Lbl_Status.Text = "Good"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(30, 207)
        Label2.Name = "Label2"
        Label2.Size = New Size(153, 28)
        Label2.TabIndex = 5
        Label2.Text = "Overall Status : "
        ' 
        ' Lbl_TotalUsage
        ' 
        Lbl_TotalUsage.AutoSize = True
        Lbl_TotalUsage.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        Lbl_TotalUsage.Location = New Point(103, 102)
        Lbl_TotalUsage.Name = "Lbl_TotalUsage"
        Lbl_TotalUsage.Size = New Size(93, 48)
        Lbl_TotalUsage.TabIndex = 4
        Lbl_TotalUsage.Text = "65%"
        ' 
        ' Lbl_TotalStorage
        ' 
        Lbl_TotalStorage.AutoSize = True
        Lbl_TotalStorage.Location = New Point(85, 161)
        Lbl_TotalStorage.Name = "Lbl_TotalStorage"
        Lbl_TotalStorage.Size = New Size(131, 25)
        Lbl_TotalStorage.TabIndex = 3
        Lbl_TotalStorage.Text = "Used of 512GB"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(37, 27)
        Label3.Name = "Label3"
        Label3.Size = New Size(215, 38)
        Label3.TabIndex = 1
        Label3.Text = "Quick Overview"
        ' 
        ' frm_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(1443, 675)
        Controls.Add(Label10)
        Controls.Add(Guna2ShadowPanel1)
        Controls.Add(Pnl_DeviceDrives)
        Name = "frm_Dashboard"
        Text = "frm_Dashboard"
        Pnl_Drive1.ResumeLayout(False)
        Pnl_Drive1.PerformLayout()
        Guna2ShadowPanel2.ResumeLayout(False)
        Guna2ShadowPanel2.PerformLayout()
        Pnl_DeviceDrives.ResumeLayout(False)
        Guna2ShadowPanel1.ResumeLayout(False)
        Guna2ShadowPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Lbl_DriveName1 As Label
    Friend WithEvents Lbl_Total_Storage As Label
    Friend WithEvents Lbl_Storage_Used As Label
    Friend WithEvents Pnl_Drive1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2ShadowPanel2 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2CircleProgressBar2 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Pnl_DeviceDrives As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Lbl_TotalStorage As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Lbl_TotalUsage As Label
    Friend WithEvents Lbl_Status As Label
End Class
