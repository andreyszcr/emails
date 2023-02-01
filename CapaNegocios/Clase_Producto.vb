Imports System.IO
Imports System.Windows.Forms

Public Class Clase_Producto

    'variables internas de trabajo

    Dim _producto As String
    Dim _cantidadProducto As Integer
    Dim _precioUnidad As Integer
    Dim _subtotal As Integer
    Dim _total As Double

#Region "Propiedades"

    Public Property Producto As String

        Get
            Return _producto
        End Get
        Set(value As String)
            _producto = value
        End Set
    End Property

    Public Property CantidadProducto As Integer

        Get
            Return _cantidadProducto
        End Get
        Set(value As Integer)
            _cantidadProducto = value
        End Set
    End Property


    Public Property PrecioUnidad As Integer

        Get
            Return _precioUnidad
        End Get
        Set(value As Integer)
            _precioUnidad = value
        End Set
    End Property

    Public Property SubTotal As Integer

        Get
            Return _subtotal
        End Get
        Set(value As Integer)
            _subtotal = value
        End Set
    End Property

    Public Property Total As Double

        Get
            Return _total
        End Get
        Set(value As Double)
            _total = value
        End Set
    End Property



#End Region

#Region "Métodos"

    Sub validarProducto()
        'validar producto

        If _producto.Trim.Length > 25 Then
            Throw New System.Exception("El nombre ingresado es incorrecto por favor intentelo de nuevo")
        ElseIf IsNumeric(_producto) Then
            Throw New System.Exception("El nombre NO puede contener números por favor intentelo de nuevo")
        ElseIf String.IsNullOrEmpty(_producto) Then
            Throw New System.Exception("El nombre NO puede quedar vacío")
        End If
    End Sub
    '*****************************************
    Sub validarCantidadProducto()
        'validar cantidad producto


        If Int32.Parse(_cantidadProducto.ToString.Length) < 1000000000 And Int32.Parse(_cantidadProducto.ToString.Length) > 10000000000 Then
            Throw New System.Exception("El Teléfono ingresado es incorrecto por favor intentelo de nuevo")
        ElseIf Not IsNumeric(_cantidadProducto) Then
            Throw New System.Exception("El telefono NO puede contener letras por favor intentelo de nuevo")
        ElseIf Int32.Parse(_cantidadProducto.ToString.Length) < 0 Then
            Throw New System.Exception("El telefono NO puede quedar en cero")
        End If

    End Sub
    '*****************************************
    Sub validarPrecioUnidad()
        'validar precio unidad

        If Int32.Parse(_precioUnidad.ToString.Length) > 1000000000 And Int32.Parse(_precioUnidad.ToString.Length) > 10000000000 Then
            Throw New System.Exception("El Teléfono ingresado es incorrecto por favor intentelo de nuevo")
        ElseIf Not IsNumeric(_precioUnidad) Then
            Throw New System.Exception("El telefono NO puede contener letras por favor intentelo de nuevo")
        ElseIf Int32.Parse(_precioUnidad.ToString.Length) < 0 Then
            Throw New System.Exception("El telefono NO puede quedar en cero")
        End If

    End Sub
    '*****************************************
    Sub validarSubTotal()
        'validar subtotal

        If Int32.Parse(_subtotal.ToString.Length) > 1000000000 And Int32.Parse(_subtotal.ToString.Length) > 10000000000 Then
            Throw New System.Exception("El Teléfono ingresado es incorrecto por favor intentelo de nuevo")
        ElseIf Not IsNumeric(_subtotal) Then
            Throw New System.Exception("El telefono NO puede contener letras por favor intentelo de nuevo")
        ElseIf Int32.Parse(_subtotal.ToString.Length) < 0 Then
            Throw New System.Exception("El telefono NO puede quedar en cero")
        End If


    End Sub
    '*****************************************

    Sub sumaPorUnidad()
        'efectuará la operación de suma de unidad por cantidad de producto que se adquiera

        _subtotal = _precioUnidad * _cantidadProducto


    End Sub

#End Region



End Class
