<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCrafting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCrafting))
        Me.lblAddItem = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.cmdCreate = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lstIngredients = New System.Windows.Forms.ListBox()
        Me.numInputID = New System.Windows.Forms.NumericUpDown()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.numOutput = New System.Windows.Forms.NumericUpDown()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.numOutputNumber = New System.Windows.Forms.NumericUpDown()
        Me.lblHowMuch = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numInputID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numOutputNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAddItem
        '
        Me.lblAddItem.AutoSize = True
        Me.lblAddItem.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddItem.Location = New System.Drawing.Point(203, 9)
        Me.lblAddItem.Name = "lblAddItem"
        Me.lblAddItem.Size = New System.Drawing.Size(156, 24)
        Me.lblAddItem.TabIndex = 13
        Me.lblAddItem.Text = "Add Crafting Recipe"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(31, 302)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(351, 85)
        Me.lblInfo.TabIndex = 37
        Me.lblInfo.Text = resources.GetString("lblInfo.Text")
        '
        'cmdCreate
        '
        Me.cmdCreate.Location = New System.Drawing.Point(409, 344)
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.Size = New System.Drawing.Size(132, 43)
        Me.cmdCreate.TabIndex = 39
        Me.cmdCreate.Text = "Create Crafting Recipe!"
        Me.cmdCreate.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(34, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(507, 240)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'lstIngredients
        '
        Me.lstIngredients.BackColor = System.Drawing.Color.White
        Me.lstIngredients.FormattingEnabled = True
        Me.lstIngredients.ItemHeight = 16
        Me.lstIngredients.Location = New System.Drawing.Point(67, 80)
        Me.lstIngredients.Name = "lstIngredients"
        Me.lstIngredients.Size = New System.Drawing.Size(191, 148)
        Me.lstIngredients.TabIndex = 42
        '
        'numInputID
        '
        Me.numInputID.Location = New System.Drawing.Point(117, 234)
        Me.numInputID.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numInputID.Name = "numInputID"
        Me.numInputID.Size = New System.Drawing.Size(96, 22)
        Me.numInputID.TabIndex = 43
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(235, 234)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(23, 22)
        Me.cmdAdd.TabIndex = 44
        Me.cmdAdd.Text = "+"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(67, 234)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(23, 22)
        Me.cmdDelete.TabIndex = 45
        Me.cmdDelete.Text = "-"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'numOutput
        '
        Me.numOutput.Location = New System.Drawing.Point(420, 157)
        Me.numOutput.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numOutput.Name = "numOutput"
        Me.numOutput.Size = New System.Drawing.Size(89, 22)
        Me.numOutput.TabIndex = 46
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.BackColor = System.Drawing.Color.Gray
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutput.ForeColor = System.Drawing.Color.White
        Me.lblOutput.Location = New System.Drawing.Point(437, 135)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(57, 19)
        Me.lblOutput.TabIndex = 47
        Me.lblOutput.Text = "Output:"
        '
        'numOutputNumber
        '
        Me.numOutputNumber.Location = New System.Drawing.Point(450, 185)
        Me.numOutputNumber.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numOutputNumber.Name = "numOutputNumber"
        Me.numOutputNumber.Size = New System.Drawing.Size(59, 22)
        Me.numOutputNumber.TabIndex = 48
        '
        'lblHowMuch
        '
        Me.lblHowMuch.AutoSize = True
        Me.lblHowMuch.BackColor = System.Drawing.Color.Gray
        Me.lblHowMuch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHowMuch.ForeColor = System.Drawing.Color.White
        Me.lblHowMuch.Location = New System.Drawing.Point(428, 187)
        Me.lblHowMuch.Name = "lblHowMuch"
        Me.lblHowMuch.Size = New System.Drawing.Size(16, 19)
        Me.lblHowMuch.TabIndex = 49
        Me.lblHowMuch.Text = "x"
        '
        'AddCrafting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 401)
        Me.Controls.Add(Me.lblHowMuch)
        Me.Controls.Add(Me.numOutputNumber)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.numOutput)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.numInputID)
        Me.Controls.Add(Me.lstIngredients)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdCreate)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblAddItem)
        Me.Name = "AddCrafting"
        Me.Text = "Add Crafting Recipe"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numInputID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numOutput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numOutputNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAddItem As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents cmdCreate As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lstIngredients As ListBox
    Friend WithEvents numInputID As NumericUpDown
    Friend WithEvents cmdAdd As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents numOutput As NumericUpDown
    Friend WithEvents lblOutput As Label
    Friend WithEvents numOutputNumber As NumericUpDown
    Friend WithEvents lblHowMuch As Label
End Class
