Option Strict On
Option Explicit On

Public Class FitnessCalc
    Private currentUser As FitnessUser = New FitnessUser()
    Private radios As New List(Of List(Of Boolean))
    Private measurements As New List(Of List(Of Double))
    Private names As New List(Of String)

    Public Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim radiosChecked As RadioButton() = {radWeightPounds, radHeightInch, radBodyMale, radFitness1, radFitness2, radFitness3, radFitness4, radFitness5}
        Dim measurementBoxes As TextBox() = {txtWeight, txtHeight, txtAge, txtWrist, txtWaist, txtHips, txtForearm}

        Dim radiosHeld = New List(Of Boolean) From {False}
        Dim measuresHeld = New List(Of Double) From {0}

        For Each item In radiosChecked
            If item.Checked Then
                radiosHeld.Add(True)
            Else radiosHeld.Add(False)
            End If
        Next

        For Each item In measurementBoxes
            If String.IsNullOrEmpty(item.Text) Then
                measuresHeld.Add(0)
            Else
                Try
                    measuresHeld.Add(CDbl(item.Text))
                Catch ex As Exception
                    MessageBox.Show("Invalid Input")
                    measuresHeld.Add(0)
                End Try
            End If
        Next

        radiosHeld.RemoveAt(0)
        measuresHeld.RemoveAt(0)

        currentUser.Radios = radiosHeld
        currentUser.Measurements = measuresHeld

        panRmrOutput.Visible = False
        panBodyFatOutput.Visible = False

        If currentUser.Rmr() <> 0 Then
            lblOutputRMR.Text = (Math.Round(currentUser.Rmr(), 2)).ToString
            lblOutputCalories.Text = (Math.Round(currentUser.Calories(), 2)).ToString
            panRmrOutput.Visible = True
        End If

        If currentUser.LeanBodyWeight() <> 0 Then
            lblOutputBodyFat.Text = (Math.Round(currentUser.BodyFatPercentage(), 2)).ToString & "%"
            lblOutputLeanBodyMass.Text = (Math.Round(currentUser.LeanBodyWeight(), 2)).ToString & "Kg"
            panBodyFatOutput.Visible = True
        End If
    End Sub

    Private Sub LbxUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxUsers.SelectedIndexChanged
        Dim radiosChecked As RadioButton() = {radWeightPounds, radHeightInch, radBodyMale, radFitness1, radFitness2, radFitness3, radFitness4, radFitness5}
        Dim measurementBoxes As TextBox() = {txtWeight, txtHeight, txtAge, txtWrist, txtWaist, txtHips, txtForearm}

        txtName.Text = names(lbxUsers.SelectedIndex)

        For i = 0 To radiosChecked.Count - 1
            Try
                radiosChecked(i).Checked = radios(lbxUsers.SelectedIndex)(i)
            Catch ex As Exception
            End Try
        Next

        For i = 0 To measurementBoxes.Count - 1
            Try
                measurementBoxes(i).Text = measurements(lbxUsers.SelectedIndex)(i).ToString
            Catch ex As Exception
            End Try
        Next

        BtnSubmit_Click(sender, e)
    End Sub

    Private Sub BtnAddSelected_Click(sender As Object, e As EventArgs) Handles btnAddSelected.Click
        Dim measurementBoxes As TextBox() = {txtWeight, txtHeight, txtAge, txtWrist, txtWaist, txtHips, txtForearm}
        Dim repeat As Boolean = False

        BtnSubmit_Click(sender, e)

        For item = 0 To lbxUsers.Items.Count - 1
            If names(item).Equals(txtName.Text) Then
                MessageBox.Show("Please enter a unique name." + vbCrLf +
                                "Duplicate name found on line: " + (item + 1).ToString)
                repeat = True
            End If
        Next

        If Not repeat Then
            If txtName.Text = "" Then
                MessageBox.Show("Please enter a unique name.")
            Else
                names.Add(txtName.Text)
                radios.Add(currentUser.Radios)
                measurements.Add(currentUser.Measurements)

                lbxUsers.Items.Clear()
                lbxUsers.Items.AddRange(names.ToArray)
                lbxUsers.SelectedIndex = lbxUsers.Items.Count - 1
            End If
        End If

        For Each item In measurementBoxes
            item.Text = ""
        Next
        panRmrOutput.Visible = False
        panBodyFatOutput.Visible = False
    End Sub
    Private Sub BtnModifyCurrent_Click(sender As Object, e As EventArgs) Handles btnModifyCurrent.Click
        Dim radiosChecked As RadioButton() = {radWeightPounds, radHeightInch, radBodyMale, radFitness1, radFitness2, radFitness3, radFitness4, radFitness5}
        Dim measurementBoxes As TextBox() = {txtWeight, txtHeight, txtAge, txtWrist, txtWaist, txtHips, txtForearm}

        Dim bufferRadios = New List(Of Boolean)
        Dim bufferMeasures = New List(Of Double)

        BtnSubmit_Click(sender, e)

        bufferRadios.AddRange(currentUser.Radios.ToArray)
        bufferMeasures.AddRange(currentUser.Measurements.ToArray)

        If lbxUsers.Items.Count <> 0 Then
            If names(lbxUsers.SelectedIndex).Equals(txtName.Text) Then
                radios(lbxUsers.SelectedIndex).Clear()
                radios(lbxUsers.SelectedIndex).AddRange(bufferRadios)
                measurements(lbxUsers.SelectedIndex).Clear()
                measurements(lbxUsers.SelectedIndex).AddRange(bufferMeasures)
            End If
        End If

        LbxUsers_SelectedIndexChanged(sender, e)
    End Sub
    Private Sub BtnDeleteSelected_Click(sender As Object, e As EventArgs) Handles btnDeleteSelected.Click
        Dim index As Integer = lbxUsers.SelectedIndex
        If lbxUsers.Items.Count <> 0 Then
            names.RemoveAt(index)
            radios.RemoveAt(index)
            measurements.RemoveAt(index)

            lbxUsers.Items.Clear()
            lbxUsers.Items.AddRange(names.ToArray)

            If index = lbxUsers.Items.Count Then
                lbxUsers.SelectedIndex = index - 1
            Else
                lbxUsers.SelectedIndex = index
            End If
        End If
    End Sub

    Private Sub RadBodyMale_CheckedChanged(sender As Object, e As EventArgs) Handles radBodyMale.CheckedChanged
        If panRmrOutput.Visible Then
            BtnSubmit_Click(sender, e)
        End If
        If panFemBodyFat.Visible Then
            panFemBodyFat.Visible = False
        End If
        If Not radBodyMale.Checked And Not radBodyFemale.Checked Then
            radBodyFemale.Checked = True
        End If
    End Sub

    Private Sub RadBodyFemale_CheckedChanged(sender As Object, e As EventArgs) Handles radBodyFemale.CheckedChanged
        If panRmrOutput.Visible Then
            BtnSubmit_Click(sender, e)
        End If
        If Not panFemBodyFat.Visible Then
            panFemBodyFat.Visible = True
        End If
    End Sub

    Private Sub RadWeightPounds_CheckedChanged(sender As Object, e As EventArgs) Handles radWeightPounds.CheckedChanged
        If panRmrOutput.Visible Then
            BtnSubmit_Click(sender, e)
        End If
        If Not radWeightPounds.Checked And Not radWeightKilos.Checked Then
            radWeightKilos.Checked = True
        End If
    End Sub

    Private Sub RadWeightKilos_CheckedChanged(sender As Object, e As EventArgs) Handles radWeightKilos.CheckedChanged
        If panRmrOutput.Visible Then
            BtnSubmit_Click(sender, e)
        End If
    End Sub

    Private Sub RadHeightInch_CheckedChanged(sender As Object, e As EventArgs) Handles radHeightInch.CheckedChanged
        If panRmrOutput.Visible Then
            BtnSubmit_Click(sender, e)
        End If
        If Not radHeightInch.Checked And Not radHeightCm.Checked Then
            radHeightCm.Checked = True
        End If
    End Sub

    Private Sub RadHeightCm_CheckedChanged(sender As Object, e As EventArgs) Handles radHeightCm.CheckedChanged
        If panRmrOutput.Visible Then
            BtnSubmit_Click(sender, e)
        End If
    End Sub

    Private Sub RadFitness1_CheckedChanged(sender As Object, e As EventArgs) Handles radFitness1.CheckedChanged
        If panRmrOutput.Visible Then
            BtnSubmit_Click(sender, e)
        End If
    End Sub

    Private Sub RadFitness2_CheckedChanged(sender As Object, e As EventArgs) Handles radFitness2.CheckedChanged
        If panRmrOutput.Visible Then
            BtnSubmit_Click(sender, e)
        End If
    End Sub

    Private Sub RadFitness3_CheckedChanged(sender As Object, e As EventArgs) Handles radFitness3.CheckedChanged
        If panRmrOutput.Visible Then
            BtnSubmit_Click(sender, e)
        End If
    End Sub

    Private Sub RadFitness4_CheckedChanged(sender As Object, e As EventArgs) Handles radFitness4.CheckedChanged
        If panRmrOutput.Visible Then
            BtnSubmit_Click(sender, e)
        End If
    End Sub

    Private Sub RadFitness5_CheckedChanged(sender As Object, e As EventArgs) Handles radFitness5.CheckedChanged
        If panRmrOutput.Visible Then
            BtnSubmit_Click(sender, e)
        End If
    End Sub
End Class
