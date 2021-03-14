<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtHoursWorked = New System.Windows.Forms.TextBox()
        Me.TxtHourlyPay = New System.Windows.Forms.TextBox()
        Me.TxtOvertimeHoursWorked = New System.Windows.Forms.TextBox()
        Me.TxtWeeksPay = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hours worked"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hourly pay"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(70, 138)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 47)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Calculate Overtime Hours and Weekly Pay"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Overtime hours worked"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Weeks pay"
        '
        'TxtHoursWorked
        '
        Me.TxtHoursWorked.Location = New System.Drawing.Point(182, 31)
        Me.TxtHoursWorked.Name = "TxtHoursWorked"
        Me.TxtHoursWorked.Size = New System.Drawing.Size(100, 20)
        Me.TxtHoursWorked.TabIndex = 5
        '
        'TxtHourlyPay
        '
        Me.TxtHourlyPay.Location = New System.Drawing.Point(182, 74)
        Me.TxtHourlyPay.Name = "TxtHourlyPay"
        Me.TxtHourlyPay.Size = New System.Drawing.Size(100, 20)
        Me.TxtHourlyPay.TabIndex = 6
        '
        'TxtOvertimeHoursWorked
        '
        Me.TxtOvertimeHoursWorked.Location = New System.Drawing.Point(182, 207)
        Me.TxtOvertimeHoursWorked.Name = "TxtOvertimeHoursWorked"
        Me.TxtOvertimeHoursWorked.ReadOnly = True
        Me.TxtOvertimeHoursWorked.Size = New System.Drawing.Size(100, 20)
        Me.TxtOvertimeHoursWorked.TabIndex = 7
        '
        'TxtWeeksPay
        '
        Me.TxtWeeksPay.Location = New System.Drawing.Point(182, 249)
        Me.TxtWeeksPay.Name = "TxtWeeksPay"
        Me.TxtWeeksPay.ReadOnly = True
        Me.TxtWeeksPay.Size = New System.Drawing.Size(100, 20)
        Me.TxtWeeksPay.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 306)
        Me.Controls.Add(Me.TxtWeeksPay)
        Me.Controls.Add(Me.TxtOvertimeHoursWorked)
        Me.Controls.Add(Me.TxtHourlyPay)
        Me.Controls.Add(Me.TxtHoursWorked)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtHoursWorked As TextBox
    Friend WithEvents TxtHourlyPay As TextBox
    Friend WithEvents TxtOvertimeHoursWorked As TextBox
    Friend WithEvents TxtWeeksPay As TextBox
End Class
