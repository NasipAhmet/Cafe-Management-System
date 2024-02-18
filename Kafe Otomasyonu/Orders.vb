Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Orders
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nasip\Documents\CafeVBDT.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DisplayItem()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub DisplayItem()
        Con.Open()
        Dim query = "Select * from ItematTBL "
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.close()
    End Sub
    Private Sub FilterbyCategory()
        Con.Open()
        Dim query = "Select * from ItematTBL where Itemcat='" & CatCB.SelectedValue.ToString() & "' "
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.close()
    End Sub
    Private Sub fillCategory()
        Con.open()
        Dim cmd = New SqlCommand("select*from CategoryDT", Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim tbl = New DataTable()
        adapter.Fill(tbl)
        CatCB.DataSource = tbl
        CatCB.DisplayMember = "CatName"
        CatCB.ValueMember = "CatName"
        Con.close()

    End Sub
    Private Sub Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()
        fillCategory()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CatCB.SelectedIndexChanged

    End Sub

    Private Sub CatCB_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CatCB.SelectionChangeCommitted
        FilterbyCategory()
    End Sub
    Dim ProdName As String
    Dim i = 0, GrdTotal = 0, price, qty
    Private Sub Addbill()
        Con.Open()
        Dim Query = "insert into OrderTbl values('" & DateTime.Today.Date() & "'," & GrdTotal & ")"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(Query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Fiş oluşturuldu")
        Con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Addbill()
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Mavi Ay Kafe", New Font("Arial", 22), Brushes.BlueViolet, 335, 35)
        e.Graphics.DrawString("", New Font("Arial", 14), Brushes.BlueViolet, 335, 35)

        Dim bm As New Bitmap(Me.BillDGV.Width, Me.BillDGV.Height)
        BillDGV.DrawToBitmap(bm, New Rectangle(0, 0, Me.BillDGV.Width, Me.BillDGV.Height))
        e.Graphics.DrawImage(bm, 0, 90)
        e.Graphics.DrawString("Toplam Fiyat= " + GrdTotal.ToString() + " " + "TL", New Font("Arial", 15), Brushes.Crimson, 325, 580)
        e.Graphics.DrawString("*******************Afiyet olsun yine bekleriz***************", New Font("Arial", 15), Brushes.Crimson, 130, 600)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Obj = New ViewOrders
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub TotalLBL_Click(sender As Object, e As EventArgs) Handles TotalLBL.Click

    End Sub

    Private Sub UpdateItem()
        Try
            Dim newQty = stock - Convert.ToInt32(QuantityTB.Text)
            Con.Open()
            Dim Query = "Update ItematTBL set IntQty=" & newQty & "where ItemID=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Ürün hesaba eklendi")
            Con.Close()
            'Reset()
            DisplayItem()
        Catch ax As Exception
            MsgBox(ax.Message)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim obj = New Login
        obj.Show()
        Me.Hide()

    End Sub

    Private Sub AddtoBillBTN_Click(sender As Object, e As EventArgs) Handles AddtoBillBTN.Click
        If key = 0 Then
            MsgBox("Lütfen bir ürün seçimi yapın")
        ElseIf Convert.ToInt32(QuantityTB.Text) > stock Then
            MsgBox("Bu üründen Yeteri Kadar Bulunmamaktadır")
        Else
            Dim rnum As Integer = BillDGV.Rows.Add()
            Dim total = Convert.ToInt32(QuantityTB.Text) * price
            i = i + 1
            BillDGV.Rows.Item(rnum).Cells("Column1").Value = i
            BillDGV.Rows.Item(rnum).Cells("Column2").Value = ProdName
            BillDGV.Rows.Item(rnum).Cells("Column4").Value = QuantityTB.Text
            BillDGV.Rows.Item(rnum).Cells("Column3").Value = price
            BillDGV.Rows.Item(rnum).Cells("Column5").Value = total
            GrdTotal = GrdTotal + total
            TotalLBL.Text = Convert.ToString(GrdTotal) + " " + "TL"
            UpdateItem()
            QuantityTB.Text = ""
            key = 0
        End If
    End Sub

    Dim key = 0, stock
    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        ProdName = row.Cells(1).Value.ToString
        If ProdName = "" Then
            key = 0
            stock = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
            stock = Convert.ToInt32(row.Cells(4).Value.ToString)
            price = (row.Cells(3).Value.ToString)
        End If
    End Sub
End Class