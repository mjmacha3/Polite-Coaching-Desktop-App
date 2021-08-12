Imports System.Data.SqlClient

Public Class UC_Accounts
    Public cond As Integer = 0
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.cbxAccesstype.Text = "" Or Me.txtEmployeeid.Text = "" Then
            MsgBox("Please complete the fields", vbInformation, Application.ProductName)
            Return
        End If
        If Me.txtEmployeeid.Text = "" Then
            MsgBox("Please select the employee", vbInformation, Application.ProductName)
            Return
        End If

        If cond = 2 Then
            Call ConnectTOSQLServer()
            strSQL = "UPDATE tblCoachingLogin SET access = '" & Me.cbxAccesstype.Text & "' WHERE [EMPLOYEE ID NUMBER] = '" & Me.txtEmployeeid.Text & "'"
            cmd = New SqlCommand(strSQL, Connection)
            Console.WriteLine(strSQL)
            cmd.ExecuteNonQuery()
            MsgBox("Successfully updated", vbInformation, Application.ProductName)
            Call DisConnectSQLServer()
            Me.ViewRecords()
        ElseIf cond = 1 Then


            Dim firstname As String = dgvAccounts.CurrentRow.Cells(1).Value
                Dim lname1 As String = dgvAccounts.CurrentRow.Cells(2).Value
                Dim lname As String = lname1.Replace(lname1.Substring(0, 1), "")
                Dim username As String = firstname.Substring(0, 1).ToUpper + lname1.Substring(0, 1).ToUpper + lname.Trim

                Call ConnectTOSQLServer()
                strSQL = "INSERT INTO tblCoachingLogin([EMPLOYEE ID NUMBER],Username, pword,hash_pass, Password,access) VALUES ('" & Me.txtEmployeeid.Text & "','" & username & "','admin12345','41E5653FC7AEB894026D6BB7B2DB7F65902B454945FA8FD65A6327047B5277FB','41E5653FC7AEB894026D6BB7B2DB7F65902B454945FA8FD65A6327047B5277FB','" & Me.cbxAccesstype.Text & "')"
                cmd = New SqlCommand(strSQL, Connection)
                Console.WriteLine(strSQL)
                cmd.ExecuteNonQuery()
                MsgBox("Records saved" & vbNewLine & "eid: " & Me.txtEmployeeid.Text & vbNewLine & "pass: admin12345", vbInformation, Application.ProductName)
                Call DisConnectSQLServer()
                Me.ViewRecords()
                cond = 0

            End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cond = 0
        If Me.btnClear.Text = "CANCEL" Then
            Me.btnEdit.Enabled = True
            Me.btnPassword.Enabled = True
            Me.txtSearch.Focus()
            Me.txtSearch.PlaceholderText = "Search"
            Me.btnClear.Text = "CLEAR"
            Me.ViewRecords()
        End If
    End Sub

    Private Sub UC_Accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewRecords()
    End Sub

    Public Sub ViewRecords()
        Call ConnectTOSQLServer()
        Dim strSql As String = ""
        If cond = 1 Then
            strSql = "SELECT FIRSTNAME, LASTNAME, [EMPLOYEE ID NUMBER], '' as Access  FROM tblVKPOEmployee_HRNames 
                       where EmployeeStatus = 'active' and [EMPLOYEE ID NUMBER]  not in (select [EMPLOYEE ID NUMBER] from tblCoachingLogin ) and ([EMPLOYEE ID NUMBER] = '" & Me.txtSearch.Text.Trim & "' or FIRSTNAME LIKE '%" & Me.txtSearch.Text.Trim & "%' or LASTNAME LIKE '%" & Me.txtSearch.Text.Trim & "%')"
            '"(FIRSTNAME Like '%" & Me.txtSearch.Text.Trim & "%'" &
            '"Or LASTNAME Like '%" & Me.txtSearch.Text.Trim & "%' or [EMPLOYEE ID NUMBER] LIKE '%" & Me.txtSearch.Text.Trim & "%' or Access LIKE '%" & Me.txtSearch.Text.Trim & "%')"

        Else

            strSql = "SELECT FIRSTNAME, LASTNAME,[EMPLOYEE ID NUMBER],Access FROM vw_CoachingLogin WHERE (FIRSTNAME LIKE '%" & Me.txtSearch.Text.Trim & "%'" &
            "Or LASTNAME Like '%" & Me.txtSearch.Text.Trim & "%' or [EMPLOYEE ID NUMBER] LIKE '%" & Me.txtSearch.Text.Trim & "%' or Access LIKE '%" & Me.txtSearch.Text.Trim & "%')"

        End If
        Console.WriteLine(strSql)
        cmd = New SqlCommand(strSql, Connection)
        reader = cmd.ExecuteReader()
        Dim x As Integer = 0
        Me.dgvAccounts.Rows.Clear()

        With Me.dgvAccounts
            While reader.Read()
                .Rows.Add()
                .RowHeadersVisible = False
                .Item(1, x).Value = reader.GetString(0)
                .Item(2, x).Value = reader.GetString(1)
                .Item(3, x).Value = reader.GetString(2)
                .Item(4, x).Value = reader.GetString(3)

                x = x + 1
            End While
        End With
        reader.Close()

        Call DisConnectSQLServer()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Me.txtEmployeeid.Clear()
        ViewRecords()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Me.btnSave.Enabled = True
        cond = 2

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter)) Then
            ViewRecords()

        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        cond = 1
        Me.txtEmployeeid.Clear()
        'Me.cbxAccesstype.Items.Clear()
        Me.btnEdit.Enabled = False
        Me.btnPassword.Enabled = False
        Me.txtSearch.Focus()
        Me.txtSearch.PlaceholderText = "Search employee id"
        Me.btnClear.Text = "CANCEL"
        Me.ViewRecords()
        Me.btnSave.Enabled = True

    End Sub

    Private Sub dgvAccounts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccounts.CellContentClick

    End Sub

    Private Sub dgvAccounts_Click(sender As Object, e As EventArgs) Handles dgvAccounts.Click

    End Sub

    Private Sub dgvAccounts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccounts.CellClick
        Dim selected As DataGridViewRow
        selected = dgvAccounts.Rows(e.RowIndex)
        Me.txtEmployeeid.Text = selected.Cells(3).Value
        Me.cbxAccesstype.Text = selected.Cells(4).Value
    End Sub

    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        Dim selected As String = dgvAccounts.CurrentRow.Cells(3).Value

        If cond = 0 Then
            If MsgBox("Do you want to reset the password on selected employee?", vbYesNo + MsgBoxStyle.Information + vbDefaultButton3, "Question") = vbYes Then

                Call resetpass(selected)
                MsgBox("eid: " & selected & vbNewLine & "pass: admin12345".ToString(), vbInformation, "Default password")

            End If
        End If


    End Sub
End Class
