Public Class Bank
    Private _owner As SWTOR_Record
    Private _UI_bank As UI_Bank
    Sub New(l As SWTOR_Record, ui As UI)
        Bank_Owner = l
        UI_Bank = New UI_Bank(ui, l.SWTOR_Type)
    End Sub
    Public Property UI_Bank As UI_Bank
        Get
            Return _UI_bank
        End Get
        Set(value As UI_Bank)
            _UI_bank = value
        End Set
    End Property
    Public Property Bank_Owner As SWTOR_Record
        Get
            Return _owner
        End Get
        Set(value As SWTOR_Record)
            _owner = value
        End Set
    End Property
End Class
