Imports System

Module Program
    Sub Main(args As String())

        'for i As Integer = 0 To 9
        '    Console.WriteLine($"The value of i is {i}")
        'Next

        'Dim data As String = "Tim,Sue,Bob,Jane"
        'Dim firstNames As List(Of String) = data.Split(","c).ToList()

        'For i As Integer = 0 To firstNames.Count - 1
        '    Console.WriteLine($"{firstNames(i)} is in attendance")
        'Next

        Dim charges As New List(Of Decimal)()

        charges.Add(23.78D)
        charges.Add(15.89D)
        charges.Add(125D)

        Dim total As Decimal = 0

        For i As Integer = 0 To charges.Count - 1
            total += charges(i)
        Next

        Console.WriteLine($"Our total charge is {total}")

    End Sub
End Module
