Module Principal

    Sub Main()

        While True
            Dim iva As Double
            Dim indice As Integer

            Dim b As Boolean = False
            While b = False
                Console.Write("Indique el indice de la factura (1, 2, 3, 4): ")
                indice = Integer.Parse(Console.ReadLine())

                If indice = 1 Or indice = 2 Or indice = 3 Or indice = 4 Then
                    b = True
                    Continue While
                End If

                Console.WriteLine("El indice tiene que ser 1, 2, 3 o 4.")
            End While

            Dim c As New CalculoIvaPorCapaDeDatos_DLL.CalculoIVAMedianteCreadorDeDatos(indice)
            Console.Write("Precio total sin IVA: ")
            Console.WriteLine(c.totalSinIVA())
            Console.Write("Precio del IVA correspondiente: ")
            Console.WriteLine(c.IVA())
            Console.WriteLine()

            Console.WriteLine("Introducir otro indice -> ENTER")
            Console.WriteLine("Terminar programa -> 0")
            Dim control = Console.ReadLine()

            If control = "0" Then
                Exit While
            End If

        End While


    End Sub

End Module
