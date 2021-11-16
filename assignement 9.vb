Module Module1

    Sub Main()
        Dim str1, str2, s1, s2, slast, sfirst As String
        Dim c1, c2 As Char
        Dim count As Integer

        slast = ""
        sfirst = ""
        str1 = ""
        str2 = ""
        s1 = ""
        s2 = ""
        c1 = ""
        c2 = ""
        count = 0

        Console.Write("Enter 1st string: ")
        str1 = Console.ReadLine

        Console.Write("Enter second string: ")
        str2 = Console.ReadLine

        For count = 1 To Len(str1)
            If Len(str1) >= 3 Then
                s1 = Left(str1, 2)
            Else
                Console.Write("string 1 invalid")
                Console.ReadLine()
            End If
        Next
        For count = 1 To Len(str2)
            If Len(str2) >= 3 Then
                s2 = Left(str2, 2)
            Else
                Console.Write("string 2 invalid")
                Console.ReadLine()
            End If
            sfirst = Replace(str1, s1, s2)
            slast = Replace(str2, s2, s1)
        Next
        Console.Write("Processed string : " & sfirst & " " & slast)
        Console.ReadKey()
    End Sub

End Module
