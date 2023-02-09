Module Principal

    Sub Main()

        Dim iva As Double



        Dim b As Boolean = False
        While b = False
            Console.WriteLine("Indique el indice de la factura (1, 2, 3, 4): ")

            Dim indice As Integer = Integer.Parse(Console.ReadLine())

            If indice = 1 Or indice = 2 Or indice = 3 Or indice = 4 Then
                b = True
                Continue While
            End If

            Console.WriteLine("El indice tiene que ser 1, 2, 3 o 4.")
        End While


        Dim c As New 
        Console.Write("Precio total sin IVA: ")
        Console.WriteLine(c.totalSinIVA())
        Console.Write("Precio del IVA correspondiente: ")
        Console.WriteLine(c.IVA())
        Console.ReadLine()


    End Sub

End Module
