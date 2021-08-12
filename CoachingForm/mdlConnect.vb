Option Explicit On

Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Data.OleDb
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Net.Mail
Imports System.Net
Imports System.Configuration
Imports System.Data.SqlTypes
Imports System.Text

Module mdlConnect


    Public ExcelConnection As New System.Data.OleDb.OleDbConnection
    Private ExcelPath As String

    Public Connection As SqlConnection
    Public Connection2 As SqlConnection
    Private Server As String
    Private Database As String
    Private UID As String
    Private Password As String


    Public Username As String
    Public SelName As String
    Public AccessType As String
    Public AccessAccount As String
    Public AccessName As String
    Public selDateInci As DateTime
    Public UpName As String
    Public UpCoachNum As String
    Public NameLastForm As String
    Public UpCDate As DateTime
    Public loginid As Int32
    Public loginname, cond As String
    Dim lock As Boolean

    Public cmd As SqlCommand
    Public strSQL As String

    Public cntr As Integer

    Private mExcelProcesses() As Process

    Public reader As SqlDataReader
    Public dataadapter As New SqlDataAdapter


    Public viewYear As String
    Public viewMonth As String
    Public viewName As String
    Public viewName2 As String
    Public viewDepartment As String
    Public viewColclicked As String
    Public viewHelp As String
    Public Task As String

    Function GetHash(theInput As String) As String
        Using hasher As SHA256 = SHA256.Create()    ' create hash object
            ' Convert to byte array and get hash
            Dim dbytes As Byte() =
                 hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))
            ' sb to create string from bytes
            Dim sBuilder As New StringBuilder()
            ' convert byte data to hex stringx
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n
            Return sBuilder.ToString()
        End Using
    End Function
    '41E5653FC7AEB894026D6BB7B2DB7F65902B454945FA8FD65A6327047B5277FB default hashpassword = admin12345

    Public Sub PasswordSet(pass As String)
        ConnectTOSQLServer()
        strSQL = "update tblCoachingLogin set Password = '" & GetHash(pass) & "' where PCIT   = '" & loginid & "'"
        cmd = New SqlCommand(strSQL, Connection)
        Console.WriteLine(strSQL)
        cmd.ExecuteNonQuery()
        MsgBox("Successfully updated password.", MsgBoxStyle.Information, Application.ProductName)
        DisConnectSQLServer()
    End Sub

    Public Sub resetpass(id As String)
        ConnectTOSQLServer()
        strSQL = "update tblCoachingLogin set pword = 'admin12345', Password = '41E5653FC7AEB894026D6BB7B2DB7F65902B454945FA8FD65A6327047B5277FB' where [EMPLOYEE ID NUMBER]   = '" & id & "'"
        cmd = New SqlCommand(strSQL, Connection)
        Console.WriteLine(strSQL)
        cmd.ExecuteNonQuery()
        'MsgBox("Successfully updated password.", MsgBoxStyle.Information, Application.ProductName)
        DisConnectSQLServer()
    End Sub


    Public Function CheckEntry(id As String) As Integer
        Call ConnectTOSQLServer()
        Dim exist = 0
        Dim cmd As SqlCommand
        Dim strSQL As String

        strSQL = "Select  Username from tblCoachingLogin where  [EMPLOYEE ID NUMBER] = '" & id.ToUpper & "' "
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()

        Do While reader.HasRows

            Do While reader.Read()
                exist = 1
            Loop
            reader.NextResult()
        Loop

        Return exist
        reader.Close()
        Call DisConnectSQLServer()
    End Function


    Public Sub ConnectTOSQLServer()
        Connection = New SqlConnection("Data Source=52.187.147.244;Initial Catalog=WORKFORCE; User Id=wfadmin;password=Wfadmin@vkpo1;")
        Try
            Connection.Open()

        Catch ex As Exception
            Console.WriteLine(ex)
            MsgBox(ex)

            End
        End Try
    End Sub

    Public Sub DisConnectSQLServer()
        Try

            Connection.Close()
        Catch ex As Exception
            MsgBox("Can not close connection ! Kindly check your internet connection. ")
        End Try
    End Sub


    Public Sub ConnectTOSQLServer2()
        Connection2 = New SqlConnection("Data Source=52.187.147.244;Initial Catalog=WORKFORCE; User Id=wfadmin;password=Wfadmin@vkpo1;")
        Try
            Connection2.Open()

        Catch ex As Exception
            MsgBox("Can not open connection ! Kindly check your internet connection. ")
            'MsgBox(ex.Message)
            End
        End Try
    End Sub

    Public Sub DisConnectSQLServer2()
        Try

            Connection2.Close()
        Catch ex As Exception
            MsgBox("Can not close connection ! ")
        End Try
    End Sub


    Public Sub Login(id As String, pass As String)
        ConnectTOSQLServer()
        Dim RequesterID = id
        Dim un As New String(Environment.UserName)

        strSQL = "select * from workforce.dbo.tblApplocker where AppName = 'Coaching' "
        Console.WriteLine(strSQL)
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader

        If reader.Read = True Then
            lock = reader.GetBoolean(2)
        End If
        reader.Close()

        If lock = False Then
            cond = "  And Username ='" & un.ToUpper & "' "
        Else
            cond = ""
        End If

        strSQL = "select distinct Access, FIRSTNAME+' '+LASTNAME as Name, LASTNAME+', '+FIRSTNAME as Name, PCIT, Username
                 from vw_CoachingLogin where [EMPLOYEE ID NUMBER]='" & id.ToUpper & "'  " & cond & " and Password = '" & GetHash(pass) & "' order by 1 "

        Console.WriteLine(strSQL)
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()

        Do While reader.Read()
            AccessType = reader.GetString(0)
            AccessAccount = reader.GetString(1)
            AccessName = reader.GetString(1)
            NameLastForm = reader.GetString(2)
            loginid = reader.GetInt32(3)
            loginname = reader.GetString(4)
        Loop
        reader.Close()
        DisConnectSQLServer()
    End Sub

    Public Sub AddRecord(id As String, name As String, dep As String, desg As String, ccat As String, rcause As String, coachingdate As Date, sup As String, fudate As Date, iDisc As String, rtcause As String, effect As String, empAP As String, supAP As String, efdateEAP As Date, efdateSAP As Date, cby As String, notedby As String, coachee As String, scanid As String, site As String, startdate As Date, subcategory As String)
        Call ConnectTOSQLServer()


        strSQL = "Insert into tblCoachingMaster2 (EID,Name,Department,Designation, CoachingCategory, RootCauseCategory, CoachingDate, Supervisor, FUCoachingDate, ItemDiscussion, RootCause, Effect, EmployeeActionPlan, SupervisorActionPlan, EffectiveDateEAP, EffectiveDateSAP, CoachedBy, NotedBy, Coachee,Updatedate,LastUpdateBy,[Status],ScanId, Site, CoachingDate2, startdate, subcategory)  select '" & id.ToUpper & "','" & name & "','" & dep & "','" & desg & "','" & ccat & "','" & rcause & "','" & coachingdate.ToString("MM/dd/yyyy") & "','" & sup & "','" & fudate.ToString("MM/dd/yyyy") & "','" & iDisc & "','" & rtcause & "','" & effect & "','" & empAP & "','" & supAP & "','" & efdateEAP.ToString("MM/dd/yyyy") & "','" & efdateSAP.ToString("MM/dd/yyyy") & "','" & cby & "','" & notedby & "','" & coachee & "',getdate(),'" & AccessName & "','ACTIVE','" & scanid & "', '" & site & "', getDate(), '" & startdate & "', '" & subcategory & "'"
        Console.WriteLine(strSQL)
        cmd = New SqlCommand(strSQL, Connection)
        cmd.ExecuteNonQuery()


        Call DisConnectSQLServer()
    End Sub


    Public Sub UpdateRecord(id As String, ccat As String, rcause As String, chdate As DateTime, sup As String, fudate As Date, iDisc As String, rtcause As String, effect As String, empAP As String, supAP As String, efdateEAP As Date, efdateSAP As Date, cby As String, notedby As String, coachee As String, name As String, dep As String, desg As String, scanid As String, coachingid As Integer, site As String, subcategory As String)
        Call ConnectTOSQLServer()


        strSQL = "update a " &
                " set Department='" & dep & "',Designation='" & desg & "', CoachingCategory='" & ccat & "', RootCauseCategory='" & rcause & "',  Supervisor='" & sup & "', FUCoachingDate='" & fudate.ToString("MM/dd/yyyy") & "', ItemDiscussion='" & iDisc & "', Effect='" & effect & "', RootCause='" & rtcause & "', EmployeeActionPlan='" & empAP & "', SupervisorActionPlan='" & supAP & "', EffectiveDateEAP='" & efdateEAP.ToString("MM/dd/yyyy") & "', 
                  EffectiveDateSAP='" & efdateSAP.ToString("MM/dd/yyyy") & "', NotedBy='" & notedby & "',
                   Updatedate=getdate(),LastUpdateBy='" & AccessName & "', scanid='" & scanid & "', 
                  site  ='" & site & "', subcategory = '" & subcategory & "' " &
                " from tblCoachingMaster2 a" &
                " where name='" & name & "' and coachingid=" & coachingid & "  "


        Console.WriteLine(strSQL)
        cmd = New SqlCommand(strSQL, Connection)
        cmd.ExecuteNonQuery()


        Call DisConnectSQLServer()
    End Sub



    Public Sub RemoveRecord(name As String, chdate As DateTime, cby As String)
        Call ConnectTOSQLServer()


        strSQL = "update a " &
                " set [status]='INACTIVE',LastUpdateBy='" & AccessName & "',Updatedate=getdate() " &
                " from tblCoachingMaster2 a" &
                " where name='" & name & "' and convert(datetime,convert(varchar(10),CoachingDate,101)+' '+convert(varchar(8),CoachingDate,108))=convert(datetime,'" & chdate.ToString("MM/dd/yyyy HH:mm:ss") & "') and CoachedBy='" & cby & "'   "


        Console.WriteLine(strSQL)
        cmd = New SqlCommand(strSQL, Connection)
        cmd.ExecuteNonQuery()


        Call DisConnectSQLServer()
    End Sub


    Public Sub ExportPDF(name As String, chdate As DateTime, cby As String, foldername As String)

        Call ConnectTOSQLServer()
        strSQL = "select *,replace(convert(varchar(10),CoachingDate,101),'/','-')+'_'+replace(convert(varchar(8),CoachingDate,108),':','.') as CDate2,replace(convert(varchar(10),CoachingDate,101),'/','-') as CDate,convert(varchar(10),FUCoachingDate,101) as FUDate,convert(varchar(10),EffectiveDateEAP,101) as EEAP,convert(varchar(10),EffectiveDateEAP,101) as ESAP from tblCoachingMaster2 a" &
                " where name='" & name & "' and convert(datetime,convert(varchar(10),CoachingDate,101)+' '+convert(varchar(8),CoachingDate,108))=convert(datetime,'" & chdate.ToString("MM/dd/yyyy HH:mm:ss") & "') and CoachedBy='" & cby & "' and status='ACTIVE'  "

        Console.WriteLine(strSQL)

        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim ds As New DataTable()
        Dim rowCnt As Integer = 0
        dataadapter.Fill(ds)
        If (ds.Rows.Count <= 0) Then
            MessageBox.Show("No records found for " & name & ".", "Coaching Form", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            While rowCnt < ds.Rows.Count


                Dim APP As New Excel.Application
                Dim worksheet As Excel.Worksheet
                Dim workbook As Excel.Workbook

                'Copy excel from format file

                Dim fileout As String
                Dim ichk As Integer = 0
                Dim srcDir As String = ""
                srcDir = My.Application.Info.DirectoryPath & "\Template\VKPO_Coaching Form_Final 2018_Template.xlsx"


                Dim dtString As New String(DateTime.Now.ToString("MM/dd/yyyy"))
                fileout = foldername & "\VKPO.CL." & ds.Rows(rowCnt).Item("Department") & "_" & ds.Rows(rowCnt).Item("Name") & "." & ds.Rows(rowCnt).Item("CDate2") & ".xlsx"
                If (File.Exists(fileout)) Then
                    Try
                        File.Delete(fileout)
                        ichk = 1
                    Catch ex As Exception
                        ichk = 0
                        Console.WriteLine("File could not be deleted : {0}", ex.Message)
                    End Try
                Else
                    ichk = 1
                End If


                If (ichk = 1) Then

                    If (ds.Rows.Count > 0) Then
                        Try

                            FileCopy(srcDir, fileout)

                        Catch dirNotFound As DirectoryNotFoundException
                            Console.WriteLine(dirNotFound.Message)
                        End Try


                        'Write to excel

                        workbook = APP.Workbooks.Open(fileout)
                        worksheet = workbook.Worksheets("Coaching Form_Revised")



                        'Dim iRowCnt As Integer = 2
                        With worksheet

                            .Cells(5, 2).value = ds.Rows(rowCnt).Item("Name")
                            .Cells(6, 2).value = ds.Rows(rowCnt).Item("EID")
                            .Cells(7, 2).value = ds.Rows(rowCnt).Item("Department")
                            .Cells(5, 4).value = ds.Rows(rowCnt).Item("Supervisor")
                            .Cells(6, 4).value = ds.Rows(rowCnt).Item("CDate").ToString.Replace("-", "/")
                            .Cells(7, 4).value = ds.Rows(rowCnt).Item("FUDate")
                            .Cells(5, 6).value = ds.Rows(rowCnt).Item("Designation")
                            .Cells(6, 6).value = ds.Rows(rowCnt).Item("CoachingCategory")
                            .Cells(7, 6).value = ds.Rows(rowCnt).Item("RootCauseCategory")
                            .Cells(10, 1).value = ds.Rows(rowCnt).Item("ItemDiscussion")
                            .Cells(10, 3).value = ds.Rows(rowCnt).Item("RootCause")
                            .Cells(10, 5).value = ds.Rows(rowCnt).Item("Effect")
                            .Cells(26, 1).value = ds.Rows(rowCnt).Item("EmployeeActionPlan")
                            .Cells(26, 4).value = ds.Rows(rowCnt).Item("SupervisorActionPlan")
                            .Cells(37, 2).value = ds.Rows(rowCnt).Item("EEAP")
                            .Cells(37, 5).value = ds.Rows(rowCnt).Item("ESAP")
                            .Cells(40, 1).value = ds.Rows(rowCnt).Item("CoachedBy")
                            .Cells(40, 3).value = ds.Rows(rowCnt).Item("NotedBy")
                            .Cells(40, 5).value = ds.Rows(rowCnt).Item("Coachee")

                        End With




                        workbook.Save()



                        Dim pdffile = foldername & "\VKPO.CL." & ds.Rows(rowCnt).Item("Department") & "_" & ds.Rows(rowCnt).Item("Name") & "." & ds.Rows(rowCnt).Item("CDate2") & ".pdf"
                        If (File.Exists(pdffile)) Then
                            Try
                                File.Delete(pdffile)


                            Catch ex As Exception

                                Console.WriteLine("File could not be deleted : {0}", ex.Message)
                            End Try

                        End If
                        Dim saveAsFormat As Excel.XlFixedFormatType = Excel.XlFixedFormatType.xlTypePDF


                        workbook.ExportAsFixedFormat(saveAsFormat, pdffile, Excel.XlFixedFormatQuality.xlQualityStandard, True, True, 1, , False, )
                        ExcelProcessInit()
                        ExcelProcesKill()
                        workbook.Close()
                        APP.Quit()
                        If (File.Exists(fileout)) Then
                            Try
                                File.Delete(fileout)
                                ichk = 1
                            Catch ex As Exception
                                ichk = 0
                                Console.WriteLine("File could not be deleted : {0}", ex.Message)
                            End Try

                        End If
                        'workbook.ActiveSheet.Close(Excel.XlSaveAction.xlDoNotSaveChanges)

                    End If
                End If
                rowCnt = rowCnt + 1
            End While
        End If
        Call DisConnectSQLServer()
    End Sub
    Private Sub ExcelProcessInit()
        Try
            'Get all currently running process Ids for Excel applications
            mExcelProcesses = Process.GetProcessesByName("Excel")
        Catch ex As Exception
        End Try
    End Sub
    Public Sub ExcelProcesKill()
        Dim oProcesses() As Process
        Dim bFound As Boolean

        Try
            'Get all currently running process Ids for Excel applications
            oProcesses = Process.GetProcessesByName("Excel")

            If oProcesses.Length > 0 Then
                For i As Integer = 0 To oProcesses.Length - 1
                    bFound = False

                    For j As Integer = 0 To mExcelProcesses.Length - 1
                        If oProcesses(i).Id = mExcelProcesses(j).Id Then
                            bFound = True
                            Exit For
                        End If
                    Next

                    If Not bFound Then
                        oProcesses(i).Kill()
                    End If
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub


    Public Sub ExportExcel(name As String, chdate As DateTime, cby As String, foldername As String)
        Console.WriteLine("counter:  " & cntr)
        Call ConnectTOSQLServer()


        strSQL = "select EID,Name,Department,Designation,Supervisor,convert(varchar(10),CoachingDate,101) as CoachingDate,CoachingCategory,RootCauseCategory,FUCoachingDate,ItemDiscussion,RootCause,Effect,EmployeeActionPlan,EffectiveDateEAP,SupervisorActionPlan,EffectiveDateSAP,CoachedBy,NotedBy,Coachee,ScanID, Site from tblCoachingMaster2 a" &
                " where name='" & name & "' and convert(datetime,convert(varchar(10),CoachingDate,101)+' '+convert(varchar(8),CoachingDate,108))=convert(datetime,'" & chdate.ToString("MM/dd/yyyy HH:mm:ss") & "') and CoachedBy='" & cby & "' and status='ACTIVE'  "

        Console.WriteLine(strSQL)

        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim ds As New DataTable()
        Dim rowCnt As Integer = 0
        dataadapter.Fill(ds)
        If (ds.Rows.Count <= 0) Then

        Else
            While rowCnt < ds.Rows.Count


                Dim APP As New Excel.Application
                Dim worksheet As Excel.Worksheet
                Dim workbook As Excel.Workbook

                'Copy excel from format file

                Dim fileout As String
                Dim ichk As Integer = 0
                Dim srcDir As String = ""
                srcDir = My.Application.Info.DirectoryPath & "\Template\VKPO_Coaching Form_FullReport_Template.xlsx"


                Dim dtString As New String(DateTime.Now.ToString("MM/dd/yyyy"))
                fileout = foldername & "\WFD.CL.CoachingReport_" & dtString.Replace("/", "-") & ".xlsx"

                If (cntr = 0) Then
                    If (File.Exists(fileout)) Then
                        Try
                            File.Delete(fileout)
                            ichk = 1
                        Catch ex As Exception
                            ichk = 0
                            Console.WriteLine("File could not be deleted : {0}", ex.Message)
                        End Try
                    Else
                        ichk = 1
                    End If
                    Try

                        FileCopy(srcDir, fileout)

                    Catch dirNotFound As DirectoryNotFoundException
                        Console.WriteLine(dirNotFound.Message)
                    End Try

                End If



                If (ds.Rows.Count > 0) Then

                    'Write to excel

                    workbook = APP.Workbooks.Open(fileout)
                    worksheet = workbook.Worksheets("Sheet1")



                    'Dim iRowCnt As Integer = 2
                    With worksheet
                        Console.WriteLine(ds.Rows(rowCnt).Item("EID") & " " & cntr + 2)

                        .Cells(cntr + 2, 1).value = ds.Rows(rowCnt).Item("EID")
                        .Cells(cntr + 2, 2).value = ds.Rows(rowCnt).Item("Name")
                        .Cells(cntr + 2, 3).value = ds.Rows(rowCnt).Item("Department")
                        .Cells(cntr + 2, 4).value = ds.Rows(rowCnt).Item("Designation")
                        .Cells(cntr + 2, 5).value = ds.Rows(rowCnt).Item("Supervisor")
                        .Cells(cntr + 2, 6).value = ds.Rows(rowCnt).Item("CoachingDate")
                        .Cells(cntr + 2, 7).value = ds.Rows(rowCnt).Item("CoachingCategory")
                        .Cells(cntr + 2, 8).value = ds.Rows(rowCnt).Item("RootCauseCategory")
                        .Cells(cntr + 2, 9).value = ds.Rows(rowCnt).Item("FUCoachingDate")
                        .Cells(cntr + 2, 10).value = ds.Rows(rowCnt).Item("ItemDiscussion")
                        .Cells(cntr + 2, 11).value = ds.Rows(rowCnt).Item("RootCause")
                        .Cells(cntr + 2, 12).value = ds.Rows(rowCnt).Item("Effect")
                        .Cells(cntr + 2, 13).value = ds.Rows(rowCnt).Item("EmployeeActionPlan")
                        .Cells(cntr + 2, 14).value = ds.Rows(rowCnt).Item("EffectiveDateEAP")
                        .Cells(cntr + 2, 15).value = ds.Rows(rowCnt).Item("SupervisorActionPlan")
                        .Cells(cntr + 2, 16).value = ds.Rows(rowCnt).Item("EffectiveDateSAP")
                        .Cells(cntr + 2, 17).value = ds.Rows(rowCnt).Item("CoachedBy")
                        .Cells(cntr + 2, 18).value = ds.Rows(rowCnt).Item("NotedBy")
                        .Cells(cntr + 2, 19).value = ds.Rows(rowCnt).Item("Coachee")
                        .Cells(cntr + 2, 20).value = ds.Rows(rowCnt).Item("ScanID")
                        .Cells(cntr + 2, 21).value = ds.Rows(rowCnt).Item("Site")

                    End With




                    workbook.Save()
                    workbook.Close()
                    APP.Quit()
                End If

                rowCnt = rowCnt + 1
            End While
        End If
        Call DisConnectSQLServer()
    End Sub


    Public Sub ExportExcelAll(foldername As String, ConYear As String, ConMonth As String, Proj As String, cCat As String, RootCause As String, NameFil As String)
        'Console.WriteLine("counter:  " & cntr)
        Call ConnectTOSQLServer()


        If (AccessAccount = "") Then

            strSQL = " select distinct EID,Name,Department,Designation,Supervisor,convert(varchar(10),CoachingDate,101) as CoachingDate,
                       CoachingCategory,RootCauseCategory, FUCoachingDate,ItemDiscussion,left(RootCause,200) as RootCause,Effect,EmployeeActionPlan,
                       EffectiveDateEAP,SupervisorActionPlan,EffectiveDateSAP,CoachedBy,NotedBy,Coachee,ScanID,Site 
                      from  tblCoachingMaster2 c
                       where 1=1
                      and c.[status]='ACTIVE' " &
                     "  " & ConYear & "   " & ConMonth & "   " & Proj & "   " & cCat & "   " & RootCause & "   " & NameFil & "  order by coachingdate desc "
        Else

            strSQL = " 	select distinct EID,Name,Department,Designation,Supervisor,convert(varchar(10),CoachingDate,101) as CoachingDate,CoachingCategory,RootCauseCategory,FUCoachingDate,ItemDiscussion,left(RootCause,200) as RootCause,Effect,EmployeeActionPlan,EffectiveDateEAP,SupervisorActionPlan,EffectiveDateSAP,CoachedBy,NotedBy,Coachee,ScanID, Site	 " &
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
                        " 	)a	 " &
                        " 	where 1=1 	 " &
                        "  " & ConYear & "   " & ConMonth & "   " & Proj & "   " & cCat & "   " & RootCause & "   " & NameFil & "  order by coachingdate desc  "



        End If
        Console.WriteLine(strSQL)

        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim ds As New DataTable()
        Dim rowCnt As Integer = 0
        dataadapter.Fill(ds)
        If (ds.Rows.Count <= 0) Then

        Else



            Dim APP As New Excel.Application
            Dim worksheet As Excel.Worksheet
            Dim workbook As Excel.Workbook

            'Copy excel from format file

            Dim fileout As String
            Dim ichk As Integer = 0
            Dim srcDir As String = ""
            srcDir = My.Application.Info.DirectoryPath & "\Template\VKPO_Coaching Form_FullReport_Template.xlsx"


            Dim dtString As New String(DateTime.Now.ToString("MM/dd/yyyy"))
            fileout = foldername & "\WFD.CL.Full_CoachingReport_" & dtString.Replace("/", "-") & ".xlsx"

            If (cntr = 0) Then
                If (File.Exists(fileout)) Then
                    Try
                        File.Delete(fileout)
                        ichk = 1
                    Catch ex As Exception
                        ichk = 0
                        Console.WriteLine("File could not be deleted : {0}", ex.Message)
                    End Try
                Else
                    ichk = 1
                End If
                Try

                    FileCopy(srcDir, fileout)

                Catch dirNotFound As DirectoryNotFoundException
                    Console.WriteLine(dirNotFound.Message)
                End Try

            End If



            If (ds.Rows.Count > 0) Then

                rowCnt = 0

                'Write to excel

                workbook = APP.Workbooks.Open(fileout)
                worksheet = workbook.Worksheets("Sheet1")

                While rowCnt < ds.Rows.Count

                    'Dim iRowCnt As Integer = 2
                    With worksheet
                        Try
                            Console.WriteLine(ds.Rows(rowCnt).Item("EID") & " " & rowCnt + 2)

                            .Cells(rowCnt + 2, 1).value = ds.Rows(rowCnt).Item("EID")
                            .Cells(rowCnt + 2, 2).value = ds.Rows(rowCnt).Item("Name")
                            .Cells(rowCnt + 2, 3).value = ds.Rows(rowCnt).Item("Department")
                            .Cells(rowCnt + 2, 4).value = ds.Rows(rowCnt).Item("Designation")
                            .Cells(rowCnt + 2, 5).value = ds.Rows(rowCnt).Item("Supervisor")
                            .Cells(rowCnt + 2, 6).value = ds.Rows(rowCnt).Item("CoachingDate")
                            .Cells(rowCnt + 2, 7).value = ds.Rows(rowCnt).Item("CoachingCategory")
                            .Cells(rowCnt + 2, 8).value = ds.Rows(rowCnt).Item("RootCauseCategory")
                            .Cells(rowCnt + 2, 9).value = ds.Rows(rowCnt).Item("FUCoachingDate")
                            .Cells(rowCnt + 2, 10).value = ds.Rows(rowCnt).Item("ItemDiscussion")
                            .Cells(rowCnt + 2, 11).value = ds.Rows(rowCnt).Item("RootCause")
                            .Cells(rowCnt + 2, 12).value = ds.Rows(rowCnt).Item("Effect")
                            .Cells(rowCnt + 2, 13).value = ds.Rows(rowCnt).Item("EmployeeActionPlan")
                            .Cells(rowCnt + 2, 14).value = ds.Rows(rowCnt).Item("EffectiveDateEAP")
                            .Cells(rowCnt + 2, 15).value = ds.Rows(rowCnt).Item("SupervisorActionPlan")
                            .Cells(rowCnt + 2, 16).value = ds.Rows(rowCnt).Item("EffectiveDateSAP")
                            .Cells(rowCnt + 2, 17).value = ds.Rows(rowCnt).Item("CoachedBy")
                            .Cells(rowCnt + 2, 18).value = ds.Rows(rowCnt).Item("NotedBy")
                            .Cells(rowCnt + 2, 19).value = ds.Rows(rowCnt).Item("Coachee")
                            .Cells(rowCnt + 2, 20).value = ds.Rows(rowCnt).Item("ScanID")
                            .Cells(rowCnt + 2, 21).value = ds.Rows(rowCnt).Item("Site")
                        Catch ex As Exception
                            'Request threw an error - Fatal failure.
                            Console.WriteLine(ex)


                        End Try
                    End With

                    Console.WriteLine(ds.Rows(rowCnt).Item("EID") & " " & rowCnt)
                    rowCnt = rowCnt + 1

                End While


                workbook.Save()
                workbook.Close()
                APP.Quit()
            End If

        End If
        Call DisConnectSQLServer()
    End Sub


    Public Sub ExportExcelQAD(year As String, month As String, rootcauseV As String, project As String, scanidV As String, foldername As String)
        Dim ConYear As String
        Dim ConMonth As String
        Dim Proj As String
        Dim RootCause As String
        Dim ScanId As String

        If (scanidV <> "ALL") Then
            ScanId = " and isnull(scanid,'') like '%" & scanidV.Replace("'", "''") & "%'  "
        Else
            ScanId = " "
        End If

        If (year <> "ALL") Then
            ConYear = " and year(coachingdate) = '" & year & "' "
        Else
            ConYear = "  "
        End If

        If (month <> "ALL") Then
            ConMonth = " and upper(left(datename(month,CoachingDate),3)) = '" & month & "' "
        Else
            ConMonth = "  "
        End If

        If (project <> "ALL") Then
            Proj = " and department = '" & project & "' "
        Else
            Proj = "  "
        End If



        If (rootcauseV <> "ALL") Then
            RootCause = " and RootCauseCategory = '" & rootcauseV & "' "
        Else
            RootCause = "  "
        End If


        Call ConnectTOSQLServer()
        strSQL = "Select isnull(ScanID,'') as ScanID,EID,Name,Department,Designation,CoachingCategory,RootCauseCategory,CoachingDate,Supervisor,FUCoachingDate,ItemDiscussion,Effect,RootCause,EmployeeActionPlan,SupervisorActionPlan,EffectiveDateEAP,EffectiveDateSAP,CoachedBy,NotedBy,Coachee,Site " &
                " from tblCoachingMaster2 where CoachingCategory='Quality Assurance Evaluation Scores Discussion' and status='ACTIVE'  " &
                    " " & ScanId & " " & ConYear & "   " & ConMonth & "  " & Proj & " " & RootCause & " order by coachingDate  "

        Console.WriteLine(strSQL)

        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim ds As New DataTable()
        Dim rowCnt As Integer = 0
        Dim checkCon As Integer = 0
        dataadapter.Fill(ds)
        If (ds.Rows.Count <= 0) Then

        Else

            Dim APP As New Excel.Application
            Dim worksheet As Excel.Worksheet
            Dim workbook As Excel.Workbook

            'Copy excel from format file

            Dim fileout As String
            Dim ichk As Integer = 0
            Dim srcDir As String = ""
            srcDir = My.Application.Info.DirectoryPath & "\Template\VKPO_Coaching Form_FullReport_QAD_Template.xlsx"


            Dim dtString As New String(DateTime.Now.ToString("MM/dd/yyyy"))
            fileout = foldername & "\WFD.CL.CoachingReport_QAD_" & dtString.Replace("/", "-") & ".xlsx"




            If (cntr = 0) Then
                If (File.Exists(fileout)) Then
                    Dim ask = MsgBox("Overwrite existing file?", MsgBoxStyle.Information + vbYesNo, "Coaching Form")
                    If (ask = vbYes) Then
                        Try
                            File.Delete(fileout)
                            ichk = 1
                        Catch ex As Exception
                            ichk = 0
                            Console.WriteLine("File could not be deleted : {0}", ex.Message)
                        End Try
                    Else
                        checkCon = 1
                    End If
                Else
                    ichk = 1
                End If
                Try

                    FileCopy(srcDir, fileout)

                Catch dirNotFound As DirectoryNotFoundException
                    Console.WriteLine(dirNotFound.Message)
                End Try

            End If


            workbook = APP.Workbooks.Open(fileout)
            worksheet = workbook.Worksheets("Sheet1")
            While rowCnt < ds.Rows.Count





                If (ds.Rows.Count > 0 And checkCon = 0) Then

                    'Write to excel


                    'Dim iRowCnt As Integer = 2
                    With worksheet
                        Console.WriteLine(ds.Rows(rowCnt).Item("EID") & " " & cntr + 2)

                        .Cells(rowCnt + 2, 1).value = ds.Rows(rowCnt).Item("ScanID")
                        .Cells(rowCnt + 2, 2).value = ds.Rows(rowCnt).Item("EID")
                        .Cells(rowCnt + 2, 3).value = ds.Rows(rowCnt).Item("Name")
                        .Cells(rowCnt + 2, 4).value = ds.Rows(rowCnt).Item("Department")
                        .Cells(rowCnt + 2, 5).value = ds.Rows(rowCnt).Item("Designation")
                        .Cells(rowCnt + 2, 6).value = ds.Rows(rowCnt).Item("Supervisor")
                        .Cells(rowCnt + 2, 7).value = ds.Rows(rowCnt).Item("CoachingDate")
                        .Cells(rowCnt + 2, 8).value = ds.Rows(rowCnt).Item("CoachingCategory")
                        .Cells(rowCnt + 2, 9).value = ds.Rows(rowCnt).Item("RootCauseCategory")
                        .Cells(rowCnt + 2, 10).value = ds.Rows(rowCnt).Item("FUCoachingDate")
                        .Cells(rowCnt + 2, 11).value = ds.Rows(rowCnt).Item("ItemDiscussion")
                        .Cells(rowCnt + 2, 12).value = ds.Rows(rowCnt).Item("RootCause")
                        .Cells(rowCnt + 2, 13).value = ds.Rows(rowCnt).Item("Effect")
                        .Cells(rowCnt + 2, 14).value = ds.Rows(rowCnt).Item("EmployeeActionPlan")
                        .Cells(rowCnt + 2, 15).value = ds.Rows(rowCnt).Item("EffectiveDateEAP")
                        .Cells(rowCnt + 2, 16).value = ds.Rows(rowCnt).Item("SupervisorActionPlan")
                        .Cells(rowCnt + 2, 17).value = ds.Rows(rowCnt).Item("EffectiveDateSAP")
                        .Cells(rowCnt + 2, 18).value = ds.Rows(rowCnt).Item("CoachedBy")
                        .Cells(rowCnt + 2, 19).value = ds.Rows(rowCnt).Item("NotedBy")
                        .Cells(rowCnt + 2, 20).value = ds.Rows(rowCnt).Item("Coachee")
                        .Cells(rowCnt + 2, 21).value = ds.Rows(rowCnt).Item("Site")
                        If (frmQADView.ProgressBar1.Value < 10) Then
                            frmQADView.ProgressBar1.Value = frmQADView.ProgressBar1.Value + 1
                        Else
                            frmQADView.ProgressBar1.Value = 2
                        End If
                    End With



                End If

                rowCnt = rowCnt + 1
            End While


            workbook.Save()
            workbook.Close()
            APP.Quit()
        End If
        Call DisConnectSQLServer()
    End Sub

    'Public Sub GetYears()

    'End Sub

End Module
