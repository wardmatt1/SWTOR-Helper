Public Class SWTOR_Record
    Private _name As String
    Private _bank As SWTOR_Helper.Bank
    Private _Panel As UI
    Private _node As String
    Private _type As Boolean
    Public Inventorys As List(Of Inventory) = New List(Of Inventory)

    Public Property SWTOR_Type As Boolean
        Get
            Return _type
        End Get
        Set(value As Boolean)
            _type = value
        End Set
    End Property
    Public Property SWTOR_Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property
    Public Property SWTOR_Node As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property SWTOR_MainPanel As UI
        Get
            Return _Panel
        End Get
        Set(value As UI)
            _Panel = value
        End Set
    End Property

    Public Property SWTOR_Bank As SWTOR_Helper.Bank
        Get
            Return _bank
        End Get
        Set(value As SWTOR_Helper.Bank)
            _bank = value
        End Set
    End Property
End Class
