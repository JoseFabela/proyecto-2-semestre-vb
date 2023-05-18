Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Proyecto_final_2ndo_semestre_c_sharp
    Public Class Usuario
        'The get and set keywords indicate that this property has both a getter and a setter, allowing read and write access to the value.
        Public Property Username As String 'This line defines a public property named Username of type string.

        'Like the previous property, it has both a getter and a setter.
        Public Property Password As String 'This line defines a public property named Password of type string.

        'It also has both a getter and a setter.
        Public Property ConfirmPassword As String 'This line defines a public property named ConfirmPassword of type string.

        ' Lista estática para almacenar los usuarios registrados
        Private Shared usuariosRegistrados As New List(Of Usuario)()
        'List<Usuario> indicates that it is a generic list that can store objects of the Usuario class or any derived class.
        'usuariosRegistrados is the name of the list variable.
        'new List<Usuario>() creates a new instance of the List<Usuario> class and initializes it as an empty list.

        'This method takes three parameters: username, password, and confirmPassword. It checks if the provided username is already registered in the usuariosRegistrados
        'list. If it is, it throws an ArgumentException with an error message.
        Public Shared Sub AgregarUsuario(username As String, password As String, confirmPassword As String)
            'This code block checks if the password and confirmPassword parameters match. If they don't, it throws an ArgumentException with an error message.

            ' Verificar si el usuario ya está registrado
            If usuariosRegistrados.Any(Function(u) u.Username = username) Then
                Throw New ArgumentException("El nombre de usuario ya está en uso.", NameOf(username))
            End If

            ' Verificar si la contraseña y la confirmación de contraseña coinciden
            If password <> confirmPassword Then
                Throw New ArgumentException("La contraseña y la confirmación de contraseña no coinciden.", NameOf(confirmPassword))
            End If

            ' Crear un nuevo usuario y agregarlo a la lista
            'This section creates a new Usuario object using the provided username and password values, and then adds it to the usuariosRegistrados list.
            Dim nuevoUsuario As New Usuario With {
                .Username = username,
                .Password = password
            }
            usuariosRegistrados.Add(nuevoUsuario)

            ' Si se seleccionó "recordar usuario", guardar la información en el archivo
            'This part saves the user information to a file. It specifies the file path as C:\Users\junio\Downloads\usuarios.txt and uses a StreamWriter
            'to write the username and password values to the file.
            Dim path As String = "C:\Users\junio\Downloads\usuarios.txt"

            Using writer As New StreamWriter(path, True)
                writer.WriteLine($"{username},{password}")
            End Using
        End Sub

        'This method takes two parameters: username and password. It searches for a user in the usuariosRegistrados list whose Username and Password properties
        'match the provided values using the FirstOrDefault LINQ method. The found Usuario object is assigned to the usuario variable.
        Public Shared Function BuscarUsuario(username As String, password As String) As Usuario
            ' Buscar el usuario con el nombre de usuario y contraseña correspondientes
            Dim usuario As Usuario = usuariosRegistrados.FirstOrDefault(Function(u) u.Username = username AndAlso u.Password = password)

            'If the usuario variable is still null after searching in the usuariosRegistrados list, this code block is executed.
            'It reads the contents of the file at the path "C:\Users\junio\Downloads\usuarios.txt" and iterates over each line.
            'It splits each line by a comma and checks if the first field (campos[0]) matches the provided username and the second field (campos[1]) matches the
            'provided password. If a match is found, a new Usuario object is created and assigned to the usuario variable, and the loop is exited using Exit For.
            If usuario Is Nothing Then
                Dim path As String = "C:\Users\junio\Downloads\usuarios.txt"
                If File.Exists(path) Then
                    Dim usuarios As String() = File.ReadAllLines(path)

                    For Each usuarioString As String In usuarios
                        Dim campos As String() = usuarioString.Split(","c)
                        If campos(0) = username AndAlso campos(1) = password Then
                            usuario = New Usuario With {
                                .Username = username,
                                .Password = password
                            }
                            Exit For
                        End If
                    Next
                End If
            End If

            Return usuario
        End Function

        Public Interface ICerrarSesion
            Sub CerrarSesion()
        End Interface
        'This code defines the ICerrarSesion interface with a single method CerrarSesion().
        'Interfaces in C# are used to define contracts that specify the behavior that implementing classes must adhere to.
        'In this case, the interface specifies that any class implementing ICerrarSesion must provide an implementation for the CerrarSesion() method.
    End Class
End Namespace
