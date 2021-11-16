Module Module1

    Sub Main()
        Dim thischar, mychar As Char
        Dim count, alphacount As Integer
        Dim str1 As String

        mychar = ""
        str1 = ""
        thischar = ""
        count = 0
        alphacount = 0

        Console.Write("Enter the string to be processed: ")
        str1 = Console.ReadLine

        Console.Write("Enter the char to be processed: ")
        mychar = Console.ReadLine

        For count = 1 To Len(str1)
            thischar = Mid(str1, count, 1)
            If UCase(thischar) = UCase(mychar) Then
                alphacount = alphacount + 1
            Else
                alphacount = alphacount

            End If
        Next
        Console.Write(alphacount)
        Console.ReadKey()
    End Sub

End Module
