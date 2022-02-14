' Program: The Hoodie Shop
' Pharynn Lewis
' Dr.Bothur
' Cpt 185
' Feb. 13,2022
' Descripition: This application is to display how the user  
' enters a quantity of the product after the selction is made 
' to show the cost.


Public Class frmhoodie
    'cost of hoodies by quantity.
    Const _cdeccostofhoodies As Decimal = 19.95D
    Const _cdectxttaxes As Decimal = 0.0875D

    'total presented with decimal

    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        'These are the Variables to be declared 
        Dim txthoodienumber As Integer
        Dim intamountofhoodies As Integer
        Dim txttotalamount As Decimal
        Dim txtpayment As Integer

        'INPUT OF USER
        'This inuput displays the quantity and selection from the user 
        'and then it is applied to the amount to be purchased.
        intamountofhoodies = txthoodienumber


        'PROCESSING DATA
        txtpayment = intamountofhoodies + Convert.ToInt32(_cdectxttaxes)
        txttotalamount = intamountofhoodies * _cdeccostofhoodies


        'OUTPUT

        lbltotalamount.Text = txttotalamount.ToString("c")

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click

        txtpayment.Text = ""
        txtamountofhoodies.Clear()
        txtamountofhoodies.Focus()

    End Sub

    Private Sub btnexitwindow_Click(sender As Object, e As EventArgs) Handles btnexitwindow.Click

        Close()

    End Sub

    Private Sub frmhoodie_Load(sender As Object, e As EventArgs) Handles Me.Load

        txtpayment.Text = "19.95"
        txtamountofhoodies.Clear()
        txtamountofhoodies.Focus()


    End Sub

End Class

