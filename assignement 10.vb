Module Module1

    Sub Main()
        Dim str1, str2, thisstr, s2, s3 As String
        Dim count As Integer

        str1 = ""
        str2 = ""
        thisstr = ""
        s2 = "ly"
        s3 = "ing"

        Console.Write("Enter the string: ")
        str1 = Console.ReadLine


        For count = 1 To Len(str1)
            thisstr = Right(str1, 3)
            If thisstr = s3 Then
                str2 = str1 & s2
            Else
                str2 = str1 & s3
            End If
            If Len(str1) < 3 Then
                Console.WriteLine(str1)
                Console.ReadLine()
            End If
        Next
        Console.Write(str2)
        Console.ReadKey()
    End Sub

End Module
