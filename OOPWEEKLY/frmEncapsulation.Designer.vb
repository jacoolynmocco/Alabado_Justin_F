<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEncapsulation
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
        lblDescription = New Label()
        lblAmount = New Label()
        txtAmount = New TextBox()
        btnDeposit = New Button()
        btnWithdraw = New Button()
        btnBalance = New Button()
        lblHistory = New Label()
        lstHistory = New ListBox()
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
        lblTitle.Text = "Encapsulation: Swamp Bank Account"
        lblTitle.ForeColor = Color.FromArgb(30, 45, 15)
        ' 
        ' lblDescription
        ' 
        lblDescription.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblDescription.Font = New Font("Segoe UI", 10.5F)
        lblDescription.Location = New Point(20, 62)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(760, 70)
        lblDescription.TabIndex = 1
        lblDescription.Text = "Encapsulation bundles data and the methods that work on it into one class. Like an onion, an object has layers: the BankAccount class keeps its balance Private, so this form can only change it through the Deposit and Withdraw methods, and can only read it through GetBalance. Try typing account.balance in the code - it will not compile."
        lblDescription.ForeColor = Color.FromArgb(92, 64, 51)
        ' 
        ' lblAmount
        ' 
        lblAmount.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        lblAmount.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblAmount.Location = New Point(20, 160)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(80, 25)
        lblAmount.TabIndex = 2
        lblAmount.Text = "Amount:"
        lblAmount.ForeColor = Color.FromArgb(30, 45, 15)
        lblAmount.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtAmount
        ' 
        txtAmount.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        txtAmount.Font = New Font("Segoe UI", 12F)
        txtAmount.Location = New Point(110, 157)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(220, 29)
        txtAmount.TabIndex = 3
        txtAmount.Text = ""
        txtAmount.BackColor = Color.FromArgb(252, 250, 232)
        txtAmount.ForeColor = Color.FromArgb(92, 64, 51)
        ' 
        ' btnDeposit
        ' 
        btnDeposit.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        btnDeposit.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        btnDeposit.Location = New Point(20, 215)
        btnDeposit.Name = "btnDeposit"
        btnDeposit.Size = New Size(150, 45)
        btnDeposit.TabIndex = 4
        btnDeposit.Text = "Deposit"
        btnDeposit.BackColor = Color.FromArgb(134, 168, 60)
        btnDeposit.ForeColor = Color.FromArgb(30, 45, 15)
        btnDeposit.FlatAppearance.BorderColor = Color.FromArgb(92, 64, 51)
        btnDeposit.FlatStyle = FlatStyle.Flat
        btnDeposit.UseVisualStyleBackColor = False
        ' 
        ' btnWithdraw
        ' 
        btnWithdraw.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        btnWithdraw.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        btnWithdraw.Location = New Point(180, 215)
        btnWithdraw.Name = "btnWithdraw"
        btnWithdraw.Size = New Size(150, 45)
        btnWithdraw.TabIndex = 5
        btnWithdraw.Text = "Withdraw"
        btnWithdraw.BackColor = Color.FromArgb(134, 168, 60)
        btnWithdraw.ForeColor = Color.FromArgb(30, 45, 15)
        btnWithdraw.FlatAppearance.BorderColor = Color.FromArgb(92, 64, 51)
        btnWithdraw.FlatStyle = FlatStyle.Flat
        btnWithdraw.UseVisualStyleBackColor = False
        ' 
        ' btnBalance
        ' 
        btnBalance.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        btnBalance.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        btnBalance.Location = New Point(340, 215)
        btnBalance.Name = "btnBalance"
        btnBalance.Size = New Size(170, 45)
        btnBalance.TabIndex = 6
        btnBalance.Text = "Balance Inquiry"
        btnBalance.BackColor = Color.FromArgb(134, 168, 60)
        btnBalance.ForeColor = Color.FromArgb(30, 45, 15)
        btnBalance.FlatAppearance.BorderColor = Color.FromArgb(92, 64, 51)
        btnBalance.FlatStyle = FlatStyle.Flat
        btnBalance.UseVisualStyleBackColor = False
        ' 
        ' lblHistory
        ' 
        lblHistory.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblHistory.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        lblHistory.Location = New Point(540, 135)
        lblHistory.Name = "lblHistory"
        lblHistory.Size = New Size(240, 23)
        lblHistory.TabIndex = 7
        lblHistory.Text = "Transaction History"
        lblHistory.ForeColor = Color.FromArgb(30, 45, 15)
        ' 
        ' lstHistory
        ' 
        lstHistory.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        lstHistory.Font = New Font("Segoe UI", 10.5F)
        lstHistory.Location = New Point(540, 161)
        lstHistory.Name = "lstHistory"
        lstHistory.Size = New Size(240, 215)
        lstHistory.TabIndex = 8
        lstHistory.BackColor = Color.FromArgb(252, 250, 232)
        lstHistory.ForeColor = Color.FromArgb(92, 64, 51)
        lstHistory.FormattingEnabled = True
        lstHistory.ItemHeight = 20
        ' 
        ' btnBack
        ' 
        btnBack.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnBack.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        btnBack.Location = New Point(680, 395)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(100, 35)
        btnBack.TabIndex = 9
        btnBack.Text = "Back"
        btnBack.BackColor = Color.FromArgb(134, 168, 60)
        btnBack.ForeColor = Color.FromArgb(30, 45, 15)
        btnBack.FlatAppearance.BorderColor = Color.FromArgb(92, 64, 51)
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' frmEncapsulation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(240, 244, 214)
        ClientSize = New Size(800, 450)
        Controls.Add(btnBack)
        Controls.Add(lstHistory)
        Controls.Add(lblHistory)
        Controls.Add(btnBalance)
        Controls.Add(btnWithdraw)
        Controls.Add(btnDeposit)
        Controls.Add(txtAmount)
        Controls.Add(lblAmount)
        Controls.Add(lblDescription)
        Controls.Add(lblTitle)
        Name = "frmEncapsulation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Encapsulation - Swamp Bank"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents btnBalance As Button
    Friend WithEvents lblHistory As Label
    Friend WithEvents lstHistory As ListBox
    Friend WithEvents btnBack As Button

End Class
