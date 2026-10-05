Public Class frmWorkingWithControls

    ' Shows the rating next to the TrackBar
    Private Sub trkRating_ValueChanged(sender As Object, e As EventArgs) Handles trkRating.ValueChanged
        lblRatingValue.Text = trkRating.Value.ToString() & " / 10"
    End Sub

    ' Each completed section fills 20% of the progress bar
    Private Sub UpdateProgress(sender As Object, e As EventArgs) Handles txtFullName.TextChanged, cboCourse.SelectedIndexChanged,
        rdoMale.CheckedChanged, rdoFemale.CheckedChanged, chkProgramming.CheckedChanged, chkMusic.CheckedChanged,
        chkSports.CheckedChanged, chkReading.CheckedChanged, lstSkills.SelectedIndexChanged

        Dim done As Integer = 0

        If txtFullName.Text.Trim() <> String.Empty Then done += 1
        If cboCourse.SelectedIndex >= 0 Then done += 1
        If rdoMale.Checked OrElse rdoFemale.Checked Then done += 1
        If chkProgramming.Checked OrElse chkMusic.Checked OrElse chkSports.Checked OrElse chkReading.Checked Then done += 1
        If lstSkills.SelectedItems.Count > 0 Then done += 1

        prgForm.Value = done * 20

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If txtFullName.Text.Trim() = String.Empty OrElse cboCourse.SelectedIndex < 0 Then
            MessageBox.Show("Please enter your full name and choose a course.", "Student Enrollment")
            Exit Sub
        End If

        Dim gender As String = "Not specified"
        If rdoMale.Checked Then gender = "Male"
        If rdoFemale.Checked Then gender = "Female"

        Dim interests As New List(Of String)
        If chkProgramming.Checked Then interests.Add("Programming")
        If chkMusic.Checked Then interests.Add("Music")
        If chkSports.Checked Then interests.Add("Sports")
        If chkReading.Checked Then interests.Add("Reading")

        Dim skills As New List(Of String)
        For Each item As Object In lstSkills.SelectedItems
            skills.Add(item.ToString())
        Next

        txtSummary.Text = "ENROLLMENT SUMMARY" & vbCrLf &
            "Name".PadRight(12) & ": " & txtFullName.Text.Trim() & vbCrLf &
            "Age".PadRight(12) & ": " & nudAge.Value.ToString() & vbCrLf &
            "Birthdate".PadRight(12) & ": " & dtpBirthdate.Value.ToShortDateString() & vbCrLf &
            "Course".PadRight(12) & ": " & cboCourse.Text & vbCrLf &
            "Gender".PadRight(12) & ": " & gender & vbCrLf &
            "Interests".PadRight(12) & ": " & If(interests.Count > 0, String.Join(", ", interests), "None") & vbCrLf &
            "Rating".PadRight(12) & ": " & trkRating.Value.ToString() & " / 10" & vbCrLf &
            "Skills".PadRight(12) & ": " & If(skills.Count > 0, String.Join(", ", skills), "None")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtFullName.Clear()
        nudAge.Value = 18
        dtpBirthdate.Value = Date.Today
        cboCourse.SelectedIndex = -1
        rdoMale.Checked = False
        rdoFemale.Checked = False
        chkProgramming.Checked = False
        chkMusic.Checked = False
        chkSports.Checked = False
        chkReading.Checked = False
        trkRating.Value = 5
        lstSkills.ClearSelected()
        txtSummary.Clear()
        txtFullName.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class