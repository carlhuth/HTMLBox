Public Class Main
    ' This function updates the preview when a user edits the HTML.
    Private Sub Update(sender As Object, e As EventArgs) Handles Editor.TextChanged
        ' Sets the document to the code typed.
        Preview.DocumentText = Editor.Text
    End Sub
End Class
