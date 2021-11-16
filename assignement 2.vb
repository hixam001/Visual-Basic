Module Module1

    Sub Main()
        Dim char1, char2 As Char
        Dim str1, str2 As String
        Dim count As Integer

        char1 = ""
        char2 = ""
        str1 = ""
        str2 = ""
        count = 0

        Console.Write("Enter the string to process: ")
        str1 = Console.ReadLine

        Console.Write("Enter character to be replaced: ")
        char1 = Console.ReadLine

        Console.Write("Enter character to replace it with: ")
        char2 = Console.ReadLine

        For count = 1 To Len(str1)
            str2 = str1.Replace(char1, char2)
        Next
        Console.Write("processed string:" & str2)
        Console.ReadKey()
    End Sub

End Module
