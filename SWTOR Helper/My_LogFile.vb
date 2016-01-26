Imports System
Imports System.IO

Module My_LogFile

    Public Sub Log(ByVal strData As String)
        Dim Dir As String = Directory.GetCurrentDirectory() + "\Log"

        'Check directory first
        If Not (System.IO.Directory.Exists(Dir)) Then
            System.IO.Directory.CreateDirectory(Dir)
        End If

        Dim objReader As System.IO.StreamWriter
        Try
            objReader = New System.IO.StreamWriter(Dir + "\Log.txt", True)
            objReader.Write("Time: " & Now() & " LOG: " & strData & vbCrLf)
            'objReader.WriteLine(vbCrLf) 'uncomment for blank line between entries
            objReader.Close()
        Catch Ex As Exception
            'Throw New Exception(Ex.Message)
        End Try
    End Sub
End Module
