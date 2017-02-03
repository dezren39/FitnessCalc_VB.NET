Option Strict On
Option Explicit On

Public Class RmrCalc
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim radioButtonsChecked As RadioButton() = {radWeightPounds, radHeightInch, radBodyMale, radFitness1, radFitness2, radFitness3, radFitness4, radFitness5}
        Dim user As Measurements = New Measurements
        Dim ctr As Integer = 0
        Dim userMeasurementBoxes As TextBox() = {txtWeight, txtHeight, txtAge} ', txtWrist, txtWaist, txtHips, txtForearm}
        Dim holdRadios = New List(Of Boolean) From {False}
        Dim holdMeasurements = New List(Of Double) From {0}

        For Each element In radioButtonsChecked
            If element.Checked Then
                holdRadios.Add(True)
            Else holdRadios.Add(False)
            End If
        Next
        'MessageBox.Show(radioButtonsChecked.Count.ToString)
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

        lblOutputRMR.Text = (Math.Round(user.Rmr(), 2)).ToString
        lblOutputCalories.Text = (Math.Round(user.Calories(), 2)).ToString
        panOutput.Visible = True

        user.Clear()
    End Sub
    Public Class Measurements
        Shared userMeasurements As List(Of Double) = New List(Of Double)
        Shared radiosChecked As List(Of Boolean) = New List(Of Boolean)
        Public Sub Input(ByVal userInputMeasurements As List(Of Double), ByVal userRadiosChecked As List(Of Boolean))
            userMeasurements = userInputMeasurements
            radiosChecked = userRadiosChecked
            Dim test As String = ""
            For i = 0 To radiosChecked.Count - 1
                test += radiosChecked(i).ToString & " "
            Next
            ' MessageBox.Show(test)
            test = ""
            For i = 0 To userMeasurements.Count - 1
                test += userMeasurements(i).ToString & " "
            Next
            ' MessageBox.Show(test)
        End Sub
        Public Sub Clear()
            radiosChecked.Clear()
            userMeasurements.Clear()
        End Sub
        Public Function Rmr() As Double

            If WeightLb() > 0 And HeightInch() > 0 And Age() > 0 Then
                If IsMale() Then
                    Rmr = (10 * WeightLb() + 6.25 * HeightInch() - 5 * Age() + 5)
                Else
                    Rmr = (10 * WeightLb() + 6.25 * HeightInch() - 5 * Age() - 161)
                End If
            Else
                Rmr = 0
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
                ToInches = userLength 'inches
            Else
                ToInches = userLength * 2.54 'centimeters
            End If
        End Function

        Shared Function ToCm(ByVal userLength As Double) As Double
            If radiosChecked(1) Then
                ToCm = userLength * 0.393701 'inches
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
                'MessageBox.Show("1")
            Else
                WeightLb = userMeasurements(0) * 0.453592
                'MessageBox.Show("0")
            End If
        End Function

        Public Shared Function WeightKg() As Double
            If radiosChecked(0) Then
                WeightKg = userMeasurements(0) * 2.20462
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

        ' Function Wrist()
        '     Wrist = userMeasurements(3)
        '  End Function
        '  Function Waist()
        '      Waist = ToInches(userMeasurements(4))
        '  End Function
        ' Function Hips()
        '     Hips = ToInches(userMeasurements(5))
        ' End Function
        ' Function Forearms()
        '     Forearms = ToInches(userMeasurements(6))
        '  End Function
    End Class
    Private Sub RadFitness1_CheckedChanged(sender As Object, e As EventArgs) Handles radFitness1.CheckedChanged
        If panOutput.Visible Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub RadFitness2_CheckedChanged(sender As Object, e As EventArgs) Handles radFitness2.CheckedChanged
        If panOutput.Visible Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub RadFitness3_CheckedChanged(sender As Object, e As EventArgs) Handles radFitness3.CheckedChanged
        If panOutput.Visible Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub RadFitness4_CheckedChanged(sender As Object, e As EventArgs) Handles radFitness4.CheckedChanged
        If panOutput.Visible Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub RadFitness5_CheckedChanged(sender As Object, e As EventArgs) Handles radFitness5.CheckedChanged
        If panOutput.Visible Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub RadBodyMale_CheckedChanged(sender As Object, e As EventArgs) Handles radBodyMale.CheckedChanged
        If panOutput.Visible Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub RadBodyFemale_CheckedChanged(sender As Object, e As EventArgs) Handles radBodyFemale.CheckedChanged
        If panOutput.Visible Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub RadWeightPounds_CheckedChanged(sender As Object, e As EventArgs) Handles radWeightPounds.CheckedChanged
        If panOutput.Visible Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub RadWeightKilos_CheckedChanged(sender As Object, e As EventArgs) Handles radWeightKilos.CheckedChanged
        If panOutput.Visible Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub RadHeightInch_CheckedChanged(sender As Object, e As EventArgs) Handles radHeightInch.CheckedChanged
        If panOutput.Visible Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub RadHeightCentimeters_CheckedChanged(sender As Object, e As EventArgs) Handles radHeightCentimeters.CheckedChanged
        If panOutput.Visible Then
            Button1_Click(sender, e)
        End If
    End Sub

End Class
