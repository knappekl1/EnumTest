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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbA = New System.Windows.Forms.TextBox()
        Me.tbB = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbSum = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "B"
        '
        'tbA
        '
        Me.tbA.Location = New System.Drawing.Point(81, 48)
        Me.tbA.Name = "tbA"
        Me.tbA.Size = New System.Drawing.Size(100, 26)
        Me.tbA.TabIndex = 1
        '
        'tbB
        '
        Me.tbB.Location = New System.Drawing.Point(81, 81)
        Me.tbB.Name = "tbB"
        Me.tbB.Size = New System.Drawing.Size(100, 26)
        Me.tbB.TabIndex = 1
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(316, 50)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(118, 57)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Division"
        '
        'tbSum
        '
        Me.tbSum.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.tbSum.Enabled = False
        Me.tbSum.Location = New System.Drawing.Point(81, 126)
        Me.tbSum.Name = "tbSum"
        Me.tbSum.Size = New System.Drawing.Size(100, 26)
        Me.tbSum.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 562)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.tbSum)
        Me.Controls.Add(Me.tbB)
        Me.Controls.Add(Me.tbA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbA As TextBox
    Friend WithEvents tbB As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tbSum As TextBox
End Class
