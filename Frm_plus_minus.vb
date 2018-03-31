Imports System.Speech.Synthesis
Imports System
Imports System.IO

Public Class Frm_plus_minus

    Private Const strInstruction As String = "Please select The Addition button or The Subtraction button."

    Private Sub Frm_plus_minus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Height = 400
        Me.Width = 600

    End Sub
    Private Sub Frm_plus_minus_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim reader As New SpeechSynthesizer()

        reader.SelectVoiceByHints(VoiceGender.Female, 10, 13,
                                  New Globalization.CultureInfo("en-GB"))
        reader.Volume = 100

        pnlInstruction.Visible = False
        pnlInstruction.Visible = True
        pnlInstruction.Location = New Point(132, 115)
        lblInstruction.Text = strInstruction
        Threading.Thread.Sleep(200)
        reader.Speak(lblInstruction.Text)
        Threading.Thread.Sleep(500)
    End Sub

    Private Sub Btn_plus_Click(sender As Object, e As EventArgs) Handles Btn_plus.Click

    End Sub

    Private Sub Btn_minus_Click(sender As Object, e As EventArgs) Handles Btn_minus.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class

