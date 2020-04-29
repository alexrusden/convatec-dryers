Namespace System
  Public NotInheritable Class Null
    Private Sub New()
    End Sub

    Public Shared Function NullToEmptyString(ByVal value As Object) As String
      If value Is Nothing OrElse TypeOf value Is DBNull Then Return String.Empty
      Dim str = TryCast(value, String) : If str IsNot Nothing Then Return str
      Return CType(value, String)
    End Function

    Public Shared Function NullToZeroInteger(ByVal value As Object) As Integer
      If value Is Nothing OrElse TypeOf value Is DBNull Then Return 0
      If TypeOf value Is Integer Then Return DirectCast(value, Integer)
      Return CType(value, Integer)
    End Function

    Public Shared Function NullToZeroDouble(ByVal value As Object) As Double
      If value Is Nothing OrElse TypeOf value Is DBNull Then Return 0
      If TypeOf value Is Double Then Return DirectCast(value, Double)
      Return CType(value, Double)
    End Function

    Public Shared Function NullToZeroDate(ByVal value As Object) As Date
      If value Is Nothing OrElse TypeOf value Is DBNull Then Return Date.MinValue
#If CF Then
      Return DirectCast(value, Date)
#Else
      If TypeOf value Is Date Then Return DirectCast(value, Date)
      ' Sometimes we get a number which is actually an Ole Automation date
      Return Date.FromOADate(CType(value, Double))
#End If
    End Function

    Public Shared Function NullToZeroDecimal(ByVal value As Object) As Decimal
      If value Is Nothing OrElse TypeOf value Is DBNull Then Return 0
      If TypeOf value Is Decimal Then Return DirectCast(value, Decimal)
      Return CType(value, Decimal)
    End Function

    Public Shared Function NullToFalse(ByVal value As Object) As Boolean
      If value Is Nothing OrElse TypeOf value Is DBNull Then Return False
      If TypeOf value Is Boolean Then Return DirectCast(value, Boolean)
      Return CType(value, Boolean)
    End Function

    Public Shared Function NullToNothingByteArray(ByVal value As Object) As Byte()
      If value Is Nothing OrElse TypeOf value Is DBNull Then Return Nothing
      Return DirectCast(value, Byte())
    End Function
  End Class
End Namespace