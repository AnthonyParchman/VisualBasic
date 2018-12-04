<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BTN_EnterNumbers = New System.Windows.Forms.Button()
        Me.BTN_Exit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTN_EnterNumbers
        '
        Me.BTN_EnterNumbers.Location = New System.Drawing.Point(115, 147)
        Me.BTN_EnterNumbers.Name = "BTN_EnterNumbers"
        Me.BTN_EnterNumbers.Size = New System.Drawing.Size(258, 66)
        Me.BTN_EnterNumbers.TabIndex = 0
        Me.BTN_EnterNumbers.Text = "Enter Numbers"
        Me.BTN_EnterNumbers.UseVisualStyleBackColor = True
        '
        'BTN_Exit
        '
        Me.BTN_Exit.Location = New System.Drawing.Point(435, 147)
        Me.BTN_Exit.Name = "BTN_Exit"
        Me.BTN_Exit.Size = New System.Drawing.Size(258, 66)
        Me.BTN_Exit.TabIndex = 1
        Me.BTN_Exit.Text = "Exit"
        Me.BTN_Exit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(133, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 281)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTN_Exit)
        Me.Controls.Add(Me.BTN_EnterNumbers)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTN_EnterNumbers As Button
    Friend WithEvents BTN_Exit As Button
    Friend WithEvents Button1 As Button
End Class
