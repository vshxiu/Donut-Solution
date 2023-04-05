'Name:         Donut Project
'Purpose:      Calculate subtotal, total and tax amount for coffee and donut varieties
'Programmer:   Sophia on 04.05.23

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmMain
    Private dblDonut As Double
    Private dblCoffee As Double
    Private dblSub As Double

    Private Sub Subtotal(ByVal dblDonutPrice As Double, ByVal dblCoffeePrice As Double)
        dblSub = dblDonut + dblCoffee
    End Sub

    Private Function SalesTax(ByVal dblSubtotal As Double) As Double
        Dim dblTax As Double
        dblTax = dblSubtotal * 0.06

        Return dblTax
    End Function

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dbltax As Double

        Select Case True
            Case radChoco.Checked
                dblDonut = 1.25
            Case radSugar.Checked
                dblDonut = 1.05
            Case radGlazed.Checked
                dblDonut = 1.05
            Case radFilled.Checked
                dblDonut = 1.5

        End Select

        Select Case True
            Case radNone.Checked
                dblCoffee = 0
            Case radRegular.Checked
                dblCoffee = 1.5
            Case radCappuccino.Checked
                dblCoffee = 2.75
        End Select

        Subtotal(dblDonut, dblCoffee)
        lblSub.Text = dblSub.ToString("C2")

        dbltax = SalesTax(dblSub)
        lblTax.Text = dbltax.ToString("C2")

        lblTotal.Text = (dbltax + dblSub).ToString("C2")


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub radFilled_CheckedChanged(sender As Object, e As EventArgs) Handles radFilled.CheckedChanged, radCappuccino.CheckedChanged, radChoco.CheckedChanged, radGlazed.CheckedChanged, radNone.CheckedChanged, radRegular.CheckedChanged, radSugar.CheckedChanged

        lblTax.Text = ""
        lblTotal.Text = ""
        lblSub.Text = ""
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Do you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If dlgButton = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
