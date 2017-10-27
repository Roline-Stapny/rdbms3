Public Class Form11

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form33.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form22.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form22.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form33.Show()
        Me.Hide()
    End Sub
End Class
