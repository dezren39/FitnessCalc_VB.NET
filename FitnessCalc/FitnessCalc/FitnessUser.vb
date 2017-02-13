Public Class FitnessUser
    Private Shared userMeasurements As List(Of Double) = New List(Of Double)
    Private Shared radiosChecked As List(Of Boolean) = New List(Of Boolean)

    Public Property Measurements() As List(Of Double)
        Get
            Dim measurementsBuffer As List(Of Double) = New List(Of Double)
            measurementsBuffer.AddRange(userMeasurements)
            Return measurementsBuffer
        End Get
        Set(ByVal value As List(Of Double))
            userMeasurements = value
        End Set
    End Property

    Public Property Radios() As List(Of Boolean)
        Get
            Dim radiosBuffer As List(Of Boolean) = New List(Of Boolean)
            radiosBuffer.AddRange(radiosChecked)
            Return radiosBuffer
        End Get
        Set(ByVal value As List(Of Boolean))
            radiosChecked = value
        End Set
    End Property

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

    Private Function ToInches(ByVal userLength As Double) As Double
        If radiosChecked(1) Then
            ToInches = userLength  'inches
        Else
            ToInches = userLength * 0.393701 'centimeters
        End If
    End Function

    Private Function ToCm(ByVal userLength As Double) As Double
        If radiosChecked(1) Then
            ToCm = userLength * 2.54  'inches
        Else
            ToCm = userLength 'centimeters
        End If
    End Function

    Private Function IsMale() As Boolean
        If radiosChecked(2) Then
            IsMale = True
        Else IsMale = False
        End If
    End Function

    Private Function WeightLb() As Double
        If radiosChecked(0) Then
            WeightLb = userMeasurements(0)
        Else
            WeightLb = userMeasurements(0) * 2.20462
        End If
    End Function

    Private Function WeightKg() As Double
        If radiosChecked(0) Then
            WeightKg = userMeasurements(0) * 0.453592
        Else
            WeightKg = userMeasurements(0)
        End If
    End Function

    Private Function HeightInch() As Double
        HeightInch = ToInches(userMeasurements(1))
    End Function

    Private Function HeightCm() As Double
        HeightCm = ToCm(userMeasurements(1))
    End Function

    Private Function Age() As Double
        Age = userMeasurements(2)
    End Function

    Private Function Wrist() As Double
        Wrist = ToInches(userMeasurements(3))
    End Function

    Private Function Waist() As Double
        Waist = ToInches(userMeasurements(4))
    End Function

    Private Function Hips() As Double
        Hips = ToInches(userMeasurements(5))
    End Function

    Private Function Forearm() As Double
        Forearm = ToInches(userMeasurements(6))
    End Function
End Class