' This program calculates the factorial of a given non-negative integer.
Module Module1

    Sub Main()
        ' Declare variables to store the input number and the calculated factorial.
        Dim n As Integer
        Dim factorial As Long = 1

        System.Console.ForegroundColor = ConsoleColor.DarkCyan
        ' Prompt the user to enter a non-negative integer.
        System.Console.Write("Please enter a non-negative integer : ")

        System.Console.ForegroundColor = ConsoleColor.Yellow
        ' Read the user's input and convert it to an integer.
        n = System.Convert.ToInt32(System.Console.ReadLine())
        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-----------------------")

        ' Check if the input is valid (non-negative).
        If n < 0 Then
            System.Console.BackgroundColor = ConsoleColor.Red
            System.Console.ForegroundColor = ConsoleColor.White
            System.Console.WriteLine("The entered number must be non-negative.")
            System.Console.ResetColor()
        Else
            ' Calculate the factorial using a loop.
            For i As Integer = 1 To n
                factorial *= i
            Next
            System.Console.BackgroundColor = ConsoleColor.Blue
            System.Console.ForegroundColor = ConsoleColor.White
            ' Display the result.
            System.Console.WriteLine($"The factorial of {n} is: {factorial}")
        End If
        System.Console.ResetColor()

        ' Programmer Inforamtion and GitHub Username
        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-----------------------")
        System.Console.ForegroundColor = ConsoleColor.Red
        System.Console.WriteLine("Programmer : Amin Mirzaei - Github(UserName) : AminMirzaeiOne")

        ' Pause the console to keep it open.
        System.Console.ReadKey()
    End Sub

End Module