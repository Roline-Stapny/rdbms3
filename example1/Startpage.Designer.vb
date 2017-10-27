<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Startpage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Startpage))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(264, 214)
        Me.Button2.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(305, 62)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Login"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe Print", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(264, 139)
        Me.Button1.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(314, 59)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Register"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(211, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 35)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Welcome To NMAMIT Fest Registration "
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(264, 287)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(305, 53)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Register your college"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Startpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 35.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(807, 369)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe Print", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.Name = "Startpage"
        Me.Text = "Startpage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
