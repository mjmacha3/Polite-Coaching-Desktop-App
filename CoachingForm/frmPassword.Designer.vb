<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblMatch = New System.Windows.Forms.Label()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.txtPass1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPass2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.BackColor = System.Drawing.Color.Transparent
        Me.lblLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLength.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.ForeColor = System.Drawing.Color.Red
        Me.lblLength.Location = New System.Drawing.Point(25, 226)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(268, 17)
        Me.lblLength.TabIndex = 22
        Me.lblLength.Text = "Password must be atleast 8 characters long."
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNumber.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.ForeColor = System.Drawing.Color.Red
        Me.lblNumber.Location = New System.Drawing.Point(25, 209)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(190, 17)
        Me.lblNumber.TabIndex = 21
        Me.lblNumber.Text = "Password must have a number."
        '
        'lblMatch
        '
        Me.lblMatch.AutoSize = True
        Me.lblMatch.BackColor = System.Drawing.Color.Transparent
        Me.lblMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMatch.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatch.ForeColor = System.Drawing.Color.Red
        Me.lblMatch.Location = New System.Drawing.Point(25, 243)
        Me.lblMatch.Name = "lblMatch"
        Me.lblMatch.Size = New System.Drawing.Size(155, 17)
        Me.lblMatch.TabIndex = 20
        Me.lblMatch.Text = "Passwords do not match."
        '
        'btnLogin
        '
        Me.btnLogin.Animated = True
        Me.btnLogin.BorderRadius = 10
        Me.btnLogin.CheckedState.Parent = Me.btnLogin
        Me.btnLogin.CustomImages.Parent = Me.btnLogin
        Me.btnLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.HoverState.Parent = Me.btnLogin
        Me.btnLogin.Location = New System.Drawing.Point(103, 149)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.ShadowDecoration.Parent = Me.btnLogin
        Me.btnLogin.Size = New System.Drawing.Size(169, 40)
        Me.btnLogin.TabIndex = 19
        Me.btnLogin.Text = "Save and Proceed"
        '
        'txtPass1
        '
        Me.txtPass1.Animated = True
        Me.txtPass1.BorderRadius = 5
        Me.txtPass1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass1.DefaultText = ""
        Me.txtPass1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPass1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPass1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPass1.DisabledState.Parent = Me.txtPass1
        Me.txtPass1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPass1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPass1.FocusedState.Parent = Me.txtPass1
        Me.txtPass1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPass1.HoverState.Parent = Me.txtPass1
        Me.txtPass1.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.txtPass1.Location = New System.Drawing.Point(28, 65)
        Me.txtPass1.Name = "txtPass1"
        Me.txtPass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPass1.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtPass1.PlaceholderText = "password"
        Me.txtPass1.SelectedText = ""
        Me.txtPass1.ShadowDecoration.Parent = Me.txtPass1
        Me.txtPass1.Size = New System.Drawing.Size(330, 36)
        Me.txtPass1.TabIndex = 17
        Me.txtPass1.UseSystemPasswordChar = True
        '
        'txtPass2
        '
        Me.txtPass2.Animated = True
        Me.txtPass2.BorderRadius = 5
        Me.txtPass2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass2.DefaultText = ""
        Me.txtPass2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPass2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPass2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPass2.DisabledState.Parent = Me.txtPass2
        Me.txtPass2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPass2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPass2.FocusedState.Parent = Me.txtPass2
        Me.txtPass2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPass2.HoverState.Parent = Me.txtPass2
        Me.txtPass2.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.txtPass2.Location = New System.Drawing.Point(28, 107)
        Me.txtPass2.Name = "txtPass2"
        Me.txtPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPass2.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtPass2.PlaceholderText = "password"
        Me.txtPass2.SelectedText = ""
        Me.txtPass2.ShadowDecoration.Parent = Me.txtPass2
        Me.txtPass2.Size = New System.Drawing.Size(330, 36)
        Me.txtPass2.TabIndex = 18
        Me.txtPass2.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(12, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 21)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Enter your OWN password"
        '
        'frmPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 274)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lblMatch)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPass1)
        Me.Controls.Add(Me.txtPass2)
        Me.Controls.Add(Me.Label5)
        Me.Name = "frmPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLength As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblMatch As Label
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtPass1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPass2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
End Class
