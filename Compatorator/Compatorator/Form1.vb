Public Class Form1

    Private Sub BTN_Compatorate_Click(sender As Object, e As EventArgs) Handles BTN_Compatorate.Click
        'dcefault output is blank
        LBL_Output.Text = ""
        'declare variables
        Dim ValueOne As Double
        Dim ValueTwo As Double
        Dim IntResul As Double
        'change variables to doubles
        ValueOne = Convert.ToDouble(TXT_NumberOne.Text)
        ValueTwo = Convert.ToDouble(TXT_NumberTwo.Text)
        'confirm they are doubles
        If Not Double.TryParse(ValueOne, IntResul) Or Not Double.TryParse(ValueTwo, IntResul) Then
            LBL_Output.Text = "Invalid Data"
            ' if statemnts to do the compatoration
        ElseIf ValueOne > ValueTwo Then
            LBL_Output.Text = "Value one is greater"


        ElseIf ValueOne < ValueTwo Then
            LBL_Output.Text = "Value Two is greater"

        Else
            LBL_Output.Text = "values are equal"

        End If

    End Sub

    Private Sub BTN_Exit_Click(sender As Object, e As EventArgs) Handles BTN_Exit.Click
        Me.Close()

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.Yes
            'nothing to do here the form is already closing
            Case Windows.Forms.DialogResult.No
                e.Cancel = True 'cancel the form closing event
                'minimize to tray/hide etc here 
        End Select
    End Sub

End Class
