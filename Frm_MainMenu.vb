Imports System.Speech.Synthesis
Imports System
Imports System.IO


Public Class Frm_MainMenu

    Private Const strInstruction1 As String = "Hello [USERNAME] My name is Marthaa and I am so glad you have visited me this [TIME]."
    Private Const strInstruction2 As String = "Would you like to play a game with me?"
    Private Const strInstruction3 As String = "You will win a certificate that you can Print and Keep."
    Private Const strInstruction4 As String = "Don't worry, I will be with you till you get your CERTIFICATE."
    Private Const strInstruction5 As String = "Click on my hand and we can begin our game."

    Private Sub Btn_thumb_Click(sender As Object, e As EventArgs) Handles Btn_thumb.Click
        Frm_plus_minus.Show()
    End Sub

    Private Sub Frm_MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Height = 400
        Me.Width = 600

    End Sub

    Private Sub Frm_MainMenu_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim reader As New SpeechSynthesizer()

        reader.SelectVoiceByHints(VoiceGender.Female, 10, 13,
                                  New Globalization.CultureInfo("en-GB"))
        reader.Volume = 100

        Dim strUsername As String = "Michael"
        Dim strGreeting As String

        If (DateTime.Now.Hour >= 16) Then
            strGreeting = "Evening"

        ElseIf DateTime.Now.Hour >= 11 Then
            strGreeting = "Afternoon"

        Else
            strGreeting = "Morning"

        End If

        lbInstruction.Text = strInstruction1.Replace("[USERNAME]", strUsername).Replace("[TIME]", strGreeting)
        reader.Speak(lbInstruction.Text)
        Threading.Thread.Sleep(500)

        pnlInstructions.Visible = False
        pnlInstructions1.Visible = True
        pnlInstructions1.Location = New Point(132, 115)
        lbInstruction1.Text = strInstruction2
        Threading.Thread.Sleep(200)
        reader.Speak(lbInstruction1.Text)
        Threading.Thread.Sleep(500)

        pnlInstructions1.Visible = False
        pnlInstructions2.Visible = True
        pnlInstructions2.Location = New Point(132, 115)
        lbInstruction2.Text = strInstruction3
        Threading.Thread.Sleep(200)
        reader.Speak(lbInstruction2.Text)
        Threading.Thread.Sleep(500)

        pnlInstructions2.Visible = False
        pnlInstructions3.Visible = True
        pnlInstructions3.Location = New Point(132, 115)
        lbInstruction3.Text = strInstruction4
        Threading.Thread.Sleep(200)
        reader.Speak(lbInstruction3.Text)
        Threading.Thread.Sleep(500)

        pnlInstructions3.Visible = False
        pnlInstructions4.Visible = True
        pnlInstructions4.Location = New Point(132, 115)
        lbInstruction4.Text = strInstruction5
        Threading.Thread.Sleep(200)
        reader.Speak(lbInstruction4.Text)
    End Sub
End Class
