Public Class CalculateMPG


    Private Sub BTN_Calculate_Click(sender As Object, e As EventArgs) Handles BTn_Calculate.Click

        'declaring variables 
        Dim Capacity As Double = 0
        Dim Distance As Double = 0
        Dim Efficeny As Double = 0

        'Should parse the text boxes and output as a double
        Capacity = Double.Parse(TXT_Capacity.Text)
        Distance = Double.Parse(TXT_Distance.Text)

        'runs the calculation 
        Efficeny = Distance / Capacity

        'outputs to the output box
        LBL_Output.Text = Efficeny.ToString


    End Sub

    Private Sub BTN_Clear_Click(sender As Object, e As EventArgs) Handles BTN_Clear.Click
        TXT_Capacity.Clear()
        TXT_Distance.Clear()
        LBL_Output.Text = ""



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

    Private Sub BTN_Exit_Click(sender As Object, e As EventArgs) Handles BTN_Exit.Click
        Me.Close()

    End Sub

End Class
