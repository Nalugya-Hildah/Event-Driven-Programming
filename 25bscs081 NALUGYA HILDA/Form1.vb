Public Class Form1

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click

        If txtStudentName.Text.Trim() = "" OrElse
           txtRegNo.Text.Trim() = "" OrElse
           txtphone.Text.Trim() = "" OrElse
           txtEmail.Text.Trim() = "" OrElse
           txtAddress.Text.Trim() = "" OrElse
           (Not radMale.Checked AndAlso Not radFemale.Checked) OrElse
           cmbEducation.SelectedIndex = -1 OrElse
           cmbCourse.SelectedIndex = -1 OrElse
           cmbIntake.SelectedIndex = -1 Then

            lblmessage.Text = "APPLICATION FAILED! Please fill in all the required fields."

        Else

            lblmessage.Text = "STUDENT APPLICATION SUBMITTED SUCCESSFULLY! Welcome to Kampala Vocational Skills Institute."

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbEducation.Items.Clear()
        cmbEducation.Items.Add("Primary")
        cmbEducation.Items.Add("O-Level")
        cmbEducation.Items.Add("A-Level")
        cmbEducation.Items.Add("Certificate")
        cmbEducation.Items.Add("Diploma")

        cmbCourse.Items.Clear()
        cmbCourse.Items.Add("Electrical Installation")
        cmbCourse.Items.Add("Plumbing")
        cmbCourse.Items.Add("Motor Vehicle Mechanics")
        cmbCourse.Items.Add("Building and Construction")
        cmbCourse.Items.Add("Tailoring and Fashion Design")
        cmbCourse.Items.Add("Hairdressing and Beauty")
        cmbCourse.Items.Add("Catering and Hotel Management")
        cmbCourse.Items.Add("Computer Applications")
        cmbCourse.Items.Add("Welding and Metal Fabrication")
        cmbCourse.Items.Add("Carpentry and Joinery")

        cmbIntake.Items.Clear()
        cmbIntake.Items.Add("January Intake")
        cmbIntake.Items.Add("May Intake")
        cmbIntake.Items.Add("September Intake")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtStudentName.Clear()
        txtRegNo.Clear()
        txtphone.Clear()
        txtEmail.Clear()
        txtAddress.Clear()

        radMale.Checked = False
        radFemale.Checked = False

        cmbEducation.SelectedIndex = -1
        cmbCourse.SelectedIndex = -1
        cmbIntake.SelectedIndex = -1

        dptDateOfBirth.Value = Date.Today

        lblmessage.Text = ""

        txtStudentName.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Dim answer As DialogResult

        answer = MessageBox.Show("Are you sure you want to exit?",
                                 "Exit Application",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)

        If answer = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub lblStudentName_Click(sender As Object, e As EventArgs) Handles lblStudentName.Click
    End Sub

    Private Sub lblRegNo_Click(sender As Object, e As EventArgs) Handles lblRegNo.Click
    End Sub

    Private Sub txtStudentName_TextChanged(sender As Object, e As EventArgs) Handles txtStudentName.TextChanged
    End Sub

    Private Sub txtRegNo_TextChanged(sender As Object, e As EventArgs) Handles txtRegNo.TextChanged
    End Sub

End Class
