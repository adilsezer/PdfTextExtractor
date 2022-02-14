Imports System.IO
Imports Tesseract
Module OCREngine
    Public Function ExtractText(pdfPath As String) As String
        CheckTessDataExist()
        Dim text As String = ""
        Try
            'creating the tesseract OCR engine with English as the language
            Using tEngine = New TesseractEngine("./tessdata", "eng", EngineMode.[Default])
                For Each pngFile In Directory.GetFiles(Path.GetDirectoryName(pdfPath), "*.png")
                    ' Load of the image file from the Pix object which is a wrapper for Leptonica PIX structure
                    Using img = Pix.LoadFromFile(pngFile)
                        'process the specified image
                        Using page = tEngine.Process(img)
                            text += page.GetText()
                        End Using
                    End Using
                    File.Delete(pngFile)
                Next pngFile
            End Using
        Catch e As Exception
            text = "Unexpected Error when extracting text: " + e.Message
        End Try
        Return text
    End Function

    Private Sub CheckTessDataExist()

        If Not Directory.Exists("./tessdata") Then
            Directory.CreateDirectory("./tessdata")
        End If

        If Not File.Exists("./tessdata/eng.traineddata") Then
            Dim tessDataOriginal = "../../eng.traineddata"
            Dim tessDataTarget = "./tessdata/eng.traineddata"
            File.Copy(tessDataOriginal, tessDataTarget, True)
        End If
    End Sub

End Module
