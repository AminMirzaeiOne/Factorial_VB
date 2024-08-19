' This program calculates the factorial of a given non-negative integer.
Module Module1

    Sub Main()
        ' Declare variables to store the input number and the calculated factorial.
        Dim n As Integer
        Dim factorial As Long = 1

        ' Prompt the user to enter a non-negative integer.
        Console.Write("Please enter a non-negative integer : ")

        ' Read the user's input and convert it to an integer.
        n = Convert.ToInt32(Console.ReadLine())

        ' Check if the input is valid (non-negative).
        If n < 0 Then
            Console.WriteLine("The entered number must be non-negative.")
        Else
            ' Calculate the factorial using a loop.
            For i As Integer = 1 To n
                factorial *= i
            Next

            ' Display the result.
            Console.WriteLine($"The factorial of {n} is: {factorial}")
        End If

        ' Programmer Inforamtion and GitHub Username
        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-----------------------")
        System.Console.ForegroundColor = ConsoleColor.Red
        System.Console.WriteLine("Programmer : Amin Mirzaei - Github(UserName) : AminMirzaeiOne")

        ' Pause the console to keep it open.
        Console.ReadKey()
    End Sub

End Module