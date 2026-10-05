<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLevel1
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLevel1))
        lblTitle = New Label()
        pnlLeft = New FlowLayoutPanel()
        btnM1 = New Button()
        btnM2 = New Button()
        btnM3 = New Button()
        btnC1 = New Button()
        btnC2 = New Button()
        btnC3 = New Button()
        pnlRight = New FlowLayoutPanel()
        pnlBoat = New FlowLayoutPanel()
        btnGo = New Button()
        btnReset = New Button()
        tmrBoat = New Timer(components)
        pnlLeft.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Courier New", 20.25F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(20, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(126, 31)
        lblTitle.TabIndex = 5
        lblTitle.Text = "LEVEL 1"
        ' 
        ' pnlLeft
        ' 
        pnlLeft.BackColor = Color.FromArgb(CByte(0), CByte(168), CByte(0))
        pnlLeft.Controls.Add(btnM1)
        pnlLeft.Controls.Add(btnM2)
        pnlLeft.Controls.Add(btnM3)
        pnlLeft.Controls.Add(btnC1)
        pnlLeft.Controls.Add(btnC2)
        pnlLeft.Controls.Add(btnC3)
        pnlLeft.Location = New Point(0, 170)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Padding = New Padding(10)
        pnlLeft.Size = New Size(234, 170)
        pnlLeft.TabIndex = 0
        ' 
        ' btnM1
        ' 
        btnM1.Anchor = AnchorStyles.None
        btnM1.BackColor = Color.Transparent
        btnM1.BackgroundImage = CType(resources.GetObject("btnM1.BackgroundImage"), Image)
        btnM1.BackgroundImageLayout = ImageLayout.Stretch
        btnM1.FlatAppearance.BorderColor = Color.Black
        btnM1.FlatAppearance.BorderSize = 0
        btnM1.FlatStyle = FlatStyle.Flat
        btnM1.Font = New Font("Courier New", 8.25F, FontStyle.Bold)
        btnM1.ForeColor = Color.White
        btnM1.Location = New Point(13, 25)
        btnM1.Name = "btnM1"
        btnM1.Size = New Size(57, 55)
        btnM1.TabIndex = 0
        btnM1.Tag = "M"
        btnM1.UseVisualStyleBackColor = False
        ' 
        ' btnM2
        ' 
        btnM2.Anchor = AnchorStyles.None
        btnM2.BackColor = Color.Transparent
        btnM2.BackgroundImage = CType(resources.GetObject("btnM2.BackgroundImage"), Image)
        btnM2.BackgroundImageLayout = ImageLayout.Stretch
        btnM2.FlatAppearance.BorderColor = Color.Black
        btnM2.FlatAppearance.BorderSize = 0
        btnM2.FlatStyle = FlatStyle.Flat
        btnM2.Font = New Font("Courier New", 8.25F, FontStyle.Bold)
        btnM2.ForeColor = Color.Transparent
        btnM2.Location = New Point(76, 13)
        btnM2.Name = "btnM2"
        btnM2.Size = New Size(57, 80)
        btnM2.TabIndex = 1
        btnM2.Tag = "M"
        btnM2.UseVisualStyleBackColor = False
        ' 
        ' btnM3
        ' 
        btnM3.BackColor = Color.Transparent
        btnM3.BackgroundImage = CType(resources.GetObject("btnM3.BackgroundImage"), Image)
        btnM3.BackgroundImageLayout = ImageLayout.Stretch
        btnM3.FlatAppearance.BorderColor = Color.Black
        btnM3.FlatAppearance.BorderSize = 0
        btnM3.FlatStyle = FlatStyle.Flat
        btnM3.Font = New Font("Courier New", 8.25F, FontStyle.Bold)
        btnM3.ForeColor = Color.Transparent
        btnM3.Location = New Point(139, 13)
        btnM3.Name = "btnM3"
        btnM3.Size = New Size(64, 64)
        btnM3.TabIndex = 2
        btnM3.Tag = "M"
        btnM3.TextImageRelation = TextImageRelation.TextAboveImage
        btnM3.UseVisualStyleBackColor = False
        ' 
        ' btnC1
        ' 
        btnC1.BackColor = Color.Transparent
        btnC1.BackgroundImage = CType(resources.GetObject("btnC1.BackgroundImage"), Image)
        btnC1.BackgroundImageLayout = ImageLayout.Stretch
        btnC1.FlatAppearance.BorderColor = Color.Black
        btnC1.FlatAppearance.BorderSize = 0
        btnC1.FlatStyle = FlatStyle.Flat
        btnC1.Font = New Font("Courier New", 8.25F, FontStyle.Bold)
        btnC1.ForeColor = Color.White
        btnC1.Location = New Point(13, 99)
        btnC1.Name = "btnC1"
        btnC1.Size = New Size(64, 64)
        btnC1.TabIndex = 3
        btnC1.Tag = "C"
        btnC1.UseVisualStyleBackColor = False
        ' 
        ' btnC2
        ' 
        btnC2.BackColor = Color.Transparent
        btnC2.BackgroundImage = CType(resources.GetObject("btnC2.BackgroundImage"), Image)
        btnC2.BackgroundImageLayout = ImageLayout.Stretch
        btnC2.FlatAppearance.BorderColor = Color.Black
        btnC2.FlatAppearance.BorderSize = 0
        btnC2.FlatStyle = FlatStyle.Flat
        btnC2.Font = New Font("Courier New", 8.25F, FontStyle.Bold)
        btnC2.ForeColor = Color.White
        btnC2.Location = New Point(83, 99)
        btnC2.Name = "btnC2"
        btnC2.Size = New Size(64, 64)
        btnC2.TabIndex = 4
        btnC2.Tag = "C"
        btnC2.UseVisualStyleBackColor = False
        ' 
        ' btnC3
        ' 
        btnC3.BackColor = Color.Transparent
        btnC3.BackgroundImage = CType(resources.GetObject("btnC3.BackgroundImage"), Image)
        btnC3.BackgroundImageLayout = ImageLayout.Stretch
        btnC3.FlatAppearance.BorderColor = Color.Black
        btnC3.FlatAppearance.BorderSize = 0
        btnC3.FlatStyle = FlatStyle.Flat
        btnC3.Font = New Font("Courier New", 8.25F, FontStyle.Bold)
        btnC3.ForeColor = Color.Wheat
        btnC3.Location = New Point(153, 99)
        btnC3.Name = "btnC3"
        btnC3.Size = New Size(64, 64)
        btnC3.TabIndex = 5
        btnC3.Tag = "C"
        btnC3.UseVisualStyleBackColor = False
        ' 
        ' pnlRight
        ' 
        pnlRight.BackColor = Color.FromArgb(CByte(0), CByte(168), CByte(0))
        pnlRight.Location = New Point(666, 170)
        pnlRight.Name = "pnlRight"
        pnlRight.Padding = New Padding(10)
        pnlRight.Size = New Size(234, 170)
        pnlRight.TabIndex = 1
        ' 
        ' pnlBoat
        ' 
        pnlBoat.BackColor = Color.Transparent
        pnlBoat.BackgroundImage = CType(resources.GetObject("pnlBoat.BackgroundImage"), Image)
        pnlBoat.BackgroundImageLayout = ImageLayout.Stretch
        pnlBoat.Location = New Point(234, 256)
        pnlBoat.Name = "pnlBoat"
        pnlBoat.Padding = New Padding(4)
        pnlBoat.Size = New Size(156, 84)
        pnlBoat.TabIndex = 2
        ' 
        ' btnGo
        ' 
        btnGo.BackColor = Color.FromArgb(CByte(252), CByte(188), CByte(60))
        btnGo.FlatAppearance.BorderColor = Color.Black
        btnGo.FlatAppearance.BorderSize = 2
        btnGo.FlatStyle = FlatStyle.Flat
        btnGo.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        btnGo.Location = New Point(400, 40)
        btnGo.Name = "btnGo"
        btnGo.Size = New Size(100, 40)
        btnGo.TabIndex = 3
        btnGo.Text = "Cross"
        btnGo.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.FromArgb(CByte(252), CByte(188), CByte(60))
        btnReset.FlatAppearance.BorderColor = Color.Black
        btnReset.FlatAppearance.BorderSize = 2
        btnReset.FlatStyle = FlatStyle.Flat
        btnReset.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        btnReset.Location = New Point(400, 90)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(100, 30)
        btnReset.TabIndex = 4
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' tmrBoat
        ' 
        tmrBoat.Interval = 15
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(92), CByte(148), CByte(252))
        ClientSize = New Size(900, 400)
        Controls.Add(lblTitle)
        Controls.Add(btnReset)
        Controls.Add(btnGo)
        Controls.Add(pnlBoat)
        Controls.Add(pnlRight)
        Controls.Add(pnlLeft)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmLevel1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Level 1"
        pnlLeft.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlLeft As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pnlRight As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pnlBoat As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnM1 As System.Windows.Forms.Button
    Friend WithEvents btnM2 As System.Windows.Forms.Button
    Friend WithEvents btnM3 As System.Windows.Forms.Button
    Friend WithEvents btnC1 As System.Windows.Forms.Button
    Friend WithEvents btnC2 As System.Windows.Forms.Button
    Friend WithEvents btnC3 As System.Windows.Forms.Button
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents tmrBoat As System.Windows.Forms.Timer

End Class
