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
        Me.LBL_TopLeftInfo = New System.Windows.Forms.Label()
        Me.Txt_GroupNumber = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LBL_TopLeftInfo
        '
        Me.LBL_TopLeftInfo.AutoSize = True
        Me.LBL_TopLeftInfo.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TopLeftInfo.Location = New System.Drawing.Point(39, 23)
        Me.LBL_TopLeftInfo.Name = "LBL_TopLeftInfo"
        Me.LBL_TopLeftInfo.Size = New System.Drawing.Size(434, 48)
        Me.LBL_TopLeftInfo.TabIndex = 0
        Me.LBL_TopLeftInfo.Text = "Enrollment Application/Change"
        '
        'Txt_GroupNumber
        '
        Me.Txt_GroupNumber.Location = New System.Drawing.Point(532, 19)
        Me.Txt_GroupNumber.Name = "Txt_GroupNumber"
        Me.Txt_GroupNumber.Size = New System.Drawing.Size(129, 26)
        Me.Txt_GroupNumber.TabIndex = 1
        Me.Txt_GroupNumber.Text = "Group Number"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(2834, 1542)
        Me.Controls.Add(Me.Txt_GroupNumber)
        Me.Controls.Add(Me.LBL_TopLeftInfo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_TopLeftInfo As Label
    Friend WithEvents Txt_GroupNumber As TextBox
End Class
