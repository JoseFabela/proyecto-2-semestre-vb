<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.btnSignOff.Location = New System.Drawing.Point(295, 429)
        Me.btnSignOff.Name = "btnSignOff"
        Me.btnSignOff.Size = New System.Drawing.Size(75, 23)
        Me.btnSignOff.TabIndex = 33
        Me.btnSignOff.Text = "Sign Off"
        Me.btnSignOff.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(80, 103)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(66, 27)
        Me.button1.TabIndex = 32
        Me.button1.Text = "Take picture"
        Me.button1.UseVisualStyleBackColor = True
        '
        'btnModificarUsuario
        '
        Me.btnModificarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarUsuario.Location = New System.Drawing.Point(150, 103)
        Me.btnModificarUsuario.Name = "btnModificarUsuario"
        Me.btnModificarUsuario.Size = New System.Drawing.Size(66, 27)
        Me.btnModificarUsuario.TabIndex = 31
        Me.btnModificarUsuario.Text = "Add picture"
        Me.btnModificarUsuario.UseVisualStyleBackColor = True
        '
        'pictureBox1
        '
        Me.pictureBox1.Location = New System.Drawing.Point(80, 45)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(136, 52)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 30
        Me.pictureBox1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(80, 429)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 29
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Red
        Me.btnSave.Location = New System.Drawing.Point(659, 54)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnOpenArchieve
        '
        Me.btnOpenArchieve.BackColor = System.Drawing.Color.Red
        Me.btnOpenArchieve.Location = New System.Drawing.Point(772, 54)
        Me.btnOpenArchieve.Name = "btnOpenArchieve"
        Me.btnOpenArchieve.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenArchieve.TabIndex = 27
        Me.btnOpenArchieve.Text = "Open File"
        Me.btnOpenArchieve.UseVisualStyleBackColor = False
        '
        'dtgProduct
        '
        Me.dtgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgProduct.Location = New System.Drawing.Point(391, 121)
        Me.dtgProduct.Name = "dtgProduct"
        Me.dtgProduct.Size = New System.Drawing.Size(467, 331)
        Me.dtgProduct.TabIndex = 26
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.label3.Location = New System.Drawing.Point(82, 256)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(86, 13)
        Me.label3.TabIndex = 25
        Me.label3.Text = "Product Quantity"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.label2.Location = New System.Drawing.Point(82, 196)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(100, 13)
        Me.label2.TabIndex = 24
        Me.label2.Text = "Price of the product"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.label1.Location = New System.Drawing.Point(82, 145)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(73, 13)
        Me.label1.TabIndex = 23
        Me.label1.Text = "Product name"
        '
        'txtPrecioDelProducto
        '
        Me.txtPrecioDelProducto.Location = New System.Drawing.Point(150, 226)
        Me.txtPrecioDelProducto.Name = "txtPrecioDelProducto"
        Me.txtPrecioDelProducto.Size = New System.Drawing.Size(183, 20)
        Me.txtPrecioDelProducto.TabIndex = 22
        '
        'txtCantidadDelProducto
        '
        Me.txtCantidadDelProducto.Location = New System.Drawing.Point(150, 280)
        Me.txtCantidadDelProducto.Name = "txtCantidadDelProducto"
        Me.txtCantidadDelProducto.Size = New System.Drawing.Size(183, 20)
        Me.txtCantidadDelProducto.TabIndex = 21
        '
        'txtNombreDeProducto
        '
        Me.txtNombreDeProducto.Location = New System.Drawing.Point(150, 161)
        Me.txtNombreDeProducto.Name = "txtNombreDeProducto"
        Me.txtNombreDeProducto.Size = New System.Drawing.Size(183, 20)
        Me.txtNombreDeProducto.TabIndex = 20
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEdit.Location = New System.Drawing.Point(511, 54)
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
        Me.btnDelete.Location = New System.Drawing.Point(402, 54)
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
        Me.btnAdd.Location = New System.Drawing.Point(295, 54)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 497)
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
        Me.Text = "Form1"
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
End Class
