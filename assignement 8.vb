Module Module1

    Sub Main()
        Dim Str1 As String
        Dim thischar, mychar As Char
        Dim count As Integer

        Str1 = ""
        thischar = ""
        myChar = ""
        count = 0

        Console.WriteLine("Enter a statement")
        Str1 = Console.ReadLine

        thischar = Left(Str1, 1)
        Console.Write(thischar)

        For count = 1 To Len(Str1) - 1
            myChar = Mid(Str1, (count + 1), 1)
            If myChar = thischar Then
                myChar = "*"
            End If
            Console.Write(myChar)
        Next
        Console.ReadKey()
    End Sub

End Module
