Public Class My_Events
    Public Event _InventoryChange(obj As Inventory)
    Sub InventoryChange(obj As Inventory)
        RaiseEvent _InventoryChange(obj)
    End Sub
End Class
