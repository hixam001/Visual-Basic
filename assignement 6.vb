Module Module1

    Sub Main()
        Dim donut, donutcount As Integer
        donut = 0
        donutcount = 0

        Console.Write("ENTER THE NUMBER OF DONUTS: ")
        donut = Console.ReadLine

        For count = 1 To donut
            If donut > 10 Then
                Console.Write("NUMBER OF DONUTS: MANY")
                Console.ReadLine()
            Else
                If Len(donut) < 10 Then
                    Console.WriteLine("NUMBER OF DONUTS: " & donut)
                    Console.ReadLine()
                End If
            End If
        Next
        Console.ReadKey()
    End Sub

End Module
