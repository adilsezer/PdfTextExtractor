Imports System.IO

Module FileWriter

    Public Sub WriteTxtFile(filePath As String, text As String)
        If Not File.Exists(filePath) Then
            Using writer As New StreamWriter(filePath, True)
                writer.WriteLine(text)
            End Using
        End If
    End Sub

End Module
