<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SubjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageTasksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewTasksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageGoalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewGoalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddGoalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubjectsToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ManageTasksToolStripMenuItem, Me.ManageGoalsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(471, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SubjectsToolStripMenuItem
        '
        Me.SubjectsToolStripMenuItem.Name = "SubjectsToolStripMenuItem"
        Me.SubjectsToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SubjectsToolStripMenuItem.Text = "Subjects"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'ManageTasksToolStripMenuItem
        '
        Me.ManageTasksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewTasksToolStripMenuItem, Me.AddTaskToolStripMenuItem})
        Me.ManageTasksToolStripMenuItem.Name = "ManageTasksToolStripMenuItem"
        Me.ManageTasksToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.ManageTasksToolStripMenuItem.Text = "Manage Tasks"
        Me.ManageTasksToolStripMenuItem.Visible = False
        '
        'ViewTasksToolStripMenuItem
        '
        Me.ViewTasksToolStripMenuItem.Name = "ViewTasksToolStripMenuItem"
        Me.ViewTasksToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ViewTasksToolStripMenuItem.Text = "View Tasks"
        '
        'AddTaskToolStripMenuItem
        '
        Me.AddTaskToolStripMenuItem.Name = "AddTaskToolStripMenuItem"
        Me.AddTaskToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddTaskToolStripMenuItem.Text = "Add Task"
        '
        'ManageGoalsToolStripMenuItem
        '
        Me.ManageGoalsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewGoalsToolStripMenuItem, Me.AddGoalToolStripMenuItem})
        Me.ManageGoalsToolStripMenuItem.Name = "ManageGoalsToolStripMenuItem"
        Me.ManageGoalsToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.ManageGoalsToolStripMenuItem.Text = "Manage Goals"
        Me.ManageGoalsToolStripMenuItem.Visible = False
        '
        'ViewGoalsToolStripMenuItem
        '
        Me.ViewGoalsToolStripMenuItem.Name = "ViewGoalsToolStripMenuItem"
        Me.ViewGoalsToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ViewGoalsToolStripMenuItem.Text = "View Goals"
        '
        'AddGoalToolStripMenuItem
        '
        Me.AddGoalToolStripMenuItem.Name = "AddGoalToolStripMenuItem"
        Me.AddGoalToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.AddGoalToolStripMenuItem.Text = "Add Goal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 290)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Home"
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SubjectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ManageTasksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewTasksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddTaskToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageGoalsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewGoalsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddGoalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
