

Public Class Form2

    Private totalAmount As Decimal = 0
    Private Sub Order1_Click(sender As Object, e As EventArgs) Handles Order1.Click, PictureBox1.Click
        AddToOrder("2-pc. Ngicken joy - P169")
    End Sub

    Private Sub Order2_Click(sender As Object, e As EventArgs) Handles Order2.Click, PictureBox2.Click
        AddToOrder("1-pc. Ngicken joy W/ Jolly Nyongetti- P135")
    End Sub

    Private Sub Order3_Click(sender As Object, e As EventArgs) Handles Order3.Click, PictureBox3.Click
        AddToOrder("1-pc. Ngicken joy - P85")
    End Sub

    Private Sub Order4_Click(sender As Object, e As EventArgs) Handles Order4.Click, PictureBox5.Click
        AddToOrder("Royal- P85")
    End Sub

    Private Sub Order5_Click(sender As Object, e As EventArgs) Handles Order5.Click, PictureBox6.Click
        AddToOrder("Sprite- P85")
    End Sub


    Private Sub Order6_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click, Order6.Click
        AddToOrder("NYALIBEE FLOAT- P85")
    End Sub



    Private Sub AddToOrder(itemText As String)

        Dim lbl As New Label()
        lbl.Text = itemText
        lbl.AutoSize = True
        lbl.Font = New Font("Arial", 10, FontStyle.Bold)
        lbl.Margin = New Padding(0, 5, 0, 5)


        panelCO.Controls.Add(lbl)


        UpdateTotal()
    End Sub

    Private Sub UpdateTotal()

        totalAmount = 0


        For Each ctrl As Control In panelCO.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl As Label = DirectCast(ctrl, Label)

                Dim priceText As String = lbl.Text.Split("P"c).Last()
                Dim price As Decimal
                If Decimal.TryParse(priceText, price) Then
                    totalAmount += price
                End If
            End If
        Next


        lbltotal.Text = $"Total: P{totalAmount.ToString("0.00")}"
    End Sub

    Private Sub Clearallbtn_Click(sender As Object, e As EventArgs) Handles Clearallbtn.Click
        panelCO.Controls.Clear()
        lbltotal.Text = "Total: P0"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If panelCO.Controls.Count = 0 Then
            MessageBox.Show("Please add items first!")
            Return
        End If
        MessageBox.Show("Order placed!", "Success")


        Receipt.Font = New Font("Consolas", 10)
        Receipt.BorderStyle = BorderStyle.None
        Receipt.Items.Clear()

        Receipt.Items.Add("         🍗 NYALIBEE 🍗")
        Receipt.Items.Add("  SM CITY SUCAT | BRANCH #002")
        Receipt.Items.Add("     Tel: 1234-5678 | VAT REG TIN: 000-000-000")
        Receipt.Items.Add("Cashier: STAFF001         Terminal: #1")
        Receipt.Items.Add("Date: " & Date.Now.ToString("yyyy-MM-dd HH:mm:ss"))
        Receipt.Items.Add("".PadRight(40, "-"))


        For Each lbl As Label In panelCO.Controls
            Receipt.Items.Add(" " & lbl.Text)
        Next

        Receipt.Items.Add("".PadRight(40, "-"))
        Receipt.Items.Add(lbltotal.Text.PadLeft(30))
        Receipt.Items.Add("Payment Method: CASH")
        Receipt.Items.Add("Change: P0.00")
        Receipt.Items.Add("".PadRight(40, "-"))
        Receipt.Items.Add("     THANK YOU FOR ORDERING!")
        Receipt.Items.Add("       PLEASE COME AGAIN ❤")
        Receipt.Items.Add("".PadRight(40, "-"))
        Receipt.Items.Add("      THIS IS YOUR OFFICIAL RECEIPT")
        Receipt.Items.Add("")





        panelCO.Controls.Clear()
        lbltotal.Text = "Total: P0"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Delivery confirmed! Your order is on its way.", "Nyailibee",
                       MessageBoxButtons.OK, MessageBoxIcon.Information)
        Receipt.Items.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()

        LoginForm1.Show()


        MessageBox.Show("Thank you for ordering!")
    End Sub
End Class
