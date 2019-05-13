Public Class InfoAnimalBase
    Public Property NombreAnimal As String = ""
    Public Sub New()
        NombreAnimal = ""
    End Sub
    Public Sub New(ByVal nombreAnimal As String)
        _NombreAnimal = nombreAnimal

    End Sub
End Class

Public Class CaracteristicaAnimalBase
    Inherits ClasificarAnimalBase
    Private _infoAnimalBase As InfoAnimalBase
    Public Sub New()

    End Sub
    Public Sub New(ByVal infoAnimalBase As InfoAnimalBase)
        _infoAnimalBase = infoAnimalBase
    End Sub

    Public Function NombreArchivo() As String
        If EsBobino(_infoAnimalBase) Then
            Return "Bobino.txt"
        Else
            Return "Equino.txt"
        End If
    End Function
End Class

Public Class Animal

    Public Property Nombre As New InfoAnimalBase
    Public Property Caracteristica As New CaracteristicaAnimalBase
    Public Sub New()

    End Sub
    Public Sub New(ByVal nombre As String)
        _Nombre = New InfoAnimalBase(nombre)
        Caracteristica = New CaracteristicaAnimalBase(_Nombre)
    End Sub

End Class



