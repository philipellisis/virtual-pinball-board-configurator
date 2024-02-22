Imports System.IO

Module Logger
    Private debug As Boolean = False
    ' Function to log message to a text file with timestamp
    Public Sub LogMessageToFile(message As String, Optional filePath As String = "log.txt")
        If debug = False Then Return
        Try
            ' Create a writer to append text to the file
            Using writer As StreamWriter = File.AppendText(filePath)
                ' Write the timestamp and the message to the file
                writer.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} - {message}")
            End Using
        Catch ex As Exception
            ' Handle any errors that might occur
            Console.WriteLine($"Error logging message: {ex.Message}")
        End Try
    End Sub
End Module
