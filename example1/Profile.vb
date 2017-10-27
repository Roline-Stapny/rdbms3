
Imports System.Data.SqlClient


Public Class Profile
    Dim sql As New Sqlcontrol
    Dim reader As SqlDataReader

    Private Sub Profile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try
        sql.SQLCon.Open()
        sql.SQLCmd.CommandText = "select * from Student where Usn='" & Form2.Label3.Text & "' and name='" & Form2.Label2.Text & "'"

        reader = sql.SQLCmd.ExecuteReader()



        If reader.Read() Then
            Label16.Text = reader.GetString(0)
            Label15.Text = reader.GetString(1)
            Label14.Text = reader.GetString(2)
            Label13.Text = reader.GetString(3)
            Label12.Text = reader.GetString(4)
            Label11.Text = reader.GetInt32(5).ToString

            Label20.Text = reader.GetString(6)
            Label19.Text = reader.GetString(7)
            Label18.Text = reader.GetString(8)
            Label17.Text = reader.GetString(9)

        End If





        ' Catch ex As Exception
        '    Me.Hide()
        '   MessageBox.Show(" error")
        '  sql.SQLCon.Close()

        'End Try

        sql.SQLCon.Close()



    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()

    End Sub

   
End Class