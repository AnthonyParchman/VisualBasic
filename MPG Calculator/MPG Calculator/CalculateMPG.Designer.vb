<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculateMPG
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
        Me.LBL_Capacity = New System.Windows.Forms.Label()
        Me.LBL_Distance = New System.Windows.Forms.Label()
        Me.BTn_Calculate = New System.Windows.Forms.Button()
        Me.BTN_Clear = New System.Windows.Forms.Button()
        Me.BTN_Exit = New System.Windows.Forms.Button()
        Me.TXT_Capacity = New System.Windows.Forms.TextBox()
        Me.TXT_Distance = New System.Windows.Forms.TextBox()
        Me.LBL_OutputDesc = New System.Windows.Forms.Label()
        Me.LBL_Output = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LBL_Capacity
        '
        Me.LBL_Capacity.AutoSize = True
        Me.LBL_Capacity.Location = New System.Drawing.Point(63, 64)
        Me.LBL_Capacity.Name = "LBL_Capacity"
        Me.LBL_Capacity.Size = New System.Drawing.Size(228, 25)
        Me.LBL_Capacity.TabIndex = 0
        Me.LBL_Capacity.Text = "Capacity (In US Gallons)"
        '
        'LBL_Distance
        '
        Me.LBL_Distance.AutoSize = True
        Me.LBL_Distance.Location = New System.Drawing.Point(63, 129)
        Me.LBL_Distance.Name = "LBL_Distance"
        Me.LBL_Distance.Size = New System.Drawing.Size(277, 25)
        Me.LBL_Distance.TabIndex = 1
        Me.LBL_Distance.Text = "Distance traveled (In Us Miles)"
        '
        'BTn_Calculate
        '
        Me.BTn_Calculate.Location = New System.Drawing.Point(68, 321)
        Me.BTn_Calculate.Name = "BTn_Calculate"
        Me.BTn_Calculate.Size = New System.Drawing.Size(140, 47)
        Me.BTn_Calculate.TabIndex = 2
        Me.BTn_Calculate.Text = "Calcuate"
        Me.BTn_Calculate.UseVisualStyleBackColor = True
        '
        'BTN_Clear
        '
        Me.BTN_Clear.Location = New System.Drawing.Point(263, 321)
        Me.BTN_Clear.Name = "BTN_Clear"
        Me.BTN_Clear.Size = New System.Drawing.Size(140, 47)
        Me.BTN_Clear.TabIndex = 3
        Me.BTN_Clear.Text = "Clear"
        Me.BTN_Clear.UseVisualStyleBackColor = True
        '
        'BTN_Exit
        '
        Me.BTN_Exit.Location = New System.Drawing.Point(459, 321)
        Me.BTN_Exit.Name = "BTN_Exit"
        Me.BTN_Exit.Size = New System.Drawing.Size(140, 47)
        Me.BTN_Exit.TabIndex = 4
        Me.BTN_Exit.Text = "Exit"
        Me.BTN_Exit.UseVisualStyleBackColor = True
        '
        'TXT_Capacity
        '
        Me.TXT_Capacity.Location = New System.Drawing.Point(499, 60)
        Me.TXT_Capacity.Name = "TXT_Capacity"
        Me.TXT_Capacity.Size = New System.Drawing.Size(100, 29)
        Me.TXT_Capacity.TabIndex = 5
        '
        'TXT_Distance
        '
        Me.TXT_Distance.Location = New System.Drawing.Point(499, 125)
        Me.TXT_Distance.Name = "TXT_Distance"
        Me.TXT_Distance.Size = New System.Drawing.Size(100, 29)
        Me.TXT_Distance.TabIndex = 6
        '
        'LBL_OutputDesc
        '
        Me.LBL_OutputDesc.AutoSize = True
        Me.LBL_OutputDesc.Location = New System.Drawing.Point(63, 218)
        Me.LBL_OutputDesc.Name = "LBL_OutputDesc"
        Me.LBL_OutputDesc.Size = New System.Drawing.Size(145, 25)
        Me.LBL_OutputDesc.TabIndex = 7
        Me.LBL_OutputDesc.Text = "Efficeny (MPG)"
        '
        'LBL_Output
        '
        Me.LBL_Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBL_Output.Location = New System.Drawing.Point(499, 214)
        Me.LBL_Output.Name = "LBL_Output"
        Me.LBL_Output.Size = New System.Drawing.Size(100, 29)
        Me.LBL_Output.TabIndex = 8
        Me.LBL_Output.Text = "Test"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 450)
        Me.Controls.Add(Me.LBL_Output)
        Me.Controls.Add(Me.LBL_OutputDesc)
        Me.Controls.Add(Me.TXT_Distance)
        Me.Controls.Add(Me.TXT_Capacity)
        Me.Controls.Add(Me.BTN_Exit)
        Me.Controls.Add(Me.BTN_Clear)
        Me.Controls.Add(Me.BTn_Calculate)
        Me.Controls.Add(Me.LBL_Distance)
        Me.Controls.Add(Me.LBL_Capacity)
        Me.Name = "Form1"
        Me.Text = "Vehicle Efficeny Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_Capacity As Label
    Friend WithEvents LBL_Distance As Label
    Friend WithEvents BTn_Calculate As Button
    Friend WithEvents BTN_Clear As Button
    Friend WithEvents BTN_Exit As Button
    Friend WithEvents TXT_Capacity As TextBox
    Friend WithEvents TXT_Distance As TextBox
    Friend WithEvents LBL_OutputDesc As Label
    Friend WithEvents LBL_Output As Label
End Class
