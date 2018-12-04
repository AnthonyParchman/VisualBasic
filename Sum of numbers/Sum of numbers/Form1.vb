Public Class Form1
    Private Sub BTN_EnterNumbers_Click(sender As Object, e As EventArgs) Handles BTN_EnterNumbers.Click
        Dim Sum As Integer
        Dim InputNumber As String


        InputNumber = InputBox("Enter a Whole Number Value", "Input Needed", "100")
        If InputNumber < 0 Then
            InputNumber = InputNumber * -1

            ' MessageBox.Show("Please Input a Positive Number")
        Else

        End If

        For Sum = 1 To InputNumber
            Sum = InputNumber * (InputNumber + 1) / 2

            MessageBox.Show("The Sum of all the integers from 1 through" & InputNumber & " Is " & Sum)

        Next


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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Hello")
    End Sub
End Class
