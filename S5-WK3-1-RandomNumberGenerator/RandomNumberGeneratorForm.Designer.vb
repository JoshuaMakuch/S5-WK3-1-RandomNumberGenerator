<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RandomNumberGeneratorForm
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
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'GenerateButton
        '
        Me.GenerateButton.Location = New System.Drawing.Point(12, 12)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(170, 84)
        Me.GenerateButton.TabIndex = 0
        Me.GenerateButton.Text = "Generate"
        Me.GenerateButton.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(12, 102)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(170, 84)
        Me.QuitButton.TabIndex = 1
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 20
        Me.DisplayListBox.Location = New System.Drawing.Point(188, 12)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(107, 204)
        Me.DisplayListBox.TabIndex = 2
        '
        'RandomNumberGeneratorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 230)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.GenerateButton)
        Me.Name = "RandomNumberGeneratorForm"
        Me.Text = "RandomNumberGeneratorForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GenerateButton As Button
    Friend WithEvents QuitButton As Button
    Friend WithEvents DisplayListBox As ListBox
End Class
