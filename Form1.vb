Imports MySql.Data.MySqlClient

Public Class Form1


    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click


        Dim connString As String = "server=127.0.0.1;port=3306;userid=root;password=BSCS2ndyear;database=Login"
        Dim conn As New MySqlConnection(connString)

        Try
            conn.Open()

            ' Step 1: Check if username exists in 'users'
            Dim checkQuery As String = "SELECT * FROM users WHERE username=@user"
            Dim checkCmd As New MySqlCommand(checkQuery, conn)
            checkCmd.Parameters.AddWithValue("@user", Fname.Text)
            Dim checkReader As MySqlDataReader = checkCmd.ExecuteReader()

            If checkReader.HasRows Then
                MessageBox.Show("Username already taken. Try another one.", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                checkReader.Close()
            Else
                checkReader.Close()

                ' Step 2: Insert into 'users' (for login)
                Dim insertUserQuery As String = "INSERT INTO users (username, password) VALUES (@user, @pass)"
                Dim insertUserCmd As New MySqlCommand(insertUserQuery, conn)
                insertUserCmd.Parameters.AddWithValue("@user", Fname.Text)
                insertUserCmd.Parameters.AddWithValue("@pass", Passtxt.Text)
                insertUserCmd.ExecuteNonQuery()

                ' Step 3: Insert into 'signup' (user info)
                Dim insertSignupQuery As String = "INSERT INTO signup (first_name, last_name, gender, phone, email, username, password) VALUES (@first_name, @last_name, @gender, @phone, @email, @user, @pass)"
                Dim insertSignupCmd As New MySqlCommand(insertSignupQuery, conn)

                insertSignupCmd.Parameters.AddWithValue("@first_name", Fname.Text)
                insertSignupCmd.Parameters.AddWithValue("@last_name", Ln.Text)
                insertSignupCmd.Parameters.AddWithValue("@gender", ComboBox1.SelectedItem.ToString())
                insertSignupCmd.Parameters.AddWithValue("@phone", pun.Text)
                insertSignupCmd.Parameters.AddWithValue("@email", Un.Text)
                insertSignupCmd.Parameters.AddWithValue("@user", Fname.Text)
                insertSignupCmd.Parameters.AddWithValue("@pass", Passtxt.Text)

                Dim result As Integer = insertSignupCmd.ExecuteNonQuery()

                If result > 0 Then
                    MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoginForm1.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Failed to save sign-up details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Connection error: " & ex.Message)
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class