Module Module1

    Sub Main()
        Dim thischar, char1, char2 As Char
        Dim most, count, counter1, counter2 As Integer
        Dim s1 As String

        thischar = ""
        char1 = ""
        char2 = ""
        most = 0
        count = 0
        counter1 = 0
        counter2 = 0
        s1 = ""

        Console.Write("Enter the string: ")
        s1 = Console.ReadLine

        For counter1 = 1 To Len(s1)
            thischar = Mid(s1, counter1, 1)
            count = 0
            For counter2 = 1 To Len(s1)
                char2 = Mid(s1, counter2, 1)
                If char2 = thischar Then count = count + 1
            Next
            If count > most Then
                most = count
                char1 = thischar
            End If
        Next
        Console.WriteLine(char1 & " was used " & most & " number of times")
        Console.ReadKey()
    End Sub

End Module
