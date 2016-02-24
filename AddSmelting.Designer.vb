<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddSmelting
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddSmelting))
        Me.lblAddItem = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numInput = New System.Windows.Forms.NumericUpDown()
        Me.numOutput = New System.Windows.Forms.NumericUpDown()
        Me.cmdCreate = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAddItem
        '
        Me.lblAddItem.AutoSize = True
        Me.lblAddItem.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddItem.Location = New System.Drawing.Point(128, 25)
        Me.lblAddItem.Name = "lblAddItem"
        Me.lblAddItem.Size = New System.Drawing.Size(163, 24)
        Me.lblAddItem.TabIndex = 13
        Me.lblAddItem.Text = "Add Smelting Recipe"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 91)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(295, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "In ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(283, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Out ID:"
        '
        'numInput
        '
        Me.numInput.Location = New System.Drawing.Point(341, 119)
        Me.numInput.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numInput.Name = "numInput"
        Me.numInput.Size = New System.Drawing.Size(77, 22)
        Me.numInput.TabIndex = 17
        '
        'numOutput
        '
        Me.numOutput.Location = New System.Drawing.Point(341, 162)
        Me.numOutput.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numOutput.Name = "numOutput"
        Me.numOutput.Size = New System.Drawing.Size(77, 22)
        Me.numOutput.TabIndex = 18
        '
        'cmdCreate
        '
        Me.cmdCreate.Location = New System.Drawing.Point(110, 250)
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.Size = New System.Drawing.Size(205, 32)
        Me.cmdCreate.TabIndex = 22
        Me.cmdCreate.Text = "Create Smelting Recipe!"
        Me.cmdCreate.UseVisualStyleBackColor = True
        '
        'AddSmelting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 294)
        Me.Controls.Add(Me.cmdCreate)
        Me.Controls.Add(Me.numOutput)
        Me.Controls.Add(Me.numInput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblAddItem)
        Me.Name = "AddSmelting"
        Me.Text = "Add Smelting Recipe"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAddItem As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents numInput As NumericUpDown
    Friend WithEvents numOutput As NumericUpDown
    Friend WithEvents cmdCreate As Button
End Class
