
Imports System.Text.RegularExpressions 'regular expression namespace
Public Class Registration
    Dim sql As New Sqlcontrol



    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If (Asc(e.KeyChar) >= 40 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True


        End If

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        If String.IsNullOrEmpty(TextBox5.Text.ToString()) Then
            MessageBox.Show("Contains empty value or null value")

        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If (Asc(e.KeyChar) >= 40 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If (Asc(e.KeyChar) >= 40 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If


    End Sub






    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        If String.IsNullOrEmpty(TextBox6.Text.ToString()) Then
            MessageBox.Show("Contains empty value or null value")

        End If
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








    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        'If not a matching character entered
        If Not Regex.Match(TextBox1.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then 'only numbers
            MessageBox.Show("Please enter alphabetic characters only!")
            TextBox1.Focus() 'return focus
            TextBox1.Clear() 'clears the textbox
        Else

            'everything is proper and gets copied into database


        End If

        
    End Sub


    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
      
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
     

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

                Try
                    sql.SQLCon.Open()
                    sql.SQLCmd.CommandText = "insert into Student values('" & TextBox5.Text & "',' " & TextBox1.Text & " ','" & TextBox6.Text & "','" & sex & "',' " & TextBox3.Text & " ',' " & TextBox2.Text & " ',' " & TextBox7.Text & " ',' " & TextBox4.Text & " ',' " & TextBox8.Text & " ','" & TextBox10.Text & "')"
                   
                    sql.SQLCmd.ExecuteNonQuery()
                    MessageBox.Show("successful")


                Catch ex As Exception
                    MessageBox.Show(ex.Message())
                    sql.SQLCon.Close()

                End Try

                sql.SQLCon.Close()
            End If
        End If


    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Startpage.Show()
    End Sub
End Class