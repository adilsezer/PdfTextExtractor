Imports System.IO

Public Class PdfTextExtractorUI

    Public Sub New()
        InitializeComponent()
        Icon = Icon.ExtractAssociatedIcon(Reflection.Assembly.GetExecutingAssembly().Location)
    End Sub

    Private Sub FolderButton_Click(sender As Object, e As EventArgs) Handles FolderButton.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            FolderPathBox.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub StartStopButton_Click(sender As Object, e As EventArgs) Handles StartStopButton.Click
        If FolderPathBox.Text = "" Then
            MessageBox.Show("Please select a folder path to monitor new PDF files!")
        ElseIf StartStopButton.Text = "Start" Then
            StartStopButton.Text = "Stop"
            StartStopButton.ForeColor = Color.Red
            FolderWatcher.StartWatcher(FolderPathBox.Text)
        ElseIf StartStopButton.Text = "Stop" Then
            StartStopButton.Text = "Start"
            StartStopButton.ForeColor = Color.Green
            FolderWatcher.Dispose()
        End If
    End Sub

    Public Sub ProcessFile(ByVal fileName As String)
        fileName = MovePDFToProcessingFolder(fileName)

        Dim pdfText As String = PdfRenderer.ReadPdfFile(fileName)
        If pdfText.Trim() = String.Empty Then
            PdfRenderer.RenderPdfToPng(fileName)
            pdfText = OCREngine.ExtractText(fileName)
        End If

        Dim txtFile As String = Path.Combine(Path.GetDirectoryName(fileName), Path.GetFileNameWithoutExtension(fileName) & ".txt")
        FileWriter.WriteTxtFile(txtFile, pdfText)
        MoveTxtToFolder()
        LogTextBox.Text += $"Txt file created for {Path.GetFileNameWithoutExtension(fileName)}" + Environment.NewLine()
    End Sub

    Private Function MovePDFToProcessingFolder(fileName As String) As String
        Dim processingFolder As String = Path.Combine(FolderPathBox.Text, "Processing")
        Dim newFileName As String = Path.Combine(processingFolder, Path.GetFileName(fileName))

        If Directory.Exists(processingFolder) Then
            Directory.Delete(processingFolder, True)
        End If

        Directory.CreateDirectory(processingFolder)
        File.Move(fileName, newFileName)
        Return newFileName
    End Function

    Private Sub MoveTxtToFolder()
        Dim dirInfo As New DirectoryInfo(Path.Combine(FolderPathBox.Text, "Processing"))
        Dim fileInfos As FileInfo() = dirInfo.GetFiles()
        For Each fi As FileInfo In fileInfos
            Dim newFolderPath As String = Path.Combine(FolderPathBox.Text, Path.GetFileNameWithoutExtension(fi.Name))
            If Not Directory.Exists(newFolderPath) Then
                Directory.CreateDirectory(newFolderPath)
            End If
            File.Move(fi.FullName, Path.Combine(newFolderPath, fi.Name))
        Next fi
    End Sub
End Class
