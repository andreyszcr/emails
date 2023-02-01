Imports System.IO
Imports System.Windows.Forms


Public Class Escritura
    '*******************************************************
    Public Sub RegistroClientes(identificacion As String, sfdArchivo As SaveFileDialog, ruta As String)


        sfdArchivo = New SaveFileDialog()

        'formato del archivo txt
        sfdArchivo.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        '*********************************
        If sfdArchivo.ShowDialog = DialogResult.OK Then
            '---------------------------------------------------
            'el nombre de la ruta que voy a registrar los datos 
            ruta = sfdArchivo.FileName


            '****************************************************************************
            My.Computer.FileSystem.WriteAllText(sfdArchivo.FileName, identificacion, True)


        End If
    End Sub
    '*******************************************************
    Public Sub RegistroProductos()

    End Sub
End Class
