Imports System
Imports System.Windows.Forms

Namespace Proyecto_final_2ndo_semestre_c_sharp
    Friend Module Program
        <STAThread>
        Public Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Registrarse())
        End Sub
    End Module
End Namespace
