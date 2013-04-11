Public Class ManageTasks
    Dim tasksTA As New EducareDataSetTableAdapters.multipleChoiceTableAdapter
    Private Sub ManageTasks_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ListBox1.Items.Clear()
        For Each task In tasksTA.GetData()
            ListBox1.Items.Add(task.question)
        Next
    End Sub

    Private Sub ManageTasks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        TaskAdd.Show()
    End Sub
End Class