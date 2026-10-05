Public Class BankAccount

    ' Private: the balance cannot be touched from outside this class
    Private balance As Decimal

    Public Sub Deposit(amount As Decimal)
        If amount > 0 Then
            balance += amount
        End If
    End Sub

    Public Function Withdraw(amount As Decimal) As Boolean
        If amount > 0 AndAlso amount <= balance Then
            balance -= amount
            Return True
        End If
        Return False
    End Function

    Public Function GetBalance() As Decimal
        Return balance
    End Function

End Class