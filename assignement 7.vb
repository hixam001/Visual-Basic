Module Module1

    Sub Main()
        Dim s, F2, L2 As String
        Dim count As Integer

        Console.Write("Enter the string: ")
        s = Console.ReadLine

        If Len(s) <= 2 Then
            Console.WriteLine(s)
            Console.ReadKey()
        End If

        For count = 1 To Len(s)
            F2 = Left(s, 2)
            L2 = Right(s, 2)
        Next
        Console.WriteLine(F2 & L2)
        Console.ReadKey()
    End Sub

End Module
