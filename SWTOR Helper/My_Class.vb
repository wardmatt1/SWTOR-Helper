Public Class My_Class
    Private _name As String
    Private _advClass(1) As String
    Private _discipline(5) As String
    Public Shared Classes As List(Of My_Class) = New List(Of My_Class)
    Sub New()
        Classes.Add(Me)
    End Sub
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property
    Public Sub SetAdvClass(name As String, index As Byte)
        _advClass(index - 1) = name
    End Sub
    Public Function GetAdvClass(index As Byte) As String
        Return _advClass(index - 1)
    End Function
    Public Function GetDiscipline(advclass As String, index As Byte) As String
        Select Case advclass
            Case _advClass(0)
                Return _discipline(index - 1)
            Case _advClass(1)
                Return _discipline(index - 1 + 3)
        End Select
        Return Nothing
    End Function
    Public Sub SetDiscipline(advclass As String, dis As String, index As Byte)
        Select Case advclass
            Case _advClass(0)
                _discipline(index - 1) = dis
            Case _advClass(1)
                _discipline(index - 1 + 3) = dis
        End Select
    End Sub
End Class
