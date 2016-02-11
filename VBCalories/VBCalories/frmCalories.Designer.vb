<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalories
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
        Me.components = New System.ComponentModel.Container()
        Me.txtProtein = New System.Windows.Forms.TextBox()
        Me.txtCarbohydrates = New System.Windows.Forms.TextBox()
        Me.txtFat = New System.Windows.Forms.TextBox()
        Me.txtCalories = New System.Windows.Forms.TextBox()
        Me.lblCalories = New System.Windows.Forms.Label()
        Me.lblProtein = New System.Windows.Forms.Label()
        Me.lblCarbohydrates = New System.Windows.Forms.Label()
        Me.lblFat = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblProgrammer = New System.Windows.Forms.Label()
        Me.ttpCalories = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtProtein
        '
        Me.txtProtein.Location = New System.Drawing.Point(165, 200)
        Me.txtProtein.Name = "txtProtein"
        Me.txtProtein.Size = New System.Drawing.Size(100, 20)
        Me.txtProtein.TabIndex = 0
        '
        'txtCarbohydrates
        '
        Me.txtCarbohydrates.Location = New System.Drawing.Point(165, 144)
        Me.txtCarbohydrates.Name = "txtCarbohydrates"
        Me.txtCarbohydrates.Size = New System.Drawing.Size(100, 20)
        Me.txtCarbohydrates.TabIndex = 1
        '
        'txtFat
        '
        Me.txtFat.Location = New System.Drawing.Point(165, 94)
        Me.txtFat.Name = "txtFat"
        Me.txtFat.Size = New System.Drawing.Size(100, 20)
        Me.txtFat.TabIndex = 2
        '
        'txtCalories
        '
        Me.txtCalories.Location = New System.Drawing.Point(165, 321)
        Me.txtCalories.Name = "txtCalories"
        Me.txtCalories.ReadOnly = True
        Me.txtCalories.Size = New System.Drawing.Size(100, 20)
        Me.txtCalories.TabIndex = 3
        '
        'lblCalories
        '
        Me.lblCalories.AutoSize = True
        Me.lblCalories.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalories.Location = New System.Drawing.Point(22, 325)
        Me.lblCalories.Name = "lblCalories"
        Me.lblCalories.Size = New System.Drawing.Size(119, 13)
        Me.lblCalories.TabIndex = 4
        Me.lblCalories.Text = "Total Calories"
        Me.ttpCalories.SetToolTip(Me.lblCalories, "Total amount of calories")
        '
        'lblProtein
        '
        Me.lblProtein.AutoSize = True
        Me.lblProtein.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProtein.Location = New System.Drawing.Point(67, 204)
        Me.lblProtein.Name = "lblProtein"
        Me.lblProtein.Size = New System.Drawing.Size(63, 13)
        Me.lblProtein.TabIndex = 5
        Me.lblProtein.Text = "Protein"
        Me.ttpCalories.SetToolTip(Me.lblProtein, "Amount of protein in the food")
        '
        'lblCarbohydrates
        '
        Me.lblCarbohydrates.AutoSize = True
        Me.lblCarbohydrates.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarbohydrates.Location = New System.Drawing.Point(36, 151)
        Me.lblCarbohydrates.Name = "lblCarbohydrates"
        Me.lblCarbohydrates.Size = New System.Drawing.Size(111, 13)
        Me.lblCarbohydrates.TabIndex = 6
        Me.lblCarbohydrates.Text = "Carbohydrates"
        Me.ttpCalories.SetToolTip(Me.lblCarbohydrates, "Amount of carbohydrates in the food")
        '
        'lblFat
        '
        Me.lblFat.AutoSize = True
        Me.lblFat.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFat.Location = New System.Drawing.Point(86, 98)
        Me.lblFat.Name = "lblFat"
        Me.lblFat.Size = New System.Drawing.Size(31, 13)
        Me.lblFat.TabIndex = 7
        Me.lblFat.Text = "Fat"
        Me.ttpCalories.SetToolTip(Me.lblFat, "Amount of fat in the food")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Handwriting", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(74, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(297, 31)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Marwin Resturaunt"
        Me.ttpCalories.SetToolTip(Me.Label5, "Resturant name")
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(39, 373)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(91, 41)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "C&alculate"
        Me.ttpCalories.SetToolTip(Me.btnCalculate, "Calculates the amount of calories")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(168, 373)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 41)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "C&lear"
        Me.ttpCalories.SetToolTip(Me.btnClear, "Clears the text boxes")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(299, 373)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 41)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "E&xit"
        Me.ttpCalories.SetToolTip(Me.btnExit, "Exitis the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblProgrammer
        '
        Me.lblProgrammer.AutoSize = True
        Me.lblProgrammer.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgrammer.Location = New System.Drawing.Point(114, 448)
        Me.lblProgrammer.Name = "lblProgrammer"
        Me.lblProgrammer.Size = New System.Drawing.Size(208, 11)
        Me.lblProgrammer.TabIndex = 13
        Me.lblProgrammer.Text = "Programmed by Alex Winstanley"
        Me.ttpCalories.SetToolTip(Me.lblProgrammer, "Programmer name")
        '
        'frmCalories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(427, 468)
        Me.Controls.Add(Me.lblProgrammer)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblFat)
        Me.Controls.Add(Me.lblCarbohydrates)
        Me.Controls.Add(Me.lblProtein)
        Me.Controls.Add(Me.lblCalories)
        Me.Controls.Add(Me.txtCalories)
        Me.Controls.Add(Me.txtFat)
        Me.Controls.Add(Me.txtCarbohydrates)
        Me.Controls.Add(Me.txtProtein)
        Me.Name = "frmCalories"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calorie Counter Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtProtein As System.Windows.Forms.TextBox
    Friend WithEvents txtCarbohydrates As System.Windows.Forms.TextBox
    Friend WithEvents txtFat As System.Windows.Forms.TextBox
    Friend WithEvents txtCalories As System.Windows.Forms.TextBox
    Friend WithEvents lblCalories As System.Windows.Forms.Label
    Friend WithEvents lblProtein As System.Windows.Forms.Label
    Friend WithEvents lblCarbohydrates As System.Windows.Forms.Label
    Friend WithEvents lblFat As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblProgrammer As System.Windows.Forms.Label
    Friend WithEvents ttpCalories As System.Windows.Forms.ToolTip

End Class
