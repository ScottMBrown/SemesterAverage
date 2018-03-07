' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' 
'Name:                  Scott Brown (100658613)
'Date:                  2018-02-21
'Course:                NETD-2202-01
'Program Description:   This is a windows form application that allows the user to
'                       enter 6 grades for the semester.  After the six grades are 
'                       entered, it will calculate the average of the semester.  
'                       Each grade will have a corresponding letter and the semester
'                       average will have a letter associated with it.  The user can
'                       reset or exit the form at any time.
'
'Project Description:   This is the second lab for Net Development 1.  This lab
'                       features sub procedures and functions to do certain tasks
'                       like validation and calculating the letter grade.
'                       The text boxes are stored into arrays and determined valid 
'                       or not through looping.  
'
' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' '

Public Class frmSemesterGrades
    'Variable used for the integer value of the input from teh user for the textboxes
    Dim userInput As Integer

    'Value of the users input in a string
    Dim inputValue As String = ""





    Private Sub txtCourseOneInput_LostFocus(sender As Object, e As EventArgs) Handles txtCourseOneInput.LostFocus
        'Setting the input value to the text box
        inputValue = txtCourseOneInput.Text


        'If statement determining if the value entered is in range and numeric using a function
        If (Me.isValid(userInput, inputValue) = True) Then

            ' making the user input variable equal to the converted input value string 
            userInput = Convert.ToInt64(inputValue)

            'Detemining the letter grade through a function and setting it to the text box
            lblCourseOneLetter.Text = Me.determineLetterGrade(userInput)

        Else
            'If the value is not valid it will select it so the user can easily enter a new value
            txtCourseOneInput.Focus()
            txtCourseOneInput.SelectAll()


        End If
    End Sub


    Private Sub txtCourseTwoInput_LostFocus(sender As Object, e As EventArgs) Handles txtCourseTwoInput.LostFocus
        'Setting the input value to the text box
        inputValue = txtCourseTwoInput.Text


        'If statement determining if the value entered is in range and numeric using a function
        If (Me.isValid(userInput, inputValue) = True) Then

            ' making the user input variable equal to the converted input value string
            userInput = Convert.ToInt64(inputValue)

            'Detemining the letter grade through a function and setting it to the text box
            lblCourseTwoLetter.Text = Me.determineLetterGrade(userInput)

        Else
            'If the value is not valid it will select it so the user can easily enter a new value
            txtCourseTwoInput.Focus()
            txtCourseTwoInput.SelectAll()
        End If
    End Sub


    Private Sub txtCourseThreeInput_LostFocus(sender As Object, e As EventArgs) Handles txtCourseThreeInput.LostFocus
        'Setting the input value to the text box
        inputValue = txtCourseThreeInput.Text


        'If statement determining if the value entered is in range and numeric using a function
        If (Me.isValid(userInput, inputValue) = True) Then

            ' making the user input variable equal to the converted input value string
            userInput = Convert.ToInt64(inputValue)

            'Detemining the letter grade through a function and setting it to the text box
            lblCourseThreeLetter.Text = Me.determineLetterGrade(userInput)

        Else
            'If the value is not valid it will select it so the user can easily enter a new value
            txtCourseThreeInput.Focus()
            txtCourseThreeInput.SelectAll()
        End If
    End Sub


    Private Sub txtCourseFourInput_LostFocus(sender As Object, e As EventArgs) Handles txtCourseFourInput.LostFocus
        'Setting the input value to the text box
        inputValue = txtCourseFourInput.Text


        'If statement determining if the value entered is in range and numeric using a function
        If (Me.isValid(userInput, inputValue) = True) Then

            ' making the user input variable equal to the converted input value string
            userInput = Convert.ToInt64(inputValue)

            'Detemining the letter grade through a function and setting it to the text box
            lblCourseFourLetter.Text = Me.determineLetterGrade(userInput)

        Else
            'If the value is not valid it will select it so the user can easily enter a new value
            txtCourseFourInput.Focus()
            txtCourseFourInput.SelectAll()
        End If
    End Sub


    Private Sub txtCourseFiveInput_LostFocus(sender As Object, e As EventArgs) Handles txtCourseFiveInput.LostFocus
        'Setting the input value to the text box
        inputValue = txtCourseFiveInput.Text


        'If statement determining if the value entered is in range and numeric using a function
        If (Me.isValid(userInput, inputValue) = True) Then

            ' making the user input variable equal to the converted input value string
            userInput = Convert.ToInt64(inputValue)

            'Detemining the letter grade through a function and setting it to the text box
            lblCourseFiveLetter.Text = Me.determineLetterGrade(userInput)

        Else
            'If the value is not valid it will select it so the user can easily enter a new value
            txtCourseFiveInput.Focus()
            txtCourseFiveInput.SelectAll()
        End If
    End Sub


    Private Sub txtCourseSixInput_LostFocus(sender As Object, e As EventArgs) Handles txtCourseSixInput.LostFocus
        'Setting the input value to the text box
        inputValue = txtCourseSixInput.Text


        'If statement determining if the value entered is in range and numeric using a function
        If (Me.isValid(userInput, inputValue) = True) Then

            ' making the user input variable equal to the converted input value string
            userInput = Convert.ToInt64(inputValue)

            'Detemining the letter grade through a function and setting it to the text box
            lblCourseSixLetter.Text = Me.determineLetterGrade(userInput)

        Else
            'If the value is not valid it will select it so the user can easily enter a new value
            txtCourseSixInput.Focus()
            txtCourseSixInput.SelectAll()

        End If
    End Sub

    ''' <summary>
    ''' Function that checks to see if the input given by the user is numeric and in the range, will return true or false 
    ''' </summary>
    ''' <param name="userInput">integer value of the users input</param>
    ''' <param name="inputValue">string value of the users input</param>
    ''' <returns></returns>
    Private Function isValid(ByVal userInput As Integer, ByVal inputValue As String) As Boolean

        If (Integer.TryParse(inputValue, userInput) = False) Then
            lblErrorDisplay.Text = "The value must be numeric"
            Return False
        ElseIf (userInput > 100 Or userInput < 0) Then
            lblErrorDisplay.Text = "The value must be between 0 and 100"
            Return False
        Else
            Return True

        End If


    End Function

    ''' <summary>
    ''' This function determines the letter grade from the given value(userInput) and return the letter grade as a string
    ''' </summary>
    ''' <param name="userInput">Integer input from the user</param>
    ''' <returns></returns>
    Private Function determineLetterGrade(ByVal userInput As Integer) As String
        'String that holds the grade letter value
        Dim gradeLetter As String = ""

        'Select statment to determine the letter grade depending on the users input
        Select Case userInput
            Case 90 To 100
                gradeLetter = "A+"
            Case 85 To 89
                gradeLetter = "A"
            Case 80 To 84
                gradeLetter = "A-"
            Case 77 To 79
                gradeLetter = "B+"
            Case 73 To 76
                gradeLetter = "B"
            Case 70 To 72
                gradeLetter = "B-"
            Case 67 To 69
                gradeLetter = "C+"
            Case 63 To 66
                gradeLetter = "C"
            Case 60 To 62
                gradeLetter = "C-"
            Case 57 To 59
                gradeLetter = "D+"
            Case 53 To 56
                gradeLetter = "D"
            Case 50 To 52
                gradeLetter = "D-"
            Case 0 To 49
                gradeLetter = "F"
        End Select
        'Return the letter grade to the function
        Return gradeLetter
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Array that hold the text boxes
        Dim textBoxesArray(5) As String

        'When the button is envoked, the text boxes are stored into the array.
        textBoxesArray(0) = txtCourseOneInput.Text
        textBoxesArray(1) = txtCourseTwoInput.Text
        textBoxesArray(2) = txtCourseThreeInput.Text
        textBoxesArray(3) = txtCourseFourInput.Text
        textBoxesArray(4) = txtCourseFiveInput.Text
        textBoxesArray(5) = txtCourseSixInput.Text

        'Variable that holds the value for the average
        Dim semesterAverage As Double = 0

        'Constant for the number of courses
        Const numberOfCourses As Integer = 6

        'Counter used to determine which grades have valid input
        Dim counter As Integer = 0

        'Making the errors equal to "" right as the button is clicked so it will start with a clean slate
        lblErrorDisplay.Text = ""

        'Looping the length of the textbox to store and check if its good
        For index As Integer = 0 To textBoxesArray.Length - 1

            'adding to the counter as the loop goes around
            counter = counter + 1

            'Making sure the value is numeric
            If (Integer.TryParse(textBoxesArray(index), userInput) = False) Then

                'If it isnt then it will give you which course has errors
                lblErrorDisplay.Text &= "Course " + counter.ToString() + " needs a value that is numeric or a between 0 and 100" + vbCrLf



            Else
                'storing the value into the textbox and adding the values of each day together
                textBoxesArray(index) = textBoxesArray(index)
                semesterAverage = semesterAverage + textBoxesArray(index)


            End If

        Next
        'If there are no erros it will go through and calculate
        If (lblErrorDisplay.Text = "") Then
            'average calculation
            semesterAverage = semesterAverage / numberOfCourses
            'formatiing 
            txtSemesterAverageValue.Text = semesterAverage.ToString("n2")

            'determining letter grade
            userInput = semesterAverage
            lblSemesterAverageLetter.Text = Me.determineLetterGrade(userInput)

            'Setting everything so you cant enter more data or calculate again
            btnCalculate.Enabled = False
            txtCourseOneInput.ReadOnly = True
            txtCourseTwoInput.ReadOnly = True
            txtCourseThreeInput.ReadOnly = True
            txtCourseFourInput.ReadOnly = True
            txtCourseFiveInput.ReadOnly = True
            txtCourseSixInput.ReadOnly = True
        Else

        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closing the form
        Me.Close()
    End Sub

    ''' <summary>
    ''' This sub sets everything back to its orginal state.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        inputValue = ""
        btnCalculate.Enabled = True
        txtCourseOneInput.ReadOnly = False
        txtCourseTwoInput.ReadOnly = False
        txtCourseThreeInput.ReadOnly = False
        txtCourseFourInput.ReadOnly = False
        txtCourseFiveInput.ReadOnly = False
        txtCourseSixInput.ReadOnly = False

        txtCourseOneInput.Text = ""
        txtCourseTwoInput.Text = ""
        txtCourseThreeInput.Text = ""
        txtCourseFourInput.Text = ""
        txtCourseFiveInput.Text = ""
        txtCourseSixInput.Text = ""
        txtSemesterAverageValue.Text = ""


        lblCourseOneLetter.Text = ""
        lblCourseTwoLetter.Text = ""
        lblCourseThreeLetter.Text = ""
        lblCourseFourLetter.Text = ""
        lblCourseFiveLetter.Text = ""
        lblCourseSixLetter.Text = ""
        lblSemesterAverageLetter.Text = ""
        lblErrorDisplay.Text = ""

        txtCourseOneInput.Focus()

    End Sub
End Class
