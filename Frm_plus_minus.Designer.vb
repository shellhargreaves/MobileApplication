<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_plus_minus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_plus_minus))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_plus = New System.Windows.Forms.Button()
        Me.Btn_minus = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pnlInstruction = New System.Windows.Forms.Panel()
        Me.lblInstruction = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInstruction.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Making Maths Memorable"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 110)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 264)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Btn_plus
        '
        Me.Btn_plus.BackColor = System.Drawing.Color.Navy
        Me.Btn_plus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_plus.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_plus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_plus.Location = New System.Drawing.Point(381, 153)
        Me.Btn_plus.Name = "Btn_plus"
        Me.Btn_plus.Size = New System.Drawing.Size(151, 119)
        Me.Btn_plus.TabIndex = 2
        Me.Btn_plus.Text = "+"
        Me.Btn_plus.UseVisualStyleBackColor = False
        '
        'Btn_minus
        '
        Me.Btn_minus.BackColor = System.Drawing.Color.Navy
        Me.Btn_minus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_minus.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_minus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_minus.Location = New System.Drawing.Point(280, 255)
        Me.Btn_minus.Name = "Btn_minus"
        Me.Btn_minus.Size = New System.Drawing.Size(151, 119)
        Me.Btn_minus.TabIndex = 3
        Me.Btn_minus.Text = "-"
        Me.Btn_minus.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.ErrorImage = CType(resources.GetObject("PictureBox2.ErrorImage"), System.Drawing.Image)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(487, 89)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(71, 67)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'pnlInstruction
        '
        Me.pnlInstruction.BackgroundImage = CType(resources.GetObject("pnlInstruction.BackgroundImage"), System.Drawing.Image)
        Me.pnlInstruction.Controls.Add(Me.lblInstruction)
        Me.pnlInstruction.Location = New System.Drawing.Point(142, 110)
        Me.pnlInstruction.Name = "pnlInstruction"
        Me.pnlInstruction.Size = New System.Drawing.Size(151, 108)
        Me.pnlInstruction.TabIndex = 5
        '
        'lblInstruction
        '
        Me.lblInstruction.AutoSize = True
        Me.lblInstruction.Location = New System.Drawing.Point(17, 23)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(56, 13)
        Me.lblInstruction.TabIndex = 0
        Me.lblInstruction.Text = "Instruction"
        '
        'Frm_plus_minus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(570, 431)
        Me.Controls.Add(Me.pnlInstruction)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Btn_minus)
        Me.Controls.Add(Me.Btn_plus)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_plus_minus"
        Me.Text = "Frm_plus_minus"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInstruction.ResumeLayout(False)
        Me.pnlInstruction.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_plus As Button
    Friend WithEvents Btn_minus As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pnlInstruction As Panel
    Friend WithEvents lblInstruction As Label
End Class
