<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FitnessCalc
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
        Me.lblYourRmr = New System.Windows.Forms.Label()
        Me.lblOutputRMR = New System.Windows.Forms.Label()
        Me.radWeightKilos = New System.Windows.Forms.RadioButton()
        Me.panBody = New System.Windows.Forms.Panel()
        Me.panWeight = New System.Windows.Forms.Panel()
        Me.radWeightPounds = New System.Windows.Forms.RadioButton()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.panHeight = New System.Windows.Forms.Panel()
        Me.radHeightCm = New System.Windows.Forms.RadioButton()
        Me.radHeightInch = New System.Windows.Forms.RadioButton()
        Me.radFitness1 = New System.Windows.Forms.RadioButton()
        Me.radFitness2 = New System.Windows.Forms.RadioButton()
        Me.radFitness3 = New System.Windows.Forms.RadioButton()
        Me.radFitness4 = New System.Windows.Forms.RadioButton()
        Me.radFitness5 = New System.Windows.Forms.RadioButton()
        Me.lblFitnessLevel = New System.Windows.Forms.Label()
        Me.lblCaloriesPerDay = New System.Windows.Forms.Label()
        Me.lblOutputCalories = New System.Windows.Forms.Label()
        Me.panRmrOutput = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblWaist = New System.Windows.Forms.Label()
        Me.lblWrist = New System.Windows.Forms.Label()
        Me.lblHips = New System.Windows.Forms.Label()
        Me.lblForearm = New System.Windows.Forms.Label()
        Me.txtWaist = New System.Windows.Forms.TextBox()
        Me.txtWrist = New System.Windows.Forms.TextBox()
        Me.txtHips = New System.Windows.Forms.TextBox()
        Me.txtForearm = New System.Windows.Forms.TextBox()
        Me.grpBodyFat = New System.Windows.Forms.GroupBox()
        Me.panHeight2 = New System.Windows.Forms.Panel()
        Me.radHeightCm2 = New System.Windows.Forms.RadioButton()
        Me.radHeightInch2 = New System.Windows.Forms.RadioButton()
        Me.panFemBodyFat = New System.Windows.Forms.Panel()
        Me.grpMain = New System.Windows.Forms.GroupBox()
        Me.panBodyFatOutput = New System.Windows.Forms.Panel()
        Me.lblLeanBodyMass = New System.Windows.Forms.Label()
        Me.lblOutputLeanBodyMass = New System.Windows.Forms.Label()
        Me.lblBodyFat = New System.Windows.Forms.Label()
        Me.lblOutputBodyFat = New System.Windows.Forms.Label()
        Me.panBody.SuspendLayout()
        Me.panWeight.SuspendLayout()
        Me.panHeight.SuspendLayout()
        Me.panRmrOutput.SuspendLayout()
        Me.grpBodyFat.SuspendLayout()
        Me.panHeight2.SuspendLayout()
        Me.panFemBodyFat.SuspendLayout()
        Me.grpMain.SuspendLayout()
        Me.panBodyFatOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBody
        '
        Me.lblBody.AutoSize = True
        Me.lblBody.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBody.Location = New System.Drawing.Point(9, 29)
        Me.lblBody.Name = "lblBody"
        Me.lblBody.Size = New System.Drawing.Size(71, 13)
        Me.lblBody.TabIndex = 1
        Me.lblBody.Text = "Body Type:"
        '
        'radBodyMale
        '
        Me.radBodyMale.AutoSize = True
        Me.radBodyMale.Checked = True
        Me.radBodyMale.Location = New System.Drawing.Point(19, 8)
        Me.radBodyMale.Name = "radBodyMale"
        Me.radBodyMale.Size = New System.Drawing.Size(48, 17)
        Me.radBodyMale.TabIndex = 0
        Me.radBodyMale.TabStop = True
        Me.radBodyMale.Text = "Male"
        Me.radBodyMale.UseVisualStyleBackColor = True
        '
        'radBodyFemale
        '
        Me.radBodyFemale.AutoSize = True
        Me.radBodyFemale.Location = New System.Drawing.Point(83, 8)
        Me.radBodyFemale.Name = "radBodyFemale"
        Me.radBodyFemale.Size = New System.Drawing.Size(59, 17)
        Me.radBodyFemale.TabIndex = 1
        Me.radBodyFemale.TabStop = True
        Me.radBodyFemale.Text = "Female"
        Me.radBodyFemale.UseVisualStyleBackColor = True
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(36, 92)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(44, 13)
        Me.lblWeight.TabIndex = 4
        Me.lblWeight.Text = "Weight:"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(85, 90)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(53, 20)
        Me.txtWeight.TabIndex = 1
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(85, 123)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(53, 20)
        Me.txtAge.TabIndex = 2
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(51, 126)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(29, 13)
        Me.lblAge.TabIndex = 9
        Me.lblAge.Text = "Age:"
        '
        'lblYourRmr
        '
        Me.lblYourRmr.AutoSize = True
        Me.lblYourRmr.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblYourRmr.Location = New System.Drawing.Point(11, 0)
        Me.lblYourRmr.Name = "lblYourRmr"
        Me.lblYourRmr.Size = New System.Drawing.Size(121, 26)
        Me.lblYourRmr.TabIndex = 11
        Me.lblYourRmr.Text = "Your RMR:"
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
        Me.radWeightKilos.TabIndex = 1
        Me.radWeightKilos.TabStop = True
        Me.radWeightKilos.Text = "kg."
        Me.radWeightKilos.UseVisualStyleBackColor = True
        '
        'panBody
        '
        Me.panBody.Controls.Add(Me.radBodyMale)
        Me.panBody.Controls.Add(Me.radBodyFemale)
        Me.panBody.Location = New System.Drawing.Point(86, 19)
        Me.panBody.Name = "panBody"
        Me.panBody.Size = New System.Drawing.Size(161, 32)
        Me.panBody.TabIndex = 3
        '
        'panWeight
        '
        Me.panWeight.Controls.Add(Me.radWeightPounds)
        Me.panWeight.Controls.Add(Me.radWeightKilos)
        Me.panWeight.Location = New System.Drawing.Point(146, 81)
        Me.panWeight.Name = "panWeight"
        Me.panWeight.Size = New System.Drawing.Size(101, 39)
        Me.panWeight.TabIndex = 5
        '
        'radWeightPounds
        '
        Me.radWeightPounds.AutoSize = True
        Me.radWeightPounds.Checked = True
        Me.radWeightPounds.Location = New System.Drawing.Point(12, 9)
        Me.radWeightPounds.Name = "radWeightPounds"
        Me.radWeightPounds.Size = New System.Drawing.Size(36, 17)
        Me.radWeightPounds.TabIndex = 0
        Me.radWeightPounds.TabStop = True
        Me.radWeightPounds.Text = "lb."
        Me.radWeightPounds.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnSubmit.Location = New System.Drawing.Point(154, 114)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(101, 33)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(39, 60)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(41, 13)
        Me.lblHeight.TabIndex = 20
        Me.lblHeight.Text = "Height:"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(85, 57)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(53, 20)
        Me.txtHeight.TabIndex = 0
        '
        'panHeight
        '
        Me.panHeight.Controls.Add(Me.radHeightCm)
        Me.panHeight.Controls.Add(Me.radHeightInch)
        Me.panHeight.Location = New System.Drawing.Point(146, 44)
        Me.panHeight.Name = "panHeight"
        Me.panHeight.Size = New System.Drawing.Size(101, 41)
        Me.panHeight.TabIndex = 4
        '
        'radHeightCm
        '
        Me.radHeightCm.AutoSize = True
        Me.radHeightCm.Location = New System.Drawing.Point(51, 14)
        Me.radHeightCm.Name = "radHeightCm"
        Me.radHeightCm.Size = New System.Drawing.Size(42, 17)
        Me.radHeightCm.TabIndex = 1
        Me.radHeightCm.TabStop = True
        Me.radHeightCm.Text = "cm."
        Me.radHeightCm.UseVisualStyleBackColor = True
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
        Me.radFitness1.Location = New System.Drawing.Point(140, 3)
        Me.radFitness1.Name = "radFitness1"
        Me.radFitness1.Size = New System.Drawing.Size(31, 17)
        Me.radFitness1.TabIndex = 0
        Me.radFitness1.TabStop = True
        Me.radFitness1.Text = "1"
        Me.radFitness1.UseVisualStyleBackColor = True
        '
        'radFitness2
        '
        Me.radFitness2.AutoSize = True
        Me.radFitness2.Location = New System.Drawing.Point(172, 3)
        Me.radFitness2.Name = "radFitness2"
        Me.radFitness2.Size = New System.Drawing.Size(31, 17)
        Me.radFitness2.TabIndex = 1
        Me.radFitness2.TabStop = True
        Me.radFitness2.Text = "2"
        Me.radFitness2.UseVisualStyleBackColor = True
        '
        'radFitness3
        '
        Me.radFitness3.AutoSize = True
        Me.radFitness3.Checked = True
        Me.radFitness3.Location = New System.Drawing.Point(203, 3)
        Me.radFitness3.Name = "radFitness3"
        Me.radFitness3.Size = New System.Drawing.Size(31, 17)
        Me.radFitness3.TabIndex = 2
        Me.radFitness3.TabStop = True
        Me.radFitness3.Text = "3"
        Me.radFitness3.UseVisualStyleBackColor = True
        '
        'radFitness4
        '
        Me.radFitness4.AutoSize = True
        Me.radFitness4.Location = New System.Drawing.Point(158, 23)
        Me.radFitness4.Name = "radFitness4"
        Me.radFitness4.Size = New System.Drawing.Size(31, 17)
        Me.radFitness4.TabIndex = 3
        Me.radFitness4.TabStop = True
        Me.radFitness4.Text = "4"
        Me.radFitness4.UseVisualStyleBackColor = True
        '
        'radFitness5
        '
        Me.radFitness5.AutoSize = True
        Me.radFitness5.Location = New System.Drawing.Point(190, 23)
        Me.radFitness5.Name = "radFitness5"
        Me.radFitness5.Size = New System.Drawing.Size(31, 17)
        Me.radFitness5.TabIndex = 4
        Me.radFitness5.TabStop = True
        Me.radFitness5.Text = "5"
        Me.radFitness5.UseVisualStyleBackColor = True
        '
        'lblFitnessLevel
        '
        Me.lblFitnessLevel.AutoSize = True
        Me.lblFitnessLevel.Location = New System.Drawing.Point(152, 43)
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
        Me.lblOutputCalories.Location = New System.Drawing.Point(147, 71)
        Me.lblOutputCalories.Name = "lblOutputCalories"
        Me.lblOutputCalories.Size = New System.Drawing.Size(0, 26)
        Me.lblOutputCalories.TabIndex = 30
        '
        'panRmrOutput
        '
        Me.panRmrOutput.Controls.Add(Me.radFitness3)
        Me.panRmrOutput.Controls.Add(Me.lblYourRmr)
        Me.panRmrOutput.Controls.Add(Me.lblOutputCalories)
        Me.panRmrOutput.Controls.Add(Me.lblOutputRMR)
        Me.panRmrOutput.Controls.Add(Me.lblCaloriesPerDay)
        Me.panRmrOutput.Controls.Add(Me.radFitness1)
        Me.panRmrOutput.Controls.Add(Me.lblFitnessLevel)
        Me.panRmrOutput.Controls.Add(Me.radFitness2)
        Me.panRmrOutput.Controls.Add(Me.radFitness5)
        Me.panRmrOutput.Controls.Add(Me.radFitness4)
        Me.panRmrOutput.Location = New System.Drawing.Point(18, 190)
        Me.panRmrOutput.Name = "panRmrOutput"
        Me.panRmrOutput.Size = New System.Drawing.Size(249, 106)
        Me.panRmrOutput.TabIndex = 2
        Me.panRmrOutput.Visible = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New System.Drawing.Point(114, 9)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(145, 13)
        Me.lblWelcome.TabIndex = 4
        Me.lblWelcome.Text = "Welcome to the Fitness Calc!"
        '
        'lblWaist
        '
        Me.lblWaist.AutoSize = True
        Me.lblWaist.Location = New System.Drawing.Point(18, 45)
        Me.lblWaist.Name = "lblWaist"
        Me.lblWaist.Size = New System.Drawing.Size(37, 13)
        Me.lblWaist.TabIndex = 3
        Me.lblWaist.Text = "Waist:"
        '
        'lblWrist
        '
        Me.lblWrist.AutoSize = True
        Me.lblWrist.Location = New System.Drawing.Point(17, 76)
        Me.lblWrist.Name = "lblWrist"
        Me.lblWrist.Size = New System.Drawing.Size(34, 13)
        Me.lblWrist.TabIndex = 34
        Me.lblWrist.Text = "Wrist:"
        '
        'lblHips
        '
        Me.lblHips.AutoSize = True
        Me.lblHips.Location = New System.Drawing.Point(20, 10)
        Me.lblHips.Name = "lblHips"
        Me.lblHips.Size = New System.Drawing.Size(31, 13)
        Me.lblHips.TabIndex = 35
        Me.lblHips.Text = "Hips:"
        '
        'lblForearm
        '
        Me.lblForearm.AutoSize = True
        Me.lblForearm.Location = New System.Drawing.Point(3, 43)
        Me.lblForearm.Name = "lblForearm"
        Me.lblForearm.Size = New System.Drawing.Size(48, 13)
        Me.lblForearm.TabIndex = 36
        Me.lblForearm.Text = "Forearm:"
        '
        'txtWaist
        '
        Me.txtWaist.Location = New System.Drawing.Point(60, 43)
        Me.txtWaist.Name = "txtWaist"
        Me.txtWaist.Size = New System.Drawing.Size(53, 20)
        Me.txtWaist.TabIndex = 1
        '
        'txtWrist
        '
        Me.txtWrist.Location = New System.Drawing.Point(57, 73)
        Me.txtWrist.Name = "txtWrist"
        Me.txtWrist.Size = New System.Drawing.Size(53, 20)
        Me.txtWrist.TabIndex = 2
        '
        'txtHips
        '
        Me.txtHips.Location = New System.Drawing.Point(57, 7)
        Me.txtHips.Name = "txtHips"
        Me.txtHips.Size = New System.Drawing.Size(53, 20)
        Me.txtHips.TabIndex = 0
        '
        'txtForearm
        '
        Me.txtForearm.Location = New System.Drawing.Point(57, 40)
        Me.txtForearm.Name = "txtForearm"
        Me.txtForearm.Size = New System.Drawing.Size(53, 20)
        Me.txtForearm.TabIndex = 1
        '
        'grpBodyFat
        '
        Me.grpBodyFat.Controls.Add(Me.panHeight2)
        Me.grpBodyFat.Controls.Add(Me.panFemBodyFat)
        Me.grpBodyFat.Controls.Add(Me.lblWaist)
        Me.grpBodyFat.Controls.Add(Me.txtWaist)
        Me.grpBodyFat.Location = New System.Drawing.Point(279, 9)
        Me.grpBodyFat.Name = "grpBodyFat"
        Me.grpBodyFat.Size = New System.Drawing.Size(131, 172)
        Me.grpBodyFat.TabIndex = 1
        Me.grpBodyFat.TabStop = False
        Me.grpBodyFat.Text = "Body Fat (Optional)"
        '
        'panHeight2
        '
        Me.panHeight2.Controls.Add(Me.radHeightCm2)
        Me.panHeight2.Controls.Add(Me.radHeightInch2)
        Me.panHeight2.Location = New System.Drawing.Point(35, 16)
        Me.panHeight2.Name = "panHeight2"
        Me.panHeight2.Size = New System.Drawing.Size(90, 27)
        Me.panHeight2.TabIndex = 0
        '
        'radHeightCm2
        '
        Me.radHeightCm2.AutoSize = True
        Me.radHeightCm2.Location = New System.Drawing.Point(48, 4)
        Me.radHeightCm2.Name = "radHeightCm2"
        Me.radHeightCm2.Size = New System.Drawing.Size(42, 17)
        Me.radHeightCm2.TabIndex = 1
        Me.radHeightCm2.TabStop = True
        Me.radHeightCm2.Text = "cm."
        Me.radHeightCm2.UseVisualStyleBackColor = True
        '
        'radHeightInch2
        '
        Me.radHeightInch2.AutoSize = True
        Me.radHeightInch2.Checked = True
        Me.radHeightInch2.Location = New System.Drawing.Point(9, 3)
        Me.radHeightInch2.Name = "radHeightInch2"
        Me.radHeightInch2.Size = New System.Drawing.Size(36, 17)
        Me.radHeightInch2.TabIndex = 0
        Me.radHeightInch2.TabStop = True
        Me.radHeightInch2.Text = "in."
        Me.radHeightInch2.UseVisualStyleBackColor = True
        '
        'panFemBodyFat
        '
        Me.panFemBodyFat.Controls.Add(Me.lblHips)
        Me.panFemBodyFat.Controls.Add(Me.lblForearm)
        Me.panFemBodyFat.Controls.Add(Me.txtForearm)
        Me.panFemBodyFat.Controls.Add(Me.txtWrist)
        Me.panFemBodyFat.Controls.Add(Me.lblWrist)
        Me.panFemBodyFat.Controls.Add(Me.txtHips)
        Me.panFemBodyFat.Location = New System.Drawing.Point(3, 66)
        Me.panFemBodyFat.Name = "panFemBodyFat"
        Me.panFemBodyFat.Size = New System.Drawing.Size(122, 100)
        Me.panFemBodyFat.TabIndex = 2
        Me.panFemBodyFat.Visible = False
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.btnSubmit)
        Me.grpMain.Controls.Add(Me.panBody)
        Me.grpMain.Controls.Add(Me.lblHeight)
        Me.grpMain.Controls.Add(Me.panWeight)
        Me.grpMain.Controls.Add(Me.txtHeight)
        Me.grpMain.Controls.Add(Me.lblWeight)
        Me.grpMain.Controls.Add(Me.panHeight)
        Me.grpMain.Controls.Add(Me.txtWeight)
        Me.grpMain.Controls.Add(Me.lblBody)
        Me.grpMain.Controls.Add(Me.txtAge)
        Me.grpMain.Controls.Add(Me.lblAge)
        Me.grpMain.Location = New System.Drawing.Point(12, 25)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(261, 156)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        Me.grpMain.Text = "RMR (Required)"
        '
        'panBodyFatOutput
        '
        Me.panBodyFatOutput.Controls.Add(Me.lblLeanBodyMass)
        Me.panBodyFatOutput.Controls.Add(Me.lblOutputLeanBodyMass)
        Me.panBodyFatOutput.Controls.Add(Me.lblBodyFat)
        Me.panBodyFatOutput.Controls.Add(Me.lblOutputBodyFat)
        Me.panBodyFatOutput.Location = New System.Drawing.Point(258, 181)
        Me.panBodyFatOutput.Name = "panBodyFatOutput"
        Me.panBodyFatOutput.Size = New System.Drawing.Size(142, 115)
        Me.panBodyFatOutput.TabIndex = 3
        Me.panBodyFatOutput.Visible = False
        '
        'lblLeanBodyMass
        '
        Me.lblLeanBodyMass.AutoSize = True
        Me.lblLeanBodyMass.Location = New System.Drawing.Point(8, 83)
        Me.lblLeanBodyMass.Name = "lblLeanBodyMass"
        Me.lblLeanBodyMass.Size = New System.Drawing.Size(89, 13)
        Me.lblLeanBodyMass.TabIndex = 29
        Me.lblLeanBodyMass.Text = "Lean Body Mass:"
        '
        'lblOutputLeanBodyMass
        '
        Me.lblOutputLeanBodyMass.AutoSize = True
        Me.lblOutputLeanBodyMass.Location = New System.Drawing.Point(92, 83)
        Me.lblOutputLeanBodyMass.Name = "lblOutputLeanBodyMass"
        Me.lblOutputLeanBodyMass.Size = New System.Drawing.Size(0, 13)
        Me.lblOutputLeanBodyMass.TabIndex = 30
        '
        'lblBodyFat
        '
        Me.lblBodyFat.AutoSize = True
        Me.lblBodyFat.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblBodyFat.Location = New System.Drawing.Point(25, 17)
        Me.lblBodyFat.Name = "lblBodyFat"
        Me.lblBodyFat.Size = New System.Drawing.Size(105, 26)
        Me.lblBodyFat.TabIndex = 12
        Me.lblBodyFat.Text = "Body Fat:"
        '
        'lblOutputBodyFat
        '
        Me.lblOutputBodyFat.AutoSize = True
        Me.lblOutputBodyFat.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblOutputBodyFat.Location = New System.Drawing.Point(23, 39)
        Me.lblOutputBodyFat.Name = "lblOutputBodyFat"
        Me.lblOutputBodyFat.Size = New System.Drawing.Size(0, 37)
        Me.lblOutputBodyFat.TabIndex = 13
        '
        'FitnessCalc
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 298)
        Me.Controls.Add(Me.panBodyFatOutput)
        Me.Controls.Add(Me.grpBodyFat)
        Me.Controls.Add(Me.grpMain)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.panRmrOutput)
        Me.Name = "FitnessCalc"
        Me.Text = "Fitness Calculator"
        Me.panBody.ResumeLayout(False)
        Me.panBody.PerformLayout()
        Me.panWeight.ResumeLayout(False)
        Me.panWeight.PerformLayout()
        Me.panHeight.ResumeLayout(False)
        Me.panHeight.PerformLayout()
        Me.panRmrOutput.ResumeLayout(False)
        Me.panRmrOutput.PerformLayout()
        Me.grpBodyFat.ResumeLayout(False)
        Me.grpBodyFat.PerformLayout()
        Me.panHeight2.ResumeLayout(False)
        Me.panHeight2.PerformLayout()
        Me.panFemBodyFat.ResumeLayout(False)
        Me.panFemBodyFat.PerformLayout()
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.panBodyFatOutput.ResumeLayout(False)
        Me.panBodyFatOutput.PerformLayout()
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
    Friend WithEvents lblYourRmr As Label
    Friend WithEvents lblOutputRMR As Label
    Friend WithEvents radWeightKilos As RadioButton
    Friend WithEvents panBody As Panel
    Friend WithEvents panWeight As Panel
    Friend WithEvents radWeightPounds As RadioButton
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblHeight As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents panHeight As Panel
    Friend WithEvents radHeightCm As RadioButton
    Friend WithEvents radHeightInch As RadioButton
    Friend WithEvents radFitness1 As RadioButton
    Friend WithEvents radFitness2 As RadioButton
    Friend WithEvents radFitness3 As RadioButton
    Friend WithEvents radFitness4 As RadioButton
    Friend WithEvents radFitness5 As RadioButton
    Friend WithEvents lblFitnessLevel As Label
    Friend WithEvents lblCaloriesPerDay As Label
    Friend WithEvents lblOutputCalories As Label
    Friend WithEvents panRmrOutput As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblWaist As Label
    Friend WithEvents lblWrist As Label
    Friend WithEvents lblHips As Label
    Friend WithEvents lblForearm As Label
    Friend WithEvents txtWaist As TextBox
    Friend WithEvents txtWrist As TextBox
    Friend WithEvents txtHips As TextBox
    Friend WithEvents txtForearm As TextBox
    Friend WithEvents grpBodyFat As GroupBox
    Friend WithEvents grpMain As GroupBox
    Friend WithEvents panFemBodyFat As Panel
    Friend WithEvents panBodyFatOutput As Panel
    Friend WithEvents lblBodyFat As Label
    Friend WithEvents lblLeanBodyMass As Label
    Friend WithEvents lblOutputBodyFat As Label
    Friend WithEvents lblOutputLeanBodyMass As Label
    Friend WithEvents panHeight2 As Panel
    Friend WithEvents radHeightCm2 As RadioButton
    Friend WithEvents radHeightInch2 As RadioButton
End Class
