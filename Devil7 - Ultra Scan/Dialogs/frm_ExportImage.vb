Public Class frm_ExportImage

#Region "Properties"
    ReadOnly Property FilenameFormat As String
        Get
            Return txt_Format.Text
        End Get
    End Property

    ReadOnly Property StartingNumber As Integer
        Get
            Return txt_StartingNumer.Value
        End Get
    End Property

    ReadOnly Property BaseFolder As String
        Get
            Return txt_Folder.Text
        End Get
    End Property

    ReadOnly Property Overwrite As Boolean
        Get
            Return rpg_Overwrite.EditValue
        End Get
    End Property
#End Region

#Region "Subs"
    Private Sub RefreshPreview()
        txt_FilenamePreview.Text = String.Format(txt_Format.Text, txt_StartingNumer.Value)
    End Sub
#End Region

#Region "Form Events"
    Private Sub frm_ExportImage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_Format.Text = My.Settings.FilenameFormat
        txt_StartingNumer.Value = My.Settings.StartingNumber
        txt_Folder.Text = Utils.GetDefaultFolder
        rpg_Overwrite.EditValue = My.Settings.OverwriteFiles
    End Sub
#End Region

#Region "Button Events"
    Private Sub txt_Folder_EditValueChanged(sender As Object, e As EventArgs) Handles txt_Folder.EditValueChanged
        If My.Computer.FileSystem.DirectoryExists(txt_Folder.Text) Then dialog_SelectFolder.SelectedPath = txt_Folder.Text

        If dialog_SelectFolder.ShowDialog = DialogResult.OK Then
            txt_Folder.Text = dialog_SelectFolder.SelectedPath
        End If
    End Sub

    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub
#End Region

#Region "Other Events"
    Private Sub txt_Format_EditValueChanged(sender As Object, e As EventArgs) Handles txt_Format.EditValueChanged
        RefreshPreview()
        My.Settings.FilenameFormat = txt_Format.Text
        My.Settings.Save()
    End Sub

    Private Sub txt_StartingNumer_ValueChanged(sender As Object, e As EventArgs) Handles txt_StartingNumer.ValueChanged
        RefreshPreview()
        My.Settings.StartingNumber = txt_StartingNumer.Value
        My.Settings.Save()
    End Sub

    Private Sub rpg_Overwrite_EditValueChanged(sender As Object, e As EventArgs) Handles rpg_Overwrite.EditValueChanged
        My.Settings.OverwriteFiles = rpg_Overwrite.EditValue
        My.Settings.Save()
    End Sub
#End Region

End Class