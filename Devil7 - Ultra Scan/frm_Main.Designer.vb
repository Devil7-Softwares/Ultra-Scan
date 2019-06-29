<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Main
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.cmb_Scanner = New DevExpress.XtraBars.BarEditItem()
        Me.cmb_Scanner_Edit = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.btn_Scan = New DevExpress.XtraBars.BarButtonItem()
        Me.sw_ShowUI = New DevExpress.XtraBars.BarToggleSwitchItem()
        Me.btn_RemovePage = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Page_MoveUp = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Page_MoveDown = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Export_BMP = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Export_JPEG = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Export_PDF = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Export_PNG = New DevExpress.XtraBars.BarButtonItem()
        Me.rp_Home = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpg_Scanner = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Pages = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Export = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.gallery_Pages = New DevExpress.XtraBars.Ribbon.GalleryControl()
        Me.GalleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
        Me.container_Main = New DevExpress.XtraEditors.SplitContainerControl()
        Me.pic_Preview = New DevExpress.XtraEditors.PictureEdit()
        Me.dialog_SavePDF = New System.Windows.Forms.SaveFileDialog()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Scanner_Edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gallery_Pages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gallery_Pages.SuspendLayout()
        CType(Me.container_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.container_Main.SuspendLayout()
        CType(Me.pic_Preview.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.cmb_Scanner, Me.btn_Scan, Me.sw_ShowUI, Me.btn_RemovePage, Me.btn_Page_MoveUp, Me.btn_Page_MoveDown, Me.btn_Export_BMP, Me.btn_Export_JPEG, Me.btn_Export_PDF, Me.btn_Export_PNG})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 13
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rp_Home})
        Me.RibbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmb_Scanner_Edit})
        Me.RibbonControl.Size = New System.Drawing.Size(745, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'cmb_Scanner
        '
        Me.cmb_Scanner.Caption = "Scanner"
        Me.cmb_Scanner.Edit = Me.cmb_Scanner_Edit
        Me.cmb_Scanner.EditWidth = 150
        Me.cmb_Scanner.Id = 1
        Me.cmb_Scanner.Name = "cmb_Scanner"
        '
        'cmb_Scanner_Edit
        '
        Me.cmb_Scanner_Edit.AutoHeight = False
        Me.cmb_Scanner_Edit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Scanner_Edit.Name = "cmb_Scanner_Edit"
        Me.cmb_Scanner_Edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'btn_Scan
        '
        Me.btn_Scan.Caption = "Scan"
        Me.btn_Scan.Id = 2
        Me.btn_Scan.ImageOptions.SvgImage = CType(resources.GetObject("btn_Scan.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Scan.Name = "btn_Scan"
        '
        'sw_ShowUI
        '
        Me.sw_ShowUI.Caption = "Show Scanner UI"
        Me.sw_ShowUI.Id = 5
        Me.sw_ShowUI.Name = "sw_ShowUI"
        '
        'btn_RemovePage
        '
        Me.btn_RemovePage.Caption = "Remove"
        Me.btn_RemovePage.Enabled = False
        Me.btn_RemovePage.Id = 6
        Me.btn_RemovePage.ImageOptions.SvgImage = CType(resources.GetObject("btn_RemovePage.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_RemovePage.Name = "btn_RemovePage"
        Me.btn_RemovePage.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'btn_Page_MoveUp
        '
        Me.btn_Page_MoveUp.Caption = "Move Up"
        Me.btn_Page_MoveUp.Enabled = False
        Me.btn_Page_MoveUp.Id = 7
        Me.btn_Page_MoveUp.ImageOptions.SvgImage = CType(resources.GetObject("btn_Page_MoveUp.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Page_MoveUp.Name = "btn_Page_MoveUp"
        Me.btn_Page_MoveUp.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'btn_Page_MoveDown
        '
        Me.btn_Page_MoveDown.Caption = "Move Down"
        Me.btn_Page_MoveDown.Enabled = False
        Me.btn_Page_MoveDown.Id = 8
        Me.btn_Page_MoveDown.ImageOptions.SvgImage = CType(resources.GetObject("btn_Page_MoveDown.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Page_MoveDown.Name = "btn_Page_MoveDown"
        Me.btn_Page_MoveDown.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'btn_Export_BMP
        '
        Me.btn_Export_BMP.Caption = "Bitmap"
        Me.btn_Export_BMP.Id = 9
        Me.btn_Export_BMP.ImageOptions.SvgImage = CType(resources.GetObject("btn_Export_BMP.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Export_BMP.Name = "btn_Export_BMP"
        '
        'btn_Export_JPEG
        '
        Me.btn_Export_JPEG.Caption = "Jpeg"
        Me.btn_Export_JPEG.Id = 10
        Me.btn_Export_JPEG.ImageOptions.SvgImage = CType(resources.GetObject("btn_Export_JPEG.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Export_JPEG.Name = "btn_Export_JPEG"
        '
        'btn_Export_PDF
        '
        Me.btn_Export_PDF.Caption = "PDF"
        Me.btn_Export_PDF.Id = 11
        Me.btn_Export_PDF.ImageOptions.SvgImage = CType(resources.GetObject("btn_Export_PDF.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Export_PDF.Name = "btn_Export_PDF"
        '
        'btn_Export_PNG
        '
        Me.btn_Export_PNG.Caption = "PNG"
        Me.btn_Export_PNG.Id = 12
        Me.btn_Export_PNG.ImageOptions.SvgImage = CType(resources.GetObject("btn_Export_PNG.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Export_PNG.Name = "btn_Export_PNG"
        '
        'rp_Home
        '
        Me.rp_Home.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpg_Scanner, Me.rpg_Pages, Me.rpg_Export})
        Me.rp_Home.Name = "rp_Home"
        Me.rp_Home.Text = "Home"
        '
        'rpg_Scanner
        '
        Me.rpg_Scanner.ItemLinks.Add(Me.cmb_Scanner)
        Me.rpg_Scanner.ItemLinks.Add(Me.sw_ShowUI)
        Me.rpg_Scanner.Name = "rpg_Scanner"
        Me.rpg_Scanner.ShowCaptionButton = False
        Me.rpg_Scanner.Text = "Scanner"
        '
        'rpg_Pages
        '
        Me.rpg_Pages.ItemLinks.Add(Me.btn_Scan)
        Me.rpg_Pages.ItemLinks.Add(Me.btn_Page_MoveUp, True)
        Me.rpg_Pages.ItemLinks.Add(Me.btn_Page_MoveDown)
        Me.rpg_Pages.ItemLinks.Add(Me.btn_RemovePage)
        Me.rpg_Pages.Name = "rpg_Pages"
        Me.rpg_Pages.ShowCaptionButton = False
        Me.rpg_Pages.Text = "Pages"
        '
        'rpg_Export
        '
        Me.rpg_Export.ItemLinks.Add(Me.btn_Export_BMP)
        Me.rpg_Export.ItemLinks.Add(Me.btn_Export_JPEG)
        Me.rpg_Export.ItemLinks.Add(Me.btn_Export_PNG)
        Me.rpg_Export.ItemLinks.Add(Me.btn_Export_PDF)
        Me.rpg_Export.Name = "rpg_Export"
        Me.rpg_Export.ShowCaptionButton = False
        Me.rpg_Export.Text = "Export"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 418)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(745, 31)
        '
        'gallery_Pages
        '
        Me.gallery_Pages.Controls.Add(Me.GalleryControlClient1)
        Me.gallery_Pages.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.gallery_Pages.Gallery.ImageSize = New System.Drawing.Size(124, 176)
        Me.gallery_Pages.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.Multiple
        Me.gallery_Pages.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside
        Me.gallery_Pages.Gallery.ShowItemText = True
        Me.gallery_Pages.Location = New System.Drawing.Point(0, 0)
        Me.gallery_Pages.Name = "gallery_Pages"
        Me.gallery_Pages.Size = New System.Drawing.Size(503, 275)
        Me.gallery_Pages.TabIndex = 2
        Me.gallery_Pages.Text = "Pages"
        '
        'GalleryControlClient1
        '
        Me.GalleryControlClient1.GalleryControl = Me.gallery_Pages
        Me.GalleryControlClient1.Location = New System.Drawing.Point(2, 2)
        Me.GalleryControlClient1.Size = New System.Drawing.Size(482, 271)
        '
        'container_Main
        '
        Me.container_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.container_Main.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.container_Main.Location = New System.Drawing.Point(0, 143)
        Me.container_Main.Name = "container_Main"
        Me.container_Main.Panel1.Controls.Add(Me.gallery_Pages)
        Me.container_Main.Panel1.Text = "Panel1"
        Me.container_Main.Panel2.Controls.Add(Me.pic_Preview)
        Me.container_Main.Panel2.Text = "Panel2"
        Me.container_Main.Size = New System.Drawing.Size(745, 275)
        Me.container_Main.SplitterPosition = 237
        Me.container_Main.TabIndex = 5
        '
        'pic_Preview
        '
        Me.pic_Preview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_Preview.Location = New System.Drawing.Point(0, 0)
        Me.pic_Preview.MenuManager = Me.RibbonControl
        Me.pic_Preview.Name = "pic_Preview"
        Me.pic_Preview.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.[True]
        Me.pic_Preview.Properties.AllowScrollViaMouseDrag = True
        Me.pic_Preview.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.[True]
        Me.pic_Preview.Properties.NullText = "Select Page to Preview"
        Me.pic_Preview.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pic_Preview.Properties.ShowScrollBars = True
        Me.pic_Preview.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.[True]
        Me.pic_Preview.Size = New System.Drawing.Size(237, 275)
        Me.pic_Preview.TabIndex = 0
        '
        'dialog_SavePDF
        '
        Me.dialog_SavePDF.DefaultExt = "pdf"
        Me.dialog_SavePDF.Filter = "Portable Document Files (*.pdf)|*.pdf"
        Me.dialog_SavePDF.FilterIndex = 0
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 449)
        Me.Controls.Add(Me.container_Main)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "frm_Main"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "frm_Main"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Scanner_Edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gallery_Pages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gallery_Pages.ResumeLayout(False)
        CType(Me.container_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.container_Main.ResumeLayout(False)
        CType(Me.pic_Preview.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents rp_Home As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpg_Scanner As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents gallery_Pages As DevExpress.XtraBars.Ribbon.GalleryControl
    Friend WithEvents GalleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient
    Friend WithEvents cmb_Scanner As DevExpress.XtraBars.BarEditItem
    Friend WithEvents cmb_Scanner_Edit As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents rpg_Pages As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Scan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sw_ShowUI As DevExpress.XtraBars.BarToggleSwitchItem
    Friend WithEvents container_Main As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents pic_Preview As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btn_RemovePage As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Page_MoveUp As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Page_MoveDown As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Export_BMP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Export_JPEG As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Export_PDF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Export_PNG As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpg_Export As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents dialog_SavePDF As SaveFileDialog
End Class
