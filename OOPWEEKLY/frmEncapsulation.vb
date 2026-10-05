Public Class frmEncapsulation

    ' The BankAccount object. Its balance is Private,
    ' so this form can only use its Public methods.
    Private account As New BankAccount()

    Private Function GetAmount() As Decimal

        Dim amount As Decimal

        If Decimal.TryParse(txtAmount.Text, amount) AndAlso amount > 0 Then
            Return amount
        End If

        MessageBox.Show("Please enter an amount greater than zero.", "Swamp Bank")
        txtAmount.Focus()
        Return 0

    End Function

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click

        Dim amount As Decimal = GetAmount()

        If amount > 0 Then
            account.Deposit(amount)
            lstHistory.Items.Add("Deposit: " & amount.ToString("C2"))
            txtAmount.Clear()
            txtAmount.Focus()
        End If

    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click

        Dim amount As Decimal = GetAmount()

        If amount > 0 Then
            If account.Withdraw(amount) Then
                lstHistory.Items.Add("Withdraw: " & amount.ToString("C2"))
                txtAmount.Clear()
                txtAmount.Focus()
            Else
                MessageBox.Show("Insufficient balance.", "Swamp Bank")
            End If
        End If

    End Sub

    Private Sub btnBalance_Click(sender As Object, e As EventArgs) Handles btnBalance.Click

        Dim balance As Decimal = account.GetBalance()

        MessageBox.Show("Your current balance is " & balance.ToString("C2"), "Swamp Bank")
        lstHistory.Items.Add("Balance Inquiry: " & balance.ToString("C2"))

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

End Class