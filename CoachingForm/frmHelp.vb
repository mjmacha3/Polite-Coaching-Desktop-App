Public Class frmHelp

    Private Sub frmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate(viewHelp)
    End Sub
End Class