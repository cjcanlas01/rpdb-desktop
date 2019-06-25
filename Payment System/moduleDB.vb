Imports MySql.Data.MySqlClient

Module moduleDB
    Public Conn As New MySqlConnection
    Public Comm As New MySqlCommand
    Public Reader_ As MySqlDataReader
    Public strQuery As String = vbNullString
    Public strQuery2 As String = vbNullString
    Public isEdit_ As String = vbNullString
    Public SearchedID As String = vbNullString
    Public isPass_ As String = vbNullString
    Public Form_ As Form
    Public isInvoice_ As String = vbNullString
    Public Year_ As String = vbNullString
    Public Organization_ As String = vbNullString
    Public isPassSF_ As String = vbNullString
    Public isPassOF_ As String = vbNullString
    Public isPassCC_ As String = vbNullString
    Public Trigger As String = vbNullString
    Public ChangeOrg As String = vbNullString
    Public ChangeYear As String = vbNullString

    Public Sub ClearTrigs()
        isPassSF_ = vbNullString
        isPassOF_ = vbNullString
        isPassSF_ = vbNullString
        Trigger = vbNullString
        ChangeOrg = vbNullString
        ChangeYear = vbNullString
    End Sub

    Public Sub Connection()
        Dim server As String = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\Connection\Server.txt")
        Dim userid As String = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\Connection\Userid.txt")
        Dim password As String = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\Connection\Password.txt")
        Dim database As String = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\Connection\Database.txt")
        Dim ConStr As String = "server =" + server + "; userid = " + userid + "; password =" + password + "; database = " + database + ";"

        With Conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = ConStr
            .Open()
        End With
    End Sub

    Public Sub SendQuery(ByVal Query As String)
        Connection()
        With Comm
            .CommandText = Query
            .Connection = Conn
            .ExecuteNonQuery()
        End With
    End Sub

    Public Sub ReaderQuery(ByVal Query As String)
        Connection()
        With Comm
            .CommandText = Query
            .Connection = Conn
            Reader_ = .ExecuteReader
        End With
    End Sub

End Module
