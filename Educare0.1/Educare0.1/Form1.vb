Public Class Form1
    Public loggedUser As Integer 'ID of logged user [1-4]
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        loggedUser = 3
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        loggedUser = 2
        Me.Hide()
        Home.Show()
    End Sub
End Class
