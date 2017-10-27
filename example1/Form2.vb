Imports System.Data.SqlClient

Public Class Form2
    ' Enum  as {Terabyte,Panorama,Papyrus,Huntainment,Adrinaline Rush,Clash Of Clans Reloaded,Pokemon Go,Game of Clues Returns,Talaash,Despicable Me,Tech Rodies,Techtainment,Twitease,Thinking Cap,Blind Drive,Speed Clubbing,Keep It Simple And Sillly,Tech Juggling,Un-Google,Tantragni} 

    Dim sql As New Sqlcontrol
    Dim reader As SqlDataReader


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sql.SQLCon.Open()
        sql.SQLCmd.CommandText = "Select Name,Usn from Student where Username='" & LoginForm1.UsernameTextBox.Text & "' and password= '" & LoginForm1.PasswordTextBox.Text & "';  "
        reader = sql.SQLCmd.ExecuteReader()

        If reader.Read() Then
            Label2.Text = reader.GetString(0)
            Label3.Text = reader.GetString(1)
        End If
        sql.SQLCon.Close()


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        LoginForm1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'when register button is clicked do this
        Try
            sql.SQLCon.Open()


            'if participant is checked then enter the value into participant
            If RadioButton1.Checked Then


                Try
                    Select Case ComboBox1.SelectedItem.ToString()
                        Case "Terabyte"

                            sql.SQLCmd.CommandText = "insert into Participant values('" & Label3.Text & "',1);"

                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select

                        Case "Panorama"
                            sql.SQLCmd.CommandText = "insert into Participant values('" & Label3.Text & "',2);"

                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try

                            Exit Select

                        Case "Papyrus"
                            sql.SQLCmd.CommandText = "insert into Participant values('" & Label3.Text & "',3);"

                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try

                            Exit Select
                        Case "Huntainment"
                            sql.SQLCmd.CommandText = "insert into Participant values('" & Label3.Text & "',4);"

                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try

                            Exit Select
                        Case "Adrinaline Rush"
                            sql.SQLCmd.CommandText = "insert into Participant values('" & Label3.Text & "',5);"

                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try

                            Exit Select
                        Case "Clash Of Clans Reloaded"
                            sql.SQLCmd.CommandText = "insert into Participant values('" & Label3.Text & "',6);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try

                            Exit Select
                        Case "Pokemon Go"
                            sql.SQLCmd.CommandText = "insert into Participant values('" & Label3.Text & "',7);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Game of Clues Returns"
                            sql.SQLCmd.CommandText = "insert into Participant values('" & Label3.Text & "',8);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Talaash"
                            sql.SQLCmd.CommandText = "insert into Participant values('" & Label3.Text & "',9);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Despicable Me"
                            sql.SQLCmd.CommandText = "insert into Participant values('" & Label3.Text & "',10);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Tech Rodies"
                            sql.SQLCmd.CommandText = "insert into Participant values('" & Label3.Text & "',11);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Techtainment"
                            sql.SQLCmd.CommandText = "insert into Participant values('" & Label3.Text & "',12);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Twitease"
                            sql.SQLCmd.CommandText = "insert into Participant values('" & Label3.Text & "',13);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Thinking Cap"
                            sql.SQLCmd.CommandText = "insert into Participant values('" & Label3.Text & "',14);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Blind Drive"
                            sql.SQLCmd.CommandText = "insert into Participant values('" & Label3.Text & "',15);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Speed Clubbing"
                            sql.SQLCmd.CommandText = "insert into Participant values('" & Label3.Text & "',16);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Keep It Simple And Sillly"
                            sql.SQLCmd.CommandText = "insert into Participant values('" & Label3.Text & "',17);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Tech Juggling"
                            sql.SQLCmd.CommandText = "insert into Participant values('" & Label3.Text & "',18);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Un-Google"
                            sql.SQLCmd.CommandText = "insert into Participant values('" & Label3.Text & "',19);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Tantragni"
                            sql.SQLCmd.CommandText = "insert into Participant values('" & Label3.Text & "',20);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case Else
                            MessageBox.Show("invalid event")

                    End Select
                    'if none of the elemnt in the combo box is selected
                Catch ex As Exception
                    MessageBox.Show("please select a combobox value")
                End Try

            Else
                'if participant is checked
                Try
                    Select Case ComboBox1.SelectedItem.ToString()
                        Case "Terabyte"

                            sql.SQLCmd.CommandText = "insert into Volounteer values('" & Label3.Text & "',1);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select

                        Case "Panorama"
                            sql.SQLCmd.CommandText = "insert into Volounteer values('" & Label3.Text & "',2);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Papyrus"
                            sql.SQLCmd.CommandText = "insert into Volounteer values('" & Label3.Text & "',3);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Huntainment"
                            sql.SQLCmd.CommandText = "insert into Volounteer values('" & Label3.Text & "',4);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Adrinaline Rush"
                            sql.SQLCmd.CommandText = "insert into Volounteer values('" & Label3.Text & "',5);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Clash Of Clans Reloaded"
                            sql.SQLCmd.CommandText = "insert into Volounteer values('" & Label3.Text & "',6);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Pokemon Go"
                            sql.SQLCmd.CommandText = "insert into Volounteer values('" & Label3.Text & "',7);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Game of Clues Returns"
                            sql.SQLCmd.CommandText = "insert into Volounteer values('" & Label3.Text & "',8);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Talaash"
                            sql.SQLCmd.CommandText = "insert into Volounteer values('" & Label3.Text & "',9);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Despicable Me"
                            sql.SQLCmd.CommandText = "insert into Volounteer values('" & Label3.Text & "',10);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Tech Rodies"
                            sql.SQLCmd.CommandText = "insert into Volounteer values('" & Label3.Text & "',11);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Techtainment"
                            sql.SQLCmd.CommandText = "insert into Volounteer values('" & Label3.Text & "',12);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Twitease"
                            sql.SQLCmd.CommandText = "insert into Volounteer values('" & Label3.Text & "',13);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Thinking Cap"
                            sql.SQLCmd.CommandText = "insert into Volounteer values('" & Label3.Text & "',14);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Blind Drive"
                            sql.SQLCmd.CommandText = "insert into Volounteer values('" & Label3.Text & "',15);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Speed Clubbing"
                            sql.SQLCmd.CommandText = "insert into Volounteer values('" & Label3.Text & "',16);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Keep It Simple And Sillly"
                            sql.SQLCmd.CommandText = "insert into Volounteer values('" & Label3.Text & "',17);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Tech Juggling"
                            sql.SQLCmd.CommandText = "insert into Volounteer values('" & Label3.Text & "',18);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Un-Google"
                            sql.SQLCmd.CommandText = "insert into Volounteer values('" & Label3.Text & "',19);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            Exit Select
                        Case "Tantragni"
                            sql.SQLCmd.CommandText = "insert into Volounteer values('" & Label3.Text & "',20);"
                            Try
                                sql.SQLCmd.ExecuteNonQuery()
                                MessageBox.Show("successful")
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try

                            Exit Select

                        Case Else
                            MessageBox.Show("invalid event")

                    End Select

                Catch ex As Exception
                    MessageBox.Show("please select the value for combobox")


                End Try
        End If






        Catch ex As Exception
            MessageBox.Show("connectionError")
            sql.SQLCon.Close()
        End Try



        sql.SQLCon.Close()

    End Sub



    Private Sub ProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfileToolStripMenuItem.Click
        Profile.Show()
        Me.Hide()

    End Sub

    'unregister button code

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            sql.SQLCon.Open()
            'if participant is checked then enter the value into participant
            If RadioButton1.Checked Then


                Try
                    Select Case ComboBox1.SelectedItem.ToString()
                        Case "Terabyte"

                            sql.SQLCmd.CommandText = "delete from Participant where Pusn='" & Label3.Text & "' and PEvent_Id=1"


                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If

                            Exit Select

                        Case "Panorama"
                            sql.SQLCmd.CommandText = "delete from Participant where Pusn='" & Label3.Text & "' and PEvent_Id=2;"

                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select

                        Case "Papyrus"
                            sql.SQLCmd.CommandText = "delete from Participant where Pusn='" & Label3.Text & "' and PEvent_Id=3;"

                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Huntainment"
                            sql.SQLCmd.CommandText = "delete from Participant where Pusn='" & Label3.Text & "' and PEvent_Id=4;"

                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If

                            Exit Select
                        Case "Adrinaline Rush"
                            sql.SQLCmd.CommandText = "delete from Participant where Pusn='" & Label3.Text & "' and PEvent_Id=5;"

                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Clash Of Clans Reloaded"
                            sql.SQLCmd.CommandText = "delete from Participant where Pusn='" & Label3.Text & "' and PEvent_Id=6;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Pokemon Go"
                            sql.SQLCmd.CommandText = "delete from Participant where Pusn='" & Label3.Text & "' and PEvent_Id=7;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Game of Clues Returns"
                            sql.SQLCmd.CommandText = "delete from Participant where Pusn='" & Label3.Text & "' and PEvent_Id=8;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Talaash"
                            sql.SQLCmd.CommandText = "delete from Participant where Pusn='" & Label3.Text & "' and PEvent_Id=9;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Despicable Me"
                            sql.SQLCmd.CommandText = "delete from Participant where Pusn='" & Label3.Text & "' and PEvent_Id=10;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Tech Rodies"
                            sql.SQLCmd.CommandText = "delete from Participant where Pusn='" & Label3.Text & "' and PEvent_Id=11;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Techtainment"
                            sql.SQLCmd.CommandText = "delete from Participant where Pusn='" & Label3.Text & "' and PEvent_Id=12;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Twitease"
                            sql.SQLCmd.CommandText = "delete from Participant where Pusn='" & Label3.Text & "' and PEvent_Id=13;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Thinking Cap"
                            sql.SQLCmd.CommandText = "delete from Participant where Pusn='" & Label3.Text & "' and PEvent_Id=14;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Blind Drive"
                            sql.SQLCmd.CommandText = "delete from Participant where Pusn='" & Label3.Text & "' and PEvent_Id=15;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Speed Clubbing"
                            sql.SQLCmd.CommandText = "delete from Participant where Pusn='" & Label3.Text & "' and PEvent_Id=16;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Keep It Simple And Sillly"
                            sql.SQLCmd.CommandText = "delete from Participant where Pusn='" & Label3.Text & "' and PEvent_Id=17;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Tech Juggling"
                            sql.SQLCmd.CommandText = "delete from Participant where Pusn='" & Label3.Text & "' and PEvent_Id=18;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Un-Google"
                            sql.SQLCmd.CommandText = "delete from Participant where Pusn='" & Label3.Text & "' and PEvent_Id=19;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Tantragni"
                            sql.SQLCmd.CommandText = "delete from Participant where Pusn='" & Label3.Text & "' and PEvent_Id=20;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case Else
                            MessageBox.Show("invalid event")

                    End Select
                    'if none of the elemnt in the combo box is selected
                Catch ex As Exception
                    MessageBox.Show("please select a combobox value")
                End Try

            Else
                'if volounteer is checked
                Try
                    Select Case ComboBox1.SelectedItem.ToString()
                        Case "Terabyte"

                            sql.SQLCmd.CommandText = "delete from Volounteer where Vusn='" & Label3.Text & "' and VEvent_id=1;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select

                        Case "Panorama"
                            sql.SQLCmd.CommandText = "delete from Volounteer where Vusn='" & Label3.Text & "' and VEvent_id=2;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Papyrus"
                            sql.SQLCmd.CommandText = "delete from Volounteer where Vusn='" & Label3.Text & "' and VEvent_id=3;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Huntainment"
                            sql.SQLCmd.CommandText = "delete from Volounteer where Vusn='" & Label3.Text & "' and VEvent_id=4;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Adrinaline Rush"
                            sql.SQLCmd.CommandText = "delete from Volounteer where Vusn='" & Label3.Text & "' and VEvent_id=5;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Clash Of Clans Reloaded"
                            sql.SQLCmd.CommandText = "delete from Volounteer where Vusn='" & Label3.Text & "' and VEvent_id=6;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Pokemon Go"
                            sql.SQLCmd.CommandText = "delete from Volounteer where Vusn='" & Label3.Text & "' and VEvent_id=7;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Game of Clues Returns"
                            sql.SQLCmd.CommandText = "delete from Volounteer where Vusn='" & Label3.Text & "' and VEvent_id=8;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Talaash"
                            sql.SQLCmd.CommandText = "delete from Volounteer where Vusn='" & Label3.Text & "' and VEvent_id=9;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Despicable Me"
                            sql.SQLCmd.CommandText = "delete from Volounteer where Vusn='" & Label3.Text & "' and VEvent_id=10;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Tech Rodies"
                            sql.SQLCmd.CommandText = "delete from Volounteer where Vusn='" & Label3.Text & "' and VEvent_id=11;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Techtainment"
                            sql.SQLCmd.CommandText = "delete from Volounteer where Vusn='" & Label3.Text & "' and VEvent_id=12;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Twitease"
                            sql.SQLCmd.CommandText = "delete from Volounteer where Vusn='" & Label3.Text & "' and VEvent_id=13;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Thinking Cap"
                            sql.SQLCmd.CommandText = "delete from Volounteer where Vusn='" & Label3.Text & "' and VEvent_id=14;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Blind Drive"
                            sql.SQLCmd.CommandText = "delete from Volounteer where Vusn='" & Label3.Text & "' and VEvent_id=15;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Speed Clubbing"
                            sql.SQLCmd.CommandText = "delete from Volounteer where Vusn='" & Label3.Text & "' and VEvent_id=16;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Keep It Simple And Sillly"
                            sql.SQLCmd.CommandText = "delete from Volounteer where Vusn='" & Label3.Text & "' and VEvent_id=17;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Tech Juggling"
                            sql.SQLCmd.CommandText = "delete from Volounteer where Vusn='" & Label3.Text & "' and VEvent_id=18;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Un-Google"
                            sql.SQLCmd.CommandText = "delete from Volounteer where Vusn='" & Label3.Text & "' and VEvent_id=19;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select
                        Case "Tantragni"
                            sql.SQLCmd.CommandText = "delete from Volounteer where Vusn='" & Label3.Text & "' and VEvent_id=20;"
                            Dim i As Integer = sql.SQLCmd.ExecuteNonQuery()
                            If (i > 0) Then
                                MessageBox.Show("successful")
                            Else
                                MessageBox.Show("you have not registered for it")
                            End If
                            Exit Select

                        Case Else
                            MessageBox.Show("invalid event")

                    End Select

                Catch ex As Exception
                    MessageBox.Show("please select the value for combobox")


                End Try
            End If


        Catch ex As Exception
            MessageBox.Show("connection error")
            sql.SQLCon.Close()
        End Try



        sql.SQLCon.Close()

    End Sub

    Private Sub UpdateDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateDetailsToolStripMenuItem.Click
        Me.Hide()
        Updatedetails.Show()



    End Sub

    Private Sub MyEventsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyEventsToolStripMenuItem.Click
        Me.Hide()
        MyEvents.Show()

    End Sub
End Class