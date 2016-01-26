Imports System.Windows.Forms

Public Class NewlegacyDIalogbox

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim name, server, acctype As String
        name = NewlegacyDIalogbox_TextBox1.Text
        server = NewlegacyDIalogbox_TextBox2.Text
        acctype = NewlegacyDIalogbox_ComboBox1.GetItemText(NewlegacyDIalogbox_ComboBox1.SelectedItem)
        If name <> Nothing And server <> Nothing And acctype <> Nothing Then
            '  Dim l As Legacy = New Legacy(name, server, acctype)
            Me.Close()
        Else
            MsgBox("You must fill in all the info.")
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub NewlegacyDIalogbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewlegacyDIalogbox_ComboBox1.SelectedIndex = 0

    End Sub
End Class
