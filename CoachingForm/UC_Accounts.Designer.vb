<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Accounts
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_Accounts))
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.cbxAccesstype = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtEmployeeid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPCname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnPassword = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvAccounts = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.EID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnNew = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.BorderRadius = 20
        Me.btnSave.CheckedState.Parent = Me.btnSave
        Me.btnSave.CustomImages.Parent = Me.btnSave
        Me.btnSave.Enabled = False
        Me.btnSave.FillColor = System.Drawing.Color.SeaGreen
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverState.Parent = Me.btnSave
        Me.btnSave.Location = New System.Drawing.Point(141, 240)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(117, 45)
        Me.btnSave.TabIndex = 42
        Me.btnSave.Text = "SAVE"
        '
        'cbxAccesstype
        '
        Me.cbxAccesstype.BackColor = System.Drawing.Color.Transparent
        Me.cbxAccesstype.BorderColor = System.Drawing.Color.Transparent
        Me.cbxAccesstype.BorderRadius = 20
        Me.cbxAccesstype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxAccesstype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAccesstype.FocusedColor = System.Drawing.Color.Empty
        Me.cbxAccesstype.FocusedState.Parent = Me.cbxAccesstype
        Me.cbxAccesstype.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbxAccesstype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbxAccesstype.FormattingEnabled = True
        Me.cbxAccesstype.HoverState.Parent = Me.cbxAccesstype
        Me.cbxAccesstype.ItemHeight = 30
        Me.cbxAccesstype.Items.AddRange(New Object() {"Limited", "Admin", "Full"})
        Me.cbxAccesstype.ItemsAppearance.Parent = Me.cbxAccesstype
        Me.cbxAccesstype.Location = New System.Drawing.Point(18, 176)
        Me.cbxAccesstype.Name = "cbxAccesstype"
        Me.cbxAccesstype.ShadowDecoration.Parent = Me.cbxAccesstype
        Me.cbxAccesstype.Size = New System.Drawing.Size(187, 36)
        Me.cbxAccesstype.TabIndex = 40
        '
        'txtEmployeeid
        '
        Me.txtEmployeeid.BorderColor = System.Drawing.Color.Transparent
        Me.txtEmployeeid.BorderRadius = 20
        Me.txtEmployeeid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmployeeid.DefaultText = ""
        Me.txtEmployeeid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmployeeid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmployeeid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmployeeid.DisabledState.Parent = Me.txtEmployeeid
        Me.txtEmployeeid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmployeeid.Enabled = False
        Me.txtEmployeeid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmployeeid.FocusedState.Parent = Me.txtEmployeeid
        Me.txtEmployeeid.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEmployeeid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmployeeid.HoverState.Parent = Me.txtEmployeeid
        Me.txtEmployeeid.Location = New System.Drawing.Point(17, 104)
        Me.txtEmployeeid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmployeeid.Name = "txtEmployeeid"
        Me.txtEmployeeid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmployeeid.PlaceholderText = ""
        Me.txtEmployeeid.SelectedText = ""
        Me.txtEmployeeid.ShadowDecoration.Parent = Me.txtEmployeeid
        Me.txtEmployeeid.Size = New System.Drawing.Size(188, 35)
        Me.txtEmployeeid.TabIndex = 39
        '
        'btnClear
        '
        Me.btnClear.BorderRadius = 20
        Me.btnClear.CheckedState.Parent = Me.btnClear
        Me.btnClear.CustomImages.Parent = Me.btnClear
        Me.btnClear.FillColor = System.Drawing.Color.Firebrick
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.HoverState.Parent = Me.btnClear
        Me.btnClear.Location = New System.Drawing.Point(18, 240)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.ShadowDecoration.Parent = Me.btnClear
        Me.btnClear.Size = New System.Drawing.Size(117, 45)
        Me.btnClear.TabIndex = 43
        Me.btnClear.Text = "CLEAR"
        '
        'btnEdit
        '
        Me.btnEdit.BorderRadius = 10
        Me.btnEdit.CheckedState.Parent = Me.btnEdit
        Me.btnEdit.CustomImages.Parent = Me.btnEdit
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.HoverState.FillColor = System.Drawing.Color.Teal
        Me.btnEdit.HoverState.Parent = Me.btnEdit
        Me.btnEdit.Location = New System.Drawing.Point(571, 23)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ShadowDecoration.Parent = Me.btnEdit
        Me.btnEdit.Size = New System.Drawing.Size(69, 28)
        Me.btnEdit.TabIndex = 48
        Me.btnEdit.Text = "EDIT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(13, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 21)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "PC Name"
        Me.Label5.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 21)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Access Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 21)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Employee ID"
        '
        'txtPCname
        '
        Me.txtPCname.BorderColor = System.Drawing.Color.Transparent
        Me.txtPCname.BorderRadius = 20
        Me.txtPCname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPCname.DefaultText = ""
        Me.txtPCname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPCname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPCname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPCname.DisabledState.Parent = Me.txtPCname
        Me.txtPCname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPCname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPCname.FocusedState.Parent = Me.txtPCname
        Me.txtPCname.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPCname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPCname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPCname.HoverState.Parent = Me.txtPCname
        Me.txtPCname.Location = New System.Drawing.Point(18, 240)
        Me.txtPCname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPCname.Name = "txtPCname"
        Me.txtPCname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPCname.PlaceholderText = ""
        Me.txtPCname.SelectedText = ""
        Me.txtPCname.ShadowDecoration.Parent = Me.txtPCname
        Me.txtPCname.Size = New System.Drawing.Size(188, 39)
        Me.txtPCname.TabIndex = 41
        Me.txtPCname.Visible = False
        '
        'txtSearch
        '
        Me.txtSearch.BorderColor = System.Drawing.Color.Black
        Me.txtSearch.BorderRadius = 10
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.Parent = Me.txtSearch
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.FocusedState.Parent = Me.txtSearch
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.Location = New System.Drawing.Point(284, 15)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(243, 36)
        Me.txtSearch.TabIndex = 47
        '
        'btnPassword
        '
        Me.btnPassword.BorderRadius = 10
        Me.btnPassword.CheckedState.Parent = Me.btnPassword
        Me.btnPassword.CustomImages.Parent = Me.btnPassword
        Me.btnPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPassword.ForeColor = System.Drawing.Color.White
        Me.btnPassword.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPassword.HoverState.Parent = Me.btnPassword
        Me.btnPassword.Location = New System.Drawing.Point(648, 24)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.ShadowDecoration.Parent = Me.btnPassword
        Me.btnPassword.Size = New System.Drawing.Size(69, 28)
        Me.btnPassword.TabIndex = 49
        Me.btnPassword.Text = "RESET"
        '
        'dgvAccounts
        '
        Me.dgvAccounts.AllowUserToAddRows = False
        Me.dgvAccounts.AllowUserToDeleteRows = False
        Me.dgvAccounts.AllowUserToResizeRows = False
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.dgvAccounts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAccounts.BackgroundColor = System.Drawing.Color.White
        Me.dgvAccounts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvAccounts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAccounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAccounts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvAccounts.ColumnHeadersHeight = 36
        Me.dgvAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EID, Me.AgentName, Me.LastName, Me.Username, Me.AccessType})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(97, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAccounts.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvAccounts.EnableHeadersVisualStyles = False
        Me.dgvAccounts.GridColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.dgvAccounts.Location = New System.Drawing.Point(272, 58)
        Me.dgvAccounts.MultiSelect = False
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.ReadOnly = True
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAccounts.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.dgvAccounts.RowHeadersVisible = False
        Me.dgvAccounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvAccounts.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAccounts.Size = New System.Drawing.Size(649, 540)
        Me.dgvAccounts.TabIndex = 50
        Me.dgvAccounts.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Orange
        Me.dgvAccounts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.dgvAccounts.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvAccounts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvAccounts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvAccounts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvAccounts.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvAccounts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.dgvAccounts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.dgvAccounts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvAccounts.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvAccounts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvAccounts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvAccounts.ThemeStyle.HeaderStyle.Height = 36
        Me.dgvAccounts.ThemeStyle.ReadOnly = True
        Me.dgvAccounts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.dgvAccounts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAccounts.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvAccounts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvAccounts.ThemeStyle.RowsStyle.Height = 22
        Me.dgvAccounts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.dgvAccounts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'EID
        '
        Me.EID.DataPropertyName = "MERID"
        Me.EID.HeaderText = "CRTID"
        Me.EID.Name = "EID"
        Me.EID.ReadOnly = True
        Me.EID.Visible = False
        '
        'AgentName
        '
        Me.AgentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AgentName.DataPropertyName = "Firstname"
        Me.AgentName.HeaderText = "First Name"
        Me.AgentName.Name = "AgentName"
        Me.AgentName.ReadOnly = True
        Me.AgentName.Width = 90
        '
        'LastName
        '
        Me.LastName.DataPropertyName = "LastName"
        Me.LastName.HeaderText = "Last Name"
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        '
        'Username
        '
        Me.Username.DataPropertyName = "Username"
        Me.Username.HeaderText = "Employee ID"
        Me.Username.Name = "Username"
        Me.Username.ReadOnly = True
        '
        'AccessType
        '
        Me.AccessType.DataPropertyName = "AccessType"
        Me.AccessType.HeaderText = "Access Type"
        Me.AccessType.Name = "AccessType"
        Me.AccessType.ReadOnly = True
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageActive = Nothing
        Me.btnSearch.Location = New System.Drawing.Point(534, 20)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(31, 31)
        Me.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSearch.TabIndex = 51
        Me.btnSearch.TabStop = False
        Me.btnSearch.Zoom = 10
        '
        'btnNew
        '
        Me.btnNew.BorderRadius = 10
        Me.btnNew.CheckedState.Parent = Me.btnNew
        Me.btnNew.CustomImages.Parent = Me.btnNew
        Me.btnNew.FillColor = System.Drawing.Color.Green
        Me.btnNew.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNew.HoverState.Parent = Me.btnNew
        Me.btnNew.Location = New System.Drawing.Point(723, 24)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.ShadowDecoration.Parent = Me.btnNew
        Me.btnNew.Size = New System.Drawing.Size(69, 28)
        Me.btnNew.TabIndex = 52
        Me.btnNew.Text = "NEW"
        '
        'UC_Accounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cbxAccesstype)
        Me.Controls.Add(Me.txtEmployeeid)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPCname)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnPassword)
        Me.Controls.Add(Me.dgvAccounts)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "UC_Accounts"
        Me.Size = New System.Drawing.Size(943, 690)
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbxAccesstype As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtEmployeeid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPCname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnPassword As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents EID As DataGridViewTextBoxColumn
    Friend WithEvents AgentName As DataGridViewTextBoxColumn
    Friend WithEvents LastName As DataGridViewTextBoxColumn
    Friend WithEvents Username As DataGridViewTextBoxColumn
    Friend WithEvents AccessType As DataGridViewTextBoxColumn
    Public WithEvents dgvAccounts As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnNew As Guna.UI2.WinForms.Guna2Button
End Class
