<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCustom
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblAddItem = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.RichTextBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAddItem
        '
        Me.lblAddItem.AutoSize = True
        Me.lblAddItem.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddItem.Location = New System.Drawing.Point(23, 20)
        Me.lblAddItem.Name = "lblAddItem"
        Me.lblAddItem.Size = New System.Drawing.Size(146, 24)
        Me.lblAddItem.TabIndex = 1
        Me.lblAddItem.Text = "Add Custom Code"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(350, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Warning: For advanced users!"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(29, 61)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(519, 290)
        Me.txtInput.TabIndex = 3
        Me.txtInput.Text = ""
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(216, 357)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(148, 32)
        Me.cmdAdd.TabIndex = 4
        Me.cmdAdd.Text = "Add code to project"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(266, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(282, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Use this to add custom code to your project"
        '
        'AddCustom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 398)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAddItem)
        Me.Name = "AddCustom"
        Me.Text = "AddCustom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAddItem As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtInput As RichTextBox
    Friend WithEvents cmdAdd As Button
    Friend WithEvents Label2 As Label
End Class
