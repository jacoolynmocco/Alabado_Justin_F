<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLessonViewer
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
        lblTitle = New Label()
        rtbContent = New RichTextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        lblPageNumber = New Label()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblTitle.Font = New Font("Segoe Print", 15F, FontStyle.Bold)
        lblTitle.Location = New Point(20, 12)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(760, 45)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Lesson Title"
        lblTitle.ForeColor = Color.FromArgb(30, 45, 15)
        ' 
        ' rtbContent
        ' 
        rtbContent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        rtbContent.Font = New Font("Segoe UI", 12F)
        rtbContent.Location = New Point(20, 65)
        rtbContent.Name = "rtbContent"
        rtbContent.Size = New Size(760, 315)
        rtbContent.TabIndex = 1
        rtbContent.Text = ""
        rtbContent.BackColor = Color.FromArgb(252, 250, 232)
        rtbContent.ForeColor = Color.FromArgb(92, 64, 51)
        rtbContent.BorderStyle = BorderStyle.FixedSingle
        rtbContent.ReadOnly = True
        rtbContent.TabStop = False
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnPrevious.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        btnPrevious.Location = New Point(20, 395)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(100, 35)
        btnPrevious.TabIndex = 2
        btnPrevious.Text = "Previous"
        btnPrevious.BackColor = Color.FromArgb(134, 168, 60)
        btnPrevious.ForeColor = Color.FromArgb(30, 45, 15)
        btnPrevious.FlatAppearance.BorderColor = Color.FromArgb(92, 64, 51)
        btnPrevious.FlatStyle = FlatStyle.Flat
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnNext.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        btnNext.Location = New Point(130, 395)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(100, 35)
        btnNext.TabIndex = 3
        btnNext.Text = "Next"
        btnNext.BackColor = Color.FromArgb(134, 168, 60)
        btnNext.ForeColor = Color.FromArgb(30, 45, 15)
        btnNext.FlatAppearance.BorderColor = Color.FromArgb(92, 64, 51)
        btnNext.FlatStyle = FlatStyle.Flat
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' lblPageNumber
        ' 
        lblPageNumber.Anchor = AnchorStyles.Bottom
        lblPageNumber.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        lblPageNumber.Location = New Point(300, 402)
        lblPageNumber.Name = "lblPageNumber"
        lblPageNumber.Size = New Size(200, 23)
        lblPageNumber.TabIndex = 4
        lblPageNumber.Text = "Page 1 of 1"
        lblPageNumber.ForeColor = Color.FromArgb(92, 64, 51)
        lblPageNumber.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnBack
        ' 
        btnBack.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnBack.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        btnBack.Location = New Point(680, 395)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(100, 35)
        btnBack.TabIndex = 5
        btnBack.Text = "Back"
        btnBack.BackColor = Color.FromArgb(134, 168, 60)
        btnBack.ForeColor = Color.FromArgb(30, 45, 15)
        btnBack.FlatAppearance.BorderColor = Color.FromArgb(92, 64, 51)
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' frmLessonViewer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(240, 244, 214)
        ClientSize = New Size(800, 450)
        Controls.Add(btnBack)
        Controls.Add(lblPageNumber)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(rtbContent)
        Controls.Add(lblTitle)
        Name = "frmLessonViewer"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Lesson Viewer"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents rtbContent As RichTextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lblPageNumber As Label
    Friend WithEvents btnBack As Button

End Class
