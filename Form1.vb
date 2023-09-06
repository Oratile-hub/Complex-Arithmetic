Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim Price As Decimal
        Dim Quantity As Decimal
        Dim Discount As Decimal
        Dim Totalcost As Decimal
        Dim VAT As Decimal
        Dim TotalcosVat As Decimal
        Dim TotalIncVAT As Decimal

        Price = 10
        Quantity = 10
        Discount = 2
        VAT = 0.15

        'The Total cost with discount is calculated as follows:
        Totalcost = Quantity * (Price - Discount)



        MsgBox("The total cost is " & Totalcost)

        TotalcosVat = VAT * Totalcost

        MsgBox(" Cost with VAT is " & TotalcosVat)

        TotalIncVAT = TotalcosVat + Totalcost

        MsgBox("Total cost including VAT is " & TotalIncVAT
               )



    End Sub
End Class
