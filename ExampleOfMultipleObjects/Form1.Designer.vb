<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBoxScene = New System.Windows.Forms.PictureBox()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        CType(Me.PictureBoxScene, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxScene
        '
        Me.PictureBoxScene.BackColor = System.Drawing.Color.White
        Me.PictureBoxScene.Location = New System.Drawing.Point(32, 23)
        Me.PictureBoxScene.Name = "PictureBoxScene"
        Me.PictureBoxScene.Size = New System.Drawing.Size(664, 449)
        Me.PictureBoxScene.TabIndex = 0
        Me.PictureBoxScene.TabStop = False
        '
        'ButtonStart
        '
        Me.ButtonStart.Location = New System.Drawing.Point(32, 498)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(75, 23)
        Me.ButtonStart.TabIndex = 1
        Me.ButtonStart.Text = "Start"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(163, 498)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(140, 20)
        Me.NumericUpDown1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 558)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.PictureBoxScene)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBoxScene, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBoxScene As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonStart As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
End Class
