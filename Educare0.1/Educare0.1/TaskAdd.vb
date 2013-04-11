Imports Educare0._1.GenerateTasks
Public Class TaskAdd

    Dim valuesCount As Integer
    Dim allAnswers As New Collection
    Public taskTypesTA As New EducareDataSetTableAdapters.taskTypesTableAdapter
    Public goalsTA As New EducareDataSetTableAdapters.goalsTableAdapter

    Private Sub TaskAdd_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        GenerateTasks.ClearMultipleQuestion(allAnswers, addTask, Me) 'TODO - make it with method
        addTask.Visible = False
        TextBox1.Visible = False
        TextBox1.Text = "Number of values"
        points.Visible = False
        points.Text = "Points"
        selectGoal.Visible = False
        selectGoal.SelectedIndex = -1
        taskTypes.SelectedIndex = -1
    End Sub
    Private Sub TaskAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each taskType In taskTypesTA.GetData()
            taskTypes.Items.Add(taskType.typeName)
        Next

        For Each goal In goalsTA.GetData()
            selectGoal.Items.Add(goal.goalName)
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "Number of values" Then
            valuesCount = 4
        Else
            valuesCount = TextBox1.Text
        End If
        GenerateTasks.GenerateMultipleQuestion(Me, valuesCount, Label2.Left, Label1.Left, Label1.Top, allAnswers, addTask)
    End Sub

    Private Sub taskTypes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles taskTypes.SelectedIndexChanged
        If taskTypes.SelectedItem = "Multiple choice" Then
            selectGoal.Visible = True
            TextBox1.Visible = True
            points.Visible = True
        End If
    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        TextBox1.Text = ""
    End Sub

    Private Sub points_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles points.GotFocus
        points.Text = ""
    End Sub

    Private Sub addTask_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addTask.Click
        GenerateTasks.AddMultipleQuestion(allAnswers(1).text, "no hint", allAnswers)
        Me.Hide()
        ManageTasks.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GenerateTasks.ClearMultipleQuestion(allAnswers, addTask, Me) 'TODO - make it with method
        addTask.Visible = False
        TextBox1.Visible = False
        TextBox1.Text = "Number of values"
        points.Visible = False
        points.Text = "Points"
        selectGoal.Visible = False
        selectGoal.SelectedIndex = -1
        taskTypes.SelectedIndex = -1
    End Sub
End Class