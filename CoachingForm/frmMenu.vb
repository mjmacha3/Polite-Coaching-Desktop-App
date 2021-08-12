Public Class frmMenu
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        UC_Home3.BringToFront()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
        If (AccessType = "Limited") Then
            btnAdmin.Visible = False
            btnQADView.Visible = False
            btnProdReport.Visible = False
            btnAccount.Visible = False

        End If
    End Sub

    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        UC_Graph2.BringToFront()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        UC_View3.BringToFront()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        UC_Admin2.BringToFront()
    End Sub

    Private Sub btnQADView_Click(sender As Object, e As EventArgs) Handles btnQADView.Click
        UC_QADView2.BringToFront()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        UC_Summary3.BringToFront()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Application.ExitThread()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        UC_Accounts.BringToFront()
        'UC_Accounts.Show()


    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click

    End Sub

    Private Sub btnProdReport_Click(sender As Object, e As EventArgs) Handles btnProdReport.Click

    End Sub
End Class