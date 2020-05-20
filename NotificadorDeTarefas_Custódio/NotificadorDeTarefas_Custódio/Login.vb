Imports System.Data.SqlClient
Public Class Login

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'If Not String.IsNullOrEmpty(UsernameTextBox.Text) And
        '        Not String.IsNullOrEmpty(PasswordTextBox.Text) Then

        '    Dim SQL As String = String.Empty
        '    SQL &= "SELECT * FROM Aluno "
        '    SQL &= "WHERE login = '" & UsernameTextBox.Text & "' "
        '    SQL &= "AND senha = '" & PasswordTextBox.Text & "'"

        '    Dim UserData As DataTable = ExecuteSQL(SQL)

        '    If UserData.Rows.Count > 0 Then

        '        UsernameTextBox.Clear()
        '        PasswordTextBox.Clear()


        '        Me.Hide()

        '        Dim formMain As New Form1()
        '        formMain.ShowDialog()
        '        formMain = Nothing

        '        Me.Show()
        '        Me.UsernameTextBox.Select()

        '    Else
        '        MsgBox("The Username or Password is incorrect. Try again.", MsgBoxStyle.Critical, "Login Form : iBasskung Tutorial")
        '        UsernameTextBox.Focus()
        '        UsernameTextBox.SelectAll()
        '    End If

        'Else
        '    MsgBox("Please enter Username and Password.", MsgBoxStyle.Critical, "Login Form : iBasskung Tutorial")
        '    UsernameTextBox.Select()
        'End If
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click

        Application.Exit()

    End Sub

    'Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '    Dim strName As String
    '    Dim strId As String
    '    Dim strPhone As String


    '    Dim query As String = String.Empty
    '    query &= "INSERT INTO Aluno (login, senha, nome"
    '    query &= "VALUES (joao, 123, Joao)"

    '    Using conn As New SqlConnection("connectionStringHere")
    '        Using comm As New SqlCommand()
    '            With comm
    '                .Connection = conn
    '                .CommandType = CommandType.Text
    '                .CommandText = query
    '                .Parameters.AddWithValue("joao", strName)
    '                .Parameters.AddWithValue("123", strId)
    '                .Parameters.AddWithValue("Joao", strPhone)
    '            End With
    '            Try
    '                conn.Open()
    '                comm.ExecuteNonQuery()

    '            Catch

    '            End Try
    '        End Using
    '    End Using

    'End Sub
End Class
