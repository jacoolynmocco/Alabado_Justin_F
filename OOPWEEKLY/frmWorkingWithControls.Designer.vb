<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWorkingWithControls
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
        lblHeading = New Label()
        rtbLesson = New RichTextBox()
        txtCode = New TextBox()
        grpEnrollment = New GroupBox()
        lblFullName = New Label()
        txtFullName = New TextBox()
        lblAge = New Label()
        nudAge = New NumericUpDown()
        lblBirthdate = New Label()
        dtpBirthdate = New DateTimePicker()
        lblCourse = New Label()
        cboCourse = New ComboBox()
        lblGender = New Label()
        rdoMale = New RadioButton()
        rdoFemale = New RadioButton()
        grpInterests = New GroupBox()
        chkProgramming = New CheckBox()
        chkMusic = New CheckBox()
        chkSports = New CheckBox()
        chkReading = New CheckBox()
        lblRating = New Label()
        trkRating = New TrackBar()
        lblRatingValue = New Label()
        lblSkills = New Label()
        lstSkills = New ListBox()
        lblProgress = New Label()
        prgForm = New ProgressBar()
        btnSubmit = New Button()
        btnClear = New Button()
        btnExit = New Button()
        txtSummary = New TextBox()
        CType(nudAge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(trkRating, System.ComponentModel.ISupportInitialize).BeginInit()
        grpEnrollment.SuspendLayout()
        grpInterests.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblHeading.Font = New Font("Segoe Print", 15F, FontStyle.Bold)
        lblHeading.Location = New Point(20, 12)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(840, 45)
        lblHeading.TabIndex = 0
        lblHeading.Text = "WEEK 8 - WORKING WITH CONTROLS AND PROPERTIES"
        lblHeading.ForeColor = Color.FromArgb(30, 45, 15)
        ' 
        ' rtbLesson
        ' 
        rtbLesson.Font = New Font("Segoe UI", 10.5F)
        rtbLesson.Location = New Point(20, 70)
        rtbLesson.Name = "rtbLesson"
        rtbLesson.Size = New Size(395, 290)
        rtbLesson.TabIndex = 1
        rtbLesson.Text = "VB.NET DIALOG BOXES" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Visual Basic .NET has many built-in dialog boxes for common tasks: opening/saving files, printing, and choosing colors or fonts. They save development time." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All of them inherit from the CommonDialog class and override RunDialog() to build the specific dialog box. RunDialog() runs automatically when you call ShowDialog()." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "COMMON DIALOG CONTROLS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ColorDialog - lets the user pick a color. Main property: Color." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FontDialog - lets the user choose a font, size, and color. Main properties: Font and Color." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "OpenFileDialog - lets the user choose a file to open. Main property: FileName." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SaveFileDialog - lets the user choose where to save a file. Main property: FileName." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PrintDialog - lets the user choose a printer and what to print." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DIALOGRESULT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ShowDialog returns a DialogResult value. Check for DialogResult.OK before using what the user chose."
        rtbLesson.BackColor = Color.FromArgb(252, 250, 232)
        rtbLesson.ForeColor = Color.FromArgb(92, 64, 51)
        rtbLesson.ReadOnly = True
        rtbLesson.TabStop = False
        ' 
        ' txtCode
        ' 
        txtCode.Font = New Font("Consolas", 11.25F)
        txtCode.Location = New Point(20, 370)
        txtCode.Name = "txtCode"
        txtCode.Size = New Size(395, 315)
        txtCode.TabIndex = 2
        txtCode.Text = "' Example: showing a ColorDialog" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dim dlgColor As New ColorDialog()" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If dlgColor.ShowDialog() = DialogResult.OK Then" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Me.BackColor = dlgColor.Color" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "End If" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "' Example: showing an OpenFileDialog" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dim dlgOpen As New OpenFileDialog()" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If dlgOpen.ShowDialog() = DialogResult.OK Then" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Dim chosenFile As String = dlgOpen.FileName" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "End If" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "' Example: showing a FontDialog" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dim dlgFont As New FontDialog()" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If dlgFont.ShowDialog() = DialogResult.OK Then" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Me.Font = dlgFont.Font" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "End If" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "' Example: showing a SaveFileDialog" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dim dlgSave As New SaveFileDialog()" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If dlgSave.ShowDialog() = DialogResult.OK Then" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Dim savePath As String = dlgSave.FileName" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "End If"
        txtCode.BackColor = Color.FromArgb(252, 250, 232)
        txtCode.ForeColor = Color.FromArgb(92, 64, 51)
        txtCode.Multiline = True
        txtCode.ReadOnly = True
        txtCode.ScrollBars = ScrollBars.Vertical
        txtCode.TabStop = False
        ' 
        ' grpEnrollment
        ' 
        grpEnrollment.Controls.Add(lblFullName)
        grpEnrollment.Controls.Add(txtFullName)
        grpEnrollment.Controls.Add(lblAge)
        grpEnrollment.Controls.Add(nudAge)
        grpEnrollment.Controls.Add(lblBirthdate)
        grpEnrollment.Controls.Add(dtpBirthdate)
        grpEnrollment.Controls.Add(lblCourse)
        grpEnrollment.Controls.Add(cboCourse)
        grpEnrollment.Controls.Add(lblGender)
        grpEnrollment.Controls.Add(rdoMale)
        grpEnrollment.Controls.Add(rdoFemale)
        grpEnrollment.Controls.Add(grpInterests)
        grpEnrollment.Controls.Add(lblRating)
        grpEnrollment.Controls.Add(trkRating)
        grpEnrollment.Controls.Add(lblRatingValue)
        grpEnrollment.Controls.Add(lblSkills)
        grpEnrollment.Controls.Add(lstSkills)
        grpEnrollment.Controls.Add(lblProgress)
        grpEnrollment.Controls.Add(prgForm)
        grpEnrollment.Controls.Add(btnSubmit)
        grpEnrollment.Controls.Add(btnClear)
        grpEnrollment.Controls.Add(btnExit)
        grpEnrollment.Controls.Add(txtSummary)
        grpEnrollment.Font = New Font("Segoe UI", 9F)
        grpEnrollment.Location = New Point(435, 70)
        grpEnrollment.Name = "grpEnrollment"
        grpEnrollment.Size = New Size(425, 615)
        grpEnrollment.TabIndex = 3
        grpEnrollment.Text = "Laboratory Activity: Student Enrollment Form"
        grpEnrollment.ForeColor = Color.FromArgb(30, 45, 15)
        grpEnrollment.TabStop = False
        ' 
        ' lblFullName
        ' 
        lblFullName.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        lblFullName.Font = New Font("Segoe UI", 9F)
        lblFullName.Location = New Point(15, 33)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(100, 20)
        lblFullName.TabIndex = 0
        lblFullName.Text = "Full Name:"
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(130, 30)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(280, 23)
        txtFullName.TabIndex = 1
        txtFullName.Text = ""
        txtFullName.BackColor = Color.FromArgb(252, 250, 232)
        txtFullName.ForeColor = Color.FromArgb(92, 64, 51)
        ' 
        ' lblAge
        ' 
        lblAge.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        lblAge.Font = New Font("Segoe UI", 9F)
        lblAge.Location = New Point(15, 73)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(100, 20)
        lblAge.TabIndex = 2
        lblAge.Text = "Age:"
        ' 
        ' nudAge
        ' 
        nudAge.Location = New Point(130, 70)
        nudAge.Name = "nudAge"
        nudAge.Size = New Size(70, 23)
        nudAge.TabIndex = 3
        nudAge.BackColor = Color.FromArgb(252, 250, 232)
        nudAge.ForeColor = Color.FromArgb(92, 64, 51)
        nudAge.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        nudAge.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudAge.Value = New Decimal(New Integer() {18, 0, 0, 0})
        ' 
        ' lblBirthdate
        ' 
        lblBirthdate.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        lblBirthdate.Font = New Font("Segoe UI", 9F)
        lblBirthdate.Location = New Point(15, 113)
        lblBirthdate.Name = "lblBirthdate"
        lblBirthdate.Size = New Size(100, 20)
        lblBirthdate.TabIndex = 4
        lblBirthdate.Text = "Birthdate:"
        ' 
        ' dtpBirthdate
        ' 
        dtpBirthdate.Location = New Point(130, 110)
        dtpBirthdate.Name = "dtpBirthdate"
        dtpBirthdate.Size = New Size(150, 23)
        dtpBirthdate.TabIndex = 5
        dtpBirthdate.Format = DateTimePickerFormat.Short
        ' 
        ' lblCourse
        ' 
        lblCourse.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        lblCourse.Font = New Font("Segoe UI", 9F)
        lblCourse.Location = New Point(15, 153)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(100, 20)
        lblCourse.TabIndex = 6
        lblCourse.Text = "Course:"
        ' 
        ' cboCourse
        ' 
        cboCourse.Location = New Point(130, 150)
        cboCourse.Name = "cboCourse"
        cboCourse.Size = New Size(280, 23)
        cboCourse.TabIndex = 7
        cboCourse.BackColor = Color.FromArgb(252, 250, 232)
        cboCourse.ForeColor = Color.FromArgb(92, 64, 51)
        cboCourse.DropDownStyle = ComboBoxStyle.DropDownList
        cboCourse.FormattingEnabled = True
        cboCourse.Items.AddRange(New Object() {"BSIT", "BSCS", "BSIS", "BSCpE"})
        ' 
        ' lblGender
        ' 
        lblGender.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        lblGender.Font = New Font("Segoe UI", 9F)
        lblGender.Location = New Point(15, 195)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(100, 20)
        lblGender.TabIndex = 8
        lblGender.Text = "Gender:"
        ' 
        ' rdoMale
        ' 
        rdoMale.Location = New Point(130, 193)
        rdoMale.Name = "rdoMale"
        rdoMale.Size = New Size(60, 19)
        rdoMale.TabIndex = 9
        rdoMale.Text = "Male"
        rdoMale.AutoSize = True
        rdoMale.UseVisualStyleBackColor = True
        ' 
        ' rdoFemale
        ' 
        rdoFemale.Location = New Point(225, 193)
        rdoFemale.Name = "rdoFemale"
        rdoFemale.Size = New Size(70, 19)
        rdoFemale.TabIndex = 10
        rdoFemale.Text = "Female"
        rdoFemale.AutoSize = True
        rdoFemale.UseVisualStyleBackColor = True
        ' 
        ' grpInterests
        ' 
        grpInterests.Controls.Add(chkProgramming)
        grpInterests.Controls.Add(chkMusic)
        grpInterests.Controls.Add(chkSports)
        grpInterests.Controls.Add(chkReading)
        grpInterests.Location = New Point(130, 220)
        grpInterests.Name = "grpInterests"
        grpInterests.Size = New Size(280, 85)
        grpInterests.TabIndex = 11
        grpInterests.Text = "Interests"
        grpInterests.TabStop = False
        ' 
        ' chkProgramming
        ' 
        chkProgramming.Location = New Point(12, 22)
        chkProgramming.Name = "chkProgramming"
        chkProgramming.Size = New Size(100, 19)
        chkProgramming.TabIndex = 0
        chkProgramming.Text = "Programming"
        chkProgramming.AutoSize = True
        chkProgramming.UseVisualStyleBackColor = True
        ' 
        ' chkMusic
        ' 
        chkMusic.Location = New Point(150, 22)
        chkMusic.Name = "chkMusic"
        chkMusic.Size = New Size(60, 19)
        chkMusic.TabIndex = 1
        chkMusic.Text = "Music"
        chkMusic.AutoSize = True
        chkMusic.UseVisualStyleBackColor = True
        ' 
        ' chkSports
        ' 
        chkSports.Location = New Point(12, 52)
        chkSports.Name = "chkSports"
        chkSports.Size = New Size(60, 19)
        chkSports.TabIndex = 2
        chkSports.Text = "Sports"
        chkSports.AutoSize = True
        chkSports.UseVisualStyleBackColor = True
        ' 
        ' chkReading
        ' 
        chkReading.Location = New Point(150, 52)
        chkReading.Name = "chkReading"
        chkReading.Size = New Size(70, 19)
        chkReading.TabIndex = 3
        chkReading.Text = "Reading"
        chkReading.AutoSize = True
        chkReading.UseVisualStyleBackColor = True
        ' 
        ' lblRating
        ' 
        lblRating.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        lblRating.Font = New Font("Segoe UI", 9F)
        lblRating.Location = New Point(15, 325)
        lblRating.Name = "lblRating"
        lblRating.Size = New Size(115, 20)
        lblRating.TabIndex = 12
        lblRating.Text = "Satisfaction Rating:"
        ' 
        ' trkRating
        ' 
        trkRating.Location = New Point(130, 315)
        trkRating.Name = "trkRating"
        trkRating.Size = New Size(220, 45)
        trkRating.TabIndex = 13
        trkRating.Maximum = 10
        trkRating.Minimum = 1
        trkRating.Value = 5
        ' 
        ' lblRatingValue
        ' 
        lblRatingValue.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        lblRatingValue.Font = New Font("Segoe UI", 9F)
        lblRatingValue.Location = New Point(355, 325)
        lblRatingValue.Name = "lblRatingValue"
        lblRatingValue.Size = New Size(60, 20)
        lblRatingValue.TabIndex = 14
        lblRatingValue.Text = "5 / 10"
        ' 
        ' lblSkills
        ' 
        lblSkills.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        lblSkills.Font = New Font("Segoe UI", 9F)
        lblSkills.Location = New Point(15, 385)
        lblSkills.Name = "lblSkills"
        lblSkills.Size = New Size(115, 20)
        lblSkills.TabIndex = 15
        lblSkills.Text = "Skills (Ctrl+Click):"
        ' 
        ' lstSkills
        ' 
        lstSkills.Location = New Point(130, 380)
        lstSkills.Name = "lstSkills"
        lstSkills.Size = New Size(280, 64)
        lstSkills.TabIndex = 16
        lstSkills.BackColor = Color.FromArgb(252, 250, 232)
        lstSkills.ForeColor = Color.FromArgb(92, 64, 51)
        lstSkills.FormattingEnabled = True
        lstSkills.SelectionMode = SelectionMode.MultiExtended
        lstSkills.Items.AddRange(New Object() {"VB.NET", "HTML/CSS", "JavaScript", "SQL", "Python", "C#"})
        ' 
        ' lblProgress
        ' 
        lblProgress.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        lblProgress.Font = New Font("Segoe UI", 9F)
        lblProgress.Location = New Point(15, 462)
        lblProgress.Name = "lblProgress"
        lblProgress.Size = New Size(115, 20)
        lblProgress.TabIndex = 17
        lblProgress.Text = "Form Progress:"
        ' 
        ' prgForm
        ' 
        prgForm.Location = New Point(130, 460)
        prgForm.Name = "prgForm"
        prgForm.Size = New Size(280, 22)
        prgForm.TabIndex = 18
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        btnSubmit.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        btnSubmit.Location = New Point(130, 497)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(85, 30)
        btnSubmit.TabIndex = 19
        btnSubmit.Text = "Submit"
        btnSubmit.BackColor = Color.FromArgb(134, 168, 60)
        btnSubmit.ForeColor = Color.FromArgb(30, 45, 15)
        btnSubmit.FlatAppearance.BorderColor = Color.FromArgb(92, 64, 51)
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        btnClear.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        btnClear.Location = New Point(225, 497)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(85, 30)
        btnClear.TabIndex = 20
        btnClear.Text = "Clear"
        btnClear.BackColor = Color.FromArgb(134, 168, 60)
        btnClear.ForeColor = Color.FromArgb(30, 45, 15)
        btnClear.FlatAppearance.BorderColor = Color.FromArgb(92, 64, 51)
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        btnExit.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        btnExit.Location = New Point(320, 497)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(85, 30)
        btnExit.TabIndex = 21
        btnExit.Text = "Exit"
        btnExit.BackColor = Color.FromArgb(134, 168, 60)
        btnExit.ForeColor = Color.FromArgb(30, 45, 15)
        btnExit.FlatAppearance.BorderColor = Color.FromArgb(92, 64, 51)
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' txtSummary
        ' 
        txtSummary.Font = New Font("Consolas", 9.75F)
        txtSummary.Location = New Point(15, 540)
        txtSummary.Name = "txtSummary"
        txtSummary.Size = New Size(395, 65)
        txtSummary.TabIndex = 22
        txtSummary.Text = ""
        txtSummary.BackColor = Color.FromArgb(252, 250, 232)
        txtSummary.ForeColor = Color.FromArgb(92, 64, 51)
        txtSummary.Multiline = True
        txtSummary.ReadOnly = True
        txtSummary.ScrollBars = ScrollBars.Vertical
        ' 
        ' frmWorkingWithControls
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.FromArgb(240, 244, 214)
        ClientSize = New Size(880, 705)
        Controls.Add(grpEnrollment)
        Controls.Add(txtCode)
        Controls.Add(rtbLesson)
        Controls.Add(lblHeading)
        Name = "frmWorkingWithControls"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Working With Controls and Properties"
        CType(nudAge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(trkRating, System.ComponentModel.ISupportInitialize).EndInit()
        grpEnrollment.ResumeLayout(False)
        grpEnrollment.PerformLayout()
        grpInterests.ResumeLayout(False)
        grpInterests.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents rtbLesson As RichTextBox
    Friend WithEvents txtCode As TextBox
    Friend WithEvents grpEnrollment As GroupBox
    Friend WithEvents lblFullName As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents nudAge As NumericUpDown
    Friend WithEvents lblBirthdate As Label
    Friend WithEvents dtpBirthdate As DateTimePicker
    Friend WithEvents lblCourse As Label
    Friend WithEvents cboCourse As ComboBox
    Friend WithEvents lblGender As Label
    Friend WithEvents rdoMale As RadioButton
    Friend WithEvents rdoFemale As RadioButton
    Friend WithEvents grpInterests As GroupBox
    Friend WithEvents chkProgramming As CheckBox
    Friend WithEvents chkMusic As CheckBox
    Friend WithEvents chkSports As CheckBox
    Friend WithEvents chkReading As CheckBox
    Friend WithEvents lblRating As Label
    Friend WithEvents trkRating As TrackBar
    Friend WithEvents lblRatingValue As Label
    Friend WithEvents lblSkills As Label
    Friend WithEvents lstSkills As ListBox
    Friend WithEvents lblProgress As Label
    Friend WithEvents prgForm As ProgressBar
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtSummary As TextBox

End Class
