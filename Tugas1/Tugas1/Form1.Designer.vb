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
        Me.ubahButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ubahButton
        '
        Me.ubahButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ubahButton.Location = New System.Drawing.Point(205, 238)
        Me.ubahButton.Name = "ubahButton"
        Me.ubahButton.Size = New System.Drawing.Size(75, 23)
        Me.ubahButton.TabIndex = 0
        Me.ubahButton.Text = "UBAH"
        Me.ubahButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.ubahButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ubahButton As System.Windows.Forms.Button

End Class
