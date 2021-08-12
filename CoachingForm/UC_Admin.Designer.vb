<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Admin
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_Admin))
        Me.vals = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.agent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTemplate = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.sdates = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuToolTip1 = New Bunifu.UI.WinForms.BunifuToolTip(Me.components)
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnImportGoal = New System.Windows.Forms.Button()
        Me.btnImportProd = New System.Windows.Forms.Button()
        Me.dgvUploadList = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.metr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.shiftdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnExcel = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuToolTip2 = New Bunifu.UI.WinForms.BunifuToolTip(Me.components)
        CType(Me.dgvTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUploadList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vals
        '
        Me.vals.HeaderText = "Value"
        Me.vals.Name = "vals"
        Me.vals.ReadOnly = True
        '
        'sa
        '
        Me.sa.HeaderText = "MetricsID"
        Me.sa.Name = "sa"
        Me.sa.ReadOnly = True
        '
        'agent
        '
        Me.agent.HeaderText = "AgentID"
        Me.agent.Name = "agent"
        Me.agent.ReadOnly = True
        '
        'dgvTemplate
        '
        Me.dgvTemplate.AllowCustomTheming = False
        Me.dgvTemplate.AllowUserToAddRows = False
        Me.dgvTemplate.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvTemplate.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTemplate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTemplate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTemplate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvTemplate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTemplate.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTemplate.ColumnHeadersHeight = 40
        Me.dgvTemplate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.agent, Me.sa, Me.sdates, Me.vals})
        Me.dgvTemplate.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTemplate.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgvTemplate.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvTemplate.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTemplate.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvTemplate.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.dgvTemplate.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTemplate.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.dgvTemplate.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.dgvTemplate.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvTemplate.CurrentTheme.Name = Nothing
        Me.dgvTemplate.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvTemplate.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgvTemplate.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvTemplate.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTemplate.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTemplate.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTemplate.EnableHeadersVisualStyles = False
        Me.dgvTemplate.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTemplate.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.dgvTemplate.HeaderBgColor = System.Drawing.Color.Empty
        Me.dgvTemplate.HeaderForeColor = System.Drawing.Color.White
        Me.dgvTemplate.Location = New System.Drawing.Point(-16, -88)
        Me.dgvTemplate.Name = "dgvTemplate"
        Me.dgvTemplate.ReadOnly = True
        Me.dgvTemplate.RowHeadersVisible = False
        Me.dgvTemplate.RowTemplate.Height = 40
        Me.dgvTemplate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTemplate.Size = New System.Drawing.Size(89, 28)
        Me.dgvTemplate.TabIndex = 37
        Me.dgvTemplate.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        Me.BunifuToolTip2.SetToolTip(Me.dgvTemplate, "")
        Me.BunifuToolTip1.SetToolTip(Me.dgvTemplate, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.dgvTemplate, Nothing)
        Me.BunifuToolTip2.SetToolTipIcon(Me.dgvTemplate, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.dgvTemplate, "")
        Me.BunifuToolTip2.SetToolTipTitle(Me.dgvTemplate, "")
        Me.dgvTemplate.Visible = False
        '
        'sdates
        '
        Me.sdates.HeaderText = "Shiftdate"
        Me.sdates.Name = "sdates"
        Me.sdates.ReadOnly = True
        '
        'BunifuToolTip1
        '
        Me.BunifuToolTip1.Active = True
        Me.BunifuToolTip1.AlignTextWithTitle = False
        Me.BunifuToolTip1.AllowAutoClose = False
        Me.BunifuToolTip1.AllowFading = True
        Me.BunifuToolTip1.AutoCloseDuration = 5000
        Me.BunifuToolTip1.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro
        Me.BunifuToolTip1.ClickToShowDisplayControl = False
        Me.BunifuToolTip1.ConvertNewlinesToBreakTags = True
        Me.BunifuToolTip1.DisplayControl = Nothing
        Me.BunifuToolTip1.EntryAnimationSpeed = 350
        Me.BunifuToolTip1.ExitAnimationSpeed = 200
        Me.BunifuToolTip1.GenerateAutoCloseDuration = False
        Me.BunifuToolTip1.IconMargin = 6
        Me.BunifuToolTip1.InitialDelay = 0
        Me.BunifuToolTip1.Name = "BunifuToolTip1"
        Me.BunifuToolTip1.Opacity = 1.0R
        Me.BunifuToolTip1.OverrideToolTipTitles = False
        Me.BunifuToolTip1.Padding = New System.Windows.Forms.Padding(10)
        Me.BunifuToolTip1.ReshowDelay = 100
        Me.BunifuToolTip1.ShowAlways = True
        Me.BunifuToolTip1.ShowBorders = False
        Me.BunifuToolTip1.ShowIcons = True
        Me.BunifuToolTip1.ShowShadows = True
        Me.BunifuToolTip1.Tag = Nothing
        Me.BunifuToolTip1.TextFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuToolTip1.TextMargin = 2
        Me.BunifuToolTip1.TitleFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuToolTip1.TitleForeColor = System.Drawing.Color.Black
        Me.BunifuToolTip1.ToolTipPosition = New System.Drawing.Point(0, 0)
        Me.BunifuToolTip1.ToolTipTitle = Nothing
        '
        'btnUpload
        '
        Me.btnUpload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpload.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.Location = New System.Drawing.Point(836, -92)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(135, 32)
        Me.btnUpload.TabIndex = 33
        Me.btnUpload.Text = "Upload to Database"
        Me.BunifuToolTip2.SetToolTip(Me.btnUpload, "")
        Me.BunifuToolTip1.SetToolTip(Me.btnUpload, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.btnUpload, Nothing)
        Me.BunifuToolTip2.SetToolTipIcon(Me.btnUpload, Nothing)
        Me.BunifuToolTip2.SetToolTipTitle(Me.btnUpload, "")
        Me.BunifuToolTip1.SetToolTipTitle(Me.btnUpload, "")
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'btnImportGoal
        '
        Me.btnImportGoal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportGoal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportGoal.Location = New System.Drawing.Point(695, -92)
        Me.btnImportGoal.Name = "btnImportGoal"
        Me.btnImportGoal.Size = New System.Drawing.Size(135, 32)
        Me.btnImportGoal.TabIndex = 34
        Me.btnImportGoal.Text = "Import Goal"
        Me.BunifuToolTip2.SetToolTip(Me.btnImportGoal, "")
        Me.BunifuToolTip1.SetToolTip(Me.btnImportGoal, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.btnImportGoal, Nothing)
        Me.BunifuToolTip2.SetToolTipIcon(Me.btnImportGoal, Nothing)
        Me.BunifuToolTip2.SetToolTipTitle(Me.btnImportGoal, "")
        Me.BunifuToolTip1.SetToolTipTitle(Me.btnImportGoal, "")
        Me.btnImportGoal.UseVisualStyleBackColor = True
        '
        'btnImportProd
        '
        Me.btnImportProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportProd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportProd.Location = New System.Drawing.Point(554, -92)
        Me.btnImportProd.Name = "btnImportProd"
        Me.btnImportProd.Size = New System.Drawing.Size(135, 32)
        Me.btnImportProd.TabIndex = 35
        Me.btnImportProd.Text = "Import Productivity"
        Me.BunifuToolTip2.SetToolTip(Me.btnImportProd, "")
        Me.BunifuToolTip1.SetToolTip(Me.btnImportProd, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.btnImportProd, Nothing)
        Me.BunifuToolTip2.SetToolTipIcon(Me.btnImportProd, Nothing)
        Me.BunifuToolTip2.SetToolTipTitle(Me.btnImportProd, "")
        Me.BunifuToolTip1.SetToolTipTitle(Me.btnImportProd, "")
        Me.btnImportProd.UseVisualStyleBackColor = True
        '
        'dgvUploadList
        '
        Me.dgvUploadList.AllowUserToAddRows = False
        Me.dgvUploadList.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvUploadList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvUploadList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvUploadList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUploadList.BackgroundColor = System.Drawing.Color.White
        Me.dgvUploadList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvUploadList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvUploadList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUploadList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvUploadList.ColumnHeadersHeight = 50
        Me.dgvUploadList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvUploadList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.metr, Me.AgentID, Me.AgentName, Me.shiftdate, Me.mname, Me.Value})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUploadList.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvUploadList.EnableHeadersVisualStyles = False
        Me.dgvUploadList.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUploadList.Location = New System.Drawing.Point(-16, -54)
        Me.dgvUploadList.Name = "dgvUploadList"
        Me.dgvUploadList.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUploadList.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvUploadList.RowHeadersVisible = False
        Me.dgvUploadList.RowHeadersWidth = 50
        Me.dgvUploadList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvUploadList.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvUploadList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUploadList.Size = New System.Drawing.Size(986, 630)
        Me.dgvUploadList.TabIndex = 32
        Me.dgvUploadList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvUploadList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvUploadList.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvUploadList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvUploadList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvUploadList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvUploadList.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvUploadList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUploadList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUploadList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvUploadList.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvUploadList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvUploadList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvUploadList.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvUploadList.ThemeStyle.ReadOnly = True
        Me.dgvUploadList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvUploadList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvUploadList.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvUploadList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvUploadList.ThemeStyle.RowsStyle.Height = 22
        Me.dgvUploadList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUploadList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BunifuToolTip1.SetToolTip(Me.dgvUploadList, "")
        Me.BunifuToolTip2.SetToolTip(Me.dgvUploadList, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.dgvUploadList, Nothing)
        Me.BunifuToolTip2.SetToolTipIcon(Me.dgvUploadList, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.dgvUploadList, "")
        Me.BunifuToolTip2.SetToolTipTitle(Me.dgvUploadList, "")
        '
        'metr
        '
        Me.metr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.metr.DataPropertyName = "MetricsID"
        Me.metr.FillWeight = 150.0!
        Me.metr.HeaderText = "MetricsID"
        Me.metr.Name = "metr"
        Me.metr.ReadOnly = True
        Me.metr.Visible = False
        Me.metr.Width = 86
        '
        'AgentID
        '
        Me.AgentID.DataPropertyName = "AgentID"
        Me.AgentID.HeaderText = "AgentID"
        Me.AgentID.Name = "AgentID"
        Me.AgentID.ReadOnly = True
        '
        'AgentName
        '
        Me.AgentName.DataPropertyName = "Name"
        Me.AgentName.HeaderText = "AgentName"
        Me.AgentName.Name = "AgentName"
        Me.AgentName.ReadOnly = True
        '
        'shiftdate
        '
        Me.shiftdate.DataPropertyName = "Date"
        Me.shiftdate.HeaderText = "Shiftdate"
        Me.shiftdate.Name = "shiftdate"
        Me.shiftdate.ReadOnly = True
        '
        'mname
        '
        Me.mname.DataPropertyName = "MetricsName"
        Me.mname.HeaderText = "Metrics Name"
        Me.mname.Name = "mname"
        Me.mname.ReadOnly = True
        '
        'Value
        '
        Me.Value.DataPropertyName = "Value"
        Me.Value.HeaderText = "Value"
        Me.Value.Name = "Value"
        Me.Value.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(805, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 32)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Upload to Database"
        Me.BunifuToolTip2.SetToolTip(Me.Button1, "")
        Me.BunifuToolTip1.SetToolTip(Me.Button1, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.Button1, Nothing)
        Me.BunifuToolTip2.SetToolTipIcon(Me.Button1, Nothing)
        Me.BunifuToolTip2.SetToolTipTitle(Me.Button1, "")
        Me.BunifuToolTip1.SetToolTipTitle(Me.Button1, "")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(664, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 32)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Import Goal"
        Me.BunifuToolTip2.SetToolTip(Me.Button2, "")
        Me.BunifuToolTip1.SetToolTip(Me.Button2, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.Button2, Nothing)
        Me.BunifuToolTip2.SetToolTipIcon(Me.Button2, Nothing)
        Me.BunifuToolTip2.SetToolTipTitle(Me.Button2, "")
        Me.BunifuToolTip1.SetToolTipTitle(Me.Button2, "")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(523, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 32)
        Me.Button3.TabIndex = 41
        Me.Button3.Text = "Import Productivity"
        Me.BunifuToolTip2.SetToolTip(Me.Button3, "")
        Me.BunifuToolTip1.SetToolTip(Me.Button3, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.Button3, Nothing)
        Me.BunifuToolTip2.SetToolTipIcon(Me.Button3, Nothing)
        Me.BunifuToolTip2.SetToolTipTitle(Me.Button3, "")
        Me.BunifuToolTip1.SetToolTipTitle(Me.Button3, "")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Guna2DataGridView1
        '
        Me.Guna2DataGridView1.AllowUserToAddRows = False
        Me.Guna2DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.Guna2DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Guna2DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.Guna2DataGridView1.ColumnHeadersHeight = 50
        Me.Guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle11
        Me.Guna2DataGridView1.EnableHeadersVisualStyles = False
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(40, 66)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.RowHeadersWidth = 50
        Me.Guna2DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Guna2DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.Guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(891, 377)
        Me.Guna2DataGridView1.TabIndex = 38
        Me.Guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 50
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = True
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BunifuToolTip1.SetToolTip(Me.Guna2DataGridView1, "")
        Me.BunifuToolTip2.SetToolTip(Me.Guna2DataGridView1, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.Guna2DataGridView1, Nothing)
        Me.BunifuToolTip2.SetToolTipIcon(Me.Guna2DataGridView1, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.Guna2DataGridView1, "")
        Me.BunifuToolTip2.SetToolTipTitle(Me.Guna2DataGridView1, "")
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.ImageActive = Nothing
        Me.btnExcel.Location = New System.Drawing.Point(517, -91)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(31, 31)
        Me.btnExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExcel.TabIndex = 36
        Me.btnExcel.TabStop = False
        Me.BunifuToolTip2.SetToolTip(Me.btnExcel, "")
        Me.BunifuToolTip1.SetToolTip(Me.btnExcel, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.btnExcel, Nothing)
        Me.BunifuToolTip2.SetToolTipIcon(Me.btnExcel, Nothing)
        Me.BunifuToolTip2.SetToolTipTitle(Me.btnExcel, "")
        Me.BunifuToolTip1.SetToolTipTitle(Me.btnExcel, "Download template here.")
        Me.btnExcel.Zoom = 10
        '
        'BunifuToolTip2
        '
        Me.BunifuToolTip2.Active = True
        Me.BunifuToolTip2.AlignTextWithTitle = False
        Me.BunifuToolTip2.AllowAutoClose = False
        Me.BunifuToolTip2.AllowFading = True
        Me.BunifuToolTip2.AutoCloseDuration = 5000
        Me.BunifuToolTip2.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuToolTip2.BorderColor = System.Drawing.Color.Gainsboro
        Me.BunifuToolTip2.ClickToShowDisplayControl = False
        Me.BunifuToolTip2.ConvertNewlinesToBreakTags = True
        Me.BunifuToolTip2.DisplayControl = Nothing
        Me.BunifuToolTip2.EntryAnimationSpeed = 350
        Me.BunifuToolTip2.ExitAnimationSpeed = 200
        Me.BunifuToolTip2.GenerateAutoCloseDuration = False
        Me.BunifuToolTip2.IconMargin = 6
        Me.BunifuToolTip2.InitialDelay = 0
        Me.BunifuToolTip2.Name = "BunifuToolTip2"
        Me.BunifuToolTip2.Opacity = 1.0R
        Me.BunifuToolTip2.OverrideToolTipTitles = False
        Me.BunifuToolTip2.Padding = New System.Windows.Forms.Padding(10)
        Me.BunifuToolTip2.ReshowDelay = 100
        Me.BunifuToolTip2.ShowAlways = True
        Me.BunifuToolTip2.ShowBorders = False
        Me.BunifuToolTip2.ShowIcons = True
        Me.BunifuToolTip2.ShowShadows = True
        Me.BunifuToolTip2.Tag = Nothing
        Me.BunifuToolTip2.TextFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuToolTip2.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuToolTip2.TextMargin = 2
        Me.BunifuToolTip2.TitleFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuToolTip2.TitleForeColor = System.Drawing.Color.Black
        Me.BunifuToolTip2.ToolTipPosition = New System.Drawing.Point(0, 0)
        Me.BunifuToolTip2.ToolTipTitle = Nothing
        '
        'UC_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Guna2DataGridView1)
        Me.Controls.Add(Me.dgvTemplate)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnImportGoal)
        Me.Controls.Add(Me.btnImportProd)
        Me.Controls.Add(Me.dgvUploadList)
        Me.Name = "UC_Admin"
        Me.Size = New System.Drawing.Size(954, 485)
        Me.BunifuToolTip2.SetToolTip(Me, "")
        Me.BunifuToolTip1.SetToolTip(Me, "")
        Me.BunifuToolTip2.SetToolTipIcon(Me, Nothing)
        Me.BunifuToolTip1.SetToolTipIcon(Me, Nothing)
        Me.BunifuToolTip2.SetToolTipTitle(Me, "")
        Me.BunifuToolTip1.SetToolTipTitle(Me, "")
        CType(Me.dgvTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUploadList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents vals As DataGridViewTextBoxColumn
    Friend WithEvents sa As DataGridViewTextBoxColumn
    Friend WithEvents agent As DataGridViewTextBoxColumn
    Friend WithEvents dgvTemplate As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents sdates As DataGridViewTextBoxColumn
    Friend WithEvents BunifuToolTip2 As Bunifu.UI.WinForms.BunifuToolTip
    Friend WithEvents BunifuToolTip1 As Bunifu.UI.WinForms.BunifuToolTip
    Friend WithEvents btnExcel As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnUpload As Button
    Friend WithEvents btnImportGoal As Button
    Friend WithEvents btnImportProd As Button
    Friend WithEvents dgvUploadList As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents metr As DataGridViewTextBoxColumn
    Friend WithEvents AgentID As DataGridViewTextBoxColumn
    Friend WithEvents AgentName As DataGridViewTextBoxColumn
    Friend WithEvents shiftdate As DataGridViewTextBoxColumn
    Friend WithEvents mname As DataGridViewTextBoxColumn
    Friend WithEvents Value As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
End Class
