Public Class EditUsers


  Private controlCode_ As ControlCode
  Public CheckTimer As New Timer

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

      Static ReadDone As Boolean

      If Not ReadDone Then 'Just get a list on system startup
        UserNameList.Items.Clear()


        For Each dr As DataRow In ControlCode.Parent.DbGetDataTable("SELECT * FROM Users  order BY UserName").Rows
          'ChemicalName is not null 
          Dim UserName = (Null.NullToEmptyString(dr("UserName")))
          Dim Pin = (Null.NullToEmptyString(dr("Pin")))

          UserNameList.Items.Add(UserName)
          ' UserNameList.Items.Add(UserName & " - " & Pin)
         

        Next dr

        ReadDone = True
      End If


    End With
  End Sub
  Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserNameList.SelectedIndexChanged

    Static UserId As String

    If UserNameList.Text <> "" Then
      UserId = CStr(UserNameList.SelectedItem)
    End If


    ' Dim TrimmedValveID = IDValve.Remove(3)

    Dim List = ControlCode.Parent.DbGetDataTable("SELECT * FROM Users WHERE UserName ='" & UserId & "'")
    If (List.Rows.Count = 0) Then


    Else

      Dim DR2 = List.Rows(0)
      TextBoxUserName.Text = Null.NullToEmptyString(DR2("UserName"))
      TextBoxPin.Text = Null.NullToEmptyString(DR2("Pin"))


    End If


  End Sub

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()


    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Private Sub UserNameList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserNameList.SelectedIndexChanged

  End Sub

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    If TextBoxUserName.Text <> "" Then
      Dim DR2 = ControlCode.Parent.DbExecute("Delete From Users where UserName ='" & TextBoxUserName.Text & "' ")
    End If

    UserNameList.Items.Clear()
    For Each dr As DataRow In ControlCode.Parent.DbGetDataTable("SELECT * FROM Users  order BY UserName").Rows
      'ChemicalName is not null 
      Dim UserName = (Null.NullToEmptyString(dr("UserName")))
      Dim Pin = (Null.NullToEmptyString(dr("Pin")))

      UserNameList.Items.Add(UserName)
    Next dr

    TextBoxUserName.Text = ""
    TextBoxPin.Text = ""

  End Sub

  Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    If (TextBoxUserName.Text <> "") And (TextBoxPin.Text <> "") Then
      Dim DR2 = ControlCode.Parent.DbExecute("INSERT INTO Users (UserName,Pin) values ('" & TextBoxUserName.Text & "','" & TextBoxPin.Text & "')")
    End If


    UserNameList.Items.Clear()
    For Each dr As DataRow In ControlCode.Parent.DbGetDataTable("SELECT * FROM Users  order BY UserName").Rows
      'ChemicalName is not null 
      Dim UserName = (Null.NullToEmptyString(dr("UserName")))
      Dim Pin = (Null.NullToEmptyString(dr("Pin")))

      UserNameList.Items.Add(UserName)
    Next dr




  End Sub

  Private Sub btUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUpdate.Click


    If (TextBoxUserName.Text <> "") And (TextBoxPin.Text <> "") Then
      Dim DR2 = ControlCode.Parent.DbExecute("Update  Users set  UserName = '" & TextBoxUserName.Text & "',Pin = '" & TextBoxPin.Text & "' where UserName = '" & TextBoxUserName.Text & "'")
    End If



    UserNameList.Items.Clear()
    For Each dr As DataRow In ControlCode.Parent.DbGetDataTable("SELECT * FROM Users  order BY UserName").Rows
      'ChemicalName is not null 
      Dim UserName = (Null.NullToEmptyString(dr("UserName")))
      Dim Pin = (Null.NullToEmptyString(dr("Pin")))

      UserNameList.Items.Add(UserName)
    Next dr

    '    Update(table_name)
    'SET column1=value, column2=value2,...
    '    WHERE(some_column = some_value)

  End Sub
End Class
