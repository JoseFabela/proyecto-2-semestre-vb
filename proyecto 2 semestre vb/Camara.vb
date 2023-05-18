Imports FaceRecognition
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.Drawing.Imaging
Imports System.Threading
Imports Timer = System.Windows.Forms.Timer

Namespace Proyecto_final_2ndo_semestre_c_sharp
    Partial Public Class Camara
        Inherits Form

        Public Delegate Sub FotoTomadaEventHandler(sender As Object, foto As Image)

        Public Event FotoTomada As FotoTomadaEventHandler

        Private videoDevices As FilterInfoCollection
        Private videoSource As VideoCaptureDevice
        Private fotogramaActual As Bitmap
        Private temporizador As Timer
        Private tiempoRestante As Integer = 5

        Public Sub New()
            InitializeComponent()
            Me.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
            Me.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            FormBorderStyle = FormBorderStyle.None

            videoDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)
            videoSource = New VideoCaptureDevice(videoDevices(0).MonikerString)
            AddHandler videoSource.NewFrame, AddressOf CapturarFrame

            temporizador = New Timer()
            temporizador.Interval = 5000 ' 5 segundos
            AddHandler temporizador.Tick, AddressOf TemporizadorTick
        End Sub

        Private Sub Camara_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            videoSource.Start()
            ActualizarTiempo()
        End Sub

        Private Sub ActualizarTiempo()
            labelTimer.Text = tiempoRestante.ToString()
        End Sub

        Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
            temporizador.Start()
        End Sub

        Private Sub videoSource_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
            pictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        End Sub



        Private Sub TemporizadorTick(sender As Object, e As EventArgs)
            videoSource.SignalToStop()
            videoSource.WaitForStop()
            TomarFoto()
            Me.Close()
        End Sub

        Private Sub TomarFoto()
            If fotogramaActual IsNot Nothing Then
                Dim rutaImagen As String = "C:\Users\junio\OneDrive\Imágenes\camara\Imagen.Png"
                fotogramaActual.Save(rutaImagen, System.Drawing.Imaging.ImageFormat.Png)
            End If
        End Sub

        Private Sub CapturarFrame(sender As Object, eventArgs As NewFrameEventArgs)
            fotogramaActual = DirectCast(eventArgs.Frame.Clone(), Bitmap)
            pictureBox1.Image = fotogramaActual
        End Sub

        Private WithEvents labelTimer As Label
        Private WithEvents label1 As Label
        Private WithEvents pictureBox1 As PictureBox
        Private WithEvents btnCapture As Button

        Private Sub InitializeComponent()
            Me.labelTimer = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.btnCapture = New System.Windows.Forms.Button()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'labelTimer
            '
            Me.labelTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelTimer.ForeColor = System.Drawing.Color.Snow
            Me.labelTimer.Location = New System.Drawing.Point(618, 96)
            Me.labelTimer.Name = "labelTimer"
            Me.labelTimer.Size = New System.Drawing.Size(161, 77)
            Me.labelTimer.TabIndex = 8
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.Snow
            Me.label1.Location = New System.Drawing.Point(618, 24)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(179, 46)
            Me.label1.TabIndex = 7
            Me.label1.Text = "THE PHOTO WILL BE TAKEN IN"
            '
            'pictureBox1
            '
            Me.pictureBox1.Location = New System.Drawing.Point(3, 12)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(609, 426)
            Me.pictureBox1.TabIndex = 6
            Me.pictureBox1.TabStop = False
            '
            'btnCapture
            '
            Me.btnCapture.Location = New System.Drawing.Point(646, 204)
            Me.btnCapture.Name = "btnCapture"
            Me.btnCapture.Size = New System.Drawing.Size(110, 23)
            Me.btnCapture.TabIndex = 5
            Me.btnCapture.Text = "CAPTURE"
            Me.btnCapture.UseVisualStyleBackColor = True
            '
            'Camara
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
            Me.ClientSize = New System.Drawing.Size(800, 450)
            Me.Controls.Add(Me.labelTimer)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.btnCapture)
            Me.Name = "Camara"
            Me.Text = "Camara"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
    End Class
End Namespace
