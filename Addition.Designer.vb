<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Addition
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Addition))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Txt_equals = New System.Windows.Forms.TextBox()
        Me.Txt_answer = New System.Windows.Forms.TextBox()
        Me.Txt_num2 = New System.Windows.Forms.TextBox()
        Me.Txt_symbol = New System.Windows.Forms.TextBox()
        Me.Txt_num1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 173)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 90)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Txt_equals
        '
        Me.Txt_equals.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_equals.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_equals.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_equals.ForeColor = System.Drawing.Color.Navy
        Me.Txt_equals.Location = New System.Drawing.Point(189, 98)
        Me.Txt_equals.Name = "Txt_equals"
        Me.Txt_equals.Size = New System.Drawing.Size(55, 41)
        Me.Txt_equals.TabIndex = 11
        Me.Txt_equals.Text = "="
        Me.Txt_equals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_answer
        '
        Me.Txt_answer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_answer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_answer.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_answer.ForeColor = System.Drawing.Color.Navy
        Me.Txt_answer.Location = New System.Drawing.Point(250, 98)
        Me.Txt_answer.Name = "Txt_answer"
        Me.Txt_answer.Size = New System.Drawing.Size(55, 41)
        Me.Txt_answer.TabIndex = 10
        Me.Txt_answer.Text = "4"
        Me.Txt_answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_num2
        '
        Me.Txt_num2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_num2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_num2.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_num2.ForeColor = System.Drawing.Color.Navy
        Me.Txt_num2.Location = New System.Drawing.Point(128, 98)
        Me.Txt_num2.Name = "Txt_num2"
        Me.Txt_num2.Size = New System.Drawing.Size(55, 41)
        Me.Txt_num2.TabIndex = 9
        Me.Txt_num2.Text = "1"
        Me.Txt_num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_symbol
        '
        Me.Txt_symbol.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_symbol.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_symbol.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_symbol.ForeColor = System.Drawing.Color.Navy
        Me.Txt_symbol.Location = New System.Drawing.Point(67, 98)
        Me.Txt_symbol.Name = "Txt_symbol"
        Me.Txt_symbol.Size = New System.Drawing.Size(55, 41)
        Me.Txt_symbol.TabIndex = 8
        Me.Txt_symbol.Text = "+"
        Me.Txt_symbol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_num1
        '
        Me.Txt_num1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_num1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_num1.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_num1.ForeColor = System.Drawing.Color.Navy
        Me.Txt_num1.Location = New System.Drawing.Point(6, 98)
        Me.Txt_num1.Name = "Txt_num1"
        Me.Txt_num1.Size = New System.Drawing.Size(55, 41)
        Me.Txt_num1.TabIndex = 7
        Me.Txt_num1.Text = "3"
        Me.Txt_num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Addition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(311, 293)
        Me.Controls.Add(Me.Txt_equals)
        Me.Controls.Add(Me.Txt_answer)
        Me.Controls.Add(Me.Txt_num2)
        Me.Controls.Add(Me.Txt_symbol)
        Me.Controls.Add(Me.Txt_num1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Addition"
        Me.Text = "Addition"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Txt_equals As TextBox
    Friend WithEvents Txt_answer As TextBox
    Friend WithEvents Txt_num2 As TextBox
    Friend WithEvents Txt_symbol As TextBox
    Friend WithEvents Txt_num1 As TextBox
End Class
