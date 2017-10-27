
Imports System.Text.RegularExpressions 'regular expression namespace
Public Class Form22


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

        If String.IsNullOrEmpty(TextBox1.Text.ToString()) Then
            MessageBox.Show("Contains empty value or null value")

        End If

        ' If TextBox1.Text.Length() < 3 Then
        'MessageBox.Show("invalid name")
        'TextBox1.Focus()
        'End If
    End Sub














    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If String.IsNullOrEmpty(TextBox3.Text.ToString()) Then
            MessageBox.Show("Contains empty value or null value")

        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If String.IsNullOrEmpty(TextBox2.Text.ToString()) Then
            MessageBox.Show("Contains empty value or null value")

        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If String.IsNullOrEmpty(TextBox4.Text.ToString()) Then
            MessageBox.Show("Contains empty value or null value")

        End If
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        If String.IsNullOrEmpty(TextBox7.Text.ToString()) Then
            MessageBox.Show("Contains empty value or null value")

        End If
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        If String.IsNullOrEmpty(TextBox8.Text.ToString()) Then
            MessageBox.Show("Contains empty value or null value")

        End If
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        If String.IsNullOrEmpty(TextBox9.Text.ToString()) Then
            MessageBox.Show("Contains empty value or null value")

        End If

        If TextBox9.Text = TextBox8.Text Then

        Else
            MessageBox.Show("Passwords are different")
        End If
    End Sub
End Class