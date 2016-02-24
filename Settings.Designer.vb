<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.lblStartID = New System.Windows.Forms.Label()
        Me.lblBlockID = New System.Windows.Forms.Label()
        Me.numItemID = New System.Windows.Forms.NumericUpDown()
        Me.numBlockID = New System.Windows.Forms.NumericUpDown()
        Me.cmdApply = New System.Windows.Forms.Button()
        CType(Me.numItemID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numBlockID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStartID
        '
        Me.lblStartID.AutoSize = True
        Me.lblStartID.Location = New System.Drawing.Point(31, 44)
        Me.lblStartID.Name = "lblStartID"
        Me.lblStartID.Size = New System.Drawing.Size(106, 17)
        Me.lblStartID.TabIndex = 0
        Me.lblStartID.Text = "Current Item ID:"
        '
        'lblBlockID
        '
        Me.lblBlockID.AutoSize = True
        Me.lblBlockID.Location = New System.Drawing.Point(31, 94)
        Me.lblBlockID.Name = "lblBlockID"
        Me.lblBlockID.Size = New System.Drawing.Size(114, 17)
        Me.lblBlockID.TabIndex = 1
        Me.lblBlockID.Text = "Current Block ID:"
        '
        'numItemID
        '
        Me.numItemID.Location = New System.Drawing.Point(234, 44)
        Me.numItemID.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numItemID.Minimum = New Decimal(New Integer() {256, 0, 0, 0})
        Me.numItemID.Name = "numItemID"
        Me.numItemID.Size = New System.Drawing.Size(80, 22)
        Me.numItemID.TabIndex = 2
        Me.numItemID.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'numBlockID
        '
        Me.numBlockID.Location = New System.Drawing.Point(234, 92)
        Me.numBlockID.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numBlockID.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numBlockID.Name = "numBlockID"
        Me.numBlockID.Size = New System.Drawing.Size(80, 22)
        Me.numBlockID.TabIndex = 3
        Me.numBlockID.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'cmdApply
        '
        Me.cmdApply.Location = New System.Drawing.Point(34, 151)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.Size = New System.Drawing.Size(280, 27)
        Me.cmdApply.TabIndex = 4
        Me.cmdApply.Text = "Apply"
        Me.cmdApply.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 218)
        Me.Controls.Add(Me.cmdApply)
        Me.Controls.Add(Me.numBlockID)
        Me.Controls.Add(Me.numItemID)
        Me.Controls.Add(Me.lblBlockID)
        Me.Controls.Add(Me.lblStartID)
        Me.Name = "Settings"
        Me.Text = "Settings"
        CType(Me.numItemID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numBlockID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStartID As Label
    Friend WithEvents lblBlockID As Label
    Friend WithEvents numItemID As NumericUpDown
    Friend WithEvents numBlockID As NumericUpDown
    Friend WithEvents cmdApply As Button
End Class
