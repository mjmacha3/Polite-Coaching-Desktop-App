<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUpdate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdate))
        Me.rtxtItemDisc = New System.Windows.Forms.RichTextBox()
        Me.rtxtCause = New System.Windows.Forms.RichTextBox()
        Me.rtxtEffect = New System.Windows.Forms.RichTextBox()
        Me.rtxtSupActPlan = New System.Windows.Forms.RichTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.rtxtEmpActPlan = New System.Windows.Forms.RichTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtEffectiveDateEA = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtEffecctiveDateSA = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cboCoachedBy = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboNotedBy = New System.Windows.Forms.ComboBox()
        Me.cboCoachee = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboDesg2 = New System.Windows.Forms.ComboBox()
        Me.cboDSup = New System.Windows.Forms.ComboBox()
        Me.cboDirect2 = New System.Windows.Forms.ComboBox()
        Me.txtCoachingID = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.cboSubCategory = New System.Windows.Forms.ComboBox()
        Me.cboSite = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtScanId = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cboID = New System.Windows.Forms.ComboBox()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.dtFUCoachingDate = New System.Windows.Forms.DateTimePicker()
        Me.dtCoachDate = New System.Windows.Forms.DateTimePicker()
        Me.cboSupervisor = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboDesignation = New System.Windows.Forms.ComboBox()
        Me.cboCampaign = New System.Windows.Forms.ComboBox()
        Me.cboRootCauseCat = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboCoachCat = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtxtItemDisc
        '
        Me.rtxtItemDisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtxtItemDisc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtItemDisc.Location = New System.Drawing.Point(14, 208)
        Me.rtxtItemDisc.Name = "rtxtItemDisc"
        Me.rtxtItemDisc.Size = New System.Drawing.Size(312, 113)
        Me.rtxtItemDisc.TabIndex = 24
        Me.rtxtItemDisc.Text = ""
        '
        'rtxtCause
        '
        Me.rtxtCause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtxtCause.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtCause.Location = New System.Drawing.Point(324, 208)
        Me.rtxtCause.Name = "rtxtCause"
        Me.rtxtCause.Size = New System.Drawing.Size(321, 113)
        Me.rtxtCause.TabIndex = 26
        Me.rtxtCause.Text = ""
        '
        'rtxtEffect
        '
        Me.rtxtEffect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtxtEffect.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtEffect.Location = New System.Drawing.Point(645, 208)
        Me.rtxtEffect.Name = "rtxtEffect"
        Me.rtxtEffect.Size = New System.Drawing.Size(312, 113)
        Me.rtxtEffect.TabIndex = 28
        Me.rtxtEffect.Text = ""
        '
        'rtxtSupActPlan
        '
        Me.rtxtSupActPlan.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtSupActPlan.Location = New System.Drawing.Point(476, 366)
        Me.rtxtSupActPlan.Name = "rtxtSupActPlan"
        Me.rtxtSupActPlan.Size = New System.Drawing.Size(474, 101)
        Me.rtxtSupActPlan.TabIndex = 33
        Me.rtxtSupActPlan.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(474, 350)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 15)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Leader's Action Plan"
        '
        'rtxtEmpActPlan
        '
        Me.rtxtEmpActPlan.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtEmpActPlan.Location = New System.Drawing.Point(20, 366)
        Me.rtxtEmpActPlan.Name = "rtxtEmpActPlan"
        Me.rtxtEmpActPlan.Size = New System.Drawing.Size(448, 101)
        Me.rtxtEmpActPlan.TabIndex = 31
        Me.rtxtEmpActPlan.Text = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(17, 350)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(131, 15)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Employee's Action Plan"
        '
        'dtEffectiveDateEA
        '
        Me.dtEffectiveDateEA.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtEffectiveDateEA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEffectiveDateEA.Location = New System.Drawing.Point(127, 486)
        Me.dtEffectiveDateEA.Name = "dtEffectiveDateEA"
        Me.dtEffectiveDateEA.Size = New System.Drawing.Size(330, 23)
        Me.dtEffectiveDateEA.TabIndex = 35
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(17, 490)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 15)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "Effectivity Date:"
        '
        'dtEffecctiveDateSA
        '
        Me.dtEffecctiveDateSA.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtEffecctiveDateSA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEffecctiveDateSA.Location = New System.Drawing.Point(601, 486)
        Me.dtEffecctiveDateSA.Name = "dtEffecctiveDateSA"
        Me.dtEffecctiveDateSA.Size = New System.Drawing.Size(349, 23)
        Me.dtEffecctiveDateSA.TabIndex = 37
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(479, 490)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 15)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Effectivity Date:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(17, 521)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 15)
        Me.Label19.TabIndex = 38
        Me.Label19.Text = "COACHED BY:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(348, 521)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 15)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "NOTED BY:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(180, 542)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 15)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "Coach"
        '
        'cboCoachedBy
        '
        Me.cboCoachedBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboCoachedBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCoachedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCoachedBy.Enabled = False
        Me.cboCoachedBy.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCoachedBy.FormattingEnabled = True
        Me.cboCoachedBy.Location = New System.Drawing.Point(115, 518)
        Me.cboCoachedBy.Name = "cboCoachedBy"
        Me.cboCoachedBy.Size = New System.Drawing.Size(208, 23)
        Me.cboCoachedBy.TabIndex = 41
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(464, 542)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(84, 15)
        Me.Label22.TabIndex = 42
        Me.Label22.Text = "Direct Superior"
        '
        'cboNotedBy
        '
        Me.cboNotedBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboNotedBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNotedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNotedBy.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNotedBy.FormattingEnabled = True
        Me.cboNotedBy.Location = New System.Drawing.Point(419, 518)
        Me.cboNotedBy.Name = "cboNotedBy"
        Me.cboNotedBy.Size = New System.Drawing.Size(208, 23)
        Me.cboNotedBy.TabIndex = 43
        '
        'cboCoachee
        '
        Me.cboCoachee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboCoachee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCoachee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCoachee.Enabled = False
        Me.cboCoachee.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCoachee.FormattingEnabled = True
        Me.cboCoachee.Location = New System.Drawing.Point(772, 518)
        Me.cboCoachee.Name = "cboCoachee"
        Me.cboCoachee.Size = New System.Drawing.Size(178, 23)
        Me.cboCoachee.TabIndex = 47
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(824, 542)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(52, 15)
        Me.Label24.TabIndex = 46
        Me.Label24.Text = "Coachee"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(647, 521)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(116, 15)
        Me.Label26.TabIndex = 44
        Me.Label26.Text = "ACKNOWLEDGED BY:"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(812, 567)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(147, 24)
        Me.btnSave.TabIndex = 51
        Me.btnSave.Text = "&SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 186)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(312, 19)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "POINTS OF DISCUSSION"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label11, "Author:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This should show the behavior that needs to be addressed in this coachin" &
        "g session.")
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(644, 186)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(311, 19)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "EFFECT"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label12, "Author:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This should outline the impact of the behavior to the employee, the comp" &
        "any, and the client (if applicable). ")
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(323, 186)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(323, 19)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "CAUSE"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label13, "Author:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This should indicate the driving force to the behavior identified under " &
        "'Points of Discussion'.")
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label25.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(519, 324)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(436, 19)
        Me.Label25.TabIndex = 87
        Me.Label25.Text = "should be SMART (Specific, Measurable, Attainable, Realistic, and Time-bound)."
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label25, "Author:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This should outline the impact of the behavior to the employee, the comp" &
        "any, and the client (if applicable). ")
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(14, 324)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(508, 19)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "ACTION PLAN  "
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Label14, "Author:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Action plan should be SMART (Specific, Measurable, Attainable, Realistic" &
        ", and Time-bound).")
        '
        'cboDesg2
        '
        Me.cboDesg2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboDesg2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDesg2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDesg2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDesg2.FormattingEnabled = True
        Me.cboDesg2.Location = New System.Drawing.Point(450, 47)
        Me.cboDesg2.Name = "cboDesg2"
        Me.cboDesg2.Size = New System.Drawing.Size(219, 23)
        Me.cboDesg2.TabIndex = 65
        Me.cboDesg2.Visible = False
        '
        'cboDSup
        '
        Me.cboDSup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboDSup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDSup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDSup.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDSup.FormattingEnabled = True
        Me.cboDSup.Location = New System.Drawing.Point(325, 18)
        Me.cboDSup.Name = "cboDSup"
        Me.cboDSup.Size = New System.Drawing.Size(196, 23)
        Me.cboDSup.TabIndex = 66
        Me.cboDSup.Visible = False
        '
        'cboDirect2
        '
        Me.cboDirect2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboDirect2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDirect2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDirect2.FormattingEnabled = True
        Me.cboDirect2.Location = New System.Drawing.Point(324, 490)
        Me.cboDirect2.Name = "cboDirect2"
        Me.cboDirect2.Size = New System.Drawing.Size(208, 23)
        Me.cboDirect2.TabIndex = 67
        Me.cboDirect2.Visible = False
        '
        'txtCoachingID
        '
        Me.txtCoachingID.Location = New System.Drawing.Point(543, 12)
        Me.txtCoachingID.MaxLength = 50
        Me.txtCoachingID.Name = "txtCoachingID"
        Me.txtCoachingID.Size = New System.Drawing.Size(126, 20)
        Me.txtCoachingID.TabIndex = 90
        Me.txtCoachingID.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(11, 546)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(82, 49)
        Me.PictureBox3.TabIndex = 92
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(666, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(292, 68)
        Me.PictureBox2.TabIndex = 91
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(211, 59)
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Location = New System.Drawing.Point(13, 346)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(459, 128)
        Me.PictureBox4.TabIndex = 77
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Location = New System.Drawing.Point(471, 346)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(482, 128)
        Me.PictureBox5.TabIndex = 78
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox6.Location = New System.Drawing.Point(13, 479)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(459, 33)
        Me.PictureBox6.TabIndex = 80
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox7.Location = New System.Drawing.Point(471, 479)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(482, 33)
        Me.PictureBox7.TabIndex = 81
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox8.Location = New System.Drawing.Point(13, 509)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(328, 52)
        Me.PictureBox8.TabIndex = 83
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox9.Location = New System.Drawing.Point(340, 509)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(300, 52)
        Me.PictureBox9.TabIndex = 84
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox10.Location = New System.Drawing.Point(639, 509)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(314, 52)
        Me.PictureBox10.TabIndex = 85
        Me.PictureBox10.TabStop = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label29.Location = New System.Drawing.Point(9, 159)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(134, 15)
        Me.Label29.TabIndex = 126
        Me.Label29.Text = "EMPLOYEE START DATE:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label28.Location = New System.Drawing.Point(592, 160)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(153, 15)
        Me.Label28.TabIndex = 125
        Me.Label28.Text = "SUB COACHING CATEGORY:"
        '
        'cboSubCategory
        '
        Me.cboSubCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboSubCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSubCategory.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSubCategory.FormattingEnabled = True
        Me.cboSubCategory.Items.AddRange(New Object() {"People", "Process", "Technology"})
        Me.cboSubCategory.Location = New System.Drawing.Point(751, 152)
        Me.cboSubCategory.Name = "cboSubCategory"
        Me.cboSubCategory.Size = New System.Drawing.Size(212, 23)
        Me.cboSubCategory.Sorted = True
        Me.cboSubCategory.TabIndex = 124
        '
        'cboSite
        '
        Me.cboSite.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboSite.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSite.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSite.FormattingEnabled = True
        Me.cboSite.Items.AddRange(New Object() {"DUMAGUETE", "MAKATI"})
        Me.cboSite.Location = New System.Drawing.Point(393, 125)
        Me.cboSite.Name = "cboSite"
        Me.cboSite.Size = New System.Drawing.Size(171, 23)
        Me.cboSite.Sorted = True
        Me.cboSite.TabIndex = 123
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(355, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 15)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "SITE:"
        '
        'txtScanId
        '
        Me.txtScanId.Location = New System.Drawing.Point(489, 99)
        Me.txtScanId.MaxLength = 50
        Me.txtScanId.Name = "txtScanId"
        Me.txtScanId.Size = New System.Drawing.Size(110, 20)
        Me.txtScanId.TabIndex = 121
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label27.Location = New System.Drawing.Point(436, 101)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(55, 15)
        Me.Label27.TabIndex = 120
        Me.Label27.Text = "SCAN ID:"
        '
        'cboID
        '
        Me.cboID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboID.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboID.FormattingEnabled = True
        Me.cboID.Location = New System.Drawing.Point(89, 101)
        Me.cboID.Name = "cboID"
        Me.cboID.Size = New System.Drawing.Size(114, 23)
        Me.cboID.Sorted = True
        Me.cboID.TabIndex = 119
        '
        'cboName
        '
        Me.cboName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(51, 73)
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(229, 23)
        Me.cboName.TabIndex = 103
        '
        'dtFUCoachingDate
        '
        Me.dtFUCoachingDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFUCoachingDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFUCoachingDate.Location = New System.Drawing.Point(448, 154)
        Me.dtFUCoachingDate.Name = "dtFUCoachingDate"
        Me.dtFUCoachingDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtFUCoachingDate.Size = New System.Drawing.Size(125, 23)
        Me.dtFUCoachingDate.TabIndex = 117
        '
        'dtCoachDate
        '
        Me.dtCoachDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtCoachDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtCoachDate.Location = New System.Drawing.Point(315, 98)
        Me.dtCoachDate.Name = "dtCoachDate"
        Me.dtCoachDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtCoachDate.Size = New System.Drawing.Size(115, 23)
        Me.dtCoachDate.TabIndex = 118
        Me.dtCoachDate.Value = New Date(2021, 7, 12, 0, 0, 0, 0)
        '
        'cboSupervisor
        '
        Me.cboSupervisor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboSupervisor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSupervisor.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSupervisor.FormattingEnabled = True
        Me.cboSupervisor.Location = New System.Drawing.Point(426, 71)
        Me.cboSupervisor.Name = "cboSupervisor"
        Me.cboSupervisor.Size = New System.Drawing.Size(196, 23)
        Me.cboSupervisor.Sorted = True
        Me.cboSupervisor.TabIndex = 116
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(209, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 15)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "COACHING DATE:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(302, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 15)
        Me.Label9.TabIndex = 114
        Me.Label9.Text = "DIRECT SUPERVISOR:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(272, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(170, 15)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "FOLLOW-UP COACHING DATE:"
        '
        'cboDesignation
        '
        Me.cboDesignation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboDesignation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDesignation.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDesignation.FormattingEnabled = True
        Me.cboDesignation.Location = New System.Drawing.Point(742, 73)
        Me.cboDesignation.Name = "cboDesignation"
        Me.cboDesignation.Size = New System.Drawing.Size(219, 23)
        Me.cboDesignation.Sorted = True
        Me.cboDesignation.TabIndex = 112
        '
        'cboCampaign
        '
        Me.cboCampaign.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboCampaign.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCampaign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCampaign.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCampaign.FormattingEnabled = True
        Me.cboCampaign.Location = New System.Drawing.Point(89, 128)
        Me.cboCampaign.Name = "cboCampaign"
        Me.cboCampaign.Size = New System.Drawing.Size(251, 23)
        Me.cboCampaign.Sorted = True
        Me.cboCampaign.TabIndex = 111
        '
        'cboRootCauseCat
        '
        Me.cboRootCauseCat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboRootCauseCat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboRootCauseCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRootCauseCat.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRootCauseCat.FormattingEnabled = True
        Me.cboRootCauseCat.Items.AddRange(New Object() {"People", "Process", "Technology"})
        Me.cboRootCauseCat.Location = New System.Drawing.Point(731, 125)
        Me.cboRootCauseCat.Name = "cboRootCauseCat"
        Me.cboRootCauseCat.Size = New System.Drawing.Size(231, 23)
        Me.cboRootCauseCat.Sorted = True
        Me.cboRootCauseCat.TabIndex = 110
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(8, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 15)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "CMPGN/DPT:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(657, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 15)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "DESIGNATION: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(586, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 15)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "ROOT CAUSE CATEGORY:"
        '
        'cboCoachCat
        '
        Me.cboCoachCat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboCoachCat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCoachCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCoachCat.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCoachCat.FormattingEnabled = True
        Me.cboCoachCat.Items.AddRange(New Object() {"Behavioral Assessment", "Performance Update", "Productivity Review", "Quality Assurance Evaluation Scores Discussion"})
        Me.cboCoachCat.Location = New System.Drawing.Point(731, 99)
        Me.cboCoachCat.Name = "cboCoachCat"
        Me.cboCoachCat.Size = New System.Drawing.Size(230, 23)
        Me.cboCoachCat.Sorted = True
        Me.cboCoachCat.TabIndex = 106
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(8, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "NAME: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(8, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "EMPLOYEE ID: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(605, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 15)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "COACHING CATEGORY:"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Enabled = False
        Me.dtpStartDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(149, 154)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpStartDate.Size = New System.Drawing.Size(115, 23)
        Me.dtpStartDate.TabIndex = 127
        Me.dtpStartDate.Value = New Date(2021, 7, 12, 0, 0, 0, 0)
        '
        'frmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(971, 607)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.cboSubCategory)
        Me.Controls.Add(Me.cboSite)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtScanId)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.cboID)
        Me.Controls.Add(Me.cboName)
        Me.Controls.Add(Me.dtFUCoachingDate)
        Me.Controls.Add(Me.dtCoachDate)
        Me.Controls.Add(Me.cboSupervisor)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboDesignation)
        Me.Controls.Add(Me.cboCampaign)
        Me.Controls.Add(Me.cboRootCauseCat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboCoachCat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtCoachingID)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cboDirect2)
        Me.Controls.Add(Me.cboDSup)
        Me.Controls.Add(Me.cboDesg2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cboCoachee)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.cboNotedBy)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cboCoachedBy)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.dtEffecctiveDateSA)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.dtEffectiveDateEA)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.rtxtSupActPlan)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.rtxtEmpActPlan)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.rtxtEffect)
        Me.Controls.Add(Me.rtxtCause)
        Me.Controls.Add(Me.rtxtItemDisc)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmUpdate"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coaching Form"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtxtItemDisc As System.Windows.Forms.RichTextBox
    Friend WithEvents rtxtCause As System.Windows.Forms.RichTextBox
    Friend WithEvents rtxtEffect As System.Windows.Forms.RichTextBox
    Friend WithEvents rtxtSupActPlan As System.Windows.Forms.RichTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents rtxtEmpActPlan As System.Windows.Forms.RichTextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtEffectiveDateEA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtEffecctiveDateSA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cboCoachedBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cboNotedBy As System.Windows.Forms.ComboBox
    Friend WithEvents cboCoachee As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboDesg2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboDSup As System.Windows.Forms.ComboBox
    Friend WithEvents cboDirect2 As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCoachingID As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents cboSubCategory As ComboBox
    Friend WithEvents cboSite As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtScanId As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents cboID As ComboBox
    Friend WithEvents cboName As ComboBox
    Friend WithEvents dtFUCoachingDate As DateTimePicker
    Friend WithEvents dtCoachDate As DateTimePicker
    Friend WithEvents cboSupervisor As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cboDesignation As ComboBox
    Friend WithEvents cboCampaign As ComboBox
    Friend WithEvents cboRootCauseCat As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cboCoachCat As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpStartDate As DateTimePicker
End Class
