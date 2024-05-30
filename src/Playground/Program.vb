Imports Extensions.Numeric

Module Program

  Sub Main() 'args As String())

    Dim value1 = 6, min = 1, max = 10

    Console.WriteLine($"Is {value1} between {min} and {max}? {value1.Between(min, max)}")

  End Sub

End Module