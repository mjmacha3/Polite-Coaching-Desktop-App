Public Class frmLogin



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim ask = MsgBox("Are you sure you want exit?", MsgBoxStyle.Information + vbYesNo, "Coaching Form")
        If (ask = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtUname.Text <> "" And txtPass.Text <> "") Then
            AccessType = ""
            Call Login(txtUname.Text.Replace("-", ""), txtPass.Text)
            If loginname <> "" Then
                If txtPass.Text = "admin12345" Then
                    MsgBox("Your account is in default mode. Please set your own password.", MsgBoxStyle.Information, Application.ProductName)
                    frmPassword.Show()
                Else
                    If (AccessType = "") Then
                        MsgBox("Invalid access!", MsgBoxStyle.Critical, "Coaching Form")
                    Else
                        Console.WriteLine(AccessType)
                        If (AccessType = "Full" Or AccessType = "Admin") Then
                            AccessAccount = ""
                        End If
                        Console.WriteLine(AccessAccount)
                        Me.Hide()
                        frmMenu.Show()

                    End If
                End If
            Else
                MsgBox("Invalid username or password.", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Both fields must be filled up.", MsgBoxStyle.Information)
        End If
    End Sub


    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False

        txtUname.Select()

    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return)) Then
            'AccessType = ""
            'Call Login(txtUname.Text.Replace("'", ""), txtPass.Text.Replace("'", ""))
            'If (AccessType = "") Then
            '    MsgBox("Invalid access!", MsgBoxStyle.Critical, "Coaching Form")
            'Else
            '    Console.WriteLine(AccessType)
            '    If (AccessType = "Full" Or AccessType = "Admin") Then
            '        AccessAccount = ""
            '    End If
            '    Console.WriteLine(AccessAccount)
            '    Me.Hide()
            '    frmMenu.Show()
            'End If

            Me.btnLogin.PerformClick()
        End If
    End Sub

    Private Sub txtUname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUname.KeyPress
        If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return)) Then
            txtPass.Select()

        End If
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub
End Class