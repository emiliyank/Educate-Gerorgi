Public Class Home

    Private Sub Home_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If Form1.loggedUser < 3 Then
            ManageTasksToolStripMenuItem.Visible = True
            ManageGoalsToolStripMenuItem.Visible = True
            Label1.Text = Form1.loggedUser & " - " & "admin"
        End If
        Label1.Text = Form1.loggedUser & " - " & "teacher"
    End Sub

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        'Form1.loggedUser = 4 'TODO- delete session data
        ManageTasksToolStripMenuItem.Visible = False
        ManageGoalsToolStripMenuItem.Visible = False
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub ViewTasksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewTasksToolStripMenuItem.Click
        Me.Hide()
        ManageTasks.Show()
    End Sub
End Class