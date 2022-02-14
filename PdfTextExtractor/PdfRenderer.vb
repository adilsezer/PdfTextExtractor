Imports System.IO
Imports System.Text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.parser
Imports PdfiumViewer

Module PdfRenderer

    Public Sub RenderPdfToPng(pdfFileName As String)
        Dim outputFileName As String = IO.Path.GetFileNameWithoutExtension(pdfFileName) & ".png"
        Dim outputFolder As String = IO.Path.GetDirectoryName(pdfFileName)
        Using document = PdfiumViewer.PdfDocument.Load(pdfFileName)
            For page As Integer = 0 To document.PageCount - 1
                Dim image = document.Render(page, 300, 300, PdfRenderFlags.CorrectFromDpi)
                image.Save(outputFolder & "\page_" & page.ToString & "_" & outputFileName, Imaging.ImageFormat.Png)
            Next page
        End Using
    End Sub

    Public Function ReadPdfFile(fileName As String) As String
        Dim text As StringBuilder = New StringBuilder()
        If File.Exists(fileName) Then
            Dim pdfReader As PdfReader = New PdfReader(fileName)
            For page As Integer = 1 To pdfReader.NumberOfPages
                Dim strategy As ITextExtractionStrategy = New SimpleTextExtractionStrategy()
                Dim currentText As String = parser.PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy)
                currentText = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(currentText)))
                text.Append(currentText)
            Next
            pdfReader.Close()
        End If
        Return text.ToString()
    End Function

End Module
