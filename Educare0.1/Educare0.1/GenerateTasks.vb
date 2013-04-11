Module GenerateTasks

    Public Sub GenerateMultipleQuestion(ByVal place As Form, ByVal answersCount As Integer, ByVal row1Left As Integer, ByVal row2Left As Integer, ByVal rowsTop As Integer, ByRef answers As Collection, ByVal btn As Object)
        'Add question
        Dim qLabel As New Label
        qLabel.Left = row1Left
        qLabel.Top = rowsTop + 10 + qLabel.Height
        qLabel.Text = "Question: "
        place.Controls.Add(qLabel)

        Dim q As New TextBox
        q.Left = row2Left
        q.Top = rowsTop + 10 + q.Height
        q.Name = "question"
        q.Width += 30
        place.Controls.Add(q)
        answers.Add(q)

        'Add answers with their types
        For i = 1 To answersCount Step 1
            Dim c As New TextBox
            c.Left = row1Left
            c.Top = rowsTop + 40 + i * (c.Height + 5)
            place.Controls.Add(c)
            answers.Add(c)
        Next
        'Add Button to INSERT into DB
        btn.visible = True 'TODO - position the button Top & Left
    End Sub

    Public Sub AddMultipleQuestion(ByVal question As String, ByVal hint As String, ByRef answers As Collection)
        Dim multChoiceTA As New EducareDataSetTableAdapters.multipleChoiceTableAdapter
        multChoiceTA.Insert(question, answers(2).text, answers(2).text, answers(3).text, answers(4).text, answers(5).text, hint) 'TODO - work for diffenrent than 4
    End Sub

    Public Sub ClearMultipleQuestion(ByRef answers As Collection, ByRef btn As Object, ByVal place As Form)
        For Each a In answers
            place.Controls.Remove(a)
        Next
        answers.Clear()
        btn.visible = False
    End Sub
End Module
