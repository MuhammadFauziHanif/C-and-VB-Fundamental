Module Module1

    Sub Main()
        Dim random As Random = New Random()
        Dim randomResult = random.Next(1, 100)
        Console.WriteLine("Random number: " & randomResult)

        Dim student As Student = New Student()
        Console.WriteLine("Student's full name: " & student.getFullName())

        Dim roll1 = random.Next(1, 7)
        Dim roll2 = random.Next(1, 7)
        Dim roll3 = random.Next(1, 7)

        Dim total = roll1 + roll2 + roll3
        Console.WriteLine("Dice roll: " & roll1 & " + " & roll2 & " + " & roll3 & " = " & total)

        If roll1 = roll2 OrElse roll1 = roll3 OrElse roll2 = roll3 Then
            Console.WriteLine("You rolled doubles!")
        End If

        If roll1 = roll2 And roll2 = roll3 Then
            Console.WriteLine("You rolled triples! +6 bonus to total!")
        End If

        If total >= 15 Then
            Console.WriteLine("You win a bonus roll!")
        End If

        If total < 15 Then
            Console.WriteLine("Sorry, you did not win a bonus roll.")
        End If

        Console.ReadLine()

    End Sub

End Module
