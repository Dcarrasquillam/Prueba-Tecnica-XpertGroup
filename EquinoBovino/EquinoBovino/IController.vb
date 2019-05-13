

Public Interface IEsBobino
    Function EsBobino(ByVal dato As InfoAnimalBase) As Boolean
End Interface

Public Interface IEsEquino
    Function EsEquino(ByVal dato As InfoAnimalBase) As Boolean
End Interface

Public Class ClasificarAnimalBase
    Implements IEsBobino, IEsEquino 
    Public Sub New()

    End Sub
    Public Function EsBobino(ByVal dato As InfoAnimalBase) As Boolean Implements IEsBobino.EsBobino
        Return dato.NombreAnimal.Contains("b")
    End Function
    Public Function EsEquino(ByVal dato As InfoAnimalBase) As Boolean Implements IEsEquino.EsEquino
        Return True
    End Function
   
End Class

