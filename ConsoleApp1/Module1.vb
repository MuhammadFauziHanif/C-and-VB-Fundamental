Module Module1

    Sub Main()
        Dim random As Random = New Random()
        Dim randomResult = random.Next(1, 100)
        Console.WriteLine("Random number: " & randomResult)
    End Sub

End Module
