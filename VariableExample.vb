'header stuff

Option Strict On 'No conversions by the compiler
Option Explicit On 'Must declare all variables

Module VariableExample 'PascalCase

    Sub Main()

        Dim x As Int16
        Dim y As Int16
        Dim result As Int16
        Dim firstName As String
        Dim lastName As String


        x = 1
        y = 2
        result = x + y


        Console.WriteLine("What is your first name?")
        firstName = Console.ReadLine()
        Console.WriteLine("What is you last name?")
        lastName = Console.ReadLine()
        Console.WriteLine("Hello " +
                          firstName + " " + lastName) 'wrap long text with a space underscore.
        Console.ReadLine()




    End Sub

End Module
