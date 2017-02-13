Option Strict On
Option Explicit On

Public Class FitnessCalc
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim radioButtonsChecked As RadioButton() = {radWeightPounds, radHeightInch, radBodyMale, radFitness1, radFitness2, radFitness3, radFitness4, radFitness5}
        Dim user As Measurements = New Measurements
        Dim ctr As Integer = 0
        Dim userMeasurementBoxes As TextBox() = {txtWeight, txtHeight, txtAge, txtWrist, txtWaist, txtHips, txtForearm}
        Dim holdRadios = New List(Of Boolean) From {False}
        Dim holdMeasurements = New List(Of Double) From {0}

        For Each element In radioButtonsChecked
            If element.Checked Then
                holdRadios.Add(True)
            Else holdRadios.Add(False)
            End If
        Next

        For Each element In userMeasurementBoxes
            If String.IsNullOrEmpty(element.Text) Then
                holdMeasurements.Add(0)
            Else
                holdMeasurements.Add(CDbl(element.Text))
            End If
        Next

        holdRadios.RemoveAt(0)
        holdMeasurements.RemoveAt(0)

        user.Input(holdMeasurements, holdRadios)

        panRmrOutput.Visible = False
        panBodyFatOutput.Visible = False

        If user.Rmr() <> 0 Then
            lblOutputRMR.Text = (Math.Round(user.Rmr(), 2)).ToString
            lblOutputCalories.Text = (Math.Round(user.Calories(), 2)).ToString
            panRmrOutput.Visible = True
        End If

        If user.LeanBodyWeight() <> 0 Then
            lblOutputBodyFat.Text = (Math.Round(user.BodyFatPercentage(), 2)).ToString & "%"
            lblOutputLeanBodyMass.Text = (Math.Round(user.LeanBodyWeight(), 2)).ToString & "Kg"
            panBodyFatOutput.Visible = True
        End If

        user.Clear()
    End Sub
    Public Class Measurements
        Shared userMeasurements As List(Of Double) = New List(Of Double)
        Shared radiosChecked As List(Of Boolean) = New List(Of Boolean)
        Public Sub Input(ByVal userInputMeasurements As List(Of Double), ByVal userRadiosChecked As List(Of Boolean))
            userMeasurements = userInputMeasurements
            radiosChecked = userRadiosChecked
        End Sub
        Public Sub Clear()
            radiosChecked.Clear()
            userMeasurements.Clear()
        End Sub
        Public Function Rmr() As Double
            If WeightKg() > 0 And HeightCm() > 0 And Age() > 0 Then
                If IsMale() Then
                    Rmr = (10 * WeightKg()) + (6.25 * HeightCm()) - (5 * Age()) + 5
                Else
                    Rmr = (10 * WeightKg()) + (6.25 * HeightCm()) - (5 * Age()) - 161
                End If
            Else
                Rmr = 0
            End If
        End Function

        Public Function BodyFatPercentage() As Double
            If LeanBodyWeight() > 0 Then
                BodyFatPercentage = ((WeightLb() - LeanBodyWeight()) * 100) / WeightLb()
            Else
                BodyFatPercentage = 0
            End If
        End Function
        Public Function LeanBodyWeight() As Double
            If WeightKg() > 0 And Waist() > 0 Then
                If IsMale() Then
                    LeanBodyWeight = ((WeightLb() * 1.082) + 94.42) - (Waist() * 4.15)
                ElseIf Hips() > 0 And Forearm() > 0 And Wrist() > 0 Then
                    LeanBodyWeight = ((((((WeightLb() * 0.732) + 8.987) + (Wrist() / 3.14)) - (Waist() * 0.157)) - (Hips() * 0.249)) + (Forearm() * 0.434))
                Else
                    LeanBodyWeight = 0
                End If
            Else
                LeanBodyWeight = 0
            End If

        End Function
        Public Function Calories() As Double
            Dim outputCalories As Double

            For i = 3 To 7
                If radiosChecked(i) Then
                    outputCalories = 1.2 + ((i - 2) * 0.175)
                End If
            Next
            Calories = outputCalories * Rmr()
        End Function

        Public Shared Function ToInches(ByVal userLength As Double) As Double
            If radiosChecked(1) Then
                ToInches = userLength  'inches
            Else
                ToInches = userLength * 0.393701 'centimeters
            End If
        End Function

        Shared Function ToCm(ByVal userLength As Double) As Double
            If radiosChecked(1) Then
                ToCm = userLength * 2.54  'inches
            Else
                ToCm = userLength 'centimeters
            End If
        End Function

        Shared Function IsMale() As Boolean
            If radiosChecked(2) Then
                IsMale = True
            Else IsMale = False
            End If
        End Function

        Public Shared Function WeightLb() As Double
            If radiosChecked(0) Then
                WeightLb = userMeasurements(0)
            Else
                WeightLb = userMeasurements(0) * 2.20462
            End If
        End Function

        Public Shared Function WeightKg() As Double
            If radiosChecked(0) Then
                WeightKg = userMeasurements(0) * 0.453592
            Else
                WeightKg = userMeasurements(0)
            End If
        End Function

        Function HeightInch() As Double
            HeightInch = ToInches(userMeasurements(1))
        End Function

        Function HeightCm() As Double
            HeightCm = ToCm(userMeasurements(1))
        End Function

        Function Age() As Double
            Age = userMeasurements(2)
        End Function

        Function Wrist() As Double
            Wrist = ToInches(userMeasurements(3))
        End Function
        Function Waist() As Double
            Waist = ToInches(userMeasurements(4))
        End Function
        Function Hips() As Double
            Hips = ToInches(userMeasurements(5))
        End Function
        Function Forearm() As Double
            Forearm = ToInches(userMeasurements(6))
        End Function
    End Class
    Private Sub RadFitness1_CheckedChanged(sender As Object, e As EventArgs) Handles radFitness1.CheckedChanged
        If panRmrOutput.Visible Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub RadFitness2_CheckedChanged(sender As Object, e As EventArgs) Handles radFitness2.CheckedChanged
        If panRmrOutput.Visible Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub RadFitness3_CheckedChanged(sender As Object, e As EventArgs) Handles radFitness3.CheckedChanged
        If panRmrOutput.Visible Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub RadFitness4_CheckedChanged(sender As Object, e As EventArgs) Handles radFitness4.CheckedChanged
        If panRmrOutput.Visible Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub RadFitness5_CheckedChanged(sender As Object, e As EventArgs) Handles radFitness5.CheckedChanged
        If panRmrOutput.Visible Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub RadBodyMale_CheckedChanged(sender As Object, e As EventArgs) Handles radBodyMale.CheckedChanged
        If panRmrOutput.Visible Then
            Button1_Click(sender, e)
        End If
        If panFemBodyFat.Visible Then
            panFemBodyFat.Visible = False
        End If
    End Sub

    Private Sub RadBodyFemale_CheckedChanged(sender As Object, e As EventArgs) Handles radBodyFemale.CheckedChanged
        If panRmrOutput.Visible Then
            Button1_Click(sender, e)
        End If

        If Not panFemBodyFat.Visible Then
            panFemBodyFat.Visible = True
        End If
    End Sub

    Private Sub RadWeightPounds_CheckedChanged(sender As Object, e As EventArgs) Handles radWeightPounds.CheckedChanged
        If panRmrOutput.Visible Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub RadWeightKilos_CheckedChanged(sender As Object, e As EventArgs) Handles radWeightKilos.CheckedChanged
        If panRmrOutput.Visible Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub RadHeightInch_CheckedChanged(sender As Object, e As EventArgs) Handles radHeightInch.CheckedChanged
        If panRmrOutput.Visible Then
            Button1_Click(sender, e)
        End If
        If radHeightInch.Checked Then
            radHeightInch2.Checked = True
        End If
    End Sub

    Private Sub RadHeightCentimeters_CheckedChanged(sender As Object, e As EventArgs) Handles radHeightCm.CheckedChanged
        If panRmrOutput.Visible Then
            Button1_Click(sender, e)
        End If
        If radHeightCm.Checked Then
            radHeightCm2.Checked = True
        End If
    End Sub

    Private Sub RadHeightInch2_CheckedChanged(sender As Object, e As EventArgs) Handles radHeightInch2.CheckedChanged
        If radHeightInch2.Checked Then
            radHeightInch.Checked = True
        End If
    End Sub

    Private Sub RadHeightCm2_CheckedChanged(sender As Object, e As EventArgs) Handles radHeightCm2.CheckedChanged
        If radHeightCm2.Checked Then
            radHeightCm.Checked = True
        End If
    End Sub
End Class
