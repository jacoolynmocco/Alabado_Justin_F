Public Class frmLevel1

    Private boatLeft As Boolean = True
    Private target As Integer
    Private Const Speed As Integer = 6   ' pixels per tick
    Private people() As Button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoubleBuffered = True
        people = {btnM1, btnM2, btnM3, btnC1, btnC2, btnC3}

        ' Optional: use your own sprites from the Sprites folder next to the exe
        Dim files = {"mario", "luigi", "peach", "goomba", "goomba", "goomba"}
        For i = 0 To 5
            Dim f = IO.Path.Combine(Application.StartupPath, "Sprites", files(i) & ".png")
            If IO.File.Exists(f) Then
                people(i).BackgroundImage = Image.FromFile(f)
                people(i).BackgroundImageLayout = ImageLayout.Zoom
                people(i).BackColor = Color.Transparent
                people(i).Text = ""
            End If
        Next
    End Sub

    ' Retro scenery: clouds, water and brick ground (drawn behind the controls)
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim g = e.Graphics
        Dim top = pnlLeft.Bottom

        For Each x In {120, 380, 640}
            g.FillEllipse(Brushes.White, x, 60, 90, 40)
            g.FillEllipse(Brushes.White, x + 20, 45, 50, 40)
        Next

        Using water As New SolidBrush(Color.FromArgb(0, 88, 248)),
              brick As New SolidBrush(Color.FromArgb(200, 76, 12))
            g.FillRectangle(water, pnlLeft.Right, top - 40, pnlRight.Left - pnlLeft.Right, ClientSize.Height - top + 40)
            g.FillRectangle(brick, 0, top, pnlLeft.Width, ClientSize.Height - top)
            g.FillRectangle(brick, pnlRight.Left, top, pnlRight.Width, ClientSize.Height - top)
        End Using

        For Each x In {0, pnlRight.Left}
            For y = top To ClientSize.Height Step 20
                g.DrawLine(Pens.Black, x, y, x + pnlLeft.Width, y)
                For bx = 0 To pnlLeft.Width Step 40
                    g.DrawLine(Pens.Black, x + bx + If((y - top) Mod 40 = 0, 0, 20), y, x + bx + If((y - top) Mod 40 = 0, 0, 20), y + 20)
                Next
            Next
        Next
    End Sub

    ' Click a character: bank -> boat, or boat -> bank (the one the boat is at)
    Private Sub Person_Click(sender As Object, e As EventArgs) Handles btnM1.Click, btnM2.Click, btnM3.Click, btnC1.Click, btnC2.Click, btnC3.Click
        If tmrBoat.Enabled Then Return
        Dim b = CType(sender, Button)
        Dim bank = If(boatLeft, pnlLeft, pnlRight)
        If b.Parent Is pnlBoat Then
            b.Parent = bank
        ElseIf b.Parent Is bank AndAlso pnlBoat.Controls.Count < 2 Then
            b.Parent = pnlBoat
        End If
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        If tmrBoat.Enabled OrElse pnlBoat.Controls.Count = 0 Then Return   ' someone has to row
        boatLeft = Not boatLeft
        target = If(boatLeft, pnlLeft.Right, pnlRight.Left - pnlBoat.Width)
        tmrBoat.Start()
    End Sub

    ' Animation: slide the boat a few pixels per tick
    Private Sub tmrBoat_Tick(sender As Object, e As EventArgs) Handles tmrBoat.Tick
        Dim d = target - pnlBoat.Left
        If Math.Abs(d) <= Speed Then
            pnlBoat.Left = target
            tmrBoat.Stop()
            Check()
        Else
            pnlBoat.Left += Math.Sign(d) * Speed
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        tmrBoat.Stop()
        For Each b In people
            b.Parent = pnlLeft
        Next
        boatLeft = True
        pnlBoat.Left = pnlLeft.Right
    End Sub

    ' Count M or C on a bank; boat passengers count for the bank the boat is at
    Private Function Cnt(bank As Panel, t As String, isLeft As Boolean) As Integer
        Dim n = bank.Controls.OfType(Of Button).Count(Function(b) b.Tag.ToString() = t)
        If boatLeft = isLeft Then n += pnlBoat.Controls.OfType(Of Button).Count(Function(b) b.Tag.ToString() = t)
        Return n
    End Function

    Private Sub Check()
        Dim ml = Cnt(pnlLeft, "M", True), cl = Cnt(pnlLeft, "C", True)
        Dim mr = Cnt(pnlRight, "M", False), cr = Cnt(pnlRight, "C", False)

        If (ml > 0 AndAlso cl > ml) OrElse (mr > 0 AndAlso cr > mr) Then
            MessageBox.Show("The Goombas got them!", "Game Over")
            btnReset.PerformClick()
        ElseIf mr = 3 AndAlso cr = 3 Then
            MessageBox.Show("Everyone made it across!", "Level Clear!")
            btnReset.PerformClick()
        End If
    End Sub

End Class
