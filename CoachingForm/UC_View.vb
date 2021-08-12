Imports System.Data.SqlClient
Public Class UC_View

    Private folderBrowserDialog1 As New FolderBrowserDialog

    Private foldername As String
    Dim checkall As Integer

    Public Sub getYears()

        Dim cond As String = ""

        If (AccessAccount = "") Then
            cond = " "
        Else
            cond = " and CoachedBy='" & AccessAccount & "' "
        End If

        cboYear.Items.Clear()
        cboMonth.Items.Clear()
        cboProject.Items.Clear()
        cboccategory.Items.Clear()
        cboRootCause.Items.Clear()

        cboYear.Items.Add("ALL")
        cboMonth.Items.Add("ALL")
        cboProject.Items.Add("ALL")
        cboccategory.Items.Add("ALL")
        cboRootCause.Items.Add("ALL")

        ConnectTOSQLServer()

        Dim strSQL As String = ""

        'strSQL = "select distinct year(CoachingDate) as [Year] from tblCoachingMaster2 " & cond & "  order by  year(CoachingDate)"

        If (AccessAccount = "") Then

            strSQL = " select distinct year(CoachingDate) as [Year] " &
                    " from  tblCoachingMaster2 c" &
                    " where 1=1 " &
                     "  and c.[status]='ACTIVE' order by  year(CoachingDate) "

        Else
            strSQL = " 	select distinct year(CoachingDate) as [Year]	 " &
                        " 	from (	 " &
                        " 	select a.*	 " &
                        " 	from tblCoachingMaster2 a	 " &
                        " 	inner join tblVKPOEmployee_HRNames b on a.Name=b.firstname+' '+lastname	 " &
                        " 	where status='active'	 " &
                        " 	and EmployeeStatus='active'	 " &
                        " 	and name in(	 " &
                        " 	select firstname+' '+lastname as name	 " &
                        " 	from tblVKPOEmployee_HRNames	 " &
                        " 	where EmployeeStatus='active'	 " &
                        " 	and Department in (	 " &
                        " 	select campaign	 " &
                        " 	from (	 " &
                        " 	select distinct campaign	 " &
                        " 	from tblVKPOEmployee_HRNames	 " &
                        " 	where EmployeeStatus='active'	 " &
                        " 	and department in(	 " &
                        " 	select distinct department	 " &
                        " 	from tblVKPOEmployee_HRNames	 " &
                        " 	where EmployeeStatus='active'	 " &
                        " 	and Supervisor='" & NameLastForm & "')	 " &
                        " 	union 	 " &
                        " 	select distinct department	 " &
                        " 	from tblVKPOEmployee_HRNames	 " &
                        " 	where EmployeeStatus='active'	 " &
                        " 	and Supervisor='" & NameLastForm & "'	 " &
                        " 	)a ))	 " &
                        " 	and b.CRank<	 " &
                        " 	(select crank 	 " &
                        " 	from tblVKPOEmployee_HRNames 	 " &
                        " 	where EmployeeStatus='active' 	 " &
                        " 	and firstname+' '+LASTNAME='" & AccessAccount & "')	 " &
                        " 	and (replace(replace(replace(b.role,' - OIT',''),' - OIC',''),'OPS','Team Leader') not in	 " &
                        " 	(select distinct replace(replace(replace(b.role,' - OIT',''),' - OIC',''),'OPS','Team Leader') 	 " &
                        " 	from tblVKPOEmployee_HRNames 	 " &
                        " 	where EmployeeStatus='active' 	 " &
                        " 	and firstname+''+LASTNAME='" & AccessAccount & "')	 " &
                        " 	)	 " &
                        " 	union 	 " &
                        " 	select *	 " &
                        " 	from tblCoachingMaster2	 " &
                        " 	where CoachedBy='" & AccessAccount & "'		and status='Active'  " &
                        " 	)a	 order by  year(CoachingDate) "

        End If

        Console.WriteLine(strSQL)

        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()

        Do While reader.HasRows

            Do While reader.Read()
                cboYear.Items.Add(reader.GetValue(0))
            Loop
            reader.NextResult()
        Loop

        reader.Close()

        'strSQL = "select distinct upper(left(datename(month,CoachingDate),3)) as [Month] from tblCoachingMaster2 " & cond & "  order by  upper(left(datename(month,CoachingDate),3))"

        If (AccessAccount = "") Then

            strSQL = " select distinct upper(left(datename(month,CoachingDate),3)) as [Month]  " &
                    " from  tblCoachingMaster2 c" &
                    " where 1=1 " &
                     "  and c.[status]='ACTIVE' order by  upper(left(datename(month,CoachingDate),3)) "
        Else

            strSQL = " 	select distinct upper(left(datename(month,CoachingDate),3)) as [Month]	 " &
                        " 	from (	 " &
                        " 	select a.*	 " &
                        " 	from tblCoachingMaster2 a	 " &
                        " 	inner join tblVKPOEmployee_HRNames b on a.Name=b.firstname+' '+lastname	 " &
                        " 	where status='active'	 " &
                        " 	and EmployeeStatus='active'	 " &
                        " 	and name in(	 " &
                        " 	select firstname+' '+lastname as name	 " &
                        " 	from tblVKPOEmployee_HRNames	 " &
                        " 	where EmployeeStatus='active'	 " &
                        " 	and Department in (	 " &
                        " 	select campaign	 " &
                        " 	from (	 " &
                        " 	select distinct campaign	 " &
                        " 	from tblVKPOEmployee_HRNames	 " &
                        " 	where EmployeeStatus='active'	 " &
                        " 	and department in(	 " &
                        " 	select distinct department	 " &
                        " 	from tblVKPOEmployee_HRNames	 " &
                        " 	where EmployeeStatus='active'	 " &
                        " 	and Supervisor='" & NameLastForm & "')	 " &
                        " 	union 	 " &
                        " 	select distinct department	 " &
                        " 	from tblVKPOEmployee_HRNames	 " &
                        " 	where EmployeeStatus='active'	 " &
                        " 	and Supervisor='" & NameLastForm & "'	 " &
                        " 	)a ))	 " &
                        " 	and b.CRank<	 " &
                        " 	(select crank 	 " &
                        " 	from tblVKPOEmployee_HRNames 	 " &
                        " 	where EmployeeStatus='active' 	 " &
                        " 	and firstname+' '+LASTNAME='" & AccessAccount & "')	 " &
                        " 	and (replace(replace(replace(b.role,' - OIT',''),' - OIC',''),'OPS','Team Leader') not in	 " &
                        " 	(select distinct replace(replace(replace(b.role,' - OIT',''),' - OIC',''),'OPS','Team Leader') 	 " &
                        " 	from tblVKPOEmployee_HRNames 	 " &
                        " 	where EmployeeStatus='active' 	 " &
                        " 	and firstname+''+LASTNAME='" & AccessAccount & "')	 " &
                        " 	)	 " &
                        " 	union 	 " &
                        " 	select *	 " &
                        " 	from tblCoachingMaster2	 " &
                        " 	where CoachedBy='" & AccessAccount & "'		and status='Active'  " &
                        " 	)a	 order by  upper(left(datename(month,CoachingDate),3)) "

            Console.WriteLine(strSQL)
        End If

        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()

        Do While reader.HasRows

            Do While reader.Read()
                cboMonth.Items.Add(reader.GetValue(0))
            Loop
            reader.NextResult()
        Loop

        reader.Close()

        'strSQL = "select distinct Department from tblCoachingMaster2 " & cond & "   order by Department "

        If (AccessAccount = "") Then

            strSQL = " select distinct Department  " &
                    " from  tblCoachingMaster2 c" &
                    " where 1=1 " &
                     "  and c.[status]='ACTIVE' order by Department "
        Else
            strSQL = " 	select campaign	 " &
                        " 	from (	 " &
                        " 	select distinct campaign	 " &
                        " 	from tblVKPOEmployee_HRNames	 " &
                        " 	where EmployeeStatus='active'	 " &
                        " 	and department in(	 " &
                        " 	select distinct department	 " &
                        " 	from tblVKPOEmployee_HRNames	 " &
                        " 	where EmployeeStatus='active'	 " &
                        " 	and Supervisor='" & NameLastForm & "')	 " &
                        " 	union 	 " &
                        " 	select distinct department	 " &
                        " 	from tblVKPOEmployee_HRNames	 " &
                        " 	where EmployeeStatus='active'	 " &
                        " 	and Supervisor='" & NameLastForm & "'	 " &
                        " 	)a  order by campaign"
        End If
        Console.WriteLine(strSQL)

        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()

        Do While reader.HasRows
            Do While reader.Read()
                cboProject.Items.Add(reader.GetString(0))
            Loop
            reader.NextResult()
        Loop

        reader.Close()

        strSQL = "select distinct CoachingCategory  from tblCoachingMaster2 where   status='ACTIVE'  " & cond & "  order by CoachingCategory "

        Console.WriteLine(strSQL)

        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()

        Do While reader.HasRows

            Do While reader.Read()
                cboccategory.Items.Add(reader.GetString(0))
            Loop
            reader.NextResult()
        Loop

        reader.Close()

        strSQL = "select distinct RootCauseCategory  from tblCoachingMaster2  where   status='ACTIVE'  " & cond & "  order by RootCauseCategory "

        Console.WriteLine(strSQL)

        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()

        Do While reader.HasRows

            Do While reader.Read()
                cboRootCause.Items.Add(reader.GetString(0))
            Loop
            reader.NextResult()
        Loop

        reader.Close()

        DisConnectSQLServer()
    End Sub

    Private Sub DisplayRecords()

        Dim cond As String = ""

        If (AccessAccount = "") Then
            cond = ""
        Else
            cond = " or CoachedBy='" & AccessAccount & "' "
        End If

        Dim ConYear As String
        Dim ConMonth As String
        Dim Proj As String
        Dim cCat As String
        Dim RootCause As String
        Dim NameFil As String

        If (txtName.Text <> "") Then
            NameFil = " and name like '%" & txtName.Text.Replace("'", "''") & "%'  "
        Else
            NameFil = ""
        End If

        If (cboYear.SelectedIndex > 0) Then
            ConYear = " and year(coachingdate) = '" & cboYear.SelectedItem & "' "
        Else
            ConYear = "  "
        End If

        If (cboMonth.SelectedIndex > 0) Then
            ConMonth = " and upper(left(datename(month,CoachingDate),3)) = '" & cboMonth.SelectedItem & "' "
        Else
            ConMonth = "  "
        End If

        If (cboProject.SelectedIndex > 0) Then
            Proj = " and department = '" & cboProject.SelectedItem & "' "
        Else
            Proj = "  "
        End If

        If (cboccategory.SelectedIndex > 0) Then
            cCat = " and CoachingCategory = '" & cboccategory.SelectedItem & "' "
        Else
            cCat = "  "
        End If

        If (cboRootCause.SelectedIndex > 0) Then
            RootCause = " and RootCauseCategory = '" & cboRootCause.SelectedItem & "' "
        Else
            RootCause = "  "
        End If

        ConnectTOSQLServer()

        'strSQL = " select CoachingDate,Name,Department,Designation,Supervisor,CoachingCategory,RootCauseCategory,FUCoachingDate, ItemDiscussion, RootCause,Effect,EmployeeActionPlan, SupervisorActionPlan, EffectiveDateEAP, EffectiveDateSAP,CoachedBy" &
        '        "  from tblCoachingMaster2 where [status]='ACTIVE'  " & ConYear & "   " & ConMonth & "   " & Proj & "   " & cCat & "   " & RootCause & " " & cond & "  " & NameFil & "  order by coachingdate desc"

        'strSQL = "select distinct a.CoachingDate,a.Name,a.Department,a.Designation,a.Supervisor,a.CoachingCategory,a.RootCauseCategory,a.FUCoachingDate, a.ItemDiscussion, a.RootCause,a.Effect,a.EmployeeActionPlan, a.SupervisorActionPlan, a.EffectiveDateEAP, a.EffectiveDateSAP,a.CoachedBy " &
        '    "            from tblCoachingMaster2 a " &
        '    "                      inner join tblVKPOEmployee_HRNames b on a.EID=b.[EMPLOYEE ID NUMBER] " &
        '               "           inner join tblVKPOEmployee_HRNames d on  (d.Department=b.Department and d.Campaign=a.Department)   or (a.CoachedBy = d.FIRSTNAME+' '+d.LASTNAME) " &
        '                  "        inner join (select * from tblVKPOEmployee_HRNames c where  c.FIRSTNAME+' '+c.LASTNAME='" & AccessAccount & "'  and EmployeeStatus='ACTIVE') c on ((c.Department=d.Department )  or (d.Department=b.Department and d.Campaign=a.Department) or (a.CoachedBy = c.FIRSTNAME+' '+c.LASTNAME)  ) " &
        '                  "        where [status]='ACTIVE' " &
        '                  "        and b.EmployeeStatus='ACTIVE' " &
        '                  "        and c.EmployeeStatus='ACTIVE' " &
        '                  "        and d.EmployeeStatus='ACTIVE' " &
        '                  "        and (( (  ( (d.Campaign=a.Department or d.Department=a.Department) and (d.Department=c.Department or d.Department=c.Campaign or b.Department=c.Campaign or b.Department=c.Department)) ) " &
        '                  "    and  ( " &
        '                  "         d.Supervisor<>c.Supervisor " &
        '                  "        and b.Supervisor<>c.Supervisor " &
        '                  "        and replace(replace(b.role,' - OIT',''),' - OIC','') not like replace(replace(c.role,' - OIT',''),' - OIC','')+'%' " &
        '                  "        and b.CRank<c.CRank) " &
        '                  "        )  " & cond & "   ) " &
        '        "  " & ConYear & "   " & ConMonth & "   " & Proj & "   " & cCat & "   " & RootCause & "   " & NameFil & "  order by coachingdate desc "

        If (AccessAccount = "") Then

            strSQL = "  SELECT DISTINCT CoachingDate, Name, startDate, Department, Designation, Supervisor, CoachingCategory, subcategory,
                         RootCauseCategory,FUCoachingDate, ItemDiscussion, RootCause,Effect, EmployeeActionPlan, SupervisorActionPlan, 
                          EffectiveDateEAP, EffectiveDateSAP,CoachedBy,ScanId, Site, CoachingNo 
                         from  tblCoachingMaster2 
                         WHERE 1=1  
                         AND [status]='ACTIVE' " & ConYear & " " & ConMonth & "   " & Proj & "   " & cCat & "   " & RootCause & "   " & NameFil & " ORDER BY coachingdate DESC"
        Else

            'strSQL = "  select distinct c.CoachingDate,c.Name,c.Department,c.Designation,c.Supervisor,c.CoachingCategory,c.RootCauseCategory,c.FUCoachingDate, c.ItemDiscussion, c.RootCause,c.Effect,c.EmployeeActionPlan, c.SupervisorActionPlan, c.EffectiveDateEAP, c.EffectiveDateSAP,c.CoachedBy,c.ScanId " &
            '"  from tblVKPOEmployee_HRNames a " &
            '"  inner join tblVKPOEmployee_HRNames b on b.Department like '%'+a.Campaign+'%' or b.Department=case when a.crank>=7 then a.Department else a.Campaign end or  b.Supervisor= a.LASTNAME+', '+a.FIRSTNAME " &
            '"  inner join tblVKPOEmployee_HRNames d on d.supervisor=b.LASTNAME+', '+b.FIRSTNAME or d.Supervisor= a.LASTNAME+', '+a.FIRSTNAME " &
            '"  inner join tblCoachingMaster2 c on c.Name=b.FIRSTNAME+' '+b.LASTNAME or c.Name=d.FIRSTNAME+' '+d.LASTNAME " &
            '"  where a.EmployeeStatus='active' " &
            '"  and b.EmployeeStatus='active' " &
            '"  and c.[status]='ACTIVE' " &
            '"  and d.EmployeeStatus='active' " &
            '"  and a.FIRSTNAME+' '+a.LASTNAME='" & AccessAccount & "' " &
            '"  and ((b.CRank<a.CRank and d.CRank<a.CRank and (replace(replace(replace(a.role,' - OIT',''),' - OIC',''),'OPS','Team Leader') not like '%'+replace(replace(replace(b.role,' - OIT',''),' - OIC',''),'OPS','Team Leader')+'%')) or  c.CoachedBy='" & AccessAccount & "') " &
            '"  and c.[status]='ACTIVE' " &
            '"  " & ConYear & "   " & ConMonth & "   " & Proj & "   " & cCat & "   " & RootCause & "   " & NameFil & "  order by coachingdate desc  "

            ' strSQL = "  select distinct c.CoachingDate,c.Name,c.Department,c.Designation,c.Supervisor,c.CoachingCategory,c.RootCauseCategory,c.FUCoachingDate, c.ItemDiscussion, c.RootCause,c.Effect,c.EmployeeActionPlan, c.SupervisorActionPlan, c.EffectiveDateEAP, c.EffectiveDateSAP,c.CoachedBy,c.ScanId " &
            '"  from tblVKPOEmployee_HRNames a " &
            '"  inner join tblVKPOEmployee_HRNames b on b.Department like '%'+a.Campaign+'%' or b.Department=case when a.crank>=7 then a.Department else a.Campaign end or  b.Supervisor= a.LASTNAME+', '+a.FIRSTNAME " &
            '"  inner join tblCoachingMaster2 c on c.Name=b.FIRSTNAME+' '+b.LASTNAME  " &
            '"  where a.EmployeeStatus='active' " &
            '"  and b.EmployeeStatus='active' " &
            '"  and c.[status]='ACTIVE' " &
            '"  and a.FIRSTNAME+' '+a.LASTNAME='" & AccessAccount & "' " &
            '"  and ((b.CRank<a.CRank and  (replace(replace(replace(a.role,' - OIT',''),' - OIC',''),'OPS','Team Leader') not like '%'+replace(replace(replace(b.role,' - OIT',''),' - OIC',''),'OPS','Team Leader')+'%')) or  c.CoachedBy='" & AccessAccount & "') " &
            '"  and c.[status]='ACTIVE' " &
            '"  " & ConYear & "   " & ConMonth & "   " & Proj & "   " & cCat & "   " & RootCause & "   " & NameFil & "  order by coachingdate desc  "

            strSQL = " 	select distinct CoachingDate,Name,startDate, Department,Designation,Supervisor,
                         CoachingCategory,subcategory,
                        RootCauseCategory,FUCoachingDate, ItemDiscussion, RootCause,Effect,
                        EmployeeActionPlan, SupervisorActionPlan, EffectiveDateEAP, EffectiveDateSAP,
                        CoachedBy,ScanId,Site, CoachingNo	 " &
                        " 	from (	 " &
                        " 	select a.*	 " &
                        " 	from tblCoachingMaster2 a	 " &
                        " 	inner join tblVKPOEmployee_HRNames b on a.Name=b.firstname+' '+lastname" &
                        " 	where status='active'	 " &
                        " 	and EmployeeStatus='active'	 " &
                        " 	and name in(	 " &
                        " 	select firstname+' '+lastname as name	 " &
                        " 	from tblVKPOEmployee_HRNames	 " &
                        " 	where EmployeeStatus='active'	 " &
                        " 	and Department in (	 " &
                        " 	select campaign	 " &
                        " 	from (	 " &
                        " 	select distinct campaign	 " &
                        " 	from tblVKPOEmployee_HRNames	 " &
                        " 	where EmployeeStatus='active'	 " &
                        " 	and department in(	 " &
                        " 	select distinct department	 " &
                        " 	from tblVKPOEmployee_HRNames	 " &
                        " 	where EmployeeStatus='active'	 " &
                        " 	and Supervisor='" & NameLastForm & "')	 " &
                        " 	union 	 " &
                        " 	select distinct department	 " &
                        " 	from tblVKPOEmployee_HRNames	 " &
                        " 	where EmployeeStatus='active'	 " &
                        " 	and Supervisor='" & NameLastForm & "'	 " &
                        " 	)a ))	 " &
                        " 	and b.CRank<	 " &
                        " 	(select crank 	 " &
                        " 	from tblVKPOEmployee_HRNames 	 " &
                        " 	where EmployeeStatus='active' 	 " &
                        " 	and firstname+' '+LASTNAME='" & AccessAccount & "')	 " &
                        " 	and (replace(replace(replace(b.role,' - OIT',''),' - OIC',''),'OPS','Team Leader') not in	 " &
                        " 	(select distinct replace(replace(replace(b.role,' - OIT',''),' - OIC',''),'OPS','Team Leader') 	 " &
                        " 	from tblVKPOEmployee_HRNames 	 " &
                        " 	where EmployeeStatus='active' 	 " &
                        " 	and firstname+''+LASTNAME='" & AccessAccount & "')	 " &
                        " 	) " &
                        " 	union 	 " &
                        " 	select *	 " &
                        " 	from tblCoachingMaster2	 " &
                        " 	where CoachedBy='" & AccessAccount & "'		and status='Active'  " &
                        " 	)a	 " &
                        " 	where 1=1 	 " &
                        "  " & ConYear & "   " & ConMonth & "   " & Proj & "   " & cCat & "   " & RootCause & "   " & NameFil & "  order by coachingdate desc  "

        End If

        Console.WriteLine(strSQL)

        cmd = New SqlCommand(strSQL, Connection)

        reader = cmd.ExecuteReader()
        'MsgBox(dr.HasRows)
        Dim x As Integer = 0
        DataGridView1.Rows.Clear()


        With DataGridView1
            While reader.Read()
                .Rows.Add()
                .RowHeadersVisible = False
                .Item(1, x).Value = "Edit"
                .Item(2, x).Value = reader.GetDateTime(0).ToString("MM/dd/yyyy")
                .Item(3, x).Value = reader.GetString(1)
                .Item(4, x).Value = reader.GetDateTime(2).ToString("MM/dd/yyyy")
                .Item(5, x).Value = reader.GetString(3)
                .Item(6, x).Value = reader.GetString(4)
                .Item(7, x).Value = reader.GetString(5)
                .Item(8, x).Value = reader.GetString(6)
                .Item(9, x).Value = reader.GetString(7)
                .Item(10, x).Value = reader.GetString(8)
                .Item(11, x).Value = reader.GetDateTime(9).ToString("MM/dd/yyyy")
                .Item(12, x).Value = reader.GetString(10)
                .Item(13, x).Value = reader.GetString(11)
                .Item(14, x).Value = reader.GetString(12)
                .Item(15, x).Value = reader.GetString(13)
                .Item(16, x).Value = reader.GetString(14)
                .Item(17, x).Value = reader.GetDateTime(15).ToString("MM/dd/yyyy")
                .Item(18, x).Value = reader.GetDateTime(16).ToString("MM/dd/yyyy")
                .Item(19, x).Value = reader.GetString(17)
                .Item(20, x).Value = reader.GetString(18)
                .Item(21, x).Value = reader.GetString(19)
                .Item(22, x).Value = reader.GetString(20)

                'Console.WriteLine(reader.GetString(15) & "   " & AccessType & "  " & AccessAccount)
                If (reader.GetString(17) = AccessName) Then
                    'Console.WriteLine(" I coach  :  " & reader.GetString(15) & "  " & AccessType)
                Else
                    '--comment muna
                    'Dim cell As New DataGridViewTextBoxCell   'Replace the ButtonCell for a TextCell'
                    'cell.Value = ""
                    'DataGridView1.Rows(x).Cells(1) = cell
                    '--until here
                    DataGridView1.Rows(x).Cells(1).Value() = "View"

                End If
                'DirectCast(ApproveShiftDatagrid.CurrentRow.Cells(5), DataGridViewButtonColumn). = Schedule.Items
                'reader.NextResult()
                x = x + 1
            End While


        End With

        DisConnectSQLServer()
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (e.RowIndex >= 0) Then
            If (e.ColumnIndex = 0) Then
                If (DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False) Then
                    DataGridView1.Rows(e.RowIndex).SetValues(True)
                Else
                    DataGridView1.Rows(e.RowIndex).SetValues(False)
                End If
            ElseIf (e.ColumnIndex = 1 And DataGridView1.Rows(e.RowIndex).Cells(1).Value = "Edit") Then
                Task = "EDIT"
                UpName = DataGridView1.Rows(e.RowIndex).Cells(3).Value

                UpCoachNum = DataGridView1.Rows(e.RowIndex).Cells(22).Value

                frmUpdate.Show()
            ElseIf (e.ColumnIndex = 1 And DataGridView1.Rows(e.RowIndex).Cells(1).Value = "View") Then
                Task = "VIEW"
                UpName = DataGridView1.Rows(e.RowIndex).Cells(3).Value

                UpCoachNum = DataGridView1.Rows(e.RowIndex).Cells(22).Value

                frmUpdate.Show()
            End If
        End If
    End Sub

    'Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
    '    Dim i As Integer = 0
    '    Dim y As Integer = 0

    '    Do While y < DataGridView1.RowCount
    '        If (DataGridView1.Rows(y).Cells(0).Value = True) Then

    '            i = i + 1
    '        End If
    '        y = y + 1

    '    Loop


    '    Dim x As Integer = DataGridView1.RowCount - 1

    '    If (i > 0) Then
    '        Dim ask = MsgBox("Are you sure you want to delete the selected record/s?", MsgBoxStyle.Information + vbYesNo, "Coaching Form")
    '        If (ask = vbYes) Then
    '            Do While x >= 0

    '                If (DataGridView1.Rows(x).Cells(0).Value = True) Then
    '                    DataGridView1.Columns(2).DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss"
    '                    Call RemoveRecord(DataGridView1.Rows(x).Cells(3).Value, DataGridView1.Rows(x).Cells(2).Value, DataGridView1.Rows(x).Cells(17).Value)
    '                    DataGridView1.Rows.RemoveAt(x)
    '                End If
    '                x = x - 1
    '            Loop
    '        End If
    '    Else
    '        MsgBox("Please select records to delete.", vbInformation, "Coaching Form")
    '    End If

    'End Sub
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim i As Integer = 0
        Dim y As Integer = 0


        Do While y < DataGridView1.RowCount
            If (DataGridView1.Rows(y).Cells(0).Value = True) Then

                i = i + 1
            End If
            y = y + 1

        Loop


        Dim x As Integer = DataGridView1.RowCount - 1

        If (i > 0) Then
            Dim ask = MsgBox("Continue export as PDF?", MsgBoxStyle.Information + vbYesNo, "Coaching Form")
            If (ask = vbYes) Then
                Dim result As DialogResult
                result = folderBrowserDialog1.ShowDialog()

                If (result = DialogResult.OK) Then
                    btnDelete.Enabled = False
                    btnExportExcel.Enabled = False
                    btnExport.Enabled = False
                    ProgressBar1.Visible = True
                    btnExportAll.Enabled = False
                    ProgressBar1.Maximum = 10
                    BackgroundWorker1.WorkerReportsProgress = True
                    BackgroundWorker1.RunWorkerAsync()
                End If
            End If

        Else
            MsgBox("Please select records to export as PDF.", vbInformation, "Coaching Form")
        End If
    End Sub

    Private Sub cboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYear.SelectedIndexChanged
        DisplayRecords()
    End Sub

    Private Sub cboProject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProject.SelectedIndexChanged
        DisplayRecords()
    End Sub

    Private Sub cboccategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboccategory.SelectedIndexChanged
        DisplayRecords()
    End Sub

    Private Sub cboRootCause_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRootCause.SelectedIndexChanged
        DisplayRecords()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Dim x As Integer = DataGridView1.RowCount - 1

            BackgroundWorker1.ReportProgress(1)
            System.Threading.Thread.Sleep(100)
            BackgroundWorker1.ReportProgress(2)

            foldername = folderBrowserDialog1.SelectedPath
            Do While x >= 0

                If (DataGridView1.Rows(x).Cells(0).Value = True) Then
                    ExportPDF(DataGridView1.Rows(x).Cells(3).Value, DataGridView1.Rows(x).Cells(2).Value, DataGridView1.Rows(x).Cells(17).Value, foldername)
                    If (ProgressBar1.Value < 10) Then
                        ProgressBar1.Value = ProgressBar1.Value + 1
                    Else
                        ProgressBar1.Value = 2
                    End If
                End If
                x = x - 1
            Loop
            System.Threading.Thread.Sleep(100)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ProgressBar1.Value = 10
        MsgBox("File(s) exported.", vbInformation, "Coaching Form")
        ProgressBar1.Visible = False
        btnDelete.Enabled = True
        btnExportExcel.Enabled = True
        btnExport.Enabled = True
        btnExportAll.Enabled = True
    End Sub


    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        Dim i As Integer = 0
        Dim y As Integer = 0




        Do While y < DataGridView1.RowCount
            If (DataGridView1.Rows(y).Cells(0).Value = True) Then

                i = i + 1
            End If
            y = y + 1

        Loop
        Dim x As Integer = DataGridView1.RowCount - 1
        If (i > 0) Then
            Dim ask = MsgBox("Continue export as Excel?", MsgBoxStyle.Information + vbYesNo, "Coaching Form")
            If (ask = vbYes) Then
                Dim result As DialogResult
                result = folderBrowserDialog1.ShowDialog()

                If (result = DialogResult.OK) Then
                    btnDelete.Enabled = False
                    btnExportExcel.Enabled = False
                    btnExport.Enabled = False
                    btnExportAll.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar1.Maximum = 10
                    BackgroundWorker2.WorkerReportsProgress = True
                    BackgroundWorker2.RunWorkerAsync()
                End If
            End If

        Else
            MsgBox("Please select records to export.", vbInformation, "Coaching Form")
        End If
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Try
            Dim x As Integer = 0
            cntr = 0
            BackgroundWorker2.ReportProgress(1)
            System.Threading.Thread.Sleep(100)
            BackgroundWorker2.ReportProgress(2)

            foldername = folderBrowserDialog1.SelectedPath
            Do While x <= DataGridView1.RowCount - 1

                If (DataGridView1.Rows(x).Cells(0).Value = True) Then
                    ExportExcel(DataGridView1.Rows(x).Cells(3).Value, DataGridView1.Rows(x).Cells(2).Value, DataGridView1.Rows(x).Cells(17).Value, foldername)
                    cntr = cntr + 1
                    If (ProgressBar1.Value < 10) Then
                        ProgressBar1.Value = ProgressBar1.Value + 1
                    Else
                        ProgressBar1.Value = 2
                    End If
                End If
                x = x + 1
            Loop
            System.Threading.Thread.Sleep(100)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged
        DisplayRecords()
    End Sub

    Private Sub BackgroundWorker2_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker2.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        ProgressBar1.Value = 10
        MsgBox("File(s) exported.", vbInformation, "Coaching Form")
        ProgressBar1.Visible = False
        btnDelete.Enabled = True
        btnExportExcel.Enabled = True
        btnExport.Enabled = True
        btnExportAll.Enabled = True
    End Sub

    'Private Sub HelpToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
    '    viewHelp = "file:///" & My.Application.Info.DirectoryPath & "\Template\WFD.CoachingForm_Manual.pdf" & "#page=13"
    '    frmHelp.Show()
    'End Sub

    Private Sub btnExportAll_Click(sender As Object, e As EventArgs) Handles btnExportAll.Click
        Dim ask = MsgBox("Continue exporting all records?", MsgBoxStyle.Information + vbYesNo, "Coaching Form")
        If (ask = vbYes) Then



            Dim result As DialogResult
            result = folderBrowserDialog1.ShowDialog()

            If (result = DialogResult.OK) Then
                btnDelete.Enabled = False
                btnExportExcel.Enabled = False
                btnExport.Enabled = False
                btnExportAll.Enabled = False
                ProgressBar1.Visible = True
                ProgressBar1.Maximum = 10
                BackgroundWorker3.WorkerReportsProgress = True
                BackgroundWorker3.RunWorkerAsync()
            End If
        End If

    End Sub

    Private Sub BackgroundWorker3_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        Try
            Dim x As Integer = 0
            cntr = 0
            BackgroundWorker3.ReportProgress(1)
            System.Threading.Thread.Sleep(100)
            BackgroundWorker3.ReportProgress(2)

            foldername = folderBrowserDialog1.SelectedPath
            'Do While x <= DataGridView1.RowCount - 1


            '    Call ExportExcel(DataGridView1.Rows(x).Cells(3).Value, DataGridView1.Rows(x).Cells(2).Value, DataGridView1.Rows(x).Cells(17).Value, foldername)
            '    cntr = cntr + 1
            '    If (ProgressBar1.Value < 10) Then
            '        ProgressBar1.Value = ProgressBar1.Value + 1
            '    Else
            '        ProgressBar1.Value = 2

            '    End If
            '    x = x + 1
            'Loop


            Dim cond As String = ""

            If (AccessAccount = "") Then
                cond = ""
            Else
                cond = " or CoachedBy='" & AccessAccount & "' "
            End If

            Dim ConYear As String
            Dim ConMonth As String
            Dim Proj As String
            Dim cCat As String
            Dim RootCause As String
            Dim NameFil As String

            If (txtName.Text <> "") Then
                NameFil = " and name like '%" & txtName.Text.Replace("'", "''") & "%'  "
            Else
                NameFil = ""
            End If

            If (cboYear.SelectedIndex > 0) Then
                ConYear = " and year(coachingdate) = '" & cboYear.SelectedItem & "' "
            Else
                ConYear = "  "
            End If

            If (cboMonth.SelectedIndex > 0) Then
                ConMonth = " and upper(left(datename(month,CoachingDate),3)) = '" & cboMonth.SelectedItem & "' "
            Else
                ConMonth = "  "
            End If

            If (cboProject.SelectedIndex > 0) Then
                Proj = " and department = '" & cboProject.SelectedItem & "' "
            Else
                Proj = "  "
            End If

            If (cboccategory.SelectedIndex > 0) Then
                cCat = " and CoachingCategory = '" & cboccategory.SelectedItem & "' "
            Else
                cCat = "  "
            End If

            If (cboRootCause.SelectedIndex > 0) Then
                RootCause = " and RootCauseCategory = '" & cboRootCause.SelectedItem & "' "
            Else
                RootCause = "  "
            End If

            ExportExcelAll(foldername, ConYear, ConMonth, Proj, cCat, RootCause, NameFil)


            System.Threading.Thread.Sleep(100)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BackgroundWorker3_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker3.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker3_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker3.RunWorkerCompleted
        ProgressBar1.Value = 10
        MsgBox("File(s) exported.", vbInformation, "Coaching Form")
        ProgressBar1.Visible = False
        btnDelete.Enabled = True
        btnExportExcel.Enabled = True
        btnExportAll.Enabled = True
        btnExport.Enabled = True
    End Sub

    Private Sub btnCheckAll_Click(sender As Object, e As EventArgs) Handles btnCheckAll.Click
        If (checkall = 0) Then
            Dim i As Integer = 0
            For i = 0 To DataGridView1.RowCount - 1
                DataGridView1.Rows(i).Cells(0).Value = True
            Next
            checkall = 1
            btnCheckAll.Text = "CHECK All"
        Else
            Dim i As Integer = 0
            For i = 0 To DataGridView1.RowCount - 1
                DataGridView1.Rows(i).Cells(0).Value = False
            Next
            checkall = 0
            btnCheckAll.Text = "UNCHECK"
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        frmAdd.Show()
    End Sub

    Private Sub bttnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim i As Integer = 0
        Dim y As Integer = 0


        Do While y < DataGridView1.RowCount
            If (DataGridView1.Rows(y).Cells(0).Value = True) Then

                i = i + 1
            End If
            y = y + 1

        Loop

        Dim x As Integer = DataGridView1.RowCount - 1

        If (i > 0) Then
            Dim ask = MsgBox("Are you sure you want to delete the selected record/s?", MsgBoxStyle.Information + vbYesNo, "Coaching Form")
            If (ask = vbYes) Then
                Do While x >= 0

                    If (DataGridView1.Rows(x).Cells(0).Value = True) Then
                        DataGridView1.Columns(2).DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss"
                        RemoveRecord(DataGridView1.Rows(x).Cells(3).Value, DataGridView1.Rows(x).Cells(2).Value, DataGridView1.Rows(x).Cells(17).Value)
                        DataGridView1.Rows.RemoveAt(x)
                    End If
                    x = x - 1
                Loop
            End If
        Else
            MsgBox("Please select records to delete.", vbInformation, "Coaching Form")
        End If

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Control.CheckForIllegalCrossThreadCalls = False
        checkall = 0
        getYears()

        If (cboYear.Items.Contains(Today.Year)) Then
            cboYear.SelectedItem = Today.Year
        Else
            If (cboYear.Items.Count > 0) Then
                cboYear.SelectedIndex = 0
            End If
        End If

        If (cboMonth.Items.Contains(Today.ToString("MMM").ToUpper)) Then
            cboMonth.SelectedItem = Today.ToString("MMM").ToUpper

        Else
            If (cboMonth.Items.Count > 0) Then
                cboMonth.SelectedIndex = 0
            End If
        End If
        If (cboProject.Items.Count > 0) Then
            cboProject.SelectedIndex = 0
        End If
        If (cboccategory.Items.Count > 0) Then
            cboccategory.SelectedIndex = 0
        End If
        If (cboRootCause.Items.Count > 0) Then
            cboRootCause.SelectedIndex = 0
        End If
        DisplayRecords()
        DataGridView1.Columns(2).DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss"
    End Sub

    Private Sub UC_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        DisplayRecords()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
