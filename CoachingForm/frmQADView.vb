Imports System.Data.SqlClient


Public Class frmQADView

    Private folderBrowserDialog1 As New FolderBrowserDialog

    Private foldername As String

    Private Sub frmQADView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        Call getYears()

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
       
        If (cboRootCause.Items.Count > 0) Then
            cboRootCause.SelectedIndex = 0
        End If
        Call DisplayRecords()
    End Sub

    Public Sub getYears()

        Dim cond As String = ""

       

        cboYear.Items.Clear()
        cboMonth.Items.Clear()
        cboProject.Items.Clear()
        cboRootCause.Items.Clear()

        cboYear.Items.Add("ALL")
        cboMonth.Items.Add("ALL")
        cboProject.Items.Add("ALL")
        cboRootCause.Items.Add("ALL")

        Call ConnectTOSQLServer()

        Dim strSQL As String = ""


        strSQL = "select distinct year(CoachingDate) as [Year] from tblCoachingMaster2 where  CoachingCategory='Quality Assurance Evaluation Scores Discussion' and status='ACTIVE'    order by  year(CoachingDate)"

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

        strSQL = "select distinct upper(left(datename(month,CoachingDate),3)) as [Month] from tblCoachingMaster2  where CoachingCategory='Quality Assurance Evaluation Scores Discussion'   and status='ACTIVE' order by  upper(left(datename(month,CoachingDate),3))"

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

        strSQL = "select distinct Department from tblCoachingMaster2 where  CoachingCategory='Quality Assurance Evaluation Scores Discussion'   and status='ACTIVE'   order by Department "

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


        strSQL = "select distinct RootCauseCategory  from tblCoachingMaster2  where  CoachingCategory='Quality Assurance Evaluation Scores Discussion'  and status='ACTIVE'    order by RootCauseCategory "

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

        Call DisConnectSQLServer()
    End Sub

    Public Sub DisplayRecords()

        Dim cond As String = ""

        If (AccessAccount = "") Then
            cond = ""
        Else
            cond = " or CoachedBy='" & AccessAccount & "' "
        End If

        Dim ConYear As String
        Dim ConMonth As String
        Dim Proj As String
        Dim RootCause As String
        Dim ScanId As String

        If (txtScanId.Text <> "") Then
            ScanId = " and scanid like '%" & txtScanId.Text.Replace("'", "''") & "%'  "
        Else
            ScanId = " "
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

       

        If (cboRootCause.SelectedIndex > 0) Then
            RootCause = " and RootCauseCategory = '" & cboRootCause.SelectedItem & "' "
        Else
            RootCause = "  "
        End If



        Call ConnectTOSQLServer()

        strSQL = "Select ScanId,Name,Department,Designation,CoachingCategory,RootCauseCategory,CoachingDate,Supervisor,FUCoachingDate,ItemDiscussion,Effect,RootCause,EmployeeActionPlan,SupervisorActionPlan,EffectiveDateEAP,EffectiveDateSAP,CoachedBy,NotedBy,Coachee " &
                " from tblCoachingMaster2 where CoachingCategory='Quality Assurance Evaluation Scores Discussion'  and status='ACTIVE' " &
                    " " & ScanId & " " & ConYear & "   " & ConMonth & "  " & Proj & " " & RootCause & " order by coachingDate  "

        Console.WriteLine(strSQL)

        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim ds As New DataSet()

        dataadapter.Fill(ds, "tblCoachingMaster2")

        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "tblCoachingMaster2"

        Call DisConnectSQLServer()
    End Sub

    Private Sub cboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYear.SelectedIndexChanged
        Call DisplayRecords()
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged
        Call DisplayRecords()
    End Sub

    Private Sub cboProject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProject.SelectedIndexChanged
        Call DisplayRecords()
    End Sub

    Private Sub cboRootCause_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRootCause.SelectedIndexChanged
        Call DisplayRecords()
    End Sub

    Private Sub txtScanId_TextChanged(sender As Object, e As EventArgs) Handles txtScanId.TextChanged
        Call DisplayRecords()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Call DisplayRecords()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click


        Dim x As Integer = DataGridView1.RowCount - 1

        If (DataGridView1.RowCount > 0) Then

            Dim result As DialogResult
            result = folderBrowserDialog1.ShowDialog()

            If (result = DialogResult.OK) Then
                btnExport.Enabled = False
                ProgressBar1.Visible = True
                ProgressBar1.Maximum = 10
                BackgroundWorker1.WorkerReportsProgress = True
                BackgroundWorker1.RunWorkerAsync()
            End If
        Else
            MsgBox("No records to export.", vbInformation, "Coaching Form")

        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Dim x As Integer = 0
            cntr = 0
            BackgroundWorker1.ReportProgress(1)
            System.Threading.Thread.Sleep(100)
            BackgroundWorker1.ReportProgress(2)

            foldername = folderBrowserDialog1.SelectedPath



            Call ExportExcelQAD(cboYear.SelectedItem, cboMonth.SelectedItem, cboRootCause.SelectedItem, cboProject.SelectedItem, txtScanId.Text, foldername)
            

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
        btnExport.Enabled = True
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