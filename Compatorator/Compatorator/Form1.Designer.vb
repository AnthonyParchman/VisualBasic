<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LBL_NumberOne = New System.Windows.Forms.Label()
        Me.LBL_NumberTwo = New System.Windows.Forms.Label()
        Me.TXT_NumberOne = New System.Windows.Forms.TextBox()
        Me.TXT_NumberTwo = New System.Windows.Forms.TextBox()
        Me.LBL_Output = New System.Windows.Forms.Label()
        Me.BTN_Compatorate = New System.Windows.Forms.Button()
        Me.BTN_Exit = New System.Windows.Forms.Button()
        Me.BTN_Clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBL_NumberOne
        '
        Me.LBL_NumberOne.AutoSize = True
        Me.LBL_NumberOne.Location = New System.Drawing.Point(112, 103)
        Me.LBL_NumberOne.Name = "LBL_NumberOne"
        Me.LBL_NumberOne.Size = New System.Drawing.Size(124, 25)
        Me.LBL_NumberOne.TabIndex = 0
        Me.LBL_NumberOne.Text = "Number One"
        '
        'LBL_NumberTwo
        '
        Me.LBL_NumberTwo.AutoSize = True
        Me.LBL_NumberTwo.Location = New System.Drawing.Point(436, 103)
        Me.LBL_NumberTwo.Name = "LBL_NumberTwo"
        Me.LBL_NumberTwo.Size = New System.Drawing.Size(124, 25)
        Me.LBL_NumberTwo.TabIndex = 1
        Me.LBL_NumberTwo.Text = "Number Two"
        '
        'TXT_NumberOne
        '
        Me.TXT_NumberOne.Location = New System.Drawing.Point(249, 103)
        Me.TXT_NumberOne.Name = "TXT_NumberOne"
        Me.TXT_NumberOne.Size = New System.Drawing.Size(100, 29)
        Me.TXT_NumberOne.TabIndex = 2
        '
        'TXT_NumberTwo
        '
        Me.TXT_NumberTwo.Location = New System.Drawing.Point(573, 103)
        Me.TXT_NumberTwo.Name = "TXT_NumberTwo"
        Me.TXT_NumberTwo.Size = New System.Drawing.Size(100, 29)
        Me.TXT_NumberTwo.TabIndex = 3
        '
        'LBL_Output
        '
        Me.LBL_Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBL_Output.Location = New System.Drawing.Point(117, 193)
        Me.LBL_Output.Name = "LBL_Output"
        Me.LBL_Output.Size = New System.Drawing.Size(450, 40)
        Me.LBL_Output.TabIndex = 4
        '
        'BTN_Compatorate
        '
        Me.BTN_Compatorate.Location = New System.Drawing.Point(117, 297)
        Me.BTN_Compatorate.Name = "BTN_Compatorate"
        Me.BTN_Compatorate.Size = New System.Drawing.Size(164, 53)
        Me.BTN_Compatorate.TabIndex = 5
        Me.BTN_Compatorate.Text = "Compatorate"
        Me.BTN_Compatorate.UseVisualStyleBackColor = True
        '
        'BTN_Exit
        '
        Me.BTN_Exit.Location = New System.Drawing.Point(509, 297)
        Me.BTN_Exit.Name = "BTN_Exit"
        Me.BTN_Exit.Size = New System.Drawing.Size(164, 53)
        Me.BTN_Exit.TabIndex = 6
        Me.BTN_Exit.Text = "Exit"
        Me.BTN_Exit.UseVisualStyleBackColor = True
        '
        'BTN_Clear
        '
        Me.BTN_Clear.Location = New System.Drawing.Point(318, 297)
        Me.BTN_Clear.Name = "BTN_Clear"
        Me.BTN_Clear.Size = New System.Drawing.Size(164, 53)
        Me.BTN_Clear.TabIndex = 7
        Me.BTN_Clear.Text = "Clear"
        Me.BTN_Clear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTN_Clear)
        Me.Controls.Add(Me.BTN_Exit)
        Me.Controls.Add(Me.BTN_Compatorate)
        Me.Controls.Add(Me.LBL_Output)
        Me.Controls.Add(Me.TXT_NumberTwo)
        Me.Controls.Add(Me.TXT_NumberOne)
        Me.Controls.Add(Me.LBL_NumberTwo)
        Me.Controls.Add(Me.LBL_NumberOne)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_NumberOne As Label
    Friend WithEvents LBL_NumberTwo As Label
    Friend WithEvents TXT_NumberOne As TextBox
    Friend WithEvents TXT_NumberTwo As TextBox
    Friend WithEvents LBL_Output As Label
    Friend WithEvents BTN_Compatorate As Button
    Friend WithEvents BTN_Exit As Button
    Friend WithEvents BTN_Clear As Button
End Class
