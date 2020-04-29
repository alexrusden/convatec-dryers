Public Class StopCycleView

  Private controlCode_ As ControlCode

  Public Property ControlCode() As ControlCode
    Get
      Return controlCode_
    End Get
    Set(ByVal value As ControlCode)
      controlCode_ = value
    End Set
  End Property

  Public Sub OnControlCodeRefreshed()
    With ControlCode

     



    End With
  End Sub



  Private Sub Program2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Program2.Click
    ControlCode.Parent.PressButton(ButtonPosition.Operator, 3)
  End Sub

  Private Sub Program1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Program1.Click
    ControlCode.Parent.StopJob()
    ControlCode.Parent.PressButton(ButtonPosition.Operator, 3)
  End Sub
End Class
