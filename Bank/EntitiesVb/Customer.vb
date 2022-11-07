Public Class Customer
    Private _name As String
    Private _dni As Integer
    Private _birthDay As Date
    Public Sub New()
        Nationality = "Argentino"
    End Sub
    Public Sub New(name As String, dni As Integer)
        Me.New()
        Me.Name = name
        Me.Dni = dni
    End Sub
    Public Sub New(name As String, dni As Integer, birthDay As Date)
        Me.New(name, dni)
        Me.BirthDay = birthDay
    End Sub

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            If value.Length > 3 Then
                _name = value
            End If
        End Set
    End Property
    Public Property Dni As Integer
        Get
            Return _dni
        End Get
        Set(value As Integer)
            If value > 999999 Then
                _dni = value
            End If
        End Set
    End Property
    Public Property BirthDay As Date
        Get
            Return _birthDay
        End Get
        Set(value As Date)
            If value.AddYears(18) < Date.Now Then
                _birthDay = value
            End If
        End Set
    End Property
    Public ReadOnly Property Age As UShort
        Get
            Dim _age = DateTime.Now.Year - _birthDay.Year
            ' si no cumplio descontar año
            Return _age
        End Get
    End Property
    Public Property Nationality As String
End Class
