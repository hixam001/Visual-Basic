Module Module1

    Sub Main()
        Dim string1 As String
        Dim count As Integer
        Dim alphabet As Char

        string1 = ""
        count = 0
        alphabet = ""

        Console.Write("input string: ")
        string1 = Console.ReadLine

        For count = 1 To Len(string1)
            If InStr(string1, UCase(alphabet), alphabet) Then
                Console.Write("the string contains both uppercase and lowercase alphabets")
                Console.ReadLine()
            Else
                Console.Write(" the string doesnot contain any alphabets")
                Console.ReadLine()
            End If
        Next
        Console.ReadKey()
    End Sub

End Module
