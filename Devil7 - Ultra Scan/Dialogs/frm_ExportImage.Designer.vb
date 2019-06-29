<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ExportImage
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ExportImage))
        Me.lbl_Format = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_StartingNumer = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_FilenamePreview = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Format = New DevExpress.XtraEditors.TextEdit()
        Me.txt_StartingNumer = New DevExpress.XtraEditors.SpinEdit()
        Me.txt_FilenamePreview = New DevExpress.XtraEditors.LabelControl()
        Me.btn_OK = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_Folder = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Folder = New DevExpress.XtraEditors.ButtonEdit()
        Me.dialog_SelectFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.lbl_Overwrite = New DevExpress.XtraEditors.LabelControl()
        Me.rpg_Overwrite = New DevExpress.XtraEditors.RadioGroup()
        CType(Me.txt_Format.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_StartingNumer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Folder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpg_Overwrite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Format
        '
        Me.lbl_Format.Location = New System.Drawing.Point(16, 41)
        Me.lbl_Format.Name = "lbl_Format"
        Me.lbl_Format.Size = New System.Drawing.Size(86, 13)
        Me.lbl_Format.TabIndex = 0
        Me.lbl_Format.Text = "Filename Format :"
        '
        'lbl_StartingNumer
        '
        Me.lbl_StartingNumer.Location = New System.Drawing.Point(17, 67)
        Me.lbl_StartingNumer.Name = "lbl_StartingNumer"
        Me.lbl_StartingNumer.Size = New System.Drawing.Size(85, 13)
        Me.lbl_StartingNumer.TabIndex = 1
        Me.lbl_StartingNumer.Text = "Starting Number :"
        '
        'lbl_FilenamePreview
        '
        Me.lbl_FilenamePreview.Location = New System.Drawing.Point(12, 95)
        Me.lbl_FilenamePreview.Name = "lbl_FilenamePreview"
        Me.lbl_FilenamePreview.Size = New System.Drawing.Size(90, 13)
        Me.lbl_FilenamePreview.TabIndex = 2
        Me.lbl_FilenamePreview.Text = "Filename Preview :"
        '
        'txt_Format
        '
        Me.txt_Format.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Format.EditValue = "Scan_{0:000}"
        Me.txt_Format.Location = New System.Drawing.Point(108, 38)
        Me.txt_Format.Name = "txt_Format"
        Me.txt_Format.Size = New System.Drawing.Size(307, 20)
        Me.txt_Format.TabIndex = 2
        '
        'txt_StartingNumer
        '
        Me.txt_StartingNumer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_StartingNumer.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_StartingNumer.Location = New System.Drawing.Point(108, 64)
        Me.txt_StartingNumer.Name = "txt_StartingNumer"
        Me.txt_StartingNumer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_StartingNumer.Properties.MaxValue = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txt_StartingNumer.Size = New System.Drawing.Size(307, 20)
        Me.txt_StartingNumer.TabIndex = 3
        '
        'txt_FilenamePreview
        '
        Me.txt_FilenamePreview.Location = New System.Drawing.Point(108, 95)
        Me.txt_FilenamePreview.Name = "txt_FilenamePreview"
        Me.txt_FilenamePreview.Size = New System.Drawing.Size(4, 13)
        Me.txt_FilenamePreview.TabIndex = 5
        Me.txt_FilenamePreview.Text = "-"
        '
        'btn_OK
        '
        Me.btn_OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_OK.Location = New System.Drawing.Point(340, 165)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(75, 23)
        Me.btn_OK.TabIndex = 0
        Me.btn_OK.Text = "OK"
        '
        'lbl_Folder
        '
        Me.lbl_Folder.Location = New System.Drawing.Point(65, 15)
        Me.lbl_Folder.Name = "lbl_Folder"
        Me.lbl_Folder.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Folder.TabIndex = 7
        Me.lbl_Folder.Text = "Folder :"
        '
        'txt_Folder
        '
        Me.txt_Folder.Location = New System.Drawing.Point(108, 12)
        Me.txt_Folder.Name = "txt_Folder"
        Me.txt_Folder.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_Folder.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txt_Folder.Size = New System.Drawing.Size(307, 20)
        Me.txt_Folder.TabIndex = 1
        '
        'lbl_Overwrite
        '
        Me.lbl_Overwrite.Location = New System.Drawing.Point(31, 123)
        Me.lbl_Overwrite.Name = "lbl_Overwrite"
        Me.lbl_Overwrite.Size = New System.Drawing.Size(71, 13)
        Me.lbl_Overwrite.TabIndex = 8
        Me.lbl_Overwrite.Text = "On File Exists :"
        '
        'rpg_Overwrite
        '
        Me.rpg_Overwrite.EditValue = False
        Me.rpg_Overwrite.Location = New System.Drawing.Point(108, 118)
        Me.rpg_Overwrite.Name = "rpg_Overwrite"
        Me.rpg_Overwrite.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rpg_Overwrite.Properties.Appearance.Options.UseBackColor = True
        Me.rpg_Overwrite.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rpg_Overwrite.Properties.Columns = 2
        Me.rpg_Overwrite.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Skip to Next Number"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Overwrite Existing File")})
        Me.rpg_Overwrite.Size = New System.Drawing.Size(278, 23)
        Me.rpg_Overwrite.TabIndex = 9
        '
        'frm_ExportImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 200)
        Me.Controls.Add(Me.rpg_Overwrite)
        Me.Controls.Add(Me.lbl_Overwrite)
        Me.Controls.Add(Me.txt_Folder)
        Me.Controls.Add(Me.lbl_Folder)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.txt_FilenamePreview)
        Me.Controls.Add(Me.txt_StartingNumer)
        Me.Controls.Add(Me.txt_Format)
        Me.Controls.Add(Me.lbl_FilenamePreview)
        Me.Controls.Add(Me.lbl_StartingNumer)
        Me.Controls.Add(Me.lbl_Format)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ExportImage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Export Options"
        CType(Me.txt_Format.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_StartingNumer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Folder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpg_Overwrite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Format As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_StartingNumer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_FilenamePreview As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Format As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_StartingNumer As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_FilenamePreview As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_OK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_Folder As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Folder As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents dialog_SelectFolder As FolderBrowserDialog
    Friend WithEvents lbl_Overwrite As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rpg_Overwrite As DevExpress.XtraEditors.RadioGroup
End Class
