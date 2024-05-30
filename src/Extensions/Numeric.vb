Imports System.Runtime.CompilerServices

Public Module Numeric

  <Extension>
  Public Function Between(value As Byte, min As Byte, max As Byte) As Boolean
    Return value >= min AndAlso value <= max
  End Function

  <Extension>
  Public Function Between(value As Short, min As Short, max As Short) As Boolean
    Return value >= min AndAlso value <= max
  End Function

  <Extension>
  Public Function Between(value As Integer, min As Integer, max As Integer) As Boolean
    Return value >= min AndAlso value <= max
  End Function

  <Extension>
  Public Function Between(value As Long, min As Long, max As Long) As Boolean
    Return value >= min AndAlso value <= max
  End Function

  <Extension>
  Public Function Between(value As Single, min As Single, max As Single) As Boolean
    Return value >= min AndAlso value <= max
  End Function

  <Extension>
  Public Function Between(value As Double, min As Double, max As Double) As Boolean
    Return value >= min AndAlso value <= max
  End Function

  <Extension>
  Public Function Between(value As Date, min As Date, max As Date) As Boolean
    Return value >= min AndAlso value <= max
  End Function

  <Extension>
  Public Function Between(value As DateOnly, min As DateOnly, max As DateOnly) As Boolean
    Return value >= min AndAlso value <= max
  End Function

  <Extension>
  Public Function Between(value As TimeOnly, min As TimeOnly, max As TimeOnly) As Boolean
    Return value >= min AndAlso value <= max
  End Function

  <Extension>
  Public Function Between(value As TimeSpan, min As TimeSpan, max As TimeSpan) As Boolean
    Return value >= min AndAlso value <= max
  End Function

  <Extension>
  Public Function ToRadians(value As Single) As Single
    Return (value * MathF.PI) / 1800
  End Function

  <Extension>
  Public Function ToRadians(value As Double) As Double
    Return (value * Math.PI) / 1800
  End Function

End Module
