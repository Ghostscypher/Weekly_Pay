Public Class Form1

    Private Sub InputData(ByRef hours As Integer, ByRef payPerHour As Integer)
        If Not Integer.TryParse(Me.TxtHoursWorked.Text, hours) Then
            MsgBox("Please enter valid hours worked", vbExclamation + vbOKOnly, "Error")
            hours = 0
        End If

        If Not Integer.TryParse(Me.TxtHourlyPay.Text, payPerHour) Then
            MsgBox("Please enter valid hours worked", vbExclamation + vbOKOnly, "Error")
            payPerHour = 0
        End If
    End Sub

    Private Sub CalculateValues(ByRef hours As Integer, ByRef payPerHour As Decimal, ByRef overTimeHours As Integer, ByRef pay As Decimal)
        If hours > 40 Then
            overTimeHours = hours - 40
        Else
            overTimeHours = 0
        End If

        pay = (payPerHour * 40) + (overTimeHours * 1.5 * payPerHour)
    End Sub

    Private Sub DisplayData(ByRef overtimeHours As Integer, ByRef pay As Decimal)
        Me.TxtOvertimeHoursWorked.Text = overtimeHours
        Me.TxtWeeksPay.Text = Format(pay, "$##.00")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hours, payPerHour, overtimeHours, pay As Decimal

        InputData(hours, payPerHour)
        CalculateValues(hours, payPerHour, overtimeHours, pay)
        DisplayData(overtimeHours, pay)

    End Sub
End Class
