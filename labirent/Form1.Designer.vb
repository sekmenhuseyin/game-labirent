<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.listBox1 = New System.Windows.Forms.ListBox
        Me.button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.Location = New System.Drawing.Point(372, 69)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(142, 277)
        Me.listBox1.TabIndex = 3
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(372, 40)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(142, 23)
        Me.button1.TabIndex = 2
        Me.button1.Text = "C�Z�MLE"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 395)
        Me.Controls.Add(Me.listBox1)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listBox1 As System.Windows.Forms.ListBox
    Friend WithEvents button1 As System.Windows.Forms.Button

End Class
