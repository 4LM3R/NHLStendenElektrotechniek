<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NA2_Momentelewaarde
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
        Me.Spanningsdeler = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Spanningsdeler
        '
        Me.Spanningsdeler.AutoSize = True
        Me.Spanningsdeler.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Spanningsdeler.Location = New System.Drawing.Point(12, 9)
        Me.Spanningsdeler.Name = "Spanningsdeler"
        Me.Spanningsdeler.Size = New System.Drawing.Size(306, 39)
        Me.Spanningsdeler.TabIndex = 1
        Me.Spanningsdeler.Text = "Momentele waarde"
        '
        'NA1_Momentelewaarde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.Spanningsdeler)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NA1_Momentelewaarde"
        Me.Text = "NA1_Momentelewaarde"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Spanningsdeler As Label
End Class
