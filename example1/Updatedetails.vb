Imports System.Data.SqlClient
Imports System.Text.RegularExpressions 'regular expression namespace


Public Class Updatedetails
    Dim sql As New Sqlcontrol
    Dim myReader As SqlDataReader
    Private Sub Updatedetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sql.SQLCon.Open()
        sql.SQLCmd.CommandText = "select * from Student where usn='" & Form2.Label3.Text & "'"
        myReader = sql.SQLCmd.ExecuteReader()
        While myReader.Read()

            TextBox5.Text = myReader.GetString(0).ToString()
            TextBox1.Text = myReader.GetString(1).ToString()
            TextBox6.Text = myReader.GetString(2).ToString()
            Dim a As String = myReader.GetString(3).ToString()
            If a = "Male" Then
                RadioButton1.Checked = True

            Else
                RadioButton2.Checked = True

            End If


            TextBox3.Text = myReader.GetString(4).ToString()

            TextBox2.Text = myReader.GetInt32(5).ToString()

            TextBox7.Text = myReader.GetString(6).ToString()
            TextBox4.Text = myReader.GetString(7).ToString()
            TextBox8.Text = myReader.GetString(8).ToString()
            TextBox10.Text = myReader.GetString(9).ToString()

        End While

        sql.SQLCon.Close()



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


            Dim sex As String
            If RadioButton1.Checked Then
                sex = "Male"
            Else
                sex = "Female"
            End If


            If TextBox9.Text <> TextBox8.Text Then
                MessageBox.Show("Passwords are different")
            Else

                ' Try
                sql.SQLCon.Open()
                sql.SQLCmd.CommandText = "update Student set Usn='" & TextBox5.Text & "' and Name= ' " & TextBox1.Text & " ' and Email_Id= '" & TextBox6.Text & "' and sex= '" & sex & "' and Address= ' " & TextBox3.Text & " ' and Sem= ' " & TextBox2.Text & " ' and Mobile_no=' " & TextBox7.Text & " ' and Username=' " & TextBox4.Text & " ' and Password=' " & TextBox8.Text & " ' and College_Id='" & TextBox10.Text & "' where Usn='" & Form2.Label3.Text & "' "

                sql.SQLCmd.ExecuteNonQuery()
                'MessageBox.Show("successful")


                ' Catch ex As Exception
                '    MessageBox.Show(ex.Message())
                '   sql.SQLCon.Close()

                '  End Try

                sql.SQLCon.Close()
            End If
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub ValidateEmail()

        'Set Up Reg Exp Pattern To Allow Most Characters, And No Special Characters
        Dim reEmail As Regex = New Regex("([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\." + ")|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})", _
        RegexOptions.IgnoreCase _
        Or RegexOptions.CultureInvariant _
        Or RegexOptions.IgnorePatternWhitespace _
        Or RegexOptions.Compiled _
        )

        Dim blnPossibleMatch As Boolean = reEmail.IsMatch(TextBox6.Text)
        Dim EmailValid As Boolean
        If blnPossibleMatch Then

            'Check If Entered Email Is In Correct Format
            If Not TextBox6.Text.Equals(reEmail.Match(TextBox6.Text).ToString) Then

                MessageBox.Show("Invalid Email Address!")

            Else

                EmailValid = True 'Email is Perfect

            End If

        Else 'Not A Match To Pattern

            EmailValid = False 'Set Boolean Variable To False
            MessageBox.Show("Invalid Email Address!") 'Inform User

            TextBox6.Clear() 'Clear Textbox

            TextBox6.Focus() 'Set Focus To TextBox

        End If

    End Sub

    Private Sub txtEmail_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.LostFocus

        ValidateEmail() 'Check Email Validity

    End Sub



End Class