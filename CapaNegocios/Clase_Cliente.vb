Imports CapaDatos
Imports System.Windows.Forms
Public Class Clase_Cliente
    'variables internas de trabajo

    Dim objetoEscritura As New Escritura
    Dim ruta As String
    Dim guardarCliente As SaveFileDialog


    Dim _nombre As String
    Dim _apellido1 As String
    Dim _apellido2 As String
    Dim _cedula As String
    Dim _telefono As Integer
    Dim _correo As String

#Region "Propiedades"
    Public Property rute As String
        Get
            Return ruta
        End Get
        Set(value As String)
            ruta = value
        End Set
    End Property
    '**********************************
    Public Property apellido As String
        Get
            Return _apellido1
        End Get
        Set(value As String)
            _apellido1 = value
        End Set
    End Property
    '***********************************
    Public Property apellido2 As String
        Get
            Return _apellido2
        End Get
        Set(value As String)
            _apellido2 = value
        End Set
    End Property


    Public Property Nombre As String

        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Cedula As String

        Get
            Return _cedula
        End Get
        Set(value As String)
            _cedula = value
        End Set
    End Property

    Public Property Telefono As Integer

        Get
            Return _telefono
        End Get
        Set(value As Integer)
            _telefono = value
        End Set
    End Property

    Public Property Correo As String

        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property



#End Region

#Region "Métodos"

    Sub ValidarNombre()

        'validar nombre
        If _nombre.Trim.Length > 15 Then
            Throw New System.Exception("El nombre ingresado es incorrecto por favor intentelo de nuevo")
        ElseIf IsNumeric(_nombre) Then
            Throw New System.Exception("El nombre NO puede contener números por favor intentelo de nuevo")
        ElseIf String.IsNullOrEmpty(_nombre) Then
            Throw New System.Exception("El nombre NO puede quedar vacío")
        End If
    End Sub
    '*****************************************
    Sub validarApellido()

        'validar apellido
        If _apellido1.Trim.Length > 20 Then
            Throw New System.Exception("El primer apellido ingresado es incorrecto por favor intentelo de nuevo")
        ElseIf IsNumeric(_apellido1) Then
            Throw New System.Exception("El primer apellido NO puede contener números por favor intentelo de nuevo")
        ElseIf String.IsNullOrEmpty(_apellido1) Then
            Throw New System.Exception("El primer apellido NO puede quedar vacío")
        End If
    End Sub
    '******************************************

    '******************************************
    Sub validarApellido2()
        'validar apellido
        If _apellido2.Trim.Length > 20 Then
            Throw New System.Exception("El segundo apellido ingresado es incorrecto por favor intentelo de nuevo")
        ElseIf IsNumeric(_apellido2) Then
            Throw New System.Exception("El segundo apellido NO puede contener números por favor intentelo de nuevo")
        ElseIf String.IsNullOrEmpty(_apellido2) Then
            Throw New System.Exception("El segundo apellido NO puede quedar vacío")
        End If
    End Sub
    '******************************************


    '*****************************************
    Sub validarCedula()
        'validar la cedula
        If _cedula.Trim.Length > 10 Then
            Throw New System.Exception("La cédula ingresada es incorrecta por favor intentelo de nuevo")
        ElseIf String.IsNullOrEmpty(_cedula) Then
            Throw New System.Exception("La cedula NO puede quedar vacío")
        End If
    End Sub
    '*****************************************

    '*****************************************
    Sub validarTelefono()
        'validar telefono

        If Int32.Parse(_telefono.ToString.Length) > 10 Then
            Throw New System.Exception("El Teléfono ingresado es incorrecto por favor intentelo de nuevo")
        ElseIf Not IsNumeric(_telefono) Then
            Throw New System.Exception("El telefono NO puede contener letras por favor intentelo de nuevo")
        ElseIf Int32.Parse(_telefono.ToString.Length) < 0 Then
            Throw New System.Exception("El telefono NO puede quedar en cero")
        End If
    End Sub
    '*****************************************


    '*****************************************
    Sub validarCorreo()

        'validar correo

        If _correo.Trim.Length > 50 Then
            Throw New System.Exception("El correo NO puede contener tantos caracteres por favor intentelo de nuevo")
        ElseIf Not (_correo.Contains("@")) Then
            Throw New System.Exception("El correo electrónico NO existe debe contener el @")
        ElseIf String.IsNullOrEmpty(_correo) Then
            Throw New System.Exception("El correo NO puede quedar vacío")
        End If

    End Sub

    '*****************************************




    Sub registrar()
        objetoEscritura.RegistroClientes(_cedula, guardarCliente, ruta)
    End Sub



#End Region




End Class
