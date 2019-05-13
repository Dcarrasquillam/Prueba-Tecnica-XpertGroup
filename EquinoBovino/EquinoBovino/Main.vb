Module Main
    Sub Main()
        Dim Animales As New List(Of Animal)
        Animales = ObtenerDato("EQUNOSBOVINOS.DAT")
        For Each a As Animal In Animales
            Console.WriteLine(a.Nombre.NombreAnimal & ", " & a.Caracteristica.NombreArchivo())
            GuardarArchivo(a.Caracteristica.NombreArchivo(), a.Nombre.NombreAnimal)
        Next
        Console.ReadKey()
    End Sub
End Module
