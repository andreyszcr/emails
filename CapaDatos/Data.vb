
Imports System.IO
Imports System.Xml
Imports System.Data


Public Class Data

    Dim ruta As String = "C:\Users\andre\source\repos\DatosPersonales\ArcihvosTxt\DatosPersonales.txt"
    Dim escritura As StreamWriter
    Dim tabla As DataSet



    Public Property table As DataTable
        Get
            Return tabla.Tables(0)
        End Get
        Set(value As DataTable)
            ''''''
        End Set
    End Property






    'metodo para hacer txt
    Public Sub ArchivoTXT(ByVal cedula As Integer, ByVal nombre As String, ByVal apellido As String, ByVal provincia As String, ByVal correo As String, ByVal consumo As Integer)
        'validacion de datos 
        'Try

        'instanacia colocando el nombre del archivo
        escritura = New StreamWriter(ruta, True)


        escritura.WriteLine(cedula.ToString + ";" + nombre.ToString + ";" + apellido.ToString + ";" + correo.ToString + ";" + consumo.ToString)



        escritura.WriteLine("\n")



            'Catch ex As Exception
            '    ' libreria de windows form 

            '    ' throw new exception 

            '    Throw New Exception(ex.Message + "Error de datos guaradados")

            'End Try

            escritura.Close()
    End Sub

    Sub tablaDatos()

    End Sub
End Class
