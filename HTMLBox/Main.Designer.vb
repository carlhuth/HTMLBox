<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.Preview = New System.Windows.Forms.WebBrowser()
        Me.Editor = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Preview
        '
        Me.Preview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Preview.Location = New System.Drawing.Point(396, 13)
        Me.Preview.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Preview.Name = "Preview"
        Me.Preview.Size = New System.Drawing.Size(361, 422)
        Me.Preview.TabIndex = 1
        '
        'Editor
        '
        Me.Editor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Editor.Location = New System.Drawing.Point(13, 13)
        Me.Editor.Name = "Editor"
        Me.Editor.Size = New System.Drawing.Size(362, 422)
        Me.Editor.TabIndex = 2
        Me.Editor.Text = ""
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 447)
        Me.Controls.Add(Me.Editor)
        Me.Controls.Add(Me.Preview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HTMLBox"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Preview As WebBrowser
    Friend WithEvents Editor As RichTextBox
End Class
