Imports System.Data.SqlClient
Public Class frmUpdate

    Private Sub frmUpdate_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Hide()
    End Sub

    Private Sub frmCoaching_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtCoachDate.Format = DateTimePickerFormat.Custom
        dtCoachDate.CustomFormat = "MM/dd/yyyy"
        dtFUCoachingDate.Format = DateTimePickerFormat.Custom
        dtFUCoachingDate.CustomFormat = "MM/dd/yyyy"
        dtEffecctiveDateSA.Format = DateTimePickerFormat.Custom
        dtEffecctiveDateSA.CustomFormat = "MM/dd/yyyy"
        dtEffectiveDateEA.Format = DateTimePickerFormat.Custom
        dtEffectiveDateEA.CustomFormat = "MM/dd/yyyy"
        getNameID()
        LoadLists()
        getForUpdate()


        If (Task = "VIEW") Then
            btnSave.Enabled = False
            cboCampaign.Enabled = False
            cboCoachCat.Enabled = False
            cboNotedBy.Enabled = False
            cboCoachCat.Enabled = False
            cboCoachee.Enabled = False
            cboDesignation.Enabled = False
            cboDSup.Enabled = False
            txtScanId.Enabled = False
            dtCoachDate.Enabled = False
            dtEffecctiveDateSA.Enabled = False
            dtEffectiveDateEA.Enabled = False
            dtFUCoachingDate.Enabled = False
            cboSupervisor.Enabled = False
            cboRootCauseCat.Enabled = False

        End If


    End Sub

    Public Sub getNameID()



        Dim strSQL As String = ""
        Dim foun As Integer = 0

        cboName.Items.Clear()
        cboDSup.Items.Clear()
        cboDirect2.Items.Clear()
        cboCoachee.Items.Clear()
        cboID.Items.Clear()
        cboDesg2.Items.Clear()
        cboSupervisor.Items.Clear()

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

        'strSQL = "select distinct firstname+' '+Lastname as Name,[EMPLOYEE ID NUMBER],a.Department ,isnull(case when b.Supervisor not like '%,%' then b.Supervisor else ltrim(rtrim(substring(b.Supervisor,CHARINDEX(', ',b.Supervisor)+1,len(b.Supervisor)))) +' '+ltrim(rtrim(substring(b.Supervisor,0,CHARINDEX(', ',b.Supervisor)))) end,'') as Supervisor,a.role,isnull((select isnull(case when Supervisor not like '%,%' then Supervisor else ltrim(rtrim(substring(Supervisor,CHARINDEX(', ',Supervisor)+1,len(Supervisor)))) +' '+ltrim(rtrim(substring(Supervisor,0,CHARINDEX(', ',Supervisor)))) end,'') as a from tblVKPOEmployee_HRNames where FIRSTNAME+' '+LASTNAME=isnull(case when b.Supervisor not like '%,%' then b.Supervisor else ltrim(rtrim(substring(b.Supervisor,CHARINDEX(', ',b.Supervisor)+1,len(b.Supervisor)))) +' '+ltrim(rtrim(substring(b.Supervisor,0,CHARINDEX(', ',b.Supervisor)))) end,'') and EmployeeStatus='active'),'') as Direct_Superior  " &
        '           " from tblVKPOEmployee_HRNames a " &
        '            " inner join (select * from tblMasterAttendance where DATE=(select MAX(date) from tblMasterAttendance where DATE<=GETDATE())) b on a.[EMPLOYEE ID NUMBER]=b.AgentID " &
        '           "  where employeestatus='ACTIVE'  and a.department not in ('EXC','EXR')  " &
        '          "   order by Supervisor "


        strSQL = "select distinct firstname+' '+Lastname as Name,[EMPLOYEE ID NUMBER],a.Department ,isnull(case when b.Supervisor not like '%,%' then b.Supervisor else ltrim(rtrim(substring(b.Supervisor,CHARINDEX(', ',b.Supervisor)+1,len(b.Supervisor)))) +' '+ltrim(rtrim(substring(b.Supervisor,0,CHARINDEX(', ',b.Supervisor)))) end,'') as Supervisor,a.role " &
             " from tblVKPOEmployee_HRNames a " &
                    " inner join (select * from tblMasterAttendance where DATE=(select MAX(date) from tblMasterAttendance)) b on a.[EMPLOYEE ID NUMBER]=b.AgentID " &
                   "  where employeestatus='ACTIVE'  and a.department not in ('EXC','EXR')  " &
                  "   order by firstname+' '+Lastname,Supervisor "

        Console.WriteLine(strSQL)

        cmd = New SqlCommand(strSQL, Connection2)
        reader = cmd.ExecuteReader()

        Do While reader.HasRows

            Do While reader.Read()
                cboName.Items.Add(reader.GetString(0))
                cboDSup.Items.Add(reader.GetString(3))
                'cboDirect2.Items.Add(reader.GetString(5))
                cboCoachee.Items.Add(reader.GetString(0))
                cboID.Items.Add(reader.GetString(1))
                If Not (cboCampaign.Items.Contains(reader.GetString(2))) Then
                    cboCampaign.Items.Add(reader.GetString(2))

                End If
                'cboCampaign.Items.Add(reader.GetString(2))
                cboDesg2.Items.Add(reader.GetString(4))

            Loop
            reader.NextResult()
        Loop

        reader.Close()


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

        Call DisConnectSQLServer()

    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        If (cboName.SelectedIndex >= 0 And cboID.SelectedIndex >= 0 And cboCampaign.SelectedIndex >= 0 And cboCoachCat.SelectedIndex >= 0 And cboDesignation.SelectedIndex >= 0 And cboCoachedBy.SelectedIndex >= 0 And cboNotedBy.SelectedIndex >= 0 And cboCoachee.SelectedIndex >= 0 And cboRootCauseCat.SelectedIndex >= 0 And rtxtEffect.Text <> "" And rtxtCause.Text <> "" And rtxtEmpActPlan.Text <> "" And rtxtItemDisc.Text <> "" And rtxtSupActPlan.Text <> "" And cboSite.SelectedIndex >= 0) Then
            Dim ask = MsgBox("Continue to update changes?", MsgBoxStyle.Information + vbYesNo, "Coaching Form")
            If (ask = vbYes) Then
                Call UpdateRecord(cboID.SelectedItem, cboCoachCat.Text.Replace("'", "''"), cboRootCauseCat.Text.Replace("'", "''"), dtCoachDate.Value, cboSupervisor.SelectedItem, dtFUCoachingDate.Value, rtxtItemDisc.Text.Replace("'", "''"), rtxtCause.Text.Replace("'", "''"), rtxtEffect.Text.Replace("'", "''"), rtxtEmpActPlan.Text.Replace("'", "''"), rtxtSupActPlan.Text.Replace("'", "''"), dtEffectiveDateEA.Value, dtEffecctiveDateSA.Value, cboCoachedBy.SelectedItem, cboNotedBy.Text.Replace("'", "''"), cboCoachee.SelectedItem, cboName.SelectedItem, cboCampaign.SelectedItem, cboDesignation.Text, txtScanId.Text.Replace("'", "''"), txtCoachingID.Text, cboSite.SelectedItem, cboSubCategory.SelectedItem)
                MsgBox("File Saved!")
                Me.Close()
            End If
        Else
            MsgBox("Please complete all fields.", MsgBoxStyle.Exclamation, "Coaching Form")
        End If

    End Sub

    Public Sub getForUpdate()
        Call ConnectTOSQLServer()

        Dim strSQL As String = ""
        Dim foun As Integer = 0

        strSQL = "select  EID,Name, startdate, Department,Designation, CoachingCategory, subCategory, 
                 RootCauseCategory, CoachingDate, Supervisor, FUCoachingDate, ItemDiscussion, 
                RootCause, Effect, EmployeeActionPlan, SupervisorActionPlan, EffectiveDateEAP, 
                EffectiveDateSAP, CoachedBy, NotedBy, Coachee,ScanId,CoachingID, Site 
                 from tblCoachingMaster2 where name='" & UpName & "' and CoachingNo = '" & UpCoachNum & "' "

        Console.WriteLine(strSQL)

        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()

        Do While reader.HasRows

            Do While reader.Read()
                cboID.SelectedItem = reader.GetString(0)
                cboName.SelectedItem = reader.GetString(1)
                dtpStartDate.Value = reader.GetDateTime(2).ToString("MM/dd/yyyy")
                cboCampaign.SelectedItem = reader.GetString(3)
                cboDesignation.SelectedItem = reader.GetString(4)
                cboCoachCat.SelectedItem = reader.GetString(5)
                cboSubCategory.SelectedItem = reader.GetString(6)
                cboRootCauseCat.SelectedItem = reader.GetString(7)
                dtCoachDate.Value = reader.GetDateTime(8).ToString("MM/dd/yyyy")
                cboSupervisor.SelectedItem = reader.GetString(9)
                dtFUCoachingDate.Value = reader.GetDateTime(10).ToString("MM/dd/yyyy")
                rtxtItemDisc.Text = reader.GetString(11)
                rtxtCause.Text = reader.GetString(12)
                rtxtEffect.Text = reader.GetString(13)
                rtxtEmpActPlan.Text = reader.GetString(14)
                rtxtSupActPlan.Text = reader.GetString(15)
                dtEffectiveDateEA.Value = reader.GetDateTime(16).ToString("MM/dd/yyyy")
                dtEffecctiveDateSA.Value = reader.GetDateTime(17).ToString("MM/dd/yyyy")
                cboSite.SelectedItem = reader.GetString(23)

                If Not (cboCoachedBy.Items.Contains(reader.GetString(18))) Then
                    cboCoachedBy.Items.Add(reader.GetString(18))
                    cboCoachedBy.SelectedItem = reader.GetString(18)
                Else
                    cboCoachedBy.SelectedItem = reader.GetString(18)
                End If
                If Not (cboNotedBy.Items.Contains(reader.GetString(19))) Then
                    cboNotedBy.Items.Add(reader.GetString(19))
                    cboNotedBy.SelectedItem = reader.GetString(19)
                Else
                    cboNotedBy.SelectedItem = reader.GetString(19)
                End If
                If Not (cboName.Items.Contains(reader.GetString(1))) Then
                    cboName.Items.Add(reader.GetString(1))
                    cboName.SelectedItem = reader.GetString(1)
                Else
                    cboName.SelectedItem = reader.GetString(1)
                End If

                If Not (cboCoachee.Items.Contains(reader.GetString(20))) Then
                    cboCoachee.Items.Add(reader.GetString(20))
                    cboCoachee.SelectedItem = reader.GetString(20)
                Else
                    cboCoachee.SelectedItem = reader.GetString(20)
                End If
                txtScanId.Text = reader.GetString(21)
                txtCoachingID.Text = reader.GetInt32(22)

            Loop
            reader.NextResult()
        Loop

        reader.Close()
        Call DisConnectSQLServer()
    End Sub

End Class
