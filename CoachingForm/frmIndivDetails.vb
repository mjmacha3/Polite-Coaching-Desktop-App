Imports System.Data.SqlClient
Public Class frmIndivDetails

    Private Sub frmSDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False

        Call RefreshTable()
    End Sub
    Private Sub RefreshTable()
        Dim cond As String = ""

        If (AccessAccount = "") Then
            cond = ""
        Else
            cond = " and CoachedBy='" & AccessAccount & "' "
        End If
        Call ConnectTOSQLServer2()


        strSQL = " select Name,convert(varchar(10),CoachingDate,101) as CoachingDate,Department,Designation,CoachingCategory,RootCauseCategory,ItemDiscussion,RootCause,Effect,EmployeeActionPlan,SupervisorActionPlan,NotedBy " &
                  "  from tblCoachingMaster2 " &
                    " where 1=1 " & viewYear & "  " & viewMonth & " " & cond & "  " & viewDepartment & "  " & viewColclicked & "  " & viewName2 & "  "



        Console.WriteLine(strSQL)


        Dim dataadapter2 = New SqlDataAdapter(strSQL, Connection)
        Dim ds As New DataSet()

        dataadapter2.Fill(ds, "tblCoachingMaster2")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "tblCoachingMaster2"
        Call DisConnectSQLServer2()
    End Sub


    Private Sub DataGridView1_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DataGridView1.RowPostPaint
        Using b As SolidBrush = New SolidBrush(DataGridView1.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString(e.RowIndex + 1.ToString(System.Globalization.CultureInfo.CurrentUICulture), _
                                   DataGridView1.DefaultCellStyle.Font, _
                                   b, _
                                   e.RowBounds.Location.X + 20, _
                                   e.RowBounds.Location.Y + 4)
        End Using
    End Sub

End Class