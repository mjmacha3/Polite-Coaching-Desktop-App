Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class UC_Graph


    Private Sub frmGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


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


        Call ConnectTOSQLServer()

            If (AccessAccount = "") Then
                strSQL = "select distinct Department, sum(case when RootCauseCategory='People' then 1 else 0 end) as People,sum(case when RootCauseCategory='Process' then 1 else 0 end) as Process,sum(case when RootCauseCategory='Technology' then 1 else 0 end) as Technology, sum(case when CoachingCategory='Behavioral Assessment' then 1 else 0 end) as [Behavioral Assessment],sum(case when CoachingCategory='Productivity Review' then 1 else 0 end) as [Productivity Review],sum(case when CoachingCategory='Performance Update' then 1 else 0 end) as [Performance Update],sum(case when CoachingCategory='Quality Assurance Evaluation Scores Discussion' then 1 else 0 end) as [Quality Assurance Evaluation Scores Discussion] " &
                " from tblCoachingMaster2 " &
                  "                                   where 1=1 and status='ACTIVE'  " & NameFil & "  " & ConYear & "   " & ConMonth & "   " & Proj & " " &
                   "                                 group by Department " &
                ""
            Else

                strSQL = " 	select distinct Department, sum(case when RootCauseCategory='People' then 1 else 0 end) as People,sum(case when RootCauseCategory='Process' then 1 else 0 end) as Process,sum(case when RootCauseCategory='Technology' then 1 else 0 end) as Technology, sum(case when CoachingCategory='Behavioral Assessment' then 1 else 0 end) as [Behavioral Assessment],sum(case when CoachingCategory='Productivity Review' then 1 else 0 end) as [Productivity Review],sum(case when CoachingCategory='Performance Update' then 1 else 0 end) as [Performance Update],sum(case when CoachingCategory='Quality Assurance Evaluation Scores Discussion' then 1 else 0 end) as [Quality Assurance Evaluation Scores Discussion]		 " &
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
                            " 	                                          group by Department		 "



            End If




            Console.WriteLine("1:  " & strSQL)
            cmd = New SqlCommand(strSQL, Connection)
            reader = cmd.ExecuteReader()
            Dim totalPep = 0
            Dim totalPro = 0
            Dim totalTech = 0
            Dim totalBA = 0
            Dim totalPR = 0
            Dim totalPU = 0
            Dim totalQAESD = 0

            Do While reader.HasRows

                Do While reader.Read()
                    Console.WriteLine(reader.GetString(0))
                    Chart1.Series.Add(reader.GetString(0))
                    Chart2.Series.Add(reader.GetString(0))
                    Chart1.Series(reader.GetString(0)).Points.AddXY("People", reader.GetInt32(1))
                    Chart1.Series(reader.GetString(0)).Points.AddXY("Process", reader.GetInt32(2))
                    Chart1.Series(reader.GetString(0)).Points.AddXY("Technology", reader.GetInt32(3))
                    Chart2.Series(reader.GetString(0)).Points.AddXY("Behavioral Assessment", reader.GetInt32(4))
                    Chart2.Series(reader.GetString(0)).Points.AddXY("Productivity Review", reader.GetInt32(5))
                    Chart2.Series(reader.GetString(0)).Points.AddXY("Performance Update", reader.GetInt32(6))
                    Chart2.Series(reader.GetString(0)).Points.AddXY("Quality Assurance Evaluation Scores Discussion", reader.GetInt32(7))
                    totalPep = totalPep + reader.GetInt32(1)
                    totalPro = totalPro + reader.GetInt32(2)
                    totalTech = totalTech + reader.GetInt32(3)
                    totalBA = totalBA + reader.GetInt32(4)
                    totalPR = totalPR + reader.GetInt32(5)
                    totalPU = totalPU + reader.GetInt32(6)
                    totalQAESD = totalQAESD + reader.GetInt32(7)
                    Chart1.Series(reader.GetString(0)).ChartType = DataVisualization.Charting.SeriesChartType.StackedColumn
                    Chart1.Series(reader.GetString(0)).ShadowOffset = 10
                    Chart2.Series(reader.GetString(0)).ChartType = DataVisualization.Charting.SeriesChartType.StackedColumn
                    Chart2.Series(reader.GetString(0)).ShadowOffset = 10
                    'If (reader.GetInt32(2) < 50 And reader.GetInt32(3) < 50) Then
                    '    Chart1.Series(reader.GetString(0)).IsValueShownAsLabel = False
                    'Else
                    '    Chart1.Series(reader.GetString(0)).IsValueShownAsLabel = True

                    'End If
                    Chart1.Series(reader.GetString(0)).IsValueShownAsLabel = True
                    Chart1.Series(reader.GetString(0)).SmartLabelStyle.IsMarkerOverlappingAllowed = False
                    Chart1.Series(reader.GetString(0)).SmartLabelStyle.IsOverlappedHidden = True
                    Chart1.Series(reader.GetString(0)).SmartLabelStyle.MovingDirection = LabelAlignmentStyles.Center

                    Chart2.Series(reader.GetString(0)).IsValueShownAsLabel = True
                    Chart2.Series(reader.GetString(0)).SmartLabelStyle.IsMarkerOverlappingAllowed = False
                    Chart2.Series(reader.GetString(0)).SmartLabelStyle.IsOverlappedHidden = True
                    Chart2.Series(reader.GetString(0)).SmartLabelStyle.MovingDirection = LabelAlignmentStyles.Center

                Loop
                reader.NextResult()
            Loop
            reader.Close()

            Chart1.Series.Add("Total")
            Chart1.Series("Total").Points.AddXY("People", totalPep)

            Chart1.Series("Total").Points.AddXY("Process", totalPro)

            Chart1.Series("Total").Points.AddXY("Technology", totalTech)
            Chart1.Series("Total").ChartType = DataVisualization.Charting.SeriesChartType.Spline
            Chart1.Series("Total").IsValueShownAsLabel = True

            Chart2.Series.Add("Total")
            Chart2.Series("Total").Points.AddXY("Behavioral Assessment", totalBA)
            Chart2.Series("Total").Points.AddXY("Productivity Review", totalPR)
            Chart2.Series("Total").Points.AddXY("Performance Update", totalPU)
            Chart2.Series("Total").Points.AddXY("Quality Assurance Evaluation Scores Discussion", totalQAESD)
            Chart2.Series("Total").ChartType = DataVisualization.Charting.SeriesChartType.Spline
            Chart2.Series("Total").IsValueShownAsLabel = True




            'If (AccessAccount = "") Then
            '    strSQL = "select RootCauseCategory,count(*) as Total " &
            '                " from tblCoachingMaster2 " &
            '            " where 1 = 1 and status='ACTIVE' " & cond & "  " & NameFil & "  " & ConYear & "   " & ConMonth & "   " & Proj & " " &
            '          "  group by RootCauseCategory "

            'Else

            '    strSQL = "select RootCauseCategory,count(*) as Total " &
            '               " from ( " &
            '                " 	select a.*	 " &
            '               " 	from tblCoachingMaster2 a	 " &
            '               " 	inner join tblVKPOEmployee_HRNames b on a.Name=b.firstname+' '+lastname	 " &
            '               " 	where status='active'	 " &
            '               " 	and EmployeeStatus='active'	 " &
            '               " 	and name in(	 " &
            '               " 	select firstname+' '+lastname as name	 " &
            '               " 	from tblVKPOEmployee_HRNames	 " &
            '               " 	where EmployeeStatus='active'	 " &
            '               " 	and Department in (	 " &
            '               " 	select campaign	 " &
            '               " 	from (	 " &
            '               " 	select distinct campaign	 " &
            '               " 	from tblVKPOEmployee_HRNames	 " &
            '               " 	where EmployeeStatus='active'	 " &
            '               " 	and department in(	 " &
            '               " 	select distinct department	 " &
            '               " 	from tblVKPOEmployee_HRNames	 " &
            '               " 	where EmployeeStatus='active'	 " &
            '               " 	and Supervisor='" & NameLastForm & "')	 " &
            '               " 	union 	 " &
            '               " 	select distinct department	 " &
            '               " 	from tblVKPOEmployee_HRNames	 " &
            '               " 	where EmployeeStatus='active'	 " &
            '               " 	and Supervisor='" & NameLastForm & "'	 " &
            '               " 	)a ))	 " &
            '               " 	and b.CRank<	 " &
            '               " 	(select crank 	 " &
            '               " 	from tblVKPOEmployee_HRNames 	 " &
            '               " 	where EmployeeStatus='active' 	 " &
            '               " 	and firstname+' '+LASTNAME='" & AccessAccount & "')	 " &
            '               " 	and (replace(replace(replace(b.role,' - OIT',''),' - OIC',''),'OPS','Team Leader') not in	 " &
            '               " 	(select distinct replace(replace(replace(b.role,' - OIT',''),' - OIC',''),'OPS','Team Leader') 	 " &
            '               " 	from tblVKPOEmployee_HRNames 	 " &
            '               " 	where EmployeeStatus='active' 	 " &
            '               " 	and firstname+''+LASTNAME='" & AccessAccount & "')	 " &
            '               " 	)	 " &
            '               " 	union 	 " &
            '               " 	select *	 " &
            '               " 	from tblCoachingMaster2	 " &
            '               " 	where CoachedBy='" & AccessAccount & "'		and status='Active'  " &
            '               " 	)a	 " &
            '           " where 1 = 1   " & NameFil & "  " & ConYear & "   " & ConMonth & "   " & Proj & " " &
            '         "  group by RootCauseCategory "

            'End If

            'Console.WriteLine("2:  " & strSQL)

            'cmd = New SqlCommand(strSQL, Connection)
            'reader = cmd.ExecuteReader()
            'Chart2.Series.Add("Root Cause Categories")

            'Do While reader.HasRows

            '    Do While reader.Read()

            '        Chart2.Series("Root Cause Categories").Points.AddXY(reader.GetString(0), reader.GetInt32(1))


            '    Loop
            '    reader.NextResult()
            'Loop

            'reader.Close()
            'Chart2.Series("Root Cause Categories").IsValueShownAsLabel = True
            'Chart2.Series("Root Cause Categories").IsVisibleInLegend = False

            'until here
            'process chart 2
            Chart1.ChartAreas(0).RecalculateAxesScale()
            'Chart2.ChartAreas(0).RecalculateAxesScale()

            Call DisConnectSQLServer()
        End Sub

        Private Sub cboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYear.SelectedIndexChanged

            Chart1.ChartAreas(0).RecalculateAxesScale()

            Do While (Chart1.Series.Count > 0)
                Chart1.Series.RemoveAt(0)

            Loop

            Chart2.ChartAreas(0).RecalculateAxesScale()

            Do While (Chart2.Series.Count > 0)
                Chart2.Series.RemoveAt(0)

            Loop

            'Chart2.Series.RemoveAt(0)
            Call DisplayRecords()


        End Sub

        Private Sub cboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged

            Chart1.ChartAreas(0).RecalculateAxesScale()

            Do While (Chart1.Series.Count > 0)
                Chart1.Series.RemoveAt(0)

            Loop

            Chart2.ChartAreas(0).RecalculateAxesScale()

            Do While (Chart2.Series.Count > 0)
                Chart2.Series.RemoveAt(0)

            Loop
            Call DisplayRecords()


        End Sub

        Private Sub cboProject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProject.SelectedIndexChanged

            Chart1.ChartAreas(0).RecalculateAxesScale()

            Do While (Chart1.Series.Count > 0)
                Chart1.Series.RemoveAt(0)

            Loop

            Chart2.ChartAreas(0).RecalculateAxesScale()

            Do While (Chart2.Series.Count > 0)
                Chart2.Series.RemoveAt(0)

            Loop
            Call DisplayRecords()


        End Sub

        Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

            Chart1.ChartAreas(0).RecalculateAxesScale()

            Do While (Chart1.Series.Count > 0)
                Chart1.Series.RemoveAt(0)

            Loop

            Chart2.ChartAreas(0).RecalculateAxesScale()

            Do While (Chart2.Series.Count > 0)
                Chart2.Series.RemoveAt(0)

            Loop
            Call DisplayRecords()


        End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call getYears()
        Call DisplayRecords()
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

    End Sub

End Class
