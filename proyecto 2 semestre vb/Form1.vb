Imports Castle.DynamicProxy.Generators.Emitters.SimpleAST
Imports Keras
Imports Newtonsoft.Json.Linq
Imports OpenTK
Imports OpenTK.Audio.OpenAL
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Xml.Linq
Imports Proyecto_final_2ndo_semestre_c_sharp.Usuario
Imports System.Net.WebRequestMethods
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports proyecto_2_semestre_vb.Proyecto_final_2ndo_semestre_c_sharp.Usuario

Namespace Proyecto_final_2ndo_semestre_c_sharp
    Partial Public Class Form1
        Inherits Form
        Implements ICerrarSesion
        Private listaProductos As New List(Of Producto)() 'The list of the products

        Public Sub New()
            'Add the columns To the Table
            InitializeComponent()
            dtgProduct.Columns.Add("Name", "Name")
            dtgProduct.Columns.Add("Price", "Price")
            dtgProduct.Columns.Add("Quantity", "Quantity")
            FormBorderStyle = FormBorderStyle.None 'This line sets the form's border style to None, which means that the form will have no border.
            Me.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage 'This line sets the PictureBox control named pictureBox1 to display the image in the center.
            'If the image is smaller than the PictureBox size, it will be displayed in the center of the PictureBox.

            Me.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom 'This line sets the PictureBox control named pictureBox1 to display the image by zooming it to fit
            'within the PictureBox bounds.The aspect ratio of the image will be preserved, and the image will be resized to completely fit within the PictureBox.

            dtgProduct.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells ' Automatically adjust the size of the first column based on the content
            dtgProduct.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill 'Automatically adjusts the size of the second column to fill the remaining space
            dtgProduct.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill ' Automatically adjust the size of the third column to fill the remaining space

            dtgProduct.DefaultCellStyle.BackColor = Color.Blue ' Change the background color of the cells
            dtgProduct.DefaultCellStyle.ForeColor = Color.White ' Change the text color of the cells
            dtgProduct.AlternatingRowsDefaultCellStyle.BackColor = Color.Black ' Change the background color of alternate rows

            dtgProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.Black ' Change the background color of the column headers
            dtgProduct.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black ' Change the text color of the column headers
            dtgProduct.ColumnHeadersDefaultCellStyle.Font = New Font(dtgProduct.Font, FontStyle.Bold) ' Change the font style of the column headers

            btnAdd.BackColor = Color.ForestGreen ' Cambia el color de fondo a azul
            btnDelete.BackColor = Color.ForestGreen
            btnEdit.BackColor = Color.ForestGreen
            btnSave.BackColor = Color.DarkRed ' Cambia el color de fondo a azul
            btnOpenArchieve.BackColor = Color.DarkRed
            btnSignOff.BackColor = Color.DarkMagenta
            btnExit.BackColor = Color.DarkCyan ' Cambia el color de fondo a azul
            btnModificarUsuario.BackColor = Color.DarkKhaki
            button1.BackColor = Color.DarkKhaki

            btnAdd.FlatStyle = FlatStyle.Flat ' Set a flat border style
            btnAdd.FlatAppearance.BorderSize = 2 ' Set the border width
            btnAdd.FlatAppearance.BorderColor = Color.Black ' Set the border color
            btnDelete.FlatStyle = FlatStyle.Flat ' Set a flat border style
            btnDelete.FlatAppearance.BorderSize = 2 ' Set the border width
            btnDelete.FlatAppearance.BorderColor = Color.Black ' Set the border color
            btnEdit.FlatStyle = FlatStyle.Flat ' Set a flat border style
            btnEdit.FlatAppearance.BorderSize = 2 ' Set the border width
            btnEdit.FlatAppearance.BorderColor = Color.Black ' Set the border color
            btnSave.FlatStyle = FlatStyle.Flat ' Set a flat border style
            btnSave.FlatAppearance.BorderSize = 2 ' Set the border width
            btnSave.FlatAppearance.BorderColor = Color.Black ' Set the border color
            btnOpenArchieve.FlatStyle = FlatStyle.Flat ' Set a flat border style
            btnOpenArchieve.FlatAppearance.BorderSize = 2 ' Set the border width
            btnOpenArchieve.FlatAppearance.BorderColor = Color.Black ' Set the border color
            btnSignOff.FlatStyle = FlatStyle.Flat ' Set a flat border style
            btnSignOff.FlatAppearance.BorderSize = 2 ' Set the border width
            btnSignOff.FlatAppearance.BorderColor = Color.Black ' Set the border color
            btnExit.FlatStyle = FlatStyle.Flat ' Set a flat border style
            btnExit.FlatAppearance.BorderSize = 2 ' Set the border width
            btnExit.FlatAppearance.BorderColor = Color.Black ' Set the border color
            btnModificarUsuario.FlatStyle = FlatStyle.Flat ' Set a flat border style
            btnModificarUsuario.FlatAppearance.BorderSize = 2 ' Set the border width
            btnModificarUsuario.FlatAppearance.BorderColor = Color.Black ' Set the border color
            button1.FlatStyle = FlatStyle.Flat ' Set a flat border style
            button1.FlatAppearance.BorderSize = 2 ' Set the border width
            button1.FlatAppearance.BorderColor = Color.Black ' Set the border color
        End Sub
        Private Sub pictureBox1_Paint(sender As Object, e As PaintEventArgs)
            Dim graphicsPath As New GraphicsPath()
            graphicsPath.AddEllipse(0, 0, pictureBox1.Width - 1, pictureBox1.Height - 1)
            pictureBox1.Region = New Region(graphicsPath)
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs)
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            AddHandler pictureBox1.Paint, AddressOf pictureBox1_Paint
        End Sub



        Private Sub InitializeComponent()
            Me.btnSignOff = New System.Windows.Forms.Button()
            Me.button1 = New System.Windows.Forms.Button()
            Me.btnModificarUsuario = New System.Windows.Forms.Button()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.btnExit = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnOpenArchieve = New System.Windows.Forms.Button()
            Me.dtgProduct = New System.Windows.Forms.DataGridView()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.txtPrecioDelProducto = New System.Windows.Forms.TextBox()
            Me.txtCantidadDelProducto = New System.Windows.Forms.TextBox()
            Me.txtNombreDeProducto = New System.Windows.Forms.TextBox()
            Me.btnEdit = New System.Windows.Forms.Button()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnAdd = New System.Windows.Forms.Button()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtgProduct, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnSignOff
            '
            Me.btnSignOff.Location = New System.Drawing.Point(219, 383)
            Me.btnSignOff.Name = "btnSignOff"
            Me.btnSignOff.Size = New System.Drawing.Size(75, 23)
            Me.btnSignOff.TabIndex = 33
            Me.btnSignOff.Text = "Sign Off"
            Me.btnSignOff.UseVisualStyleBackColor = True
            '
            'button1
            '
            Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button1.Location = New System.Drawing.Point(4, 57)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(66, 27)
            Me.button1.TabIndex = 32
            Me.button1.Text = "Take picture"
            Me.button1.UseVisualStyleBackColor = True
            '
            'btnModificarUsuario
            '
            Me.btnModificarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificarUsuario.Location = New System.Drawing.Point(74, 57)
            Me.btnModificarUsuario.Name = "btnModificarUsuario"
            Me.btnModificarUsuario.Size = New System.Drawing.Size(66, 27)
            Me.btnModificarUsuario.TabIndex = 31
            Me.btnModificarUsuario.Text = "Add picture"
            Me.btnModificarUsuario.UseVisualStyleBackColor = True
            '
            'pictureBox1
            '
            Me.pictureBox1.Location = New System.Drawing.Point(4, -1)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(136, 52)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pictureBox1.TabIndex = 30
            Me.pictureBox1.TabStop = False
            '
            'btnExit
            '
            Me.btnExit.Location = New System.Drawing.Point(4, 383)
            Me.btnExit.Name = "btnExit"
            Me.btnExit.Size = New System.Drawing.Size(75, 23)
            Me.btnExit.TabIndex = 29
            Me.btnExit.Text = "Exit"
            Me.btnExit.UseVisualStyleBackColor = True
            '
            'btnSave
            '
            Me.btnSave.BackColor = System.Drawing.Color.Red
            Me.btnSave.Location = New System.Drawing.Point(583, 8)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(75, 23)
            Me.btnSave.TabIndex = 28
            Me.btnSave.Text = "Save"
            Me.btnSave.UseVisualStyleBackColor = False
            '
            'btnOpenArchieve
            '
            Me.btnOpenArchieve.BackColor = System.Drawing.Color.Red
            Me.btnOpenArchieve.Location = New System.Drawing.Point(696, 8)
            Me.btnOpenArchieve.Name = "btnOpenArchieve"
            Me.btnOpenArchieve.Size = New System.Drawing.Size(75, 23)
            Me.btnOpenArchieve.TabIndex = 27
            Me.btnOpenArchieve.Text = "Open File"
            Me.btnOpenArchieve.UseVisualStyleBackColor = False
            '
            'dtgProduct
            '
            Me.dtgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dtgProduct.Location = New System.Drawing.Point(315, 75)
            Me.dtgProduct.Name = "dtgProduct"
            Me.dtgProduct.Size = New System.Drawing.Size(467, 331)
            Me.dtgProduct.TabIndex = 26
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.BackColor = System.Drawing.SystemColors.MenuHighlight
            Me.label3.Location = New System.Drawing.Point(6, 210)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(86, 13)
            Me.label3.TabIndex = 25
            Me.label3.Text = "Product Quantity"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.BackColor = System.Drawing.SystemColors.MenuHighlight
            Me.label2.Location = New System.Drawing.Point(6, 150)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(100, 13)
            Me.label2.TabIndex = 24
            Me.label2.Text = "Price of the product"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.BackColor = System.Drawing.SystemColors.MenuHighlight
            Me.label1.Location = New System.Drawing.Point(6, 99)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(73, 13)
            Me.label1.TabIndex = 23
            Me.label1.Text = "Product name"
            '
            'txtPrecioDelProducto
            '
            Me.txtPrecioDelProducto.Location = New System.Drawing.Point(74, 180)
            Me.txtPrecioDelProducto.Name = "txtPrecioDelProducto"
            Me.txtPrecioDelProducto.Size = New System.Drawing.Size(183, 20)
            Me.txtPrecioDelProducto.TabIndex = 22
            '
            'txtCantidadDelProducto
            '
            Me.txtCantidadDelProducto.Location = New System.Drawing.Point(74, 234)
            Me.txtCantidadDelProducto.Name = "txtCantidadDelProducto"
            Me.txtCantidadDelProducto.Size = New System.Drawing.Size(183, 20)
            Me.txtCantidadDelProducto.TabIndex = 21
            '
            'txtNombreDeProducto
            '
            Me.txtNombreDeProducto.Location = New System.Drawing.Point(74, 115)
            Me.txtNombreDeProducto.Name = "txtNombreDeProducto"
            Me.txtNombreDeProducto.Size = New System.Drawing.Size(183, 20)
            Me.txtNombreDeProducto.TabIndex = 20
            '
            'btnEdit
            '
            Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
            Me.btnEdit.Location = New System.Drawing.Point(435, 8)
            Me.btnEdit.Name = "btnEdit"
            Me.btnEdit.Size = New System.Drawing.Size(75, 23)
            Me.btnEdit.TabIndex = 19
            Me.btnEdit.Text = "Edit"
            Me.btnEdit.UseVisualStyleBackColor = False
            '
            'btnDelete
            '
            Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
            Me.btnDelete.Location = New System.Drawing.Point(326, 8)
            Me.btnDelete.Name = "btnDelete"
            Me.btnDelete.Size = New System.Drawing.Size(75, 23)
            Me.btnDelete.TabIndex = 18
            Me.btnDelete.Text = "Delete"
            Me.btnDelete.UseVisualStyleBackColor = False
            '
            'btnAdd
            '
            Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
            Me.btnAdd.Location = New System.Drawing.Point(219, 8)
            Me.btnAdd.Name = "btnAdd"
            Me.btnAdd.Size = New System.Drawing.Size(75, 23)
            Me.btnAdd.TabIndex = 17
            Me.btnAdd.Text = "Add"
            Me.btnAdd.UseVisualStyleBackColor = False
            '
            'Form1
            '
            Me.ClientSize = New System.Drawing.Size(817, 452)
            Me.Controls.Add(Me.btnSignOff)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.btnModificarUsuario)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.btnExit)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnOpenArchieve)
            Me.Controls.Add(Me.dtgProduct)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.txtPrecioDelProducto)
            Me.Controls.Add(Me.txtCantidadDelProducto)
            Me.Controls.Add(Me.txtNombreDeProducto)
            Me.Controls.Add(Me.btnEdit)
            Me.Controls.Add(Me.btnDelete)
            Me.Controls.Add(Me.btnAdd)
            Me.Name = "Form1"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtgProduct, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private WithEvents btnSignOff As Button
        Private WithEvents button1 As Button
        Private WithEvents btnModificarUsuario As Button
        Private WithEvents pictureBox1 As PictureBox
        Private WithEvents btnExit As Button
        Private WithEvents btnSave As Button
        Private WithEvents btnOpenArchieve As Button
        Private WithEvents dtgProduct As DataGridView
        Private WithEvents label3 As Label
        Private WithEvents label2 As Label
        Private WithEvents label1 As Label
        Private WithEvents txtPrecioDelProducto As TextBox
        Private WithEvents txtCantidadDelProducto As TextBox
        Private WithEvents txtNombreDeProducto As TextBox
        Private WithEvents btnEdit As Button
        Private WithEvents btnDelete As Button
        Private WithEvents btnAdd As Button
        Public Class Producto
            Public Property Name As String
            Public Property Quantity As Integer
            Public Property Price As Double

            Public Sub New(name As String, price As Double, quantity As Integer)
                Me.Name = name
                Me.Quantity = quantity
                Me.Price = price
            End Sub
        End Class

        Private Sub UpdateTableOfproducts()
            dtgProduct.Rows.Clear()

            For Each p As Producto In listaProductos
                dtgProduct.Rows.Add(p.Name, p.Price, p.Quantity)
            Next
        End Sub
        Private Sub btnDelete_Click(sender As Object, e As EventArgs)
            Dim indiceSeleccionado As Integer = dtgProduct.CurrentRow.Index

            If dtgProduct.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a row to delete.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If MessageBox.Show("Are you sure you want to delete the selected row?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                listaProductos.RemoveAt(indiceSeleccionado)
            Else
                Return
            End If

            UpdateTableOfproducts()
        End Sub

        Private Sub btnEdit_Click(sender As Object, e As EventArgs)
            If dtgProduct.SelectedRows.Count = 1 Then
                ' Establecemos la propiedad ReadOnly del DataGridView en false
                dtgProduct.ReadOnly = True
            End If
        End Sub

        Private Sub dataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs)
            ' Establecemos la propiedad ReadOnly de las filas no seleccionadas en true
            For Each row As DataGridViewRow In dtgProduct.Rows
                If row.Index <> e.RowIndex Then
                    row.ReadOnly = True
                End If
            Next
        End Sub
        Private Sub btnOpenArchieve_Click(sender As Object, e As EventArgs)
            Dim openFileDialog1 As New OpenFileDialog()
            openFileDialog1.Filter = "Archivos TXT (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
            openFileDialog1.Title = "Selecciona un archivo CSV"

            If openFileDialog1.ShowDialog() = DialogResult.OK Then
                Try
                    Dim sr As New StreamReader(openFileDialog1.FileName)
                    Dim line As String = ""
                    Dim strArray As String()

                    line = sr.ReadLine()
                    While line IsNot Nothing
                        line = RemoveAccents(line)
                        strArray = line.Split(";"c)

                        If listaProductos.Any(Function(p) p.Name = strArray(0)) Then
                            MessageBox.Show($"El producto con el nombre {strArray(0)} ya ha sido agregado anteriormente.", "Error al agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Continue While
                        End If

                        Dim price As Double
                        Dim quantity As Integer

                        If Not Double.TryParse(strArray(1), NumberStyles.Float, CultureInfo.InvariantCulture, price) Then
                            MessageBox.Show("El formato del precio es incorrecto.")
                            Continue While
                        End If

                        If Not Integer.TryParse(strArray(2), quantity) Then
                            MessageBox.Show("El formato de la cantidad es incorrecto.")
                            Continue While
                        End If

                        Dim newProduct As New Producto(strArray(0), price, quantity)
                        listaProductos.Add(newProduct)
                    End While

                    sr.Close()
                    UpdateTableOfproducts()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End If
        End Sub

        Private Function RemoveAccents(input As String) As String
            Return New String(input _
        .Normalize(NormalizationForm.FormD) _
        .Where(Function(c) CharUnicodeInfo.GetUnicodeCategory(c) <> UnicodeCategory.NonSpacingMark) _
        .ToArray())
        End Function

        Private Sub btnSave_Click(sender As Object, e As EventArgs)
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "Archivos TXT (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
            saveFileDialog1.Title = "Guardar archivo CSV"
            saveFileDialog1.FileName = "nuevo_archivo.csv"

            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                Try
                    Using sw As New StreamWriter(saveFileDialog1.FileName)
                        For Each p As Producto In listaProductos
                            sw.WriteLine($"{p.Name};{p.Price};{p.Quantity}")
                        Next
                    End Using

                    MessageBox.Show("Archivo guardado correctamente.", "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error al guardar el archivo: " & ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Sub

        Private Sub btnExit_Click(sender As Object, e As EventArgs)
            Application.Exit()
            Me.Close()
        End Sub


        Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
            'Add the new product to the list of the products
            'We check if the txtNombreDeProducto, txtPrecioDelProducto, and txtCantidadDelProducto fields are empty using string.IsNullOrEmpty.
            'If any of them is empty, we show a warning message and return, preventing adding a product without complete information.
            If String.IsNullOrEmpty(txtNombreDeProducto.Text) OrElse String.IsNullOrEmpty(txtPrecioDelProducto.Text) OrElse String.IsNullOrEmpty(txtCantidadDelProducto.Text) Then
                MessageBox.Show("No hay información para agregar.", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Verificar si el producto ya existe en la lista
            Dim nombre As String = txtNombreDeProducto.Text
            'We check if the product already exists in the list using listaProductos.Any(Function(p) p.Name = name). If it already exists,
            'we show a warning message and return.
            If listaProductos.Any(Function(p) p.Name = nombre) Then
                MessageBox.Show("El producto ya existe en la lista.", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Convertir el precio y la cantidad
            Dim precio As Double
            Dim cantidad As Integer
            ' We convert the price and quantity entered in the text fields to the double and int data types, respectively.
            ' We use Double.TryParse and Integer.TryParse to check if the values are numeric and perform the conversion.
            ' If the format is invalid, we show an error message and return.
            If Not Double.TryParse(txtPrecioDelProducto.Text, precio) Then
                MessageBox.Show("El formato del precio es incorrecto")
                Return
            End If

            If Not Integer.TryParse(txtCantidadDelProducto.Text, cantidad) Then
                MessageBox.Show("El formato de la cantidad es incorrecto")
                Return
            End If

            ' Crear el nuevo producto y agregarlo a la lista
            ' We create a new Producto object with the entered name, price, and quantity, and add it to the listaProductos list.
            Dim newProduct As New Producto(nombre, precio, cantidad)
            listaProductos.Add(newProduct)

            ' We clear the input fields.
            txtNombreDeProducto.Clear()
            txtCantidadDelProducto.Clear()
            txtPrecioDelProducto.Clear()
            'We call the UpdateTableOfproducts method to update the product table and display the newly added product.
            UpdateTableOfproducts()

        End Sub

        Private Sub btnModificarUsuario_Click(sender As Object, e As EventArgs)
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Try
                    Dim rutaImagen As String = openFileDialog.FileName
                    pictureBox1.Image = Image.FromFile(rutaImagen)
                Catch ex As Exception
                    MessageBox.Show("Error al abrir la imagen: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Sub

        Private Sub button1_Click(sender As Object, e As EventArgs)
            Dim camara As New Camara()
            camara.ShowDialog()
        End Sub

        Public Sub CerrarSesion()
            ' Código para cerrar sesión
            ' ...

            ' Redirigir al formulario de inicio de sesión
            Dim formInicioSesion As New Inicio_de_sesion()
            formInicioSesion.Show()
            Me.Hide()
        End Sub


        Private Sub ICerrarSesion_CerrarSesion() Implements ICerrarSesion.CerrarSesion
            Throw New NotImplementedException()
        End Sub

        Private Sub btnModificarUsuario_Click_1(sender As Object, e As EventArgs) Handles btnModificarUsuario.Click

        End Sub

        Private Sub btnSignOff_Click_1(sender As Object, e As EventArgs) Handles btnSignOff.Click
            ' Llamar al método de la interfaz para cerrar sesión
            Dim cerrarSesion As ICerrarSesion = DirectCast(Me, ICerrarSesion)
            cerrarSesion.CerrarSesion()
        End Sub
    End Class
End Namespace