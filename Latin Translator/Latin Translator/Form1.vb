Public Class Form1
    Private Sub BTN_Sinister_Click(sender As Object, e As EventArgs) Handles BTN_Sinister.Click
        LBL_Output.Text = "Left"

    End Sub

    Private Sub BTN_Medium_Click(sender As Object, e As EventArgs) Handles BTN_Medium.Click
        LBL_Output.Text = "Middle"

    End Sub

    Private Sub BTN_Dexter_Click(sender As Object, e As EventArgs) Handles BTN_Dexter.Click
        LBL_Output.Text = "Right"

    End Sub

    Private Sub BTN_Exit_Click(sender As Object, e As EventArgs) Handles BTN_Exit.Click
        Me.Close()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Select Case MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.Yes
            'nothing to do here the form is already closing
            Case Windows.Forms.DialogResult.No
                e.Cancel = True 'cancel the form closing event
                'minimize to tray/hide etc here 
        End Select
    End Sub
End Class
