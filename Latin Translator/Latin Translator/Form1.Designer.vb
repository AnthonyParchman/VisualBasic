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
        Me.BTN_Sinister = New System.Windows.Forms.Button()
        Me.BTN_Medium = New System.Windows.Forms.Button()
        Me.BTN_Dexter = New System.Windows.Forms.Button()
        Me.BTN_Exit = New System.Windows.Forms.Button()
        Me.LBL_Output = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTN_Sinister
        '
        Me.BTN_Sinister.Location = New System.Drawing.Point(114, 259)
        Me.BTN_Sinister.Name = "BTN_Sinister"
        Me.BTN_Sinister.Size = New System.Drawing.Size(144, 55)
        Me.BTN_Sinister.TabIndex = 0
        Me.BTN_Sinister.Text = "Sinister"
        Me.BTN_Sinister.UseVisualStyleBackColor = True
        '
        'BTN_Medium
        '
        Me.BTN_Medium.Location = New System.Drawing.Point(314, 259)
        Me.BTN_Medium.Name = "BTN_Medium"
        Me.BTN_Medium.Size = New System.Drawing.Size(144, 55)
        Me.BTN_Medium.TabIndex = 1
        Me.BTN_Medium.Text = "Medium"
        Me.BTN_Medium.UseVisualStyleBackColor = True
        '
        'BTN_Dexter
        '
        Me.BTN_Dexter.Location = New System.Drawing.Point(530, 259)
        Me.BTN_Dexter.Name = "BTN_Dexter"
        Me.BTN_Dexter.Size = New System.Drawing.Size(144, 55)
        Me.BTN_Dexter.TabIndex = 2
        Me.BTN_Dexter.Text = "Dexter"
        Me.BTN_Dexter.UseVisualStyleBackColor = True
        '
        'BTN_Exit
        '
        Me.BTN_Exit.Location = New System.Drawing.Point(314, 378)
        Me.BTN_Exit.Name = "BTN_Exit"
        Me.BTN_Exit.Size = New System.Drawing.Size(144, 55)
        Me.BTN_Exit.TabIndex = 3
        Me.BTN_Exit.Text = "Exit"
        Me.BTN_Exit.UseVisualStyleBackColor = True
        '
        'LBL_Output
        '
        Me.LBL_Output.AutoSize = True
        Me.LBL_Output.Location = New System.Drawing.Point(258, 115)
        Me.LBL_Output.Name = "LBL_Output"
        Me.LBL_Output.Size = New System.Drawing.Size(0, 25)
        Me.LBL_Output.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LBL_Output)
        Me.Controls.Add(Me.BTN_Exit)
        Me.Controls.Add(Me.BTN_Dexter)
        Me.Controls.Add(Me.BTN_Medium)
        Me.Controls.Add(Me.BTN_Sinister)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_Sinister As Button
    Friend WithEvents BTN_Medium As Button
    Friend WithEvents BTN_Dexter As Button
    Friend WithEvents BTN_Exit As Button
    Friend WithEvents LBL_Output As Label
End Class
