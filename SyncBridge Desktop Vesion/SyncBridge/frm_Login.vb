Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports FireSharp.Response
Imports Newtonsoft.Json

Public Class frm_Login
    Dim client As IFirebaseClient
    Dim fsc As New FirebaseConfig With {
        .AuthSecret = "JEES1CTNYACYQFKfGLD3FAM0zhDHMIeVpwkMtGL2",
        .BasePath = "https://my-application-8dd80-default-rtdb.firebaseio.com/"
    }

    Private Sub InitializeClient()
        Try
            client = New FireSharp.FirebaseClient(fsc)
            If client Is Nothing Then
                MessageBox.Show("Failed to connect to Firebase database")
            End If
        Catch ex As Exception
            MessageBox.Show("Error Occurred: " + ex.Message)
        End Try
    End Sub

    Private Sub frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeClient()
    End Sub

    Private Async Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        ' Validate input fields
        If String.IsNullOrEmpty(txt_Email.Text) Or String.IsNullOrEmpty(txt_Password.Text) Then
            MessageBox.Show("Please enter both email and password", "Validation Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Normalize email (remove comma and convert to proper format)

            ' Get user data from Firebase
            Dim response As FirebaseResponse = Await client.GetAsync($"Users/{txt_Email.Text.Replace(".", ",")}")

            If response.Body = "null" Then
                MessageBox.Show("User not found", "Login Failed",
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Deserialize the response
            Dim userData As Dictionary(Of String, Object) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response.Body)

            ' Verify password
            If userData.ContainsKey("password") AndAlso
               userData("password").ToString() = txt_Password.Text Then

                My.Settings.UID = txt_Email.Text.Replace(".", ",") ' Save the UID
                My.Settings.Save()
                MessageBox.Show("Login successful!")
                Me.DialogResult = DialogResult.OK
            Else
                MessageBox.Show("Incorrect password", "Login Failed",
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show($"Error during login: {ex.Message}", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txt_Email_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Email.KeyPress
        ' Optional: Add email validation if needed
    End Sub

    Private Sub txt_Password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Password.KeyPress
        ' Allow enter key to trigger login
        If e.KeyChar = ChrW(Keys.Enter) Then
            btn_Login_Click(sender, e)
            e.Handled = True
        End If
    End Sub
End Class