Public Class Utils

#Region "Public Functions"
    Public Shared Function GetDefaultFolder() As String
        If My.Settings.DefaultFolder = "" Then
            My.Settings.DefaultFolder = IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyPictures, "Scans")
            My.Settings.Save()
        End If
        If Not My.Computer.FileSystem.DirectoryExists(My.Settings.DefaultFolder) Then My.Computer.FileSystem.CreateDirectory(My.Settings.DefaultFolder)
        Return My.Settings.DefaultFolder
    End Function
#End Region

End Class
