<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RmrCalc
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
        Me.lblBody = New System.Windows.Forms.Label()
        Me.radBodyMale = New System.Windows.Forms.RadioButton()
        Me.radBodyFemale = New System.Windows.Forms.RadioButton()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblOutputMessage = New System.Windows.Forms.Label()
        Me.lblOutputRMR = New System.Windows.Forms.Label()
        Me.radWeightKilos = New System.Windows.Forms.RadioButton()
        Me.panBody = New System.Windows.Forms.Panel()
        Me.panWeight = New System.Windows.Forms.Panel()
        Me.radWeightPounds = New System.Windows.Forms.RadioButton()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.panHeight = New System.Windows.Forms.Panel()
        Me.radHeightCentimeters = New System.Windows.Forms.RadioButton()
        Me.radHeightInch = New System.Windows.Forms.RadioButton()
        Me.radFitness1 = New System.Windows.Forms.RadioButton()
        Me.radFitness2 = New System.Windows.Forms.RadioButton()
        Me.radFitness3 = New System.Windows.Forms.RadioButton()
        Me.radFitness4 = New System.Windows.Forms.RadioButton()
        Me.radFitness5 = New System.Windows.Forms.RadioButton()
        Me.lblFitnessLevel = New System.Windows.Forms.Label()
        Me.lblCaloriesPerDay = New System.Windows.Forms.Label()
        Me.lblOutputCalories = New System.Windows.Forms.Label()
        Me.panOutput = New System.Windows.Forms.Panel()
        Me.panBody.SuspendLayout()
        Me.panWeight.SuspendLayout()
        Me.panHeight.SuspendLayout()
        Me.panOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBody
        '
        Me.lblBody.AutoSize = True
        Me.lblBody.Location = New System.Drawing.Point(12, 9)
        Me.lblBody.Name = "lblBody"
        Me.lblBody.Size = New System.Drawing.Size(61, 13)
        Me.lblBody.TabIndex = 1
        Me.lblBody.Text = "Body Type:"
        '
        'radBodyMale
        '
        Me.radBodyMale.AutoSize = True
        Me.radBodyMale.Location = New System.Drawing.Point(8, 6)
        Me.radBodyMale.Name = "radBodyMale"
        Me.radBodyMale.Size = New System.Drawing.Size(48, 17)
        Me.radBodyMale.TabIndex = 2
        Me.radBodyMale.TabStop = True
        Me.radBodyMale.Text = "Male"
        Me.radBodyMale.UseVisualStyleBackColor = True
        '
        'radBodyFemale
        '
        Me.radBodyFemale.AutoSize = True
        Me.radBodyFemale.Location = New System.Drawing.Point(62, 6)
        Me.radBodyFemale.Name = "radBodyFemale"
        Me.radBodyFemale.Size = New System.Drawing.Size(59, 17)
        Me.radBodyFemale.TabIndex = 3
        Me.radBodyFemale.TabStop = True
        Me.radBodyFemale.Text = "Female"
        Me.radBodyFemale.UseVisualStyleBackColor = True
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(31, 40)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(44, 13)
        Me.lblWeight.TabIndex = 4
        Me.lblWeight.Text = "Weight:"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(80, 38)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(53, 20)
        Me.txtWeight.TabIndex = 5
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(80, 109)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(53, 20)
        Me.txtAge.TabIndex = 8
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(46, 112)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(29, 13)
        Me.lblAge.TabIndex = 9
        Me.lblAge.Text = "Age:"
        '
        'lblOutputMessage
        '
        Me.lblOutputMessage.AutoSize = True
        Me.lblOutputMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblOutputMessage.Location = New System.Drawing.Point(11, 0)
        Me.lblOutputMessage.Name = "lblOutputMessage"
        Me.lblOutputMessage.Size = New System.Drawing.Size(121, 26)
        Me.lblOutputMessage.TabIndex = 11
        Me.lblOutputMessage.Text = "Your RMR:"
        '
        'lblOutputRMR
        '
        Me.lblOutputRMR.AutoSize = True
        Me.lblOutputRMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.lblOutputRMR.Location = New System.Drawing.Point(9, 25)
        Me.lblOutputRMR.Name = "lblOutputRMR"
        Me.lblOutputRMR.Size = New System.Drawing.Size(0, 37)
        Me.lblOutputRMR.TabIndex = 12
        '
        'radWeightKilos
        '
        Me.radWeightKilos.AutoSize = True
        Me.radWeightKilos.Location = New System.Drawing.Point(51, 9)
        Me.radWeightKilos.Name = "radWeightKilos"
        Me.radWeightKilos.Size = New System.Drawing.Size(40, 17)
        Me.radWeightKilos.TabIndex = 7
        Me.radWeightKilos.Text = "kg."
        Me.radWeightKilos.UseVisualStyleBackColor = True
        '
        'panBody
        '
        Me.panBody.Controls.Add(Me.radBodyMale)
        Me.panBody.Controls.Add(Me.radBodyFemale)
        Me.panBody.Location = New System.Drawing.Point(79, 0)
        Me.panBody.Name = "panBody"
        Me.panBody.Size = New System.Drawing.Size(136, 32)
        Me.panBody.TabIndex = 17
        '
        'panWeight
        '
        Me.panWeight.Controls.Add(Me.radWeightPounds)
        Me.panWeight.Controls.Add(Me.radWeightKilos)
        Me.panWeight.Location = New System.Drawing.Point(141, 29)
        Me.panWeight.Name = "panWeight"
        Me.panWeight.Size = New System.Drawing.Size(101, 39)
        Me.panWeight.TabIndex = 18
        '
        'radWeightPounds
        '
        Me.radWeightPounds.AutoSize = True
        Me.radWeightPounds.Checked = True
        Me.radWeightPounds.Location = New System.Drawing.Point(12, 9)
        Me.radWeightPounds.Name = "radWeightPounds"
        Me.radWeightPounds.Size = New System.Drawing.Size(36, 17)
        Me.radWeightPounds.TabIndex = 8
        Me.radWeightPounds.TabStop = True
        Me.radWeightPounds.Text = "lb."
        Me.radWeightPounds.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnSubmit.Location = New System.Drawing.Point(140, 113)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(101, 33)
        Me.btnSubmit.TabIndex = 19
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(34, 77)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(41, 13)
        Me.lblHeight.TabIndex = 20
        Me.lblHeight.Text = "Height:"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(80, 74)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(53, 20)
        Me.txtHeight.TabIndex = 21
        '
        'panHeight
        '
        Me.panHeight.Controls.Add(Me.radHeightCentimeters)
        Me.panHeight.Controls.Add(Me.radHeightInch)
        Me.panHeight.Location = New System.Drawing.Point(141, 61)
        Me.panHeight.Name = "panHeight"
        Me.panHeight.Size = New System.Drawing.Size(101, 41)
        Me.panHeight.TabIndex = 22
        '
        'radHeightCentimeters
        '
        Me.radHeightCentimeters.AutoSize = True
        Me.radHeightCentimeters.Location = New System.Drawing.Point(51, 14)
        Me.radHeightCentimeters.Name = "radHeightCentimeters"
        Me.radHeightCentimeters.Size = New System.Drawing.Size(42, 17)
        Me.radHeightCentimeters.TabIndex = 1
        Me.radHeightCentimeters.TabStop = True
        Me.radHeightCentimeters.Text = "cm."
        Me.radHeightCentimeters.UseVisualStyleBackColor = True
        '
        'radHeightInch
        '
        Me.radHeightInch.AutoSize = True
        Me.radHeightInch.Checked = True
        Me.radHeightInch.Location = New System.Drawing.Point(12, 14)
        Me.radHeightInch.Name = "radHeightInch"
        Me.radHeightInch.Size = New System.Drawing.Size(36, 17)
        Me.radHeightInch.TabIndex = 0
        Me.radHeightInch.TabStop = True
        Me.radHeightInch.Text = "in."
        Me.radHeightInch.UseVisualStyleBackColor = True
        '
        'radFitness1
        '
        Me.radFitness1.AutoSize = True
        Me.radFitness1.Location = New System.Drawing.Point(148, 9)
        Me.radFitness1.Name = "radFitness1"
        Me.radFitness1.Size = New System.Drawing.Size(31, 17)
        Me.radFitness1.TabIndex = 23
        Me.radFitness1.Text = "1"
        Me.radFitness1.UseVisualStyleBackColor = True
        '
        'radFitness2
        '
        Me.radFitness2.AutoSize = True
        Me.radFitness2.Location = New System.Drawing.Point(180, 9)
        Me.radFitness2.Name = "radFitness2"
        Me.radFitness2.Size = New System.Drawing.Size(31, 17)
        Me.radFitness2.TabIndex = 24
        Me.radFitness2.Text = "2"
        Me.radFitness2.UseVisualStyleBackColor = True
        '
        'radFitness3
        '
        Me.radFitness3.AutoSize = True
        Me.radFitness3.Checked = True
        Me.radFitness3.Location = New System.Drawing.Point(211, 9)
        Me.radFitness3.Name = "radFitness3"
        Me.radFitness3.Size = New System.Drawing.Size(31, 17)
        Me.radFitness3.TabIndex = 25
        Me.radFitness3.TabStop = True
        Me.radFitness3.Text = "3"
        Me.radFitness3.UseVisualStyleBackColor = True
        '
        'radFitness4
        '
        Me.radFitness4.AutoSize = True
        Me.radFitness4.Location = New System.Drawing.Point(166, 29)
        Me.radFitness4.Name = "radFitness4"
        Me.radFitness4.Size = New System.Drawing.Size(31, 17)
        Me.radFitness4.TabIndex = 26
        Me.radFitness4.Text = "4"
        Me.radFitness4.UseVisualStyleBackColor = True
        '
        'radFitness5
        '
        Me.radFitness5.AutoSize = True
        Me.radFitness5.Location = New System.Drawing.Point(198, 29)
        Me.radFitness5.Name = "radFitness5"
        Me.radFitness5.Size = New System.Drawing.Size(31, 17)
        Me.radFitness5.TabIndex = 27
        Me.radFitness5.Text = "5"
        Me.radFitness5.UseVisualStyleBackColor = True
        '
        'lblFitnessLevel
        '
        Me.lblFitnessLevel.AutoSize = True
        Me.lblFitnessLevel.Location = New System.Drawing.Point(160, 49)
        Me.lblFitnessLevel.Name = "lblFitnessLevel"
        Me.lblFitnessLevel.Size = New System.Drawing.Size(69, 13)
        Me.lblFitnessLevel.TabIndex = 28
        Me.lblFitnessLevel.Text = "Fitness Level"
        '
        'lblCaloriesPerDay
        '
        Me.lblCaloriesPerDay.AutoSize = True
        Me.lblCaloriesPerDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblCaloriesPerDay.Location = New System.Drawing.Point(13, 71)
        Me.lblCaloriesPerDay.Name = "lblCaloriesPerDay"
        Me.lblCaloriesPerDay.Size = New System.Drawing.Size(141, 25)
        Me.lblCaloriesPerDay.TabIndex = 29
        Me.lblCaloriesPerDay.Text = "Calories / Day:"
        '
        'lblOutputCalories
        '
        Me.lblOutputCalories.AutoSize = True
        Me.lblOutputCalories.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblOutputCalories.Location = New System.Drawing.Point(152, 71)
        Me.lblOutputCalories.Name = "lblOutputCalories"
        Me.lblOutputCalories.Size = New System.Drawing.Size(0, 26)
        Me.lblOutputCalories.TabIndex = 30
        '
        'panOutput
        '
        Me.panOutput.Controls.Add(Me.lblOutputMessage)
        Me.panOutput.Controls.Add(Me.lblOutputCalories)
        Me.panOutput.Controls.Add(Me.lblOutputRMR)
        Me.panOutput.Controls.Add(Me.lblCaloriesPerDay)
        Me.panOutput.Controls.Add(Me.radFitness1)
        Me.panOutput.Controls.Add(Me.lblFitnessLevel)
        Me.panOutput.Controls.Add(Me.radFitness2)
        Me.panOutput.Controls.Add(Me.radFitness5)
        Me.panOutput.Controls.Add(Me.radFitness3)
        Me.panOutput.Controls.Add(Me.radFitness4)
        Me.panOutput.Location = New System.Drawing.Point(-3, 152)
        Me.panOutput.Name = "panOutput"
        Me.panOutput.Size = New System.Drawing.Size(265, 115)
        Me.panOutput.TabIndex = 31
        Me.panOutput.Visible = False
        '
        'RmrCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 261)
        Me.Controls.Add(Me.panOutput)
        Me.Controls.Add(Me.panHeight)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.panWeight)
        Me.Controls.Add(Me.panBody)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblBody)
        Me.Name = "RmrCalc"
        Me.Text = "RMR Calculator"
        Me.panBody.ResumeLayout(False)
        Me.panBody.PerformLayout()
        Me.panWeight.ResumeLayout(False)
        Me.panWeight.PerformLayout()
        Me.panHeight.ResumeLayout(False)
        Me.panHeight.PerformLayout()
        Me.panOutput.ResumeLayout(False)
        Me.panOutput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBody As Label
    Friend WithEvents radBodyMale As RadioButton
    Friend WithEvents radBodyFemale As RadioButton
    Friend WithEvents lblWeight As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents lblOutputMessage As Label
    Friend WithEvents lblOutputRMR As Label
    Friend WithEvents radWeightKilos As RadioButton
    Friend WithEvents panBody As Panel
    Friend WithEvents panWeight As Panel
    Friend WithEvents radWeightPounds As RadioButton
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblHeight As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents panHeight As Panel
    Friend WithEvents radHeightCentimeters As RadioButton
    Friend WithEvents radHeightInch As RadioButton
    Friend WithEvents radFitness1 As RadioButton
    Friend WithEvents radFitness2 As RadioButton
    Friend WithEvents radFitness3 As RadioButton
    Friend WithEvents radFitness4 As RadioButton
    Friend WithEvents radFitness5 As RadioButton
    Friend WithEvents lblFitnessLevel As Label
    Friend WithEvents lblCaloriesPerDay As Label
    Friend WithEvents lblOutputCalories As Label
    Friend WithEvents panOutput As Panel
End Class
