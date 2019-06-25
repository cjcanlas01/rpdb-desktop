Imports MySql.Data.MySqlClient
Module moduleDB2

    Public Conn_ As New MySqlConnection
    Public Comm_ As New MySqlCommand
    Public Reader_2 As MySqlDataReader
    Public Form_2 As Form
   

    Public Sub Connection2(ByVal database As String)
        Dim server As String = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\Connection\Server.txt")
        Dim userid As String = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\Connection\Userid.txt")
        Dim password As String = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\Connection\Password.txt")
        'Dim database As String = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\Connection\Database2.txt")
        Dim ConStr As String = "server =" + server + "; userid = " + userid + "; password =" + password + "; database = " + database + ";"

        With Conn_
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = ConStr
            .Open()
        End With
    End Sub

    Public Sub SendQuery2(ByVal Query As String, ByVal database As String)
        Connection2(database)
        With Comm_
            .CommandText = Query
            .Connection = Conn_
            .ExecuteNonQuery()
        End With
    End Sub

    Public Sub ReaderQuery2(ByVal Query As String, ByVal database As String)
        Connection2(database)
        With Comm_
            .CommandText = Query
            .Connection = Conn_
            Reader_2 = .ExecuteReader
        End With
    End Sub

End Module
