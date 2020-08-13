Public Class bookMovie

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim clear As DialogResult

        clear = MessageBox.Show("Confirm if you want to clear order", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If clear = DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub btnAddCart_Click(sender As Object, e As EventArgs) Handles btnAddCart.Click
        If ListView1.Items.Count = 0 Then
            Dim item1 As ListViewItem

            item1 = ListView1.Items.Add(txtIdBooking.Text)
            item1.SubItems.Add(txtName.Text)
            item1.SubItems.Add(txtPhoneNumber.Text)
            item1.SubItems.Add(txtMovieName.Text)
            item1.SubItems.Add(txtQuantity.Text)
            item1.SubItems.Add(txtSeatNo.Text)
            item1.SubItems.Add(txtPromotionCode.Text)
            item1.SubItems.Add(DateTimePicker1.Checked)
            item1 = Nothing

        Else
            With ListView1
                Dim addItem As ListViewItem
                addItem = .FindItemWithText(txtIdBooking.Text, True, 0, True)
                If Not addItem Is Nothing Then
                    MessageBox.Show("Add" & txtIdBooking.Text & "already add book", "Add booking", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Else
                    Dim item1 As ListViewItem
                    item1 = ListView1.Items.Add(txtIdBooking.Text)
                    item1.SubItems.Add(txtName.Text)
                    item1.SubItems.Add(txtPhoneNumber.Text)
                    item1.SubItems.Add(txtMovieName.Text)
                    item1.SubItems.Add(txtQuantity.Text)
                    item1.SubItems.Add(txtSeatNo.Text)
                    item1.SubItems.Add(txtPromotionCode.Text)
                    item1.SubItems.Add(DateTimePicker1.Checked)
                    item1 = Nothing
                End If
            End With


        End If


        txtIdBooking.Text = ""
        txtName.Text = ""
        txtPhoneNumber.Text = ""
        txtMovieName.Text = ""
        txtQuantity.Text = ""
        txtSeatNo.Text = ""
        txtPromotionCode.Text = ""
        DateTimePicker1.Checked = ""

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim item1 As ListViewItem
        item1 = ListView1.SelectedItems(0)
        item1.Remove()
        Label3.Text = ""
    End Sub
End Class