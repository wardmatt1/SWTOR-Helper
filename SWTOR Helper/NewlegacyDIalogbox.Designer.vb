<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewlegacyDIalogbox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.NewlegacyDIalogbox_ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.NewlegacyDIalogbox_TextBox2 = New System.Windows.Forms.TextBox()
        Me.NewlegacyDIalogbox_TextBox1 = New System.Windows.Forms.TextBox()
        Me.NewlegacyDIalogbox_Label3 = New System.Windows.Forms.Label()
        Me.NewlegacyDIalogbox_Label2 = New System.Windows.Forms.Label()
        Me.NewlegacyDIalogbox_Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(29, 93)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'NewlegacyDIalogbox_ComboBox1
        '
        Me.NewlegacyDIalogbox_ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NewlegacyDIalogbox_ComboBox1.FormattingEnabled = True
        Me.NewlegacyDIalogbox_ComboBox1.Items.AddRange(New Object() {"Free to Play", "Prefered", "Subscribed"})
        Me.NewlegacyDIalogbox_ComboBox1.Location = New System.Drawing.Point(91, 58)
        Me.NewlegacyDIalogbox_ComboBox1.Name = "NewlegacyDIalogbox_ComboBox1"
        Me.NewlegacyDIalogbox_ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.NewlegacyDIalogbox_ComboBox1.TabIndex = 14
        '
        'NewlegacyDIalogbox_TextBox2
        '
        Me.NewlegacyDIalogbox_TextBox2.Location = New System.Drawing.Point(91, 31)
        Me.NewlegacyDIalogbox_TextBox2.Name = "NewlegacyDIalogbox_TextBox2"
        Me.NewlegacyDIalogbox_TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.NewlegacyDIalogbox_TextBox2.TabIndex = 13
        '
        'NewlegacyDIalogbox_TextBox1
        '
        Me.NewlegacyDIalogbox_TextBox1.Location = New System.Drawing.Point(91, 6)
        Me.NewlegacyDIalogbox_TextBox1.Name = "NewlegacyDIalogbox_TextBox1"
        Me.NewlegacyDIalogbox_TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.NewlegacyDIalogbox_TextBox1.TabIndex = 9
        '
        'NewlegacyDIalogbox_Label3
        '
        Me.NewlegacyDIalogbox_Label3.AutoSize = True
        Me.NewlegacyDIalogbox_Label3.Location = New System.Drawing.Point(12, 62)
        Me.NewlegacyDIalogbox_Label3.Name = "NewlegacyDIalogbox_Label3"
        Me.NewlegacyDIalogbox_Label3.Size = New System.Drawing.Size(68, 13)
        Me.NewlegacyDIalogbox_Label3.TabIndex = 10
        Me.NewlegacyDIalogbox_Label3.Text = "Acount Type"
        '
        'NewlegacyDIalogbox_Label2
        '
        Me.NewlegacyDIalogbox_Label2.AutoSize = True
        Me.NewlegacyDIalogbox_Label2.Location = New System.Drawing.Point(12, 34)
        Me.NewlegacyDIalogbox_Label2.Name = "NewlegacyDIalogbox_Label2"
        Me.NewlegacyDIalogbox_Label2.Size = New System.Drawing.Size(38, 13)
        Me.NewlegacyDIalogbox_Label2.TabIndex = 11
        Me.NewlegacyDIalogbox_Label2.Text = "Server"
        '
        'NewlegacyDIalogbox_Label1
        '
        Me.NewlegacyDIalogbox_Label1.AutoSize = True
        Me.NewlegacyDIalogbox_Label1.Location = New System.Drawing.Point(12, 9)
        Me.NewlegacyDIalogbox_Label1.Name = "NewlegacyDIalogbox_Label1"
        Me.NewlegacyDIalogbox_Label1.Size = New System.Drawing.Size(73, 13)
        Me.NewlegacyDIalogbox_Label1.TabIndex = 12
        Me.NewlegacyDIalogbox_Label1.Text = "Legacy Name"
        '
        'NewlegacyDIalogbox
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(202, 134)
        Me.Controls.Add(Me.NewlegacyDIalogbox_ComboBox1)
        Me.Controls.Add(Me.NewlegacyDIalogbox_TextBox2)
        Me.Controls.Add(Me.NewlegacyDIalogbox_TextBox1)
        Me.Controls.Add(Me.NewlegacyDIalogbox_Label3)
        Me.Controls.Add(Me.NewlegacyDIalogbox_Label2)
        Me.Controls.Add(Me.NewlegacyDIalogbox_Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewlegacyDIalogbox"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "NewlegacyDIalogbox"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents NewlegacyDIalogbox_ComboBox1 As ComboBox
    Friend WithEvents NewlegacyDIalogbox_TextBox2 As TextBox
    Friend WithEvents NewlegacyDIalogbox_TextBox1 As TextBox
    Friend WithEvents NewlegacyDIalogbox_Label3 As Label
    Friend WithEvents NewlegacyDIalogbox_Label2 As Label
    Friend WithEvents NewlegacyDIalogbox_Label1 As Label
End Class
