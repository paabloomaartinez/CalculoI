Module Principal

    Sub Main()

        Dim iva As Double
        Console.WriteLine("Indique el total a pagar: ")
        Dim tv As Double = Console.ReadLine
        Dim b As Boolean = False
        While b = False
            Console.WriteLine("Tipos de IVA: General 21%, Reducido 10%, Productos basicos 4%")
            Console.WriteLine("Escoja el tipo de IVA (General, Reducido, Productos basicos): ")
            Dim nv As String = Console.ReadLine
            If nv = "General" Then
                iva = 0.21
                b = True
            ElseIf nv = "Reducido" Then
                iva = 0.1
                b = True
            ElseIf nv = "Productos Basicos" Then
                iva = 0.04
                b = True
            Else
                Console.WriteLine("No se ha escogido un Tipo de IVA correcto.")
            End If
        End While
        Dim c As New CalculoIVA_DLL.CalculoIVA(tv, iva)
        Console.Write("Precio total sin IVA: ")
        Console.WriteLine(c.totalSinIVA())
        Console.Write("Precio del IVA correspondiente: ")
        Console.WriteLine(c.IVA())
        Console.ReadLine()

    End Sub

End Module
