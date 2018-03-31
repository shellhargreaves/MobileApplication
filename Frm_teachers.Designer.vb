<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_teachers
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
        Me.Lbl_heading = New System.Windows.Forms.Label()
        Me.Lbl_teachers = New System.Windows.Forms.Label()
        Me.Lbl_parents = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Lbl_heading
        '
        Me.Lbl_heading.AutoSize = True
        Me.Lbl_heading.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_heading.ForeColor = System.Drawing.Color.Navy
        Me.Lbl_heading.Location = New System.Drawing.Point(203, 9)
        Me.Lbl_heading.Name = "Lbl_heading"
        Me.Lbl_heading.Size = New System.Drawing.Size(377, 40)
        Me.Lbl_heading.TabIndex = 0
        Me.Lbl_heading.Text = "Making Maths Memorable"
        Me.Lbl_heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_teachers
        '
        Me.Lbl_teachers.AutoSize = True
        Me.Lbl_teachers.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_teachers.ForeColor = System.Drawing.Color.Navy
        Me.Lbl_teachers.Location = New System.Drawing.Point(15, 41)
        Me.Lbl_teachers.Name = "Lbl_teachers"
        Me.Lbl_teachers.Size = New System.Drawing.Size(121, 35)
        Me.Lbl_teachers.TabIndex = 1
        Me.Lbl_teachers.Text = "Teachers"
        '
        'Lbl_parents
        '
        Me.Lbl_parents.AutoSize = True
        Me.Lbl_parents.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_parents.ForeColor = System.Drawing.Color.Navy
        Me.Lbl_parents.Location = New System.Drawing.Point(15, 304)
        Me.Lbl_parents.Name = "Lbl_parents"
        Me.Lbl_parents.Size = New System.Drawing.Size(102, 35)
        Me.Lbl_parents.TabIndex = 3
        Me.Lbl_parents.Text = "Parents"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBox1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Navy
        Me.TextBox1.Location = New System.Drawing.Point(39, 351)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(350, 172)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "Learning Outcomes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Student will follow instructions of a game." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Interact with tec" &
    "hnology." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Achieve basic maths calculations." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Focus with in a task to achieve a r" &
    "eward. "
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBox2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Navy
        Me.TextBox2.Location = New System.Drawing.Point(39, 99)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(350, 202)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = "Learning Outcomes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Follow the rules of the game." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Keep focuced until answer is ac" &
    "hieved." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Follow simple additional and subtraction calculations." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Focus on one ta" &
    "sk at a time."
        '
        'Frm_teachers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(767, 525)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Lbl_parents)
        Me.Controls.Add(Me.Lbl_teachers)
        Me.Controls.Add(Me.Lbl_heading)
        Me.Name = "Frm_teachers"
        Me.Text = "Frm_teachers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_heading As Label
    Friend WithEvents Lbl_teachers As Label
    Friend WithEvents Lbl_parents As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
