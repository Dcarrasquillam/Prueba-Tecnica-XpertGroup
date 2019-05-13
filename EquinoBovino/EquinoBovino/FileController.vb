Imports System.IO
Module FileController

    Public Function ObtenerDato(ByVal ArchivoBase As String) As List(Of Animal)
        Dim Lista_Animales As New List(Of Animal)
        Dim Animal As New Animal

        Try
            Using Archivo As New StreamReader(ArchivoBase)
                While Archivo.Peek <> -1
                    ':::Leemos cada linea del archivo TXT
                    Dim linea As String = Archivo.ReadLine()
                    ':::Validamos que la linea no este vacia
                    If String.IsNullOrEmpty(linea) Then
                        Continue While
                    End If
                    Animal = New Animal(linea)
                    Lista_Animales.Add(Animal)
                End While

                Archivo.Close()
            End Using

        Catch ex As Exception

        End Try
        Return Lista_Animales
    End Function
    Public Function GuardarArchivo(ByVal NombreArchivo As String, ByVal ValorGuardar As String) As Boolean

        'Dim Archivo As FileStream
        Try
            Using Archivo As New StreamWriter(NombreArchivo, True)
                Archivo.WriteLine(ValorGuardar)
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Module
