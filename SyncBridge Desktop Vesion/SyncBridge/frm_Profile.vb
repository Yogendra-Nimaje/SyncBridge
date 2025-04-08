Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports FireSharp.Response
Imports Newtonsoft.Json.Linq
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Drawing
Imports Newtonsoft.Json

Public Class frm_Profile
    Dim client As IFirebaseClient
    Dim fsc As New FirebaseConfig With {
        .AuthSecret = "JEES1CTNYACYQFKfGLD3FAM0zhDHMIeVpwkMtGL2",
        .BasePath = "https://my-application-8dd80-default-rtdb.firebaseio.com/"
    }

    Private Sub frm_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeClient()
        LoadUserProfile(My.Settings.UID)
    End Sub

    Private Sub InitializeClient()
        Try
            client = New FireSharp.FirebaseClient(fsc)
            If client Is Nothing Then
                MessageBox.Show("Failed to connect to Firebase.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error Occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadUserProfile(email As String)
        Try
            Dim response As FirebaseResponse = client.Get("Users/" & email)
            If response.Body IsNot Nothing AndAlso response.Body <> "null" Then
                Dim userData = JObject.Parse(response.Body)
                txt_FirstName.Text = userData("firstname")?.ToString()
                txt_LastName.Text = userData("lastname")?.ToString()
                txt_Email.Text = userData("email")?.ToString()
                txt_MobileNo.Text = userData("phoneNumber")?.ToString()

                ' Load profile image if available
                If userData("profileImage") IsNot Nothing AndAlso Not String.IsNullOrEmpty(userData("profileImage").ToString()) Then
                    pic_Profile.Image = Base64ToImage(userData("profileImage").ToString())
                Else
                    pic_Profile.Image = My.Resources.Resources.profile ' Default image
                End If

                ' Initial state: Text boxes disabled, btn_ChangePhoto always enabled
                SetFieldsEnabled(False)
                btn_ChangePhoto.Enabled = True ' Always enabled
            Else
                SetFieldsEnabled(False)
                btn_ChangePhoto.Enabled = True ' Still enabled even if no data
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to load profile: " & ex.Message)
        End Try
    End Sub

    Private Sub SetFieldsEnabled(isEnabled As Boolean)
        txt_FirstName.Enabled = isEnabled
        txt_LastName.Enabled = isEnabled
        txt_MobileNo.Enabled = isEnabled
        txt_Email.Enabled = False ' Email remains disabled always
        btn_UpdateProfile.Text = If(isEnabled, "Save Changes", "Update Profile")
    End Sub

    Private Sub btn_UpdateProfile_Click(sender As Object, e As EventArgs) Handles btn_UpdateProfile.Click
        If btn_UpdateProfile.Text = "Update Profile" Then
            ' Switch to edit mode
            SetFieldsEnabled(True)
        Else
            ' Save changes mode
            If Not ValidateInput() Then Exit Sub

            Dim userProfile As New Dictionary(Of String, Object) From {
                {"firstname", txt_FirstName.Text},
                {"lastname", txt_LastName.Text},
                {"email", txt_Email.Text},
                {"phoneNumber", txt_MobileNo.Text},
                {"profileImage", ImageToBase64(pic_Profile.Image)}
            }

            Try
                Dim response As FirebaseResponse = client.Set("Users/admin@admin,com", userProfile)
                If response.StatusCode = Net.HttpStatusCode.OK Then
                    MessageBox.Show("Profile updated successfully!")
                    SetFieldsEnabled(False) ' Disable text boxes after save
                    btn_ChangePhoto.Enabled = True ' Ensure this stays enabled
                Else
                    MessageBox.Show("Failed to update profile. Status: " & response.StatusCode.ToString())
                End If
            Catch ex As Exception
                MessageBox.Show("Update failed: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_ChangePhoto_Click(sender As Object, e As EventArgs) Handles btn_ChangePhoto.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp"
            ofd.Title = "Select Profile Image"
            If ofd.ShowDialog() = DialogResult.OK Then
                Try
                    pic_Profile.Image = Image.FromFile(ofd.FileName)
                Catch ex As Exception
                    MessageBox.Show("Failed to load image: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    Private Function ValidateInput() As Boolean
        If String.IsNullOrWhiteSpace(txt_FirstName.Text) Then
            MessageBox.Show("First Name cannot be empty.")
            Return False
        End If
        If String.IsNullOrWhiteSpace(txt_LastName.Text) Then
            MessageBox.Show("Last Name cannot be empty.")
            Return False
        End If

        Dim phonePattern As String = "^\+?[0-9]{10,15}$"
        If Not Regex.IsMatch(txt_MobileNo.Text, phonePattern) Then
            MessageBox.Show("Invalid phone number format. Use 10-15 digits, optionally starting with '+'.")
            Return False
        End If

        If pic_Profile.Image Is Nothing Then
            MessageBox.Show("Please select a profile image.")
            Return False
        End If

        Return True
    End Function

    Private Function ImageToBase64(img As Image) As String
        If img Is Nothing Then Return ""
        Using ms As New MemoryStream()
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
            Return Convert.ToBase64String(ms.ToArray())
        End Using
    End Function

    Private Function Base64ToImage(base64String As String) As Image
        Try
            Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
            Using ms As New MemoryStream(imageBytes)
                Return Image.FromStream(ms)
            End Using
        Catch ex As Exception
            MessageBox.Show("Invalid Base64 image data: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            My.Settings.UID = ""
            My.Settings.Save()

            Application.Restart()
            ' Close the current instance
            Environment.Exit(0)
        End If


    End Sub
End Class