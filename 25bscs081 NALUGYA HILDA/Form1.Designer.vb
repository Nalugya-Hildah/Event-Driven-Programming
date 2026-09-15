<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblSchoolName = New Label()
        lblTitle = New Label()
        Label1lblSlogan = New Label()
        lblStudentName = New Label()
        txtStudentName = New TextBox()
        lblRegNo = New Label()
        txtRegNo = New TextBox()
        lblDateofBirth = New Label()
        dptDateOfBirth = New DateTimePicker()
        lblGender = New Label()
        lblphone = New Label()
        txtphone = New TextBox()
        txtEmail = New TextBox()
        lblEmail = New Label()
        lblEducationInfo = New Label()
        lblEducation = New Label()
        cmbEducation = New ComboBox()
        cmbCourse = New ComboBox()
        lblCourse = New Label()
        lblIntake = New Label()
        ColorDialog1 = New ColorDialog()
        cmbIntake = New ComboBox()
        lbladdressinfo = New Label()
        lbladress = New Label()
        txtAddress = New TextBox()
        btnApply = New Button()
        btnClear = New Button()
        btnExit = New Button()
        lblmessage = New Label()
        radMale = New RadioButton()
        radFemale = New RadioButton()
        SuspendLayout()
        ' 
        ' lblSchoolName
        ' 
        lblSchoolName.AutoSize = True
        lblSchoolName.BackColor = Color.Transparent
        lblSchoolName.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSchoolName.Location = New Point(338, 6)
        lblSchoolName.Name = "lblSchoolName"
        lblSchoolName.Size = New Size(498, 32)
        lblSchoolName.TabIndex = 0
        lblSchoolName.Text = "KAMPALA VOCATIONAL SKILLS INSTITUTE"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(433, 38)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(285, 25)
        lblTitle.TabIndex = 1
        lblTitle.Text = "STUDENT APPLICATION FORM"
        ' 
        ' Label1lblSlogan
        ' 
        Label1lblSlogan.AutoSize = True
        Label1lblSlogan.BackColor = Color.Transparent
        Label1lblSlogan.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1lblSlogan.Location = New Point(406, 63)
        Label1lblSlogan.Name = "Label1lblSlogan"
        Label1lblSlogan.Size = New Size(353, 21)
        Label1lblSlogan.TabIndex = 2
        Label1lblSlogan.Text = "Building Skills Today, Creating Careers Tomorrow"
        ' 
        ' lblStudentName
        ' 
        lblStudentName.AutoSize = True
        lblStudentName.BackColor = Color.White
        lblStudentName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblStudentName.ForeColor = SystemColors.WindowText
        lblStudentName.Location = New Point(202, 114)
        lblStudentName.Name = "lblStudentName"
        lblStudentName.Size = New Size(131, 21)
        lblStudentName.TabIndex = 3
        lblStudentName.Text = "Students Name:"
        ' 
        ' txtStudentName
        ' 
        txtStudentName.BackColor = SystemColors.InactiveBorder
        txtStudentName.Location = New Point(427, 107)
        txtStudentName.Name = "txtStudentName"
        txtStudentName.Size = New Size(307, 23)
        txtStudentName.TabIndex = 4
        ' 
        ' lblRegNo
        ' 
        lblRegNo.AutoSize = True
        lblRegNo.BackColor = Color.White
        lblRegNo.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblRegNo.ForeColor = SystemColors.WindowText
        lblRegNo.Location = New Point(202, 152)
        lblRegNo.Name = "lblRegNo"
        lblRegNo.Size = New Size(134, 21)
        lblRegNo.TabIndex = 5
        lblRegNo.Text = "Registration No:"
        ' 
        ' txtRegNo
        ' 
        txtRegNo.BackColor = SystemColors.InactiveBorder
        txtRegNo.Location = New Point(427, 150)
        txtRegNo.Name = "txtRegNo"
        txtRegNo.Size = New Size(307, 23)
        txtRegNo.TabIndex = 6
        ' 
        ' lblDateofBirth
        ' 
        lblDateofBirth.AutoSize = True
        lblDateofBirth.BackColor = Color.White
        lblDateofBirth.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblDateofBirth.ForeColor = SystemColors.WindowText
        lblDateofBirth.Location = New Point(202, 188)
        lblDateofBirth.Name = "lblDateofBirth"
        lblDateofBirth.Size = New Size(111, 21)
        lblDateofBirth.TabIndex = 7
        lblDateofBirth.Text = "Date of Birth:"
        ' 
        ' dptDateOfBirth
        ' 
        dptDateOfBirth.CalendarMonthBackground = SystemColors.InactiveBorder
        dptDateOfBirth.Location = New Point(427, 182)
        dptDateOfBirth.Name = "dptDateOfBirth"
        dptDateOfBirth.Size = New Size(307, 23)
        dptDateOfBirth.TabIndex = 8
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.BackColor = Color.White
        lblGender.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblGender.ForeColor = SystemColors.WindowText
        lblGender.Location = New Point(202, 223)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(70, 21)
        lblGender.TabIndex = 9
        lblGender.Text = "Gender:"
        ' 
        ' lblphone
        ' 
        lblphone.AutoSize = True
        lblphone.BackColor = Color.White
        lblphone.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblphone.ForeColor = SystemColors.WindowText
        lblphone.Location = New Point(202, 249)
        lblphone.Name = "lblphone"
        lblphone.Size = New Size(162, 21)
        lblphone.TabIndex = 11
        lblphone.Text = "Telephone Number:"
        ' 
        ' txtphone
        ' 
        txtphone.BackColor = SystemColors.InactiveBorder
        txtphone.Location = New Point(427, 241)
        txtphone.Name = "txtphone"
        txtphone.Size = New Size(307, 23)
        txtphone.TabIndex = 12
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.InactiveBorder
        txtEmail.Location = New Point(427, 268)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(301, 23)
        txtEmail.TabIndex = 13
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.BackColor = Color.White
        lblEmail.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblEmail.ForeColor = SystemColors.WindowText
        lblEmail.Location = New Point(202, 276)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(57, 21)
        lblEmail.TabIndex = 14
        lblEmail.Text = "Email:"
        ' 
        ' lblEducationInfo
        ' 
        lblEducationInfo.AutoSize = True
        lblEducationInfo.BackColor = Color.Transparent
        lblEducationInfo.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEducationInfo.ForeColor = SystemColors.WindowText
        lblEducationInfo.Location = New Point(406, 305)
        lblEducationInfo.Name = "lblEducationInfo"
        lblEducationInfo.Size = New Size(177, 17)
        lblEducationInfo.TabIndex = 15
        lblEducationInfo.Text = "EDUCATION INFORMATION"
        ' 
        ' lblEducation
        ' 
        lblEducation.AutoSize = True
        lblEducation.BackColor = Color.White
        lblEducation.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblEducation.ForeColor = SystemColors.WindowText
        lblEducation.Location = New Point(202, 340)
        lblEducation.Name = "lblEducation"
        lblEducation.Size = New Size(158, 21)
        lblEducation.TabIndex = 16
        lblEducation.Text = "Highest education :"
        ' 
        ' cmbEducation
        ' 
        cmbEducation.BackColor = SystemColors.InactiveBorder
        cmbEducation.FormattingEnabled = True
        cmbEducation.Location = New Point(427, 337)
        cmbEducation.Name = "cmbEducation"
        cmbEducation.Size = New Size(320, 23)
        cmbEducation.TabIndex = 17
        ' 
        ' cmbCourse
        ' 
        cmbCourse.BackColor = SystemColors.InactiveBorder
        cmbCourse.FormattingEnabled = True
        cmbCourse.Location = New Point(427, 368)
        cmbCourse.Name = "cmbCourse"
        cmbCourse.Size = New Size(320, 23)
        cmbCourse.TabIndex = 18
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.BackColor = Color.White
        lblCourse.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblCourse.ForeColor = SystemColors.WindowText
        lblCourse.Location = New Point(202, 376)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(121, 21)
        lblCourse.TabIndex = 19
        lblCourse.Text = "Course / Skills:"
        ' 
        ' lblIntake
        ' 
        lblIntake.AutoSize = True
        lblIntake.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblIntake.ForeColor = SystemColors.WindowText
        lblIntake.Location = New Point(202, 407)
        lblIntake.Name = "lblIntake"
        lblIntake.Size = New Size(131, 21)
        lblIntake.TabIndex = 20
        lblIntake.Text = "Prefered Intake:"
        ' 
        ' cmbIntake
        ' 
        cmbIntake.BackColor = SystemColors.InactiveBorder
        cmbIntake.FormattingEnabled = True
        cmbIntake.Location = New Point(427, 399)
        cmbIntake.Name = "cmbIntake"
        cmbIntake.Size = New Size(318, 23)
        cmbIntake.TabIndex = 21
        ' 
        ' lbladdressinfo
        ' 
        lbladdressinfo.AutoSize = True
        lbladdressinfo.BackColor = Color.Gainsboro
        lbladdressinfo.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbladdressinfo.ForeColor = SystemColors.WindowText
        lbladdressinfo.Location = New Point(481, 450)
        lbladdressinfo.Name = "lbladdressinfo"
        lbladdressinfo.Size = New Size(161, 17)
        lbladdressinfo.TabIndex = 22
        lbladdressinfo.Text = "ADDRESS INFORMATION"
        ' 
        ' lbladress
        ' 
        lbladress.AutoSize = True
        lbladress.BackColor = Color.White
        lbladress.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lbladress.ForeColor = SystemColors.WindowText
        lbladress.Location = New Point(202, 489)
        lbladress.Name = "lbladress"
        lbladress.Size = New Size(74, 21)
        lbladress.TabIndex = 23
        lbladress.Text = "Address:"
        ' 
        ' txtAddress
        ' 
        txtAddress.BackColor = SystemColors.InactiveBorder
        txtAddress.Location = New Point(427, 481)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(320, 23)
        txtAddress.TabIndex = 24
        ' 
        ' btnApply
        ' 
        btnApply.BackColor = Color.SkyBlue
        btnApply.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnApply.Location = New Point(223, 541)
        btnApply.Name = "btnApply"
        btnApply.Size = New Size(145, 23)
        btnApply.TabIndex = 25
        btnApply.Text = "APPLY / REGISTER"
        btnApply.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.SkyBlue
        btnClear.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(406, 542)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 26
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.SkyBlue
        btnExit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(536, 542)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 27
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' lblmessage
        ' 
        lblmessage.BackColor = Color.White
        lblmessage.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblmessage.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        lblmessage.Location = New Point(427, 616)
        lblmessage.Name = "lblmessage"
        lblmessage.Size = New Size(332, 61)
        lblmessage.TabIndex = 28
        ' 
        ' radMale
        ' 
        radMale.AutoSize = True
        radMale.Location = New Point(427, 211)
        radMale.Name = "radMale"
        radMale.Size = New Size(51, 19)
        radMale.TabIndex = 29
        radMale.TabStop = True
        radMale.Text = "Male"
        radMale.UseVisualStyleBackColor = True
        ' 
        ' radFemale
        ' 
        radFemale.AutoSize = True
        radFemale.Location = New Point(498, 211)
        radFemale.Name = "radFemale"
        radFemale.Size = New Size(63, 19)
        radFemale.TabIndex = 30
        radFemale.TabStop = True
        radFemale.Text = "Female"
        radFemale.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.Kampala_Vocational_Skills_Institute
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(915, 742)
        Controls.Add(radFemale)
        Controls.Add(radMale)
        Controls.Add(lblmessage)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnApply)
        Controls.Add(txtAddress)
        Controls.Add(lbladress)
        Controls.Add(lbladdressinfo)
        Controls.Add(cmbIntake)
        Controls.Add(lblIntake)
        Controls.Add(lblCourse)
        Controls.Add(cmbCourse)
        Controls.Add(cmbEducation)
        Controls.Add(lblEducation)
        Controls.Add(lblEducationInfo)
        Controls.Add(lblEmail)
        Controls.Add(txtEmail)
        Controls.Add(txtphone)
        Controls.Add(lblphone)
        Controls.Add(lblGender)
        Controls.Add(dptDateOfBirth)
        Controls.Add(lblDateofBirth)
        Controls.Add(txtRegNo)
        Controls.Add(lblRegNo)
        Controls.Add(txtStudentName)
        Controls.Add(lblStudentName)
        Controls.Add(Label1lblSlogan)
        Controls.Add(lblTitle)
        Controls.Add(lblSchoolName)
        ForeColor = SystemColors.WindowText
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSchoolName As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1lblSlogan As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents lblRegNo As Label
    Friend WithEvents txtRegNo As TextBox
    Friend WithEvents lblDateofBirth As Label
    Friend WithEvents dptDateOfBirth As DateTimePicker
    Friend WithEvents lblGender As Label
    Friend WithEvents lblphone As Label
    Friend WithEvents txtphone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblEducationInfo As Label
    Friend WithEvents lblEducation As Label
    Friend WithEvents cmbEducation As ComboBox
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblIntake As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents cmbIntake As ComboBox
    Friend WithEvents lbladdressinfo As Label
    Friend WithEvents lbladress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents btnApply As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblmessage As Label
    Friend WithEvents radMale As RadioButton
    Friend WithEvents radFemale As RadioButton

End Class
