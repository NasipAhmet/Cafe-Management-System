Imports System.Data.SqlClient
Public Class Items
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nasip\Documents\CafeVBDT.mdf;Integrated Security=True;Connect Timeout=30")



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CatTB.Text = "" Then
            MsgBox("Lütfen bir kategori girin")
        Else
            Con.Open()
            Dim Query = "insert into CategoryDT values('" & CatTB.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Kategori Eklendi")
            Con.Close()
            CatTB.Text = ""
            fillCategory()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()

    End Sub
    Private Sub Reset()
        ItnameTB.Text() = ""
        CatCB.SelectedIndex = 0
        QuantityTB.Text = ""
        ItPriceTB.Text = ""

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

    Private Sub ResetBTN_Click(sender As Object, e As EventArgs) Handles ResetBTN.Click
        Reset()
    End Sub

    Private Sub Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillCategory()
        DisplayItem()
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

    Private Sub AddBTN_Click(sender As Object, e As EventArgs) Handles AddBTN.Click
        If CatCB.SelectedIndex = -1 Or ItnameTB.Text = "" Or ItPriceTB.Text = "" Or QuantityTB.Text = "" Then
            MsgBox("Eksik bilgi girdiniz")
        Else
            Con.Open()
            Dim Query = "insert into ItematTBL values('" & ItnameTB.Text & "','" & CatCB.SelectedValue.ToString() & "'," & ItPriceTB.Text & "," & QuantityTB.Text & ")"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Ürün Eklendi")
            Con.Close()
            Reset()
            DisplayItem()
        End If
    End Sub
    Dim key = 0
    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        ItnameTB.Text = row.Cells(1).Value.ToString
        CatCB.SelectedValue = row.Cells(2).Value.ToString
        ItPriceTB.Text = row.Cells(3).Value.ToString
        QuantityTB.Text = row.Cells(4).Value.ToString
        If ItnameTB.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub DeleteBTN_Click(sender As Object, e As EventArgs) Handles DeleteBTN.Click
        If key = 0 Then
            MsgBox("Öncelikle silmek istediğiniz ürünü seçin ")
        Else
            Con.Open()
            Dim Query = "Delete from ItematTBL Where ItemID=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Ürün başarıyla silindi")
            Con.Close()
            Reset()
            DisplayItem()
        End If
    End Sub

    Private Sub EditBTN_Click(sender As Object, e As EventArgs) Handles EditBTN.Click
        If CatCB.SelectedIndex = -1 Or ItnameTB.Text = "" Or ItPriceTB.Text = "" Or QuantityTB.Text = "" Then
            MsgBox("Eksik bilgi girdiniz")
        Else
            Try
                Con.Open()
                Dim Query = "Update ItematTBL set ItemName='" & ItnameTB.Text & "', ItemCat='" & CatCB.SelectedValue.ToString() & "', ItemPrice=" & ItPriceTB.Text & ",IntQty=" & QuantityTB.Text & "where ItemID=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Ürün Düzenlendi")
                Con.Close()
                Reset()
                DisplayItem()
            Catch ax As Exception
                MsgBox(ax.Message)
            End Try
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton2.Click
        Dim obj = New Login
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub ItemDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemDGV.CellContentClick

    End Sub
End Class
