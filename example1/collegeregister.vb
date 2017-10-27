Imports System.Text.RegularExpressions ' Regular Expressions Namespace

Public Class collegeregister
    Dim sql As New Sqlcontrol

    Private Sub collegeregister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim emptyTextBoxes =
        From txt In Me.Controls.OfType(Of TextBox)()
        Where txt.Text.Length = 0
        Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill following textboxes: {0}",
                            String.Join(",", emptyTextBoxes)))
        Else


            Try
                sql.SQLCon.Open()
                sql.SQLCmd.CommandText = "insert into college values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
                sql.SQLCmd.ExecuteNonQuery()
                MessageBox.Show("successful")

            Catch ex As Exception
                MessageBox.Show("error")

            End Try

        End If

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If Not Regex.Match(TextBox2.Text, "^[a-z ]*$", RegexOptions.IgnoreCase).Success Then 'Only Letters

            MessageBox.Show("Please Enter Alphabetic Characters Only!") 'Inform User

            TextBox2.Focus() 'Return Focus
            TextBox2.Clear() 'Clear Text
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Startpage.Show()

    End Sub
End Class