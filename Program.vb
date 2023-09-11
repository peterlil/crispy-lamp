Imports System

Module Program

    Sub Main(args As String())

        ' creates a list of items and every time the user presses . on the keyboard, add an item to the list
        ' and display the list in the console

        Dim items As New List(Of ItemClass)

        While True
            Dim key As ConsoleKeyInfo = Console.ReadKey(True)
            If key.Key = ConsoleKey.OemPeriod Then
                items.Add(New ItemClass() With {.Id = items.Count + 1, .Value = "Item " & (items.Count + 1)})
                Console.WriteLine("Item " & (items.Count) & " added")
                Console.WriteLine("Items:")
                For Each item As ItemClass In items
                    Console.WriteLine(item.Id & " " & item.Value)
                Next
            End If
        End While
    End Sub
End Module

