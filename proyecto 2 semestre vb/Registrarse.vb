Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports AForge.Video.DirectShow
Imports AForge.Video
Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging

Namespace Proyecto_final_2ndo_semestre_c_sharp
    Partial Public Class Registrarse
        Inherits Form

        Public Sub New()
            InitializeComponent()
            FormBorderStyle = FormBorderStyle.None
        End Sub

        Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
            Dim username As String = textUser.Text
            Dim password As String = textPassword.Text
            Dim confirmPassword As String = txtConfirmPassword.Text

            If username = Nothing OrElse password = Nothing OrElse confirmPassword = Nothing OrElse username = "" OrElse password = "" OrElse confirmPassword = " " OrElse username = " " OrElse password = " " OrElse confirmPassword = " " Then
                MessageBox.Show("NO PUEDE SER NULO")
                Return
            End If

            Try
                Usuario.AgregarUsuario(username, password, confirmPassword)
                MessageBox.Show("Usuario registrado correctamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                textUser.Clear()
                textPassword.Clear()
                txtConfirmPassword.Clear()
            Catch ex As ArgumentException
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub linkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked
            Dim inicio_De_Sesion As New Inicio_de_sesion()
            inicio_De_Sesion.ShowDialog()
            Me.Hide()
        End Sub



        Private WithEvents label6 As Label
        Private WithEvents textPassword As TextBox
        Private WithEvents label5 As Label
        Private WithEvents textUser As TextBox
        Private WithEvents linkLabel1 As LinkLabel
        Private WithEvents button1 As Button
        Private WithEvents label4 As Label
        Private WithEvents txtConfirmPassword As TextBox

        Private Sub InitializeComponent()
            Me.label6 = New System.Windows.Forms.Label()
            Me.textPassword = New System.Windows.Forms.TextBox()
            Me.label5 = New System.Windows.Forms.Label()
            Me.textUser = New System.Windows.Forms.TextBox()
            Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
            Me.button1 = New System.Windows.Forms.Button()
            Me.label4 = New System.Windows.Forms.Label()
            Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
            Me.SuspendLayout()
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(282, 165)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(70, 13)
            Me.label6.TabIndex = 32
            Me.label6.Text = "PASSWORD"
            '
            'textPassword
            '
            Me.textPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(113, Byte), Integer))
            Me.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textPassword.Location = New System.Drawing.Point(285, 195)
            Me.textPassword.Name = "textPassword"
            Me.textPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.textPassword.Size = New System.Drawing.Size(240, 13)
            Me.textPassword.TabIndex = 31
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(282, 97)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(37, 13)
            Me.label5.TabIndex = 30
            Me.label5.Text = "USER"
            '
            'textUser
            '
            Me.textUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(113, Byte), Integer))
            Me.textUser.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textUser.Location = New System.Drawing.Point(285, 129)
            Me.textUser.Name = "textUser"
            Me.textUser.Size = New System.Drawing.Size(240, 13)
            Me.textUser.TabIndex = 29
            '
            'linkLabel1
            '
            Me.linkLabel1.AutoSize = True
            Me.linkLabel1.Location = New System.Drawing.Point(276, 340)
            Me.linkLabel1.Name = "linkLabel1"
            Me.linkLabel1.Size = New System.Drawing.Size(43, 13)
            Me.linkLabel1.TabIndex = 28
            Me.linkLabel1.TabStop = True
            Me.linkLabel1.Text = "LOG IN"
            '
            'button1
            '
            Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button1.Location = New System.Drawing.Point(413, 328)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(79, 25)
            Me.button1.TabIndex = 27
            Me.button1.Text = "Register"
            Me.button1.UseVisualStyleBackColor = True
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(282, 251)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(122, 13)
            Me.label4.TabIndex = 26
            Me.label4.Text = "CONFIRM PASSWORD"
            '
            'txtConfirmPassword
            '
            Me.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(113, Byte), Integer))
            Me.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtConfirmPassword.Location = New System.Drawing.Point(285, 281)
            Me.txtConfirmPassword.Name = "txtConfirmPassword"
            Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtConfirmPassword.Size = New System.Drawing.Size(240, 13)
            Me.txtConfirmPassword.TabIndex = 25
            '
            'Registrarse
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(800, 450)
            Me.Controls.Add(Me.label6)
            Me.Controls.Add(Me.textPassword)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.textUser)
            Me.Controls.Add(Me.linkLabel1)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.txtConfirmPassword)
            Me.Name = "Registrarse"
            Me.Text = "Registrarse"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private Sub button1_Click_1(sender As Object, e As EventArgs) Handles button1.Click

        End Sub
    End Class
End Namespace
