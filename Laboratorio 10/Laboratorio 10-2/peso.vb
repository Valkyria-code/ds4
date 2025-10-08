Imports System

Module peso
    Sub Main()
        Dim M As Double
        Dim G As Double
        Dim P As Double

        G = 9.8

        Console.WriteLine("Ingrese la masa del objeto: ")
        M = Console.ReadLine

        P = M * G

        Console.WriteLine("Peso del objetos, {0}", P)
        Console.ReadKey()
    End Sub
End Module
