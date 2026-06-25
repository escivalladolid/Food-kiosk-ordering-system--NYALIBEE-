

Imports MySql.Data.MySqlClient
Imports Mysqlx


Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Dim conn As New MySqlConnection


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim connString As String = "server=127.0.0.1;port=3306;userid=root;password=BSCS2ndyear;database=Login"
        Dim conn As New MySqlConnection(connString)

        Try
            conn.Open()

            Dim query As String = "SELECT * FROM users WHERE username=@user AND password=@pass"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@user", UsernameTextBox.Text)
            cmd.Parameters.AddWithValue("@pass", PasswordTextBox.Text)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then

                If UsernameTextBox.Text = "admin" And PasswordTextBox.Text = "admin" Then
                    MessageBox.Show("Admin login successful!", "Admin Access", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.Hide()
                    Adminonly.Show()
                Else
                    MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.Hide()
                    progressbar.Show()
                End If
            Else
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Connection error: " & ex.Message)
        End Try


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Form1.Show()


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, PictureBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
