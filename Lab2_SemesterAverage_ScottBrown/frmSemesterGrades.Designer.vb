<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemesterGrades
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
        Me.lblErrorDisplay = New System.Windows.Forms.Label()
        Me.lblCourseOne = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSemesterAverageValue = New System.Windows.Forms.TextBox()
        Me.txtCourseSixInput = New System.Windows.Forms.TextBox()
        Me.txtCourseFiveInput = New System.Windows.Forms.TextBox()
        Me.txtCourseFourInput = New System.Windows.Forms.TextBox()
        Me.txtCourseThreeInput = New System.Windows.Forms.TextBox()
        Me.txtCourseTwoInput = New System.Windows.Forms.TextBox()
        Me.txtCourseOneInput = New System.Windows.Forms.TextBox()
        Me.lblCourseOneLetter = New System.Windows.Forms.Label()
        Me.lblCourseTwoLetter = New System.Windows.Forms.Label()
        Me.lblCourseThreeLetter = New System.Windows.Forms.Label()
        Me.lblCourseFourLetter = New System.Windows.Forms.Label()
        Me.lblCourseFiveLetter = New System.Windows.Forms.Label()
        Me.lblCourseSixLetter = New System.Windows.Forms.Label()
        Me.lblSemesterAverageLetter = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ttSemesterGrades = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblErrorDisplay
        '
        Me.lblErrorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblErrorDisplay.Location = New System.Drawing.Point(12, 304)
        Me.lblErrorDisplay.Name = "lblErrorDisplay"
        Me.lblErrorDisplay.Size = New System.Drawing.Size(345, 228)
        Me.lblErrorDisplay.TabIndex = 21
        Me.lblErrorDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttSemesterGrades.SetToolTip(Me.lblErrorDisplay, "Displays the errors in your form.")
        '
        'lblCourseOne
        '
        Me.lblCourseOne.Location = New System.Drawing.Point(19, 19)
        Me.lblCourseOne.Name = "lblCourseOne"
        Me.lblCourseOne.Size = New System.Drawing.Size(100, 23)
        Me.lblCourseOne.TabIndex = 0
        Me.lblCourseOne.Text = "Course &1:"
        Me.lblCourseOne.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(19, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Course &2:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(19, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Course &3:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(19, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Course &4:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(19, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Course &5:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(19, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Course &6:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(19, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "&Semester:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSemesterAverageValue
        '
        Me.txtSemesterAverageValue.BackColor = System.Drawing.SystemColors.Menu
        Me.txtSemesterAverageValue.Location = New System.Drawing.Point(125, 267)
        Me.txtSemesterAverageValue.Name = "txtSemesterAverageValue"
        Me.txtSemesterAverageValue.ReadOnly = True
        Me.txtSemesterAverageValue.Size = New System.Drawing.Size(100, 22)
        Me.txtSemesterAverageValue.TabIndex = 19
        Me.txtSemesterAverageValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttSemesterGrades.SetToolTip(Me.txtSemesterAverageValue, "This is the average of all your grades for the semester. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Displayed as a number." &
        "")
        '
        'txtCourseSixInput
        '
        Me.txtCourseSixInput.Location = New System.Drawing.Point(125, 223)
        Me.txtCourseSixInput.Name = "txtCourseSixInput"
        Me.txtCourseSixInput.Size = New System.Drawing.Size(100, 22)
        Me.txtCourseSixInput.TabIndex = 16
        Me.txtCourseSixInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttSemesterGrades.SetToolTip(Me.txtCourseSixInput, "Enter the number grade for course six.")
        '
        'txtCourseFiveInput
        '
        Me.txtCourseFiveInput.Location = New System.Drawing.Point(125, 179)
        Me.txtCourseFiveInput.Name = "txtCourseFiveInput"
        Me.txtCourseFiveInput.Size = New System.Drawing.Size(100, 22)
        Me.txtCourseFiveInput.TabIndex = 13
        Me.txtCourseFiveInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttSemesterGrades.SetToolTip(Me.txtCourseFiveInput, "Enter the number grade for course five.")
        '
        'txtCourseFourInput
        '
        Me.txtCourseFourInput.Location = New System.Drawing.Point(125, 139)
        Me.txtCourseFourInput.Name = "txtCourseFourInput"
        Me.txtCourseFourInput.Size = New System.Drawing.Size(100, 22)
        Me.txtCourseFourInput.TabIndex = 10
        Me.txtCourseFourInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttSemesterGrades.SetToolTip(Me.txtCourseFourInput, "Enter the number grade for course four.")
        '
        'txtCourseThreeInput
        '
        Me.txtCourseThreeInput.Location = New System.Drawing.Point(125, 100)
        Me.txtCourseThreeInput.Name = "txtCourseThreeInput"
        Me.txtCourseThreeInput.Size = New System.Drawing.Size(100, 22)
        Me.txtCourseThreeInput.TabIndex = 7
        Me.txtCourseThreeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttSemesterGrades.SetToolTip(Me.txtCourseThreeInput, "Enter the number grade for course three.")
        '
        'txtCourseTwoInput
        '
        Me.txtCourseTwoInput.Location = New System.Drawing.Point(125, 57)
        Me.txtCourseTwoInput.Name = "txtCourseTwoInput"
        Me.txtCourseTwoInput.Size = New System.Drawing.Size(100, 22)
        Me.txtCourseTwoInput.TabIndex = 4
        Me.txtCourseTwoInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttSemesterGrades.SetToolTip(Me.txtCourseTwoInput, "Enter the number grade for course two.")
        '
        'txtCourseOneInput
        '
        Me.txtCourseOneInput.Location = New System.Drawing.Point(125, 19)
        Me.txtCourseOneInput.Name = "txtCourseOneInput"
        Me.txtCourseOneInput.Size = New System.Drawing.Size(100, 22)
        Me.txtCourseOneInput.TabIndex = 1
        Me.txtCourseOneInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttSemesterGrades.SetToolTip(Me.txtCourseOneInput, "Enter the number grade for course one.")
        '
        'lblCourseOneLetter
        '
        Me.lblCourseOneLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseOneLetter.Location = New System.Drawing.Point(257, 18)
        Me.lblCourseOneLetter.Name = "lblCourseOneLetter"
        Me.lblCourseOneLetter.Size = New System.Drawing.Size(100, 23)
        Me.lblCourseOneLetter.TabIndex = 2
        Me.lblCourseOneLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttSemesterGrades.SetToolTip(Me.lblCourseOneLetter, "Displays the letter grade for course one.")
        '
        'lblCourseTwoLetter
        '
        Me.lblCourseTwoLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseTwoLetter.Location = New System.Drawing.Point(257, 57)
        Me.lblCourseTwoLetter.Name = "lblCourseTwoLetter"
        Me.lblCourseTwoLetter.Size = New System.Drawing.Size(100, 23)
        Me.lblCourseTwoLetter.TabIndex = 5
        Me.lblCourseTwoLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttSemesterGrades.SetToolTip(Me.lblCourseTwoLetter, "Displays the letter grade for course two.")
        '
        'lblCourseThreeLetter
        '
        Me.lblCourseThreeLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseThreeLetter.Location = New System.Drawing.Point(257, 100)
        Me.lblCourseThreeLetter.Name = "lblCourseThreeLetter"
        Me.lblCourseThreeLetter.Size = New System.Drawing.Size(100, 23)
        Me.lblCourseThreeLetter.TabIndex = 8
        Me.lblCourseThreeLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttSemesterGrades.SetToolTip(Me.lblCourseThreeLetter, "Displays the letter grade for course three.")
        '
        'lblCourseFourLetter
        '
        Me.lblCourseFourLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseFourLetter.Location = New System.Drawing.Point(257, 138)
        Me.lblCourseFourLetter.Name = "lblCourseFourLetter"
        Me.lblCourseFourLetter.Size = New System.Drawing.Size(100, 23)
        Me.lblCourseFourLetter.TabIndex = 11
        Me.lblCourseFourLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttSemesterGrades.SetToolTip(Me.lblCourseFourLetter, "Displays the letter grade for course four.")
        '
        'lblCourseFiveLetter
        '
        Me.lblCourseFiveLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseFiveLetter.Location = New System.Drawing.Point(257, 179)
        Me.lblCourseFiveLetter.Name = "lblCourseFiveLetter"
        Me.lblCourseFiveLetter.Size = New System.Drawing.Size(100, 23)
        Me.lblCourseFiveLetter.TabIndex = 14
        Me.lblCourseFiveLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttSemesterGrades.SetToolTip(Me.lblCourseFiveLetter, "Displays the letter grade for course five.")
        '
        'lblCourseSixLetter
        '
        Me.lblCourseSixLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseSixLetter.Location = New System.Drawing.Point(257, 222)
        Me.lblCourseSixLetter.Name = "lblCourseSixLetter"
        Me.lblCourseSixLetter.Size = New System.Drawing.Size(100, 23)
        Me.lblCourseSixLetter.TabIndex = 17
        Me.lblCourseSixLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttSemesterGrades.SetToolTip(Me.lblCourseSixLetter, "Displays the letter grade for course six.")
        '
        'lblSemesterAverageLetter
        '
        Me.lblSemesterAverageLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSemesterAverageLetter.Location = New System.Drawing.Point(257, 266)
        Me.lblSemesterAverageLetter.Name = "lblSemesterAverageLetter"
        Me.lblSemesterAverageLetter.Size = New System.Drawing.Size(100, 23)
        Me.lblSemesterAverageLetter.TabIndex = 20
        Me.lblSemesterAverageLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttSemesterGrades.SetToolTip(Me.lblSemesterAverageLetter, "Displays the letter grade for the semester.")
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(60, 548)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(95, 34)
        Me.btnCalculate.TabIndex = 22
        Me.btnCalculate.Text = "&Calculate"
        Me.ttSemesterGrades.SetToolTip(Me.btnCalculate, "Press to calculate the semester average.")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(161, 548)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(95, 34)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "&Reset"
        Me.ttSemesterGrades.SetToolTip(Me.btnReset, "Press to reset the windows form.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(262, 548)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(95, 34)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "&Exit"
        Me.ttSemesterGrades.SetToolTip(Me.btnExit, "Press to exit the windows form.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmSemesterGrades
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(369, 594)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblSemesterAverageLetter)
        Me.Controls.Add(Me.lblCourseSixLetter)
        Me.Controls.Add(Me.lblCourseFiveLetter)
        Me.Controls.Add(Me.lblCourseFourLetter)
        Me.Controls.Add(Me.lblCourseThreeLetter)
        Me.Controls.Add(Me.lblCourseTwoLetter)
        Me.Controls.Add(Me.lblCourseOneLetter)
        Me.Controls.Add(Me.txtCourseOneInput)
        Me.Controls.Add(Me.txtCourseTwoInput)
        Me.Controls.Add(Me.txtCourseThreeInput)
        Me.Controls.Add(Me.txtCourseFourInput)
        Me.Controls.Add(Me.txtCourseFiveInput)
        Me.Controls.Add(Me.txtCourseSixInput)
        Me.Controls.Add(Me.txtSemesterAverageValue)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCourseOne)
        Me.Controls.Add(Me.lblErrorDisplay)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSemesterGrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblErrorDisplay As Label
    Friend WithEvents lblCourseOne As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSemesterAverageValue As TextBox
    Friend WithEvents txtCourseSixInput As TextBox
    Friend WithEvents txtCourseFiveInput As TextBox
    Friend WithEvents txtCourseFourInput As TextBox
    Friend WithEvents txtCourseThreeInput As TextBox
    Friend WithEvents txtCourseTwoInput As TextBox
    Friend WithEvents txtCourseOneInput As TextBox
    Friend WithEvents lblCourseOneLetter As Label
    Friend WithEvents lblCourseTwoLetter As Label
    Friend WithEvents lblCourseThreeLetter As Label
    Friend WithEvents lblCourseFourLetter As Label
    Friend WithEvents lblCourseFiveLetter As Label
    Friend WithEvents lblCourseSixLetter As Label
    Friend WithEvents lblSemesterAverageLetter As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ttSemesterGrades As ToolTip
End Class
