Imports System.IO
Module FolderWatcher

    Public WithEvents m_FileSystemWatcher As FileSystemWatcher
    Public Sub StartWatcher(inputFolder As String)
        m_FileSystemWatcher = New FileSystemWatcher(inputFolder, "*.pdf")
        m_FileSystemWatcher.SynchronizingObject = PdfTextExtractorUI
        m_FileSystemWatcher.NotifyFilter = 0
        m_FileSystemWatcher.NotifyFilter =
            m_FileSystemWatcher.NotifyFilter Or
            NotifyFilters.FileName
        m_FileSystemWatcher.EnableRaisingEvents = True

        ' Process any files that already exist.
        ProcessExistingFiles(inputFolder)
    End Sub

    ' Process a new file.
    Private Sub m_FileSystemWatcher_Created(ByVal sender As _
    Object, ByVal e As FileSystemEventArgs) _
    Handles m_FileSystemWatcher.Created
        Try
            m_FileSystemWatcher.EnableRaisingEvents = False
            PdfTextExtractorUI.ProcessFile(e.FullPath)
        Finally
            m_FileSystemWatcher.EnableRaisingEvents = True
        End Try
    End Sub

    Public Sub Dispose()
        m_FileSystemWatcher.EnableRaisingEvents = False
        m_FileSystemWatcher.Dispose()
    End Sub

    ' Process existing files.
    Private Sub ProcessExistingFiles(ByVal inputFolder As _
        String)
        Dim dirInfo As New DirectoryInfo(inputFolder)
        Dim fileInfos As FileInfo() = dirInfo.GetFiles()
        For Each fi As FileInfo In fileInfos
            PdfTextExtractorUI.ProcessFile(fi.FullName)
        Next fi
    End Sub

End Module
