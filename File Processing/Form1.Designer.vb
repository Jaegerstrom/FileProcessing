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
        Me.ButtonWrite = New System.Windows.Forms.Button()
        Me.ButtonRead = New System.Windows.Forms.Button()
        Me.ButtonReadPerLine = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ButtonOpenFile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonWrite
        '
        Me.ButtonWrite.Location = New System.Drawing.Point(198, 181)
        Me.ButtonWrite.Name = "ButtonWrite"
        Me.ButtonWrite.Size = New System.Drawing.Size(190, 82)
        Me.ButtonWrite.TabIndex = 0
        Me.ButtonWrite.Text = "Write"
        Me.ButtonWrite.UseVisualStyleBackColor = True
        '
        'ButtonRead
        '
        Me.ButtonRead.Location = New System.Drawing.Point(198, 93)
        Me.ButtonRead.Name = "ButtonRead"
        Me.ButtonRead.Size = New System.Drawing.Size(190, 82)
        Me.ButtonRead.TabIndex = 1
        Me.ButtonRead.Text = "Read"
        Me.ButtonRead.UseVisualStyleBackColor = True
        '
        'ButtonReadPerLine
        '
        Me.ButtonReadPerLine.Location = New System.Drawing.Point(394, 272)
        Me.ButtonReadPerLine.Name = "ButtonReadPerLine"
        Me.ButtonReadPerLine.Size = New System.Drawing.Size(190, 79)
        Me.ButtonReadPerLine.TabIndex = 2
        Me.ButtonReadPerLine.Text = "Read Per Line"
        Me.ButtonReadPerLine.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(394, 93)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(190, 173)
        Me.ListBox1.TabIndex = 3
        '
        'ButtonOpenFile
        '
        Me.ButtonOpenFile.Location = New System.Drawing.Point(198, 269)
        Me.ButtonOpenFile.Name = "ButtonOpenFile"
        Me.ButtonOpenFile.Size = New System.Drawing.Size(190, 82)
        Me.ButtonOpenFile.TabIndex = 4
        Me.ButtonOpenFile.Text = "Open File"
        Me.ButtonOpenFile.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonOpenFile)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ButtonReadPerLine)
        Me.Controls.Add(Me.ButtonRead)
        Me.Controls.Add(Me.ButtonWrite)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonWrite As Button
    Friend WithEvents ButtonRead As Button
    Friend WithEvents ButtonReadPerLine As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ButtonOpenFile As Button
End Class
