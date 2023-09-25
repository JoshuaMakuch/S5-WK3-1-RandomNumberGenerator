'Joshua Makuch
'RCET 3371
'Fall 2023
'Random Number Generator
'https://github.com/JoshuaMakuch/S5-WK3-1-RandomNumberGenerator

Option Strict On
Option Explicit On

Public Class RandomNumberGeneratorForm

    Dim random As New Random() 'Creates an instance of the random class and the new generates a new seed each run through to provide pseudo randomness

    'Generate Button
    Private Sub GenerateButton_Click(sender As Object, e As EventArgs) Handles GenerateButton.Click


        'Clears the display list box for a new set of numbers
        DisplayListBox.Items.Clear()

        For n As Integer = 0 To 9

            'The .next generates a random integer (>= first and < second), but .NextDouble can be used to generate a random double (0.000... to 0.999...)
            DisplayListBox.Items.Add(n + 1 & ":       " & CStr(random.Next(-10, 11)))

        Next

    End Sub

    'Quit Button
    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

End Class
