Imports System.Data.SqlClient
Public Class frmSDetails

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


        strSQL = " select Name,count(*) as Frequency " &
                  "  from tblCoachingMaster2 " &
                    " where 1=1 and  status='ACTIVE'  " & viewYear & "  " & viewMonth & "  " & viewDepartment & "  " & viewColclicked & "  " & viewName & "  " & cond & "  " &
                    " group by name "


        Console.WriteLine(strSQL)


        Dim dataadapter2 = New SqlDataAdapter(strSQL, Connection)
        Dim ds As New DataSet()

        dataadapter2.Fill(ds, "tblCoachingMaster2")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "tblCoachingMaster2"
        Call DisConnectSQLServer2()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (e.RowIndex >= 0 And e.RowIndex < DataGridView1.RowCount And e.ColumnIndex >= 1) Then
            viewName2 = " and name = '" & DataGridView1.Rows(e.RowIndex).Cells(0).Value() & "'  "
            frmIndivDetails.Close()
            frmIndivDetails.Show(Me)
        End If
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