Imports Accord.Statistics.Kernels
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports Python.Runtime
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Dynamic
Imports System.IO
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Proyecto_final_2ndo_semestre_c_sharp
    Partial Public Class Inicio_de_sesion
        Inherits Form
        Private intentosFallidos As Integer = 0
        Private usuario As String
        Private dispositivos As FilterInfoCollection
        Private fuenteVideo As VideoCaptureDevice
        Private fotogramaActual As Bitmap
        Private Const MaximoIntentosFallidos As Integer = 3

        Public Sub New()
            InitializeComponent()

            Me.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
            Me.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom

            dispositivos = New FilterInfoCollection(FilterCategory.VideoInputDevice)
            fuenteVideo = New VideoCaptureDevice(dispositivos(0).MonikerString)
            FormBorderStyle = FormBorderStyle.None
        End Sub



        Private Sub LblRegistrarse_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

        End Sub

        Private Sub CapturarFrame(sender As Object, eventArgs As NewFrameEventArgs)
            fotogramaActual = CType(eventArgs.Frame.Clone(), Bitmap)
        End Sub



        Private videoCaptureDevice As VideoCaptureDevice
        Private isScanned As Boolean = False


        Private Sub TomarFoto(username As String)
            fuenteVideo.Start()
            Thread.Sleep(5000)

            Dim fotograma As Bitmap = CType(fotogramaActual.Clone(), Bitmap)
            fuenteVideo.Stop()

            If fotogramaActual IsNot Nothing Then
                Dim fecha As String = DateTime.Now.ToString("yyyyMMddHHmmss")
                Dim nombreArchivo As String = $"Foto_{username}_{fecha}.jpg"
                Dim rutaEscritorio As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                Dim rutaCompleta As String = Path.Combine(rutaEscritorio, nombreArchivo)

                fotogramaActual.Save(rutaCompleta, System.Drawing.Imaging.ImageFormat.Jpeg)
            End If
        End Sub

        Private Sub FormInicioSesion_FormClosing(sender As Object, e As FormClosingEventArgs)
            If fuenteVideo IsNot Nothing AndAlso fuenteVideo.IsRunning Then
                fuenteVideo.SignalToStop()
                fuenteVideo.WaitForStop()
                fuenteVideo = Nothing
            End If
        End Sub

        Private Sub btnSignOff_Click(sender As Object, e As EventArgs)
            Application.Exit()
        End Sub

        Private WithEvents btnSignOff As Button
        Private WithEvents BtnLogIn As Button
        Private WithEvents LblRegistrarse As LinkLabel
        Private WithEvents pictureBox1 As PictureBox
        Private WithEvents label3 As Label
        Private WithEvents label2 As Label
        Private WithEvents txtPassword As TextBox
        Private WithEvents label1 As Label
        Private WithEvents txtUser As TextBox

        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio_de_sesion))
            Me.btnSignOff = New System.Windows.Forms.Button()
            Me.BtnLogIn = New System.Windows.Forms.Button()
            Me.LblRegistrarse = New System.Windows.Forms.LinkLabel()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.txtPassword = New System.Windows.Forms.TextBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.txtUser = New System.Windows.Forms.TextBox()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnSignOff
            '
            Me.btnSignOff.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSignOff.Location = New System.Drawing.Point(704, 12)
            Me.btnSignOff.Name = "btnSignOff"
            Me.btnSignOff.Size = New System.Drawing.Size(75, 27)
            Me.btnSignOff.TabIndex = 20
            Me.btnSignOff.Text = "Sign Off"
            Me.btnSignOff.UseVisualStyleBackColor = True
            '
            'BtnLogIn
            '
            Me.BtnLogIn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnLogIn.Location = New System.Drawing.Point(644, 307)
            Me.BtnLogIn.Name = "BtnLogIn"
            Me.BtnLogIn.Size = New System.Drawing.Size(66, 23)
            Me.BtnLogIn.TabIndex = 18
            Me.BtnLogIn.Text = "LOG IN"
            Me.BtnLogIn.UseVisualStyleBackColor = True
            '
            'LblRegistrarse
            '
            Me.LblRegistrarse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblRegistrarse.Location = New System.Drawing.Point(457, 343)
            Me.LblRegistrarse.Name = "LblRegistrarse"
            Me.LblRegistrarse.Size = New System.Drawing.Size(187, 24)
            Me.LblRegistrarse.TabIndex = 17
            Me.LblRegistrarse.TabStop = True
            Me.LblRegistrarse.Text = "Registrarse"
            Me.LblRegistrarse.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'pictureBox1
            '
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(12, 12)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(340, 342)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox1.TabIndex = 16
            Me.pictureBox1.TabStop = False
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("BankGothic Md BT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.SystemColors.Desktop
            Me.label3.Location = New System.Drawing.Point(482, 120)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(79, 17)
            Me.label3.TabIndex = 15
            Me.label3.Text = "LOG IN"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(428, 229)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(70, 13)
            Me.label2.TabIndex = 14
            Me.label2.Text = "PASSWORD"
            '
            'txtPassword
            '
            Me.txtPassword.Location = New System.Drawing.Point(431, 261)
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtPassword.Size = New System.Drawing.Size(240, 20)
            Me.txtPassword.TabIndex = 13
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(428, 161)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(40, 13)
            Me.label1.TabIndex = 12
            Me.label1.Text = "USER:"
            '
            'txtUser
            '
            Me.txtUser.Location = New System.Drawing.Point(431, 188)
            Me.txtUser.Name = "txtUser"
            Me.txtUser.Size = New System.Drawing.Size(240, 20)
            Me.txtUser.TabIndex = 11
            '
            'Inicio_de_sesion
            '
            Me.ClientSize = New System.Drawing.Size(791, 438)
            Me.Controls.Add(Me.btnSignOff)
            Me.Controls.Add(Me.BtnLogIn)
            Me.Controls.Add(Me.LblRegistrarse)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.txtPassword)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.txtUser)
            Me.Name = "Inicio_de_sesion"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private Sub Inicio_de_sesion_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim dispositivosVideo As FilterInfoCollection = New FilterInfoCollection(FilterCategory.VideoInputDevice)

            If dispositivosVideo.Count > 0 Then
                fuenteVideo = New VideoCaptureDevice(dispositivosVideo(0).MonikerString)
                AddHandler fuenteVideo.NewFrame, AddressOf CapturarFrame
            Else
                MessageBox.Show("No se encontraron dispositivos de captura de video.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Sub

        Private Sub BtnLogIn_Click_1(sender As Object, e As EventArgs) Handles BtnLogIn.Click
            ' It retrieves the entered username and password from the respective text boxes.
            Dim username As String = txtUser.Text
            Dim password As String = txtPassword.Text

            ' The Usuario.BuscarUsuario(username, password) method is called to find the user with the given username and password.

            ' Find the user with the given username
            Dim usuario As Usuario = Usuario.BuscarUsuario(username, password)

            If usuario Is Nothing Then
                MessageBox.Show("El usuario no existe o la contraseña es incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ' If no user is found or the password is incorrect, an error message is displayed, and the intentosFallidos variable is incremented.
                intentosFallidos += 1

                If intentosFallidos = MaximoIntentosFallidos Then
                    ' If the number of failed attempts reaches the maximum allowed (MaximoIntentosFallidos), the TomarFoto(username) method is called to take a photo.
                    TomarFoto(username)
                End If
                Return
            End If

            ' If a user is found and the password is correct, the code inside the else block is executed.
            ' Mostrar el formulario de inventario
            ' The inventory form (Form1) is displayed, and a message box is shown with the text "Que haremos el dia de hoy?" followed by the username.
            Dim inventoryForm As New Form1()
            inventoryForm.Show()
            MessageBox.Show("Que haremos el dia de hoy? " & username)

            ' The current form (Inicio_de_sesion) is hidden.
            Me.Hide()

        End Sub

        Private Sub LblRegistrarse_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblRegistrarse.LinkClicked
            Dim inicio As Registrarse
            inicio.ShowDialog()
        End Sub
    End Class
End Namespace
