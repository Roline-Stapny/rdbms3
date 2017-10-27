Imports System.Data.SqlClient


Public Class MyEvents
    Dim sql As New Sqlcontrol
    Dim reader As SqlDataReader

    Private Sub ListView2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView2.SelectedIndexChanged

    End Sub

    Private Sub MyEvents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim name As String = Form2.Label2.Text
        Dim usn As String = Form2.Label3.Text


        ListView1.View = View.List
        ListView2.View = View.List

        Try

       
        sql.SQLCon.Open()

        sql.SQLCmd.CommandText = "select Event_Name from event where Event_Id in (select PEvent_Id from participant where Pusn='" & usn & "') "
        reader = sql.SQLCmd.ExecuteReader()
        Me.ListView1.Items.Clear()

        While reader.Read()

            Dim lvi As New ListViewItem(reader.GetString(0))
            Me.ListView1.Items.Add(lvi)

        End While

        reader.Close()


        sql.SQLCmd.CommandText = "select Event_Name from event where Event_Id in (select VEvent_Id from Volounteer where Vusn='" & usn & "') "
        reader = sql.SQLCmd.ExecuteReader()
        Me.ListView2.Items.Clear()

        While reader.Read()

            Dim lvi As New ListViewItem(reader.GetString(0))
            Me.ListView2.Items.Add(lvi)

        End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("error")
            sql.SQLCon.Close()
        End Try
        sql.SQLCon.Close()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()

    End Sub
End Class