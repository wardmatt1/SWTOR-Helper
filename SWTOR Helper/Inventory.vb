Public Class Inventory
    Private _owner As SWTOR_Record
    Private _type As Boolean
    Private _slots As List(Of InventoryItem) = New List(Of InventoryItem)
    Private _maxslots As Byte
    Private _slotsused As Byte = 0
    Sub New(owner As SWTOR_Record, Optional type As Boolean = True) 'type true = bank
        If type = True Then
            _maxslots = 80
        Else
            _maxslots = 40
        End If
        _owner = owner
    End Sub
    Public Sub addItem(item As My_item, count As Byte)
        Dim invitem As InventoryItem = New InventoryItem(item, Me, count)
        _slots.Add(invitem)
        slotsused += 1
    End Sub
    Public Sub remItem(slot As Integer)
        _slots.RemoveAt(slot)
        slotsused = slotsused - 1
    End Sub
    Property slotsused
        Get
            Return _slotsused
        End Get
        Set(value)
            If Not (value = _slotsused) Then
                _slotsused = value
                Events.InventoryChange(Me)
            End If

        End Set
    End Property
End Class
