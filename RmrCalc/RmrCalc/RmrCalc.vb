Public Class RmrCalc
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim weight As Double
        Dim height As Double
        Dim age As Double
        Dim outputRMR As Double
        Dim outputCalories As Double

        Double.TryParse(txtWeight.Text, weight)
        Double.TryParse(txtHeight.Text, height)
        Double.TryParse(txtAge.Text, age)

        If radWeightPounds.Checked And weight > 0 Then
            weight = weight * 0.453592
        End If

        If radHeightInch.Checked And height > 0 Then
            height = height * 2.54
        End If

        If weight > 0 And height > 0 And age > 0 And (radBodyMale.Checked Or radBodyFemale.Checked) Then
            If radBodyMale.Checked Then
                outputRMR = (10 * weight + 6.25 * height - 5 * age + 5)
            ElseIf radBodyFemale.Checked Then
                outputRMR = (10 * weight + 6.25 * height - 5 * age - 161)
            End If

            Select Case True
                Case radFitness1.Checked
                    outputCalories = 1.2
                Case radFitness2.Checked
                    outputCalories = 1.375
                Case radFitness3.Checked
                    outputCalories = 1.55
                Case radFitness4.Checked
                    outputCalories = 1.725
                Case radFitness5.Checked
                    outputCalories = 1.9
            End Select

            outputCalories = outputCalories * outputRMR

            lblOutputRMR.Text = (Math.Round(outputRMR, 2)).ToString
            lblOutputCalories.Text = (Math.Round(outputCalories, 2)).ToString
            panOutput.Visible = True
        End If
    End Sub

    Private Sub radFitness1_CheckedChanged(sender As Object, e As EventArgs) Handles radFitness1.CheckedChanged
        If panOutput.Visible Then
            button1_Click(sender, e)
        End If
    End Sub

    Private Sub radFitness2_CheckedChanged(sender As Object, e As EventArgs) Handles radFitness2.CheckedChanged
        If panOutput.Visible Then
            button1_Click(sender, e)
        End If
    End Sub

    Private Sub radFitness3_CheckedChanged(sender As Object, e As EventArgs) Handles radFitness3.CheckedChanged
        If panOutput.Visible Then
            button1_Click(sender, e)
        End If
    End Sub

    Private Sub radFitness4_CheckedChanged(sender As Object, e As EventArgs) Handles radFitness4.CheckedChanged
        If panOutput.Visible Then
            button1_Click(sender, e)
        End If
    End Sub

    Private Sub radFitness5_CheckedChanged(sender As Object, e As EventArgs) Handles radFitness5.CheckedChanged
        If panOutput.Visible Then
            button1_Click(sender, e)
        End If
    End Sub

    Private Sub radBodyMale_CheckedChanged(sender As Object, e As EventArgs) Handles radBodyMale.CheckedChanged
        If panOutput.Visible Then
            button1_Click(sender, e)
        End If
    End Sub

    Private Sub radBodyFemale_CheckedChanged(sender As Object, e As EventArgs) Handles radBodyFemale.CheckedChanged
        If panOutput.Visible Then
            button1_Click(sender, e)
        End If
    End Sub

    Private Sub radWeightPounds_CheckedChanged(sender As Object, e As EventArgs) Handles radWeightPounds.CheckedChanged
        If panOutput.Visible Then
            button1_Click(sender, e)
        End If
    End Sub

    Private Sub radWeightKilos_CheckedChanged(sender As Object, e As EventArgs) Handles radWeightKilos.CheckedChanged
        If panOutput.Visible Then
            button1_Click(sender, e)
        End If
    End Sub

    Private Sub radHeightInch_CheckedChanged(sender As Object, e As EventArgs) Handles radHeightInch.CheckedChanged
        If panOutput.Visible Then
            button1_Click(sender, e)
        End If
    End Sub

    Private Sub radHeightCentimeters_CheckedChanged(sender As Object, e As EventArgs) Handles radHeightCentimeters.CheckedChanged
        If panOutput.Visible Then
            button1_Click(sender, e)
        End If
    End Sub
End Class
