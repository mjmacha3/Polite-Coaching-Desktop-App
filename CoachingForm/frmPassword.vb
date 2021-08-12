Public Class frmPassword
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (lblLength.ForeColor = Color.Red Or lblMatch.ForeColor = Color.Red Or lblNumber.ForeColor = Color.Red) Then
            MsgBox("All requirements must be met first.", MsgBoxStyle.OkOnly, Application.ProductName)
        Else
            If (AccessType = "") Then
                MsgBox("Invalid access!", MsgBoxStyle.Critical, "Coaching Form")
            Else
                If (AccessType = "Full" Or AccessType = "Admin") Then
                    AccessAccount = ""
                End If
                PasswordSet(txtPass1.Text)
                Me.Close()
                frmMenu.Show()
            End If
        End If
    End Sub

    Private Sub TxtPass1_TextChanged(sender As Object, e As EventArgs) Handles txtPass1.TextChanged, txtPass2.TextChanged
        If (txtPass1.Text.Length < 8) Then
            lblLength.ForeColor = Color.Red
        Else
            lblLength.ForeColor = Color.White
        End If

        Dim s As String = txtPass1.Text
        Const numbers = "0123456789"

        If s.IndexOfAny(numbers.ToArray) > -1 Then
            lblNumber.ForeColor = Color.White
        Else
            lblNumber.ForeColor = Color.Red
        End If

        If txtPass2.Text <> "" And txtPass1.Text = txtPass2.Text Then
            lblMatch.ForeColor = Color.White
        Else
            lblMatch.ForeColor = Color.Red
        End If

    End Sub

    Private Sub frmPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class