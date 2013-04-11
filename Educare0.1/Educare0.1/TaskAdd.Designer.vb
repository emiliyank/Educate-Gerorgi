<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.taskTypes = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.selectGoal = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.points = New System.Windows.Forms.TextBox()
        Me.addTask = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'taskTypes
        '
        Me.taskTypes.FormattingEnabled = True
        Me.taskTypes.Location = New System.Drawing.Point(27, 32)
        Me.taskTypes.Name = "taskTypes"
        Me.taskTypes.Size = New System.Drawing.Size(121, 21)
        Me.taskTypes.TabIndex = 0
        Me.taskTypes.Text = "Type"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(27, 123)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Number of values"
        Me.TextBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(27, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Generate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'selectGoal
        '
        Me.selectGoal.FormattingEnabled = True
        Me.selectGoal.Location = New System.Drawing.Point(27, 76)
        Me.selectGoal.Name = "selectGoal"
        Me.selectGoal.Size = New System.Drawing.Size(121, 21)
        Me.selectGoal.TabIndex = 3
        Me.selectGoal.Text = "Select Goal"
        Me.selectGoal.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(374, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Points"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(238, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Goals"
        '
        'points
        '
        Me.points.Location = New System.Drawing.Point(27, 160)
        Me.points.Name = "points"
        Me.points.Size = New System.Drawing.Size(100, 20)
        Me.points.TabIndex = 6
        Me.points.Text = "Points"
        Me.points.Visible = False
        '
        'addTask
        '
        Me.addTask.Location = New System.Drawing.Point(212, 287)
        Me.addTask.Name = "addTask"
        Me.addTask.Size = New System.Drawing.Size(75, 23)
        Me.addTask.TabIndex = 7
        Me.addTask.Text = "Add Task"
        Me.addTask.UseVisualStyleBackColor = True
        Me.addTask.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(27, 270)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TaskAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 346)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.addTask)
        Me.Controls.Add(Me.points)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.selectGoal)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.taskTypes)
        Me.Name = "TaskAdd"
        Me.Text = "TaskAdd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents taskTypes As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents selectGoal As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents points As System.Windows.Forms.TextBox
    Friend WithEvents addTask As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
