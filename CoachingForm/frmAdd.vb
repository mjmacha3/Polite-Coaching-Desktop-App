Imports System.Data.SqlClient
Imports System.IO

Public Class frmAdd


    Public namePress As Integer
    Public idPress As Integer
    Public nameIndex As Integer
    Public idIndex As Integer

    Private folderBrowserDialog1 As New FolderBrowserDialog

    Private foldername As String




    Private Sub frmCoaching_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtCoachDate.Value = Date.Today
        Timer1.Enabled = True
        namePress = 0
        idPress = 0
        nameIndex = 0
        idIndex = 0
        Call getNameID()
        LoadLists()
        cboCoachCat.SelectedIndex = 0
        cboRootCauseCat.SelectedIndex = 0
        Console.WriteLine(cboCoachedBy.Items.Contains(AccessAccount))
        If (cboCoachedBy.Items.Contains(AccessName)) Then
            cboCoachedBy.SelectedItem = AccessName
            cboCoachedBy.Enabled = False
        Else

            cboCoachedBy.Items.Add(AccessName)
            cboCoachedBy.SelectedItem = AccessName
            cboCoachedBy.Enabled = False
        End If
        'MsgBox(cboCoachedBy.SelectedItem)

        'While namePress < cboID.Items.Count
        '    Console.WriteLine(cboID.Items.Item(namePress))
        '    namePress = namePress + 1
        'End While
        'Console.WriteLine(namePress & "  count 1")
        'namePress = 0
        'While namePress < cboIdOrg.Items.Count
        '    Console.WriteLine(cboIdOrg.Items.Item(namePress))
        '    namePress = namePress + 1
        'End While
        'Console.WriteLine(namePress & "  count 2")
        dtCoachDate.Format = DateTimePickerFormat.Custom
        dtCoachDate.CustomFormat = "MM/dd/yyyy"
        dtFUCoachingDate.Format = DateTimePickerFormat.Custom
        dtFUCoachingDate.CustomFormat = "MM/dd/yyyy"
        dtEffecctiveDateSA.Format = DateTimePickerFormat.Custom
        dtEffecctiveDateSA.CustomFormat = "MM/dd/yyyy"
        dtEffectiveDateEA.Format = DateTimePickerFormat.Custom
        dtEffectiveDateEA.CustomFormat = "MM/dd/yyyy"

    End Sub

    Public Sub getNameID()

        Dim strSQL As String = ""
        Dim foun As Integer = 0

        cboName.Items.Clear()
        cboDSup.Items.Clear()
        cboIdOrg.Items.Clear()
        cboDirect2.Items.Clear()
        cboCoachee.Items.Clear()
        cboID.Items.Clear()
        cboDep2.Items.Clear()
        cboDesg2.Items.Clear()
        cboSupervisor.Items.Clear()
        cboSite2.Items.Clear()
        cboSite.Items.Clear()
        cboStartDate.Items.Clear()
        cboStartDate2.Items.Clear()

        Call ConnectTOSQLServer()
        strSQL = "select distinct Supervisor from tblSupervisors "

        Console.WriteLine(strSQL)

        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()

        Do While reader.HasRows

            Do While reader.Read()
               cboSupervisor.Items.Add(reader.GetString(0))
            Loop
            reader.NextResult()
        Loop

        reader.Close()

        strSQL = "select distinct a.Supervisor from tblSupervisors a inner join tblVKPOEmployee_HRNames b on a.Supervisor=FIRSTNAME+' '+LASTNAME where employeestatus='active' and notedby=1 "

        Console.WriteLine(strSQL)

        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()

        Do While reader.HasRows

            Do While reader.Read()
                cboDirect2.Items.Add(reader.GetString(0))
            Loop
            reader.NextResult()
        Loop


        reader.Close()

        Call DisConnectSQLServer()





        Call ConnectTOSQLServer2()

        '"select distinct firstname+' '+Lastname as Name,[EMPLOYEE ID NUMBER],a.Department ,isnull(case when b.Supervisor not like '%,%' then b.Supervisor else ltrim(rtrim(substring(b.Supervisor,CHARINDEX(', ',b.Supervisor)+1,len(b.Supervisor)))) +' '+ltrim(rtrim(substring(b.Supervisor,0,CHARINDEX(', ',b.Supervisor)))) end,'') as Supervisor,a.role " &  
        ' ''  ,isnull((select isnull(case when Supervisor not like '%,%' then Supervisor else ltrim(rtrim(substring(Supervisor,CHARINDEX(', ',Supervisor)+1,len(Supervisor)))) +' '+ltrim(rtrim(substring(Supervisor,0,CHARINDEX(', ',Supervisor)))) end,'') as a from tblVKPOEmployee_HRNames where FIRSTNAME+' '+LASTNAME=isnull(case when b.Supervisor not like '%,%' then b.Supervisor else ltrim(rtrim(substring(b.Supervisor,CHARINDEX(', ',b.Supervisor)+1,len(b.Supervisor)))) +' '+ltrim(rtrim(substring(b.Supervisor,0,CHARINDEX(', ',b.Supervisor)))) end,'') and EmployeeStatus='active'),'') as Direct_Superior  " 
        '      " from tblVKPOEmployee_HRNames a " &
        '             " inner join (select * from tblMasterAttendance where DATE=(select MAX(date) from tblMasterAttendance)) b on a.[EMPLOYEE ID NUMBER]=b.AgentID " &
        '            "  where employeestatus='ACTIVE'  and a.department not in ('EXC','EXR')  " &
        '           "   order by firstname+' '+Lastname,Supervisor "


        strSQL = "select distinct firstname+' '+Lastname as Name,[EMPLOYEE ID NUMBER], a.Department, isnull(case when b.Supervisor not like '%,%' then b.Supervisor else ltrim(rtrim(substring(b.Supervisor,CHARINDEX(', ',b.Supervisor)+1,len(b.Supervisor)))) +' '+ltrim(rtrim(substring(b.Supervisor,0,CHARINDEX(', ',b.Supervisor)))) end,'') as Supervisor,a.role, a.Location, a.Datelock" &
             " from tblVKPOEmployee_HRNames a " &
                    " inner join (select * from tblMasterAttendance where DATE=(select MAX(date) from tblMasterAttendance)) b on a.[EMPLOYEE ID NUMBER]=b.AgentID " &
                   "  where employeestatus='ACTIVE'  and a.department not in ('EXC','EXR')  " &
                  "   order by firstname+' '+Lastname,Supervisor"

        Console.WriteLine(strSQL)

        cmd = New SqlCommand(strSQL, Connection2)
        reader = cmd.ExecuteReader()

        Do While reader.HasRows

            Do While reader.Read()
                cboName.Items.Add(reader.GetString(0))
                cboDSup.Items.Add(reader.GetString(3))
                cboSite2.Items.Add(reader.GetString(5))
                cboCoachee.Items.Add(reader.GetString(0))
                cboID.Items.Add(reader.GetString(1))
                cboIdOrg.Items.Add(reader.GetString(1))
                cboDep2.Items.Add(reader.GetString(2))
                cboDesg2.Items.Add(reader.GetString(4))
                cboStartDate2.Items.Add(reader.GetDateTime(6))
            Loop
            reader.NextResult()
        Loop

        reader.Close()


        'If (cboDSup.Items.Count > 0) Then
        '    Dim i = 0
        '    While i < cboDSup.Items.Count
        '        If Not (cboSupervisor.Items.Contains(cboDSup.Items(i))) Then
        '            If (cboDSup.Items(i) <> "") Then

        '                cboSupervisor.Items.Add(cboDSup.Items(i))
        '                cboCoachedBy.Items.Add(cboDSup.Items(i))
        '            End If
        '        End If
        '        i = i + 1
        '    End While
        'End If
        'cboCoachedBy.Items.Add("Tessa Jane Lopez")

        If (cboDirect2.Items.Count > 0) Then
            Dim i = 0
            While i < cboDirect2.Items.Count
                If Not (cboNotedBy.Items.Contains(cboDirect2.Items(i))) Then
                    If (cboDirect2.Items(i) <> "") Then
                        cboNotedBy.Items.Add(cboDirect2.Items(i))
                    End If
                End If
                i = i + 1
            End While
        End If

        If (cboStartDate2.Items.Count > 0) Then
            Dim i = 0
            While i < cboStartDate2.Items.Count
                If Not (cboStartDate.Items.Contains(cboStartDate2.Items(i))) Then
                    If (cboStartDate2.Items(i) <> Date.MinValue) Then
                        cboStartDate.Items.Add(cboStartDate2.Items(i))
                    End If
                End If
                i = i + 1
            End While
        End If


        If (cboSite2.Items.Count > 0) Then
            Dim i = 0
            While i < cboSite2.Items.Count
                If Not (cboSite.Items.Contains(cboSite2.Items(i))) Then
                    If (cboSite2.Items(i) <> "") Then
                        cboSite.Items.Add(cboSite2.Items(i))
                    End If
                End If
                i = i + 1
            End While
        End If


        If (cboDep2.Items.Count > 0) Then
            Dim i = 0
            While i < cboDep2.Items.Count
                If Not (cboCampaign.Items.Contains(cboDep2.Items(i))) Then
                    If (cboDep2.Items(i) <> "") Then
                        cboCampaign.Items.Add(cboDep2.Items(i))
                    End If
                End If
                i = i + 1
            End While
        End If

        'strSQL = "select top 1 ltrim(rtrim(substring(OM,CHARINDEX(', ',OM)+1,len(OM)))) +' '+ltrim(rtrim(substring(OM,0,CHARINDEX(', ',OM))))   from tblVKPOEmployee_HRNames f  inner join tblASLAdmins b on f.[EMPLOYEE ID NUMBER]=b.ID   where FIRSTNAME+' '+Lastname='" & AccessName & "'  and EmployeeStatus='Active'"
        strSQL = "select top 1 ltrim(rtrim(substring(Supervisor,CHARINDEX(', ',Supervisor)+1,len(Supervisor)))) +' '+ltrim(rtrim(substring(Supervisor,0,CHARINDEX(', ',Supervisor))))   " &
                "    from tblMasterAttendance f  " &
                  "   inner join tblASLAdmins b on f.AgentID=b.ID   " &
                 "    where  f.DATE=(select max (date) as MXD from tblMasterAttendance where ltrim(rtrim(substring(name,CHARINDEX(', ',name)+1,len(name)))) +' '+ltrim(rtrim(substring(name,0,CHARINDEX(', ',name))))='" & AccessName & "' ) " &
                 "    and ltrim(rtrim(substring(name,CHARINDEX(', ',name)+1,len(name)))) +' '+ltrim(rtrim(substring(name,0,CHARINDEX(', ',name))))='" & AccessName & "'  "

        Console.WriteLine(strSQL)

        cmd = New SqlCommand(strSQL, Connection2)
        reader = cmd.ExecuteReader()

        Do While reader.HasRows

            Do While reader.Read()
                If (cboNotedBy.Items.Contains(reader.GetString(0))) Then
                    cboNotedBy.SelectedItem = reader.GetString(0)
                Else
                    cboNotedBy.Items.Add(reader.GetString(0))
                    cboNotedBy.SelectedItem = reader.GetString(0)
                End If
            Loop
            reader.NextResult()
        Loop

        reader.Close()
        Call DisConnectSQLServer2()

    End Sub




    Public Sub LoadLists()
        cboCoachCat.Items.Clear()
        cboRootCauseCat.Items.Clear()
        cboDesignation.Items.Clear()

        Call ConnectTOSQLServer()

        Dim strSQL As String = ""
        Dim foun As Integer = 0

        strSQL = "select distinct Designation from tblCoachingDesignation order by Designation "

        Console.WriteLine(strSQL)

        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()

        Do While reader.HasRows

            Do While reader.Read()
                cboDesignation.Items.Add(reader.GetString(0))

            Loop
            reader.NextResult()
        Loop

        reader.Close()

        'strSQL = "select distinct Location from tblVkpoEmployee_HRNames where EmployeeStatus = 'ACTIVE' order by Location "

        'Console.WriteLine(strSQL)

        'cmd = New SqlCommand(strSQL, Connection)
        'reader = cmd.ExecuteReader()

        'Do While reader.HasRows

        '    Do While reader.Read()
        '        cboSite.Items.Add(reader.GetString(0))

        '    Loop
        '    reader.NextResult()
        'Loop

        'reader.Close()

        strSQL = "select distinct Category from tblCoachingCategory order by Category "

        Console.WriteLine(strSQL)

        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()

        Do While reader.HasRows

            Do While reader.Read()
                cboCoachCat.Items.Add(reader.GetString(0))
            Loop
            reader.NextResult()
        Loop

        reader.Close()

        strSQL = "select distinct RootCause from tblCoachingRootCause order by RootCause "

        Console.WriteLine(strSQL)

        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()

        Do While reader.HasRows

            Do While reader.Read()
                cboRootCauseCat.Items.Add(reader.GetString(0))
            Loop
            reader.NextResult()
        Loop

        reader.Close()


        strSQL = "select distinct SubCategory from tblCoachingSubCategory"

        Console.WriteLine(strSQL)

        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()

        Do While reader.HasRows

            Do While reader.Read()
                cboSubCategory.Items.Add(reader.GetString(0))
            Loop
            reader.NextResult()
        Loop

        reader.Close()

        Call DisConnectSQLServer()

    End Sub

    Private Sub cboName_Leave(sender As Object, e As EventArgs) Handles cboName.Leave
        cboName.SelectedItem = cboCoachee.SelectedItem
    End Sub

    'comment

    Private Sub cboName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged
        If (cboName.SelectedIndex > 0) Then
            cboIdOrg.SelectedIndex = cboName.SelectedIndex
            cboID.SelectedItem = cboIdOrg.SelectedItem
            cboDep2.SelectedIndex = cboName.SelectedIndex
            cboCampaign.SelectedItem = cboDep2.SelectedItem
            cboDSup.SelectedIndex = cboName.SelectedIndex
            cboSite2.SelectedIndex = cboName.SelectedIndex
            cboSite.SelectedItem = cboSite2.SelectedItem
            cboStartDate2.SelectedIndex = cboName.SelectedIndex
            cboStartDate.SelectedItem = cboStartDate2.SelectedItem

            Console.WriteLine(cboName.SelectedIndex & "  " & cboIdOrg.SelectedIndex)
            Console.WriteLine(cboName.SelectedItem & "  " & cboIdOrg.SelectedItem)
            Console.WriteLine(cboName.SelectedItem & "  " & cboID.SelectedItem)
            If (cboSupervisor.Items.Contains(cboDSup.SelectedItem)) Then
                cboSupervisor.SelectedItem = cboDSup.SelectedItem
            Else
                cboSupervisor.Items.Add(cboDSup.SelectedItem)
                cboSupervisor.SelectedItem = cboDSup.SelectedItem
            End If

            'cboSupervisor.SelectedItem = cboDSup.SelectedItem
            'cboCoachedBy.SelectedItem = cboDSup.SelectedItem
            cboCoachee.SelectedItem = cboName.SelectedItem
            'cboDirect2.SelectedIndex = cboName.SelectedIndex
            'cboNotedBy.SelectedItem = cboDirect2.SelectedItem
            cboDesg2.SelectedIndex = cboName.SelectedIndex
            cboDesignation.SelectedItem = cboDesg2.SelectedItem
        End If

      
    End Sub


    Private Sub cboID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboID.SelectedIndexChanged


        If (cboID.SelectedIndex > 0) Then
            cboIdOrg.SelectedItem = cboID.SelectedItem
            cboName.SelectedIndex = cboIdOrg.SelectedIndex
            cboDep2.SelectedIndex = cboIdOrg.SelectedIndex
            cboCampaign.SelectedItem = cboDep2.SelectedItem
            cboDSup.SelectedIndex = cboIdOrg.SelectedIndex
            cboSite2.SelectedIndex = cboIdOrg.SelectedIndex
            cboSite.SelectedItem = cboSite2.SelectedItem
            cboStartDate2.SelectedIndex = cboIdOrg.SelectedIndex
            cboStartDate.SelectedItem = cboStartDate2.SelectedItem

            If (cboSupervisor.Items.Contains(cboDSup.SelectedItem)) Then
                cboSupervisor.SelectedItem = cboDSup.SelectedItem
            Else
                cboSupervisor.Items.Add(cboDSup.SelectedItem)
                cboSupervisor.SelectedItem = cboDSup.SelectedItem
            End If

            'cboSupervisor.SelectedItem = cboDSup.SelectedItem
            'cboCoachedBy.SelectedItem = cboDSup.SelectedItem
            cboCoachee.SelectedItem = cboName.SelectedItem
            'cboDirect2.SelectedIndex = cboIdOrg.SelectedIndex
            'cboNotedBy.SelectedItem = cboDirect2.SelectedItem
            cboDesg2.SelectedIndex = cboIdOrg.SelectedIndex
            cboDesignation.SelectedItem = cboDesg2.SelectedItem

        End If
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (dtCoachDate.Value > dtDateTodate.Value) Then
            Dim ask = MsgBox("Coaching Date is greater than Date today! Please select another coaching date.", MsgBoxStyle.Critical + vbOKOnly, "Coaching Form")
        Else
            If (cboName.SelectedIndex >= 0 And cboID.SelectedIndex >= 0 And cboCampaign.SelectedIndex >= 0 And cboCoachCat.SelectedIndex >= 0 And cboDesignation.SelectedIndex >= 0 And cboCoachedBy.SelectedIndex >= 0 And cboNotedBy.SelectedIndex >= 0 And cboCoachee.SelectedIndex >= 0 And cboRootCauseCat.SelectedIndex >= 0 And rtxtCause.Text <> "" And rtxtEffect.Text <> "" And rtxtEmpActPlan.Text <> "" And rtxtItemDisc.Text <> "" And rtxtSupActPlan.Text <> "" And cboSite.SelectedIndex >= 0 And cboSubCategory.SelectedIndex >= 0) Then
                Dim ask = MsgBox("Continue to save?", MsgBoxStyle.Information + vbYesNo, "Coaching Form")
                If (ask = vbYes) Then
                    Call AddRecord(cboID.SelectedItem, cboName.SelectedItem, cboCampaign.SelectedItem, cboDesignation.SelectedItem, cboCoachCat.SelectedItem, cboRootCauseCat.Text.Replace("'", "''"), dtCoachDate.Value, cboSupervisor.SelectedItem, dtFUCoachingDate.Value, rtxtItemDisc.Text.Replace("'", "''"), rtxtCause.Text.Replace("'", "''"), rtxtEffect.Text.Replace("'", "''"), rtxtEmpActPlan.Text.Replace("'", "''"), rtxtSupActPlan.Text.Replace("'", "''"), dtEffectiveDateEA.Value, dtEffecctiveDateSA.Value, cboCoachedBy.SelectedItem, cboNotedBy.Text.Replace("'", "''"), cboCoachee.SelectedItem, txtScanId.Text.Replace("'", "''"), cboSite.SelectedItem, cboStartDate.SelectedItem, cboSubCategory.SelectedItem)
                    MsgBox("File Saved!")
                    Call clearFields()

                End If
            Else
                MsgBox("Please complete all fields.", MsgBoxStyle.Exclamation, "Coaching Form")

            End If
        End If
    End Sub

    Public Sub clearFields()
        cboSite.SelectedIndex = 0
        cboName.SelectedIndex = 0
        cboCampaign.SelectedIndex = 0
        cboSupervisor.SelectedIndex = 0
        cboCoachee.SelectedIndex = 0
        'cboNotedBy.SelectedIndex = 0
        cboDesg2.SelectedIndex = 0
        cboDesignation.SelectedIndex = 0
        dtCoachDate.Value = Date.Now
        dtEffecctiveDateSA.Value = Date.Now
        dtEffectiveDateEA.Value = Date.Now
        dtFUCoachingDate.Value = Date.Now
        rtxtEffect.Text = ""
        rtxtCause.Text = ""
        rtxtEmpActPlan.Text = ""
        rtxtItemDisc.Text = ""
        rtxtSupActPlan.Text = ""
        txtScanId.Text = ""
        cboSite.SelectedIndex = 0
        cboSite2.SelectedIndex = 0
        cboStartDate2.SelectedIndex = 0
        cboStartDate.SelectedIndex = 0
        cboSubCategory.SelectedIndex = 0


        If (cboCoachedBy.Items.Contains(AccessName)) Then
            cboCoachedBy.SelectedItem = AccessName
            cboCoachedBy.Enabled = False
        Else

            cboCoachedBy.Items.Add(AccessName)
            cboCoachedBy.SelectedItem = AccessName
            cboCoachedBy.Enabled = False
        End If
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

        viewHelp = "file:///" & My.Application.Info.DirectoryPath & "\Template\WFD.CoachingForm_Manual.pdf" & "#page=12"
        frmHelp.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dtDateTodate.Value = Date.Now.ToString("MM/dd/yyyy hh:mm:ss")
    End Sub

    Private Sub cboSupervisor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSupervisor.SelectedIndexChanged

    End Sub



    'Private Sub Site()

    '    ConnectTOSQLServer()



    '    strSQL = "select disctinct Location from tblVKPOEmployee_HRNames
    '             where [EMPLOYEE ID NUMBER] = '" & cboID.SelectedItem & "' "

    '    Console.WriteLine(strSQL)

    '    cmd = New SqlCommand(strSQL, Connection2)
    '    reader = cmd.ExecuteReader()

    '    Do While reader.HasRows

    '        Do While reader.Read()
    '            cboSite2.Items.Add(reader.GetString(0))
    '        Loop
    '        reader.NextResult()
    '    Loop

    '    reader.Close()
    '    Call DisConnectSQLServer()

    'End Sub

End Class
