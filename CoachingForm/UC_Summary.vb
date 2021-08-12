Imports System.Data.SqlClient

Public Class UC_Summary


    Public Sub getYears()

        Dim cond As String = ""

        If (AccessAccount = "") Then
            cond = ""
        Else
            cond = " where CoachedBy='" & AccessAccount & "' "
        End If

        cboYear.Items.Clear()
        cboMonth.Items.Clear()
        cboProject.Items.Clear()

        cboYear.Items.Add("ALL")
        cboMonth.Items.Add("ALL")
        cboProject.Items.Add("ALL")

        Call ConnectTOSQLServer()

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
                        " 	where CoachedBy='" & AccessAccount & "'	and status='Active' " &
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

        ' strSQL = "select distinct upper(left(datename(month,CoachingDate),3)) as [Month] from tblCoachingMaster2 " & cond & "  order by  upper(left(datename(month,CoachingDate),3))"
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
                        " 	where CoachedBy='" & AccessAccount & "' 	and status='Active' 	 " &
                        " 	)a	 order by  upper(left(datename(month,CoachingDate),3)) "

        End If

        Console.WriteLine(strSQL)

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


        Call DisConnectSQLServer()
    End Sub

    Public Sub DisplayRecords()

        Dim cond As String = ""

        If (AccessAccount = "") Then
            cond = ""
        Else
            cond = " and CoachedBy='" & AccessAccount & "' "
        End If

        Dim ConYear As String
        Dim ConMonth As String
        Dim Proj As String
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





        ConnectTOSQLServer()

        If (AccessAccount = "") Then
            strSQL = "(select Department, sum(case when RootCauseCategory='People' then 1 else 0 end) as People,sum(case when RootCauseCategory='Process' then 1 else 0 end) as Process,sum(case when RootCauseCategory='Technology' then 1 else 0 end) as Technology, sum(case when CoachingCategory='Behavioral Assessment' then 1 else 0 end) as [Behavioral Assessment],sum(case when CoachingCategory='Productivity Review' then 1 else 0 end) as [Productivity Review],sum(case when CoachingCategory='Performance Update' then 1 else 0 end) as [Performance Update],sum(case when CoachingCategory='Quality Assurance Evaluation Scores Discussion' then 1 else 0 end) as [Quality Assurance Evaluation Scores Discussion] " &
            " from tblCoachingMaster2 " &
              "                                   where 1=1 and status='ACTIVE'  " & cond & "  " & NameFil & "  " & ConYear & "   " & ConMonth & "   " & Proj & " " &
               "                                 group by Department " &
            " union all " &
                         "   select 'OVERALL TOTAL',sum(case when RootCauseCategory='People' then 1 else 0 end) as People,sum(case when RootCauseCategory='Process' then 1 else 0 end) as Process,sum(case when RootCauseCategory='Technology' then 1 else 0 end) as Technology, sum(case when CoachingCategory='Behavioral Assessment' then 1 else 0 end) as CoachingCategory,sum(case when CoachingCategory='Productivity Review' then 1 else 0 end) as [Productivity Review],sum(case when CoachingCategory='Performance Update' then 1 else 0 end) as [Performance Update],sum(case when CoachingCategory='Quality Assurance Evaluation Scores Discussion' then 1 else 0 end) as [Quality Assurance Evaluation Scores Discussion]   " &
             " from tblCoachingMaster2 " &
               "             where 1=1 and status='ACTIVE'  " & cond & "  " & NameFil & "  " & ConYear & "   " & ConMonth & "   " & Proj & " " &
                "             " &
                 "            ) "
        Else

            strSQL = " 	(select Department, sum(case when RootCauseCategory='People' then 1 else 0 end) as People,sum(case when RootCauseCategory='Process' then 1 else 0 end) as Process,sum(case when RootCauseCategory='Technology' then 1 else 0 end) as Technology, sum(case when CoachingCategory='Behavioral Assessment' then 1 else 0 end) as [Behavioral Assessment],sum(case when CoachingCategory='Productivity Review' then 1 else 0 end) as [Productivity Review],sum(case when CoachingCategory='Performance Update' then 1 else 0 end) as [Performance Update],sum(case when CoachingCategory='Quality Assurance Evaluation Scores Discussion' then 1 else 0 end) as [Quality Assurance Evaluation Scores Discussion]		 " &
                        " 	       from (		 " &
                        " 	select a.*		 " &
                        " from tblCoachingMaster2 a	 " &
                        " inner join tblVKPOEmployee_HRNames b on a.Name=b.firstname+' '+lastname	 " &
                        " where status='active'	 " &
                        " and EmployeeStatus='active'	 " &
                        " and name in(	 " &
                        " select firstname+' '+lastname as name	 " &
                        " from tblVKPOEmployee_HRNames	 " &
                        " where EmployeeStatus='active'	 " &
                        " and Department in (	 " &
                        " select campaign	 " &
                        " from (	 " &
                        " select distinct campaign	 " &
                        " from tblVKPOEmployee_HRNames	 " &
                        " where EmployeeStatus='active'	 " &
                        " and department in(	 " &
                        " select distinct department	 " &
                        " from tblVKPOEmployee_HRNames	 " &
                        " where EmployeeStatus='active'	 " &
                        " and Supervisor='" & NameLastForm & "')	 " &
                        " union 	 " &
                        " select distinct department	 " &
                        " from tblVKPOEmployee_HRNames	 " &
                        " where EmployeeStatus='active'	 " &
                        " and Supervisor='" & NameLastForm & "'	 " &
                        " )a ))	 " &
                        " and b.CRank<	 " &
                        " (select crank 	 " &
                        " from tblVKPOEmployee_HRNames 	 " &
                        " where EmployeeStatus='active' 	 " &
                        " and firstname+' '+LASTNAME='" & AccessAccount & "')	 " &
                        " and (replace(replace(replace(b.role,' - OIT',''),' - OIC',''),'OPS','Team Leader') not in	 " &
                        " (select distinct replace(replace(replace(b.role,' - OIT',''),' - OIC',''),'OPS','Team Leader') 	 " &
                        " from tblVKPOEmployee_HRNames 	 " &
                        " where EmployeeStatus='active' 	 " &
                        " and firstname+''+LASTNAME='" & AccessAccount & "')	 " &
                        " )	 " &
                        " union 	 " &
                        " select *	 " &
                        " from tblCoachingMaster2	 " &
                        " where CoachedBy='" & AccessAccount & "'		and status='Active'  " &
                        " )a	 " &
                        " 	where 1=1 " & NameFil & "  " & ConYear & "   " & ConMonth & "   " & Proj & " " &
                        " 	                                          group by Department		 " &
                        " 	union all		 " &
                        " 	                      select 'OVERALL TOTAL',sum(case when RootCauseCategory='People' then 1 else 0 end) as People,sum(case when RootCauseCategory='Process' then 1 else 0 end) as Process,sum(case when RootCauseCategory='Technology' then 1 else 0 end) as Technology, sum(case when CoachingCategory='Behavioral Assessment' then 1 else 0 end) as CoachingCategory,sum(case when CoachingCategory='Productivity Review' then 1 else 0 end) as [Productivity Review],sum(case when CoachingCategory='Performance Update' then 1 else 0 end) as [Performance Update],sum(case when CoachingCategory='Quality Assurance Evaluation Scores Discussion' then 1 else 0 end) as [Quality Assurance Evaluation Scores Discussion]  		 " &
                        " 	        from (		 " &
                        " 	select a.*		 " &
                        " from tblCoachingMaster2 a	 " &
                        " inner join tblVKPOEmployee_HRNames b on a.Name=b.firstname+' '+lastname	 " &
                        " where status='active'	 " &
                        " and EmployeeStatus='active'	 " &
                        " and name in(	 " &
                        " select firstname+' '+lastname as name	 " &
                        " from tblVKPOEmployee_HRNames	 " &
                        " where EmployeeStatus='active'	 " &
                        " and Department in (	 " &
                        " select campaign	 " &
                        " from (	 " &
                        " select distinct campaign	 " &
                        " from tblVKPOEmployee_HRNames	 " &
                        " where EmployeeStatus='active'	 " &
                        " and department in(	 " &
                        " select distinct department	 " &
                        " from tblVKPOEmployee_HRNames	 " &
                        " where EmployeeStatus='active'	 " &
                        " and Supervisor='" & NameLastForm & "')	 " &
                        " union 	 " &
                        " select distinct department	 " &
                        " from tblVKPOEmployee_HRNames	 " &
                        " where EmployeeStatus='active'	 " &
                        " and Supervisor='" & NameLastForm & "'	 " &
                        " )a ))	 " &
                        " and b.CRank<	 " &
                        " (select crank 	 " &
                        " from tblVKPOEmployee_HRNames 	 " &
                        " where EmployeeStatus='active' 	 " &
                        " and firstname+' '+LASTNAME='" & AccessAccount & "')	 " &
                        " and (replace(replace(replace(b.role,' - OIT',''),' - OIC',''),'OPS','Team Leader') not in	 " &
                        " (select distinct replace(replace(replace(b.role,' - OIT',''),' - OIC',''),'OPS','Team Leader') 	 " &
                        " from tblVKPOEmployee_HRNames 	 " &
                        " where EmployeeStatus='active' 	 " &
                        " and firstname+''+LASTNAME='" & AccessAccount & "')	 " &
                        " )	 " &
                        " union 	 " &
                        " select *	 " &
                        " from tblCoachingMaster2	 " &
                        " where CoachedBy='" & AccessAccount & "'		and status='Active'  " &
                        " )a	 " &
                        " 	                      where 1=1  " & NameFil & "  " & ConYear & "   " & ConMonth & "   " & Proj & " " &
                        " 	                       		 " &
                        " 	                       ) 		 "


        End If

        Console.WriteLine(strSQL)

        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim ds As New DataSet()

        dataadapter.Fill(ds, "tblCoachingMaster2")

        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "tblCoachingMaster2"

        DisConnectSQLServer()
    End Sub

    Private Sub cboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYear.SelectedIndexChanged
        DisplayRecords()
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged
        DisplayRecords()
    End Sub

    Private Sub cboProject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProject.SelectedIndexChanged
        DisplayRecords()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        DisplayRecords()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (e.RowIndex >= 0 And e.RowIndex < DataGridView1.RowCount And e.ColumnIndex >= 1) Then


            If (DataGridView1.Rows(e.RowIndex).Cells(0).Value() = "OVERALL TOTAL") Then

                If (cboYear.SelectedIndex = 0) Then

                    viewYear = ""
                Else

                    viewYear = " and year(CoachingDate) = '" & cboYear.SelectedItem & "' "
                End If

                If (cboMonth.SelectedIndex = 0) Then

                    viewMonth = ""
                Else

                    viewMonth = " and upper(left(datename(month,CoachingDate),3)) = '" & cboMonth.SelectedItem & "' "
                End If

                If (cboProject.SelectedIndex = 0) Then

                    viewDepartment = ""
                Else

                    viewDepartment = " and Department = '" & cboProject.SelectedItem & "' "
                End If

            Else

                If (cboYear.SelectedIndex = 0) Then

                    viewYear = ""
                Else

                    viewYear = " and year(CoachingDate) = '" & cboYear.SelectedItem & "' "
                End If

                If (cboMonth.SelectedIndex = 0) Then

                    viewMonth = ""
                Else

                    viewMonth = " and upper(left(datename(month,CoachingDate),3)) = '" & cboMonth.SelectedItem & "' "
                End If




                'viewYear = " and year(CoachingDate) = '" & cboYear.SelectedItem & "' "
                'viewMonth = " and upper(left(datename(month,CoachingDate),3)) = '" & cboMonth.SelectedItem & "' "
                viewDepartment = " and Department = '" & DataGridView1.Rows(e.RowIndex).Cells(0).Value() & "' "
            End If

            If (e.ColumnIndex = 1) Then
                viewColclicked = " and RootCauseCategory='People' "
            ElseIf (e.ColumnIndex = 2) Then
                viewColclicked = " and RootCauseCategory='Process' "
            ElseIf (e.ColumnIndex = 3) Then
                viewColclicked = " and RootCauseCategory='Technology' "
            ElseIf (e.ColumnIndex = 4) Then
                viewColclicked = " and CoachingCategory='Behavioral Assessment' "
            ElseIf (e.ColumnIndex = 5) Then
                viewColclicked = " and CoachingCategory='Productivity Review' "
            ElseIf (e.ColumnIndex = 6) Then
                viewColclicked = " and CoachingCategory='Performance Update' "
            ElseIf (e.ColumnIndex = 7) Then
                viewColclicked = " and  CoachingCategory='Quality Assurance Evaluation Scores Discussion' "
            End If

            If (txtName.Text <> "") Then
                viewName = " and name like '%" & txtName.Text & "%'  "
            Else
                viewName = " "
            End If

            frmSDetails.Close()
            frmSDetails.Show(Me)

        End If
    End Sub



    Private Sub DataGridView1_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DataGridView1.RowPostPaint
        Using b As SolidBrush = New SolidBrush(DataGridView1.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString(e.RowIndex + 1.ToString(System.Globalization.CultureInfo.CurrentUICulture),
                                   DataGridView1.DefaultCellStyle.Font,
                                   b,
                                   e.RowBounds.Location.X + 20,
                                   e.RowBounds.Location.Y + 4)
        End Using
    End Sub

    Private Sub Refresh()
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

        DisplayRecords()
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Refresh()
    End Sub
End Class
