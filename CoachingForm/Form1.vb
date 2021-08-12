Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ConnectTOSQLServer()



        'Add per department

        If (AccessAccount = "") Then
            strSQL = "select Department, sum(case when RootCauseCategory='People' then 1 else 0 end) as People,sum(case when RootCauseCategory='Process' then 1 else 0 end) as Process,sum(case when RootCauseCategory='Technology' then 1 else 0 end) as Technology, sum(case when CoachingCategory='Behavioral Assessment' then 1 else 0 end) as [Behavioral Assessment],sum(case when CoachingCategory='Productivity Review' then 1 else 0 end) as [Productivity Review],sum(case when CoachingCategory='Performance Update' then 1 else 0 end) as [Performance Update],sum(case when CoachingCategory='Quality Assurance Evaluation Scores Discussion' then 1 else 0 end) as [Quality Assurance Evaluation Scores Discussion] " &
            " from tblCoachingMaster2 " &
              "                                   where 1=1 and status='ACTIVE'  " &
               "                                 group by Department " &
            ""
        Else

            strSQL = " 	select Department, sum(case when RootCauseCategory='People' then 1 else 0 end) as People,sum(case when RootCauseCategory='Process' then 1 else 0 end) as Process,sum(case when RootCauseCategory='Technology' then 1 else 0 end) as Technology, sum(case when CoachingCategory='Behavioral Assessment' then 1 else 0 end) as [Behavioral Assessment],sum(case when CoachingCategory='Productivity Review' then 1 else 0 end) as [Productivity Review],sum(case when CoachingCategory='Performance Update' then 1 else 0 end) as [Performance Update],sum(case when CoachingCategory='Quality Assurance Evaluation Scores Discussion' then 1 else 0 end) as [Quality Assurance Evaluation Scores Discussion]		 " &
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
                        " 	where 1=1 " &
                        " 	                                          group by Department		 "



        End If

        Console.WriteLine("3:  " & strSQL)


        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()
        Dim totalPep = 0
        Dim totalPro = 0
        Dim totalTech = 0

        Do While reader.HasRows

            Do While reader.Read()
                Chart1.Series.Add(reader.GetString(0))
                Chart1.Series(reader.GetString(0)).Points.AddXY("People", reader.GetInt32(1))
                Chart1.Series(reader.GetString(0)).Points.AddXY("Process", reader.GetInt32(2))
                Chart1.Series(reader.GetString(0)).Points.AddXY("Technology", reader.GetInt32(3))
                Chart1.Series(reader.GetString(0)).Points.AddXY("Behavioral Assessment", reader.GetInt32(4))
                Chart1.Series(reader.GetString(0)).Points.AddXY("Productivity Review", reader.GetInt32(5))
                Chart1.Series(reader.GetString(0)).Points.AddXY("Performance Update", reader.GetInt32(6))
                Chart1.Series(reader.GetString(0)).Points.AddXY("Quality Assurance Evaluation Scores Discussion", reader.GetInt32(7))
                totalPep = totalPep + reader.GetInt32(1)
                totalPro = totalPro + reader.GetInt32(2)
                totalTech = totalTech + reader.GetInt32(3)
                Chart1.Series(reader.GetString(0)).ChartType = DataVisualization.Charting.SeriesChartType.StackedColumn
                If (reader.GetInt32(1) < 50 And reader.GetInt32(2) < 50 And reader.GetInt32(3) < 50) Then
                    Chart1.Series(reader.GetString(0)).IsValueShownAsLabel = False
                Else
                    Chart1.Series(reader.GetString(0)).IsValueShownAsLabel = True

                End If
                'Chart1.Series(reader.GetString(0)).IsValueShownAsLabel = True
                Chart1.Series(reader.GetString(0)).SmartLabelStyle.IsMarkerOverlappingAllowed = False
                Chart1.Series(reader.GetString(0)).SmartLabelStyle.IsOverlappedHidden = True
                Chart1.Series(reader.GetString(0)).SmartLabelStyle.MovingDirection = LabelAlignmentStyles.Center

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

        Call DisConnectSQLServer()

    End Sub
End Class