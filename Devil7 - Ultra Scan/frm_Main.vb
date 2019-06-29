Imports DevExpress.XtraBars
Imports Dynamsoft.TWAIN
Imports Dynamsoft.TWAIN.Interface

Public Class frm_Main : Implements IAcquireCallback

#Region "Variables"
    Private TWAINManager As TwainManager
    Private ScanCount As Integer = 1
    Private FitZoomPrecent As Double = -1
#End Region

#Region "Properties"
    Private ReadOnly Property Pages As DevExpress.XtraBars.Ribbon.GalleryItemGroup
        Get
            If gallery_Pages.Gallery.Groups.Count = 0 Then gallery_Pages.Gallery.Groups.Add(New DevExpress.XtraBars.Ribbon.GalleryItemGroup With {.Caption = "Scanned Pages"})
            Return gallery_Pages.Gallery.Groups(0)
        End Get
    End Property

    Private ReadOnly Property ScannerIndex As Integer
        Get
            Return cmb_Scanner_Edit.Items.IndexOf(cmb_Scanner.EditValue)
        End Get
    End Property
#End Region

#Region "Constructor"
    Public Sub New()
        InitializeComponent()
        DevExpress.UserSkins.BonusSkins.Register()
        TWAINManager = New TwainManager(Keys.DynamSoftKey)
    End Sub
#End Region

#Region "Subs"
    Function ShowMessage(ByVal Text As String, ByVal Caption As String, ByVal Buttons As MessageBoxButtons, ByVal Icon As MessageBoxIcon) As DialogResult
        Return DevExpress.XtraEditors.XtraMessageBox.Show(Text, Caption, Buttons, Icon)
    End Function

    Private Sub RefreshScanners()
        cmb_Scanner_Edit.Items.Clear()
        For i As Integer = 0 To TWAINManager.SourceCount - 1
            cmb_Scanner_Edit.Items.Add(TWAINManager.SourceNameItems(i))
        Next
        If cmb_Scanner_Edit.Items.Count > 0 And cmb_Scanner.EditValue Is Nothing Then cmb_Scanner.EditValue = cmb_Scanner_Edit.Items(0)
    End Sub

    Private Sub EnableControls()
        If InvokeRequired Then
            Invoke(Sub() EnableControls())
        Else
            rpg_Pages.Enabled = True
            rpg_Scanner.Enabled = True
        End If
    End Sub

    Private Sub DisableControls()
        If InvokeRequired Then
            Invoke(Sub() DisableControls())
        Else
            rpg_Pages.Enabled = False
            rpg_Scanner.Enabled = False
        End If
    End Sub

    Private Sub ZoomToFit()
        Dim ZoomPercent As Double = Math.Min(100, Math.Min((pic_Preview.Width - 12) * 100 / pic_Preview.Image.Width,
                               (pic_Preview.Height - 2) * 100 / pic_Preview.Image.Height))
        pic_Preview.Properties.ZoomPercent = ZoomPercent
        FitZoomPrecent = ZoomPercent
    End Sub

    Private Sub RetainFit()
        If FitZoomPrecent <> -1 And pic_Preview.Properties.ZoomPercent = FitZoomPrecent Then
            ZoomToFit()
        End If
    End Sub

    Private Sub CheckForSelectedItems()
        If InvokeRequired Then
            Invoke(Sub() CheckForSelectedItems())
        Else
            Dim Count As Integer = gallery_Pages.Gallery.GetCheckedItemsCount

            If Count = 0 Then
                btn_Page_MoveDown.Enabled = False
                btn_Page_MoveUp.Enabled = False
                btn_RemovePage.Enabled = False
            ElseIf Count = 1 Then
                btn_Page_MoveDown.Enabled = (Pages.Items.IndexOf(gallery_Pages.Gallery.GetCheckedItems(0)) < Pages.Items.Count - 1)
                btn_Page_MoveUp.Enabled = (Pages.Items.IndexOf(gallery_Pages.Gallery.GetCheckedItems(0)) > 0)
                btn_RemovePage.Enabled = True
            ElseIf Count > 1 Then
                btn_Page_MoveDown.Enabled = False
                btn_Page_MoveUp.Enabled = False
                btn_RemovePage.Enabled = True
            End If

            If Count > 0 Then
                Try
                    pic_Preview.Image = gallery_Pages.Gallery.GetCheckedItems(Count - 1).Image
                    ZoomToFit()
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub
#End Region

#Region "Interface"
#Region "AcquireCallback"
    Private Sub IAcquireCallback_OnPreAllTransfers() Implements IAcquireCallback.OnPreAllTransfers
        DisableControls()
    End Sub

    Private Function IAcquireCallback_OnPreTransfer() As Boolean Implements IAcquireCallback.OnPreTransfer
        Return True
    End Function

    Private Function IAcquireCallback_OnPostTransfer(bit As Bitmap) As Boolean Implements IAcquireCallback.OnPostTransfer
        Pages.Items.Add(New DevExpress.XtraBars.Ribbon.GalleryItem(bit, String.Format("Scan {0:000}", ScanCount), ""))
        Me.ScanCount += 1
        CheckForSelectedItems()
        Return True
    End Function

    Private Sub IAcquireCallback_OnPostAllTransfers() Implements IAcquireCallback.OnPostAllTransfers
        EnableControls()
    End Sub

    Private Sub IAcquireCallback_OnSourceUIClose() Implements IAcquireCallback.OnSourceUIClose
        EnableControls()
    End Sub

    Private Sub IAcquireCallback_OnTransferCancelled() Implements IAcquireCallback.OnTransferCancelled
        ShowMessage("Scan cancelled by the user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        EnableControls()
    End Sub

    Private Sub IAcquireCallback_OnTransferError() Implements IAcquireCallback.OnTransferError
        ShowMessage("Scan failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
#End Region
#End Region

#Region "Form Events"
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        TWAINManager.OpenSourceManager()
        RefreshScanners()
    End Sub

    Private Sub frm_Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        TWAINManager.CloseSource()
        TWAINManager.CloseSourceManager()
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_Scan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Scan.ItemClick
        TWAINManager.SelectSourceByIndex(ScannerIndex)
        TWAINManager.IfShowUI = sw_ShowUI.Checked
        TWAINManager.OpenSource()
        TWAINManager.AcquireImage(Me)
    End Sub

    Private Sub btn_Page_MoveUp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Page_MoveUp.ItemClick
        If Pages.GetCheckedItemsCount = 1 Then
            Dim SelectedItem As DevExpress.XtraBars.Ribbon.GalleryItem = Pages.GetCheckedItems(0)
            Dim NewIndex As Integer = Pages.Items.IndexOf(SelectedItem) - 1
            If NewIndex >= 0 Then
                Pages.Items.Remove(SelectedItem)
                Pages.Items.Insert(NewIndex, SelectedItem)
                CheckForSelectedItems()
            End If
        End If
    End Sub

    Private Sub btn_Page_MoveDown_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Page_MoveDown.ItemClick
        If Pages.GetCheckedItemsCount = 1 Then
            Dim SelectedItem As DevExpress.XtraBars.Ribbon.GalleryItem = Pages.GetCheckedItems(0)
            Dim NewIndex As Integer = Pages.Items.IndexOf(SelectedItem) + 1
            If NewIndex <= Pages.Items.Count - 1 Then
                Pages.Items.Remove(SelectedItem)
                Pages.Items.Insert(NewIndex, SelectedItem)
                CheckForSelectedItems()
            End If
        End If
    End Sub

    Private Sub btn_RemovePage_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_RemovePage.ItemClick
        If Pages.GetCheckedItemsCount > 0 Then
            If ShowMessage("Do you want to remove selected pages? This action cannot be reversed!", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                Dim Items2Remove As List(Of DevExpress.XtraBars.Ribbon.GalleryItem) = Pages.GetCheckedItems
                For Each i As DevExpress.XtraBars.Ribbon.GalleryItem In Items2Remove
                    Pages.Items.Remove(i)
                Next
            End If
        End If
    End Sub
#End Region

#Region "Export Events"
    Private Sub btn_Export_BMP_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Export_BMP.ItemClick
        Dim D As New frm_ExportImage
        If D.ShowDialog = DialogResult.OK Then
            Dim FileIndex As Integer = D.StartingNumber
            For Each Item As DevExpress.XtraBars.Ribbon.GalleryItem In Pages.Items
BuildFilePath:
                Dim FilePath As String = IO.Path.Combine(D.BaseFolder, String.Format(D.FilenameFormat, FileIndex) & ".bmp")
                If Not D.Overwrite AndAlso My.Computer.FileSystem.FileExists(FilePath) Then
                    FileIndex += 1
                    GoTo BuildFilePath
                End If
                Item.Image.Save(FilePath, Imaging.ImageFormat.Bmp)
                FileIndex += 1
            Next
        End If
    End Sub

    Private Sub btn_Export_JPEG_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Export_JPEG.ItemClick
        Dim D As New frm_ExportImage
        If D.ShowDialog = DialogResult.OK Then
            Dim FileIndex As Integer = D.StartingNumber
            For Each Item As DevExpress.XtraBars.Ribbon.GalleryItem In Pages.Items
BuildFilePath:
                Dim FilePath As String = IO.Path.Combine(D.BaseFolder, String.Format(D.FilenameFormat, FileIndex) & ".jpg")
                If Not D.Overwrite AndAlso My.Computer.FileSystem.FileExists(FilePath) Then
                    FileIndex += 1
                    GoTo BuildFilePath
                End If
                Item.Image.Save(FilePath, Imaging.ImageFormat.Jpeg)
                FileIndex += 1
            Next
        End If
    End Sub

    Private Sub btn_Export_PNG_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Export_PNG.ItemClick
        Dim D As New frm_ExportImage
        If D.ShowDialog = DialogResult.OK Then
            Dim FileIndex As Integer = D.StartingNumber
            For Each Item As DevExpress.XtraBars.Ribbon.GalleryItem In Pages.Items
BuildFilePath:
                Dim FilePath As String = IO.Path.Combine(D.BaseFolder, String.Format(D.FilenameFormat, FileIndex) & ".png")
                If Not D.Overwrite AndAlso My.Computer.FileSystem.FileExists(FilePath) Then
                    FileIndex += 1
                    GoTo BuildFilePath
                End If
                Item.Image.Save(FilePath, Imaging.ImageFormat.Png)
                FileIndex += 1
            Next
            My.Settings.StartingNumber = FileIndex
            My.Settings.Save()
        End If
    End Sub
#End Region

#Region "Other Events"
    Private Sub gallery_Pages_Gallery_ItemCheckedChanged(sender As Object, e As DevExpress.XtraBars.Ribbon.GalleryItemEventArgs) Handles gallery_Pages.Gallery.ItemCheckedChanged
        CheckForSelectedItems()
    End Sub

    Private Sub container_Main_SplitterMoving(sender As Object, e As DevExpress.XtraEditors.SplitMovingEventArgs) Handles container_Main.SplitterMoving
        RetainFit()
    End Sub

    Private Sub container_Main_SizeChanged(sender As Object, e As EventArgs) Handles container_Main.SizeChanged
        RetainFit()
    End Sub
#End Region

End Class