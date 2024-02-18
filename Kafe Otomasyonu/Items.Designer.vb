<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Items
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Items))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CatTB = New System.Windows.Forms.TextBox()
        Me.ItemDGV = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ResetBTN = New System.Windows.Forms.Button()
        Me.DeleteBTN = New System.Windows.Forms.Button()
        Me.EditBTN = New System.Windows.Forms.Button()
        Me.AddBTN = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CatCB = New System.Windows.Forms.ComboBox()
        Me.ItnameTB = New System.Windows.Forms.TextBox()
        Me.QuantityTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ItPriceTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ExitButton2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.ItemDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.CatTB)
        Me.Panel1.Controls.Add(Me.ItemDGV)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Panel1.Location = New System.Drawing.Point(306, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1170, 818)
        Me.Panel1.TabIndex = 0
        '
        'CatTB
        '
        Me.CatTB.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CatTB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CatTB.Location = New System.Drawing.Point(255, 113)
        Me.CatTB.Multiline = True
        Me.CatTB.Name = "CatTB"
        Me.CatTB.Size = New System.Drawing.Size(188, 33)
        Me.CatTB.TabIndex = 19
        '
        'ItemDGV
        '
        Me.ItemDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ItemDGV.BackgroundColor = System.Drawing.Color.White
        Me.ItemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ItemDGV.DefaultCellStyle = DataGridViewCellStyle1
        Me.ItemDGV.Location = New System.Drawing.Point(65, 445)
        Me.ItemDGV.Name = "ItemDGV"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ItemDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ItemDGV.RowHeadersWidth = 30
        Me.ItemDGV.RowTemplate.Height = 25
        Me.ItemDGV.Size = New System.Drawing.Size(1049, 350)
        Me.ItemDGV.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Constantia", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label7.Location = New System.Drawing.Point(536, 378)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(213, 45)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Ürün Listesi"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(468, 111)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 36)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Kategoriyi Ekle"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Constantia", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(65, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 33)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Kategori  Adı"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ResetBTN)
        Me.Panel2.Controls.Add(Me.DeleteBTN)
        Me.Panel2.Controls.Add(Me.EditBTN)
        Me.Panel2.Controls.Add(Me.AddBTN)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.CatCB)
        Me.Panel2.Controls.Add(Me.ItnameTB)
        Me.Panel2.Controls.Add(Me.QuantityTB)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.ItPriceTB)
        Me.Panel2.Location = New System.Drawing.Point(65, 174)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1049, 189)
        Me.Panel2.TabIndex = 12
        '
        'ResetBTN
        '
        Me.ResetBTN.BackColor = System.Drawing.Color.DodgerBlue
        Me.ResetBTN.FlatAppearance.BorderSize = 0
        Me.ResetBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBTN.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ResetBTN.ForeColor = System.Drawing.Color.White
        Me.ResetBTN.Image = CType(resources.GetObject("ResetBTN.Image"), System.Drawing.Image)
        Me.ResetBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ResetBTN.Location = New System.Drawing.Point(774, 131)
        Me.ResetBTN.Name = "ResetBTN"
        Me.ResetBTN.Size = New System.Drawing.Size(170, 36)
        Me.ResetBTN.TabIndex = 19
        Me.ResetBTN.Text = "Sıfırla"
        Me.ResetBTN.UseVisualStyleBackColor = False
        '
        'DeleteBTN
        '
        Me.DeleteBTN.BackColor = System.Drawing.Color.DodgerBlue
        Me.DeleteBTN.FlatAppearance.BorderSize = 0
        Me.DeleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBTN.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DeleteBTN.ForeColor = System.Drawing.Color.White
        Me.DeleteBTN.Image = CType(resources.GetObject("DeleteBTN.Image"), System.Drawing.Image)
        Me.DeleteBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteBTN.Location = New System.Drawing.Point(543, 131)
        Me.DeleteBTN.Name = "DeleteBTN"
        Me.DeleteBTN.Size = New System.Drawing.Size(170, 36)
        Me.DeleteBTN.TabIndex = 18
        Me.DeleteBTN.Text = "Sil"
        Me.DeleteBTN.UseVisualStyleBackColor = False
        '
        'EditBTN
        '
        Me.EditBTN.BackColor = System.Drawing.Color.DodgerBlue
        Me.EditBTN.FlatAppearance.BorderSize = 0
        Me.EditBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditBTN.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EditBTN.ForeColor = System.Drawing.Color.White
        Me.EditBTN.Image = CType(resources.GetObject("EditBTN.Image"), System.Drawing.Image)
        Me.EditBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditBTN.Location = New System.Drawing.Point(341, 131)
        Me.EditBTN.Name = "EditBTN"
        Me.EditBTN.Size = New System.Drawing.Size(170, 36)
        Me.EditBTN.TabIndex = 17
        Me.EditBTN.Text = "Düzenle"
        Me.EditBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EditBTN.UseVisualStyleBackColor = False
        '
        'AddBTN
        '
        Me.AddBTN.BackColor = System.Drawing.Color.DodgerBlue
        Me.AddBTN.FlatAppearance.BorderSize = 0
        Me.AddBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBTN.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AddBTN.ForeColor = System.Drawing.Color.White
        Me.AddBTN.Image = CType(resources.GetObject("AddBTN.Image"), System.Drawing.Image)
        Me.AddBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddBTN.Location = New System.Drawing.Point(122, 131)
        Me.AddBTN.Name = "AddBTN"
        Me.AddBTN.Size = New System.Drawing.Size(170, 36)
        Me.AddBTN.TabIndex = 16
        Me.AddBTN.Text = "Ekle"
        Me.AddBTN.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(543, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 27)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Miktarı"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(811, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 27)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Kategori"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label5.Location = New System.Drawing.Point(77, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 27)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Ürün Adı"
        '
        'CatCB
        '
        Me.CatCB.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CatCB.FormattingEnabled = True
        Me.CatCB.Location = New System.Drawing.Point(744, 61)
        Me.CatCB.Name = "CatCB"
        Me.CatCB.Size = New System.Drawing.Size(239, 33)
        Me.CatCB.TabIndex = 10
        '
        'ItnameTB
        '
        Me.ItnameTB.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ItnameTB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ItnameTB.Location = New System.Drawing.Point(30, 61)
        Me.ItnameTB.Multiline = True
        Me.ItnameTB.Name = "ItnameTB"
        Me.ItnameTB.Size = New System.Drawing.Size(188, 33)
        Me.ItnameTB.TabIndex = 5
        '
        'QuantityTB
        '
        Me.QuantityTB.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.QuantityTB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.QuantityTB.Location = New System.Drawing.Point(487, 61)
        Me.QuantityTB.Multiline = True
        Me.QuantityTB.Name = "QuantityTB"
        Me.QuantityTB.Size = New System.Drawing.Size(202, 33)
        Me.QuantityTB.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(324, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 27)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fiyatı"
        '
        'ItPriceTB
        '
        Me.ItPriceTB.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ItPriceTB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ItPriceTB.Location = New System.Drawing.Point(261, 61)
        Me.ItPriceTB.Multiline = True
        Me.ItPriceTB.Name = "ItPriceTB"
        Me.ItPriceTB.Size = New System.Drawing.Size(186, 33)
        Me.ItPriceTB.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label4.Location = New System.Drawing.Point(397, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(358, 45)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Ürün Yönetim Ekranı"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1452, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'ExitButton2
        '
        Me.ExitButton2.BackColor = System.Drawing.Color.DodgerBlue
        Me.ExitButton2.FlatAppearance.BorderSize = 0
        Me.ExitButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton2.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton2.ForeColor = System.Drawing.Color.White
        Me.ExitButton2.Image = CType(resources.GetObject("ExitButton2.Image"), System.Drawing.Image)
        Me.ExitButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ExitButton2.Location = New System.Drawing.Point(60, 815)
        Me.ExitButton2.Name = "ExitButton2"
        Me.ExitButton2.Size = New System.Drawing.Size(202, 59)
        Me.ExitButton2.TabIndex = 36
        Me.ExitButton2.Text = "Çıkış Yap"
        Me.ExitButton2.UseVisualStyleBackColor = False
        '
        'Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(1512, 929)
        Me.Controls.Add(Me.ExitButton2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Items"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Items"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ItemDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CatCB As ComboBox
    Friend WithEvents ItnameTB As TextBox
    Friend WithEvents QuantityTB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ItPriceTB As TextBox
    Friend WithEvents ItemDGV As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents DeleteBTN As Button
    Friend WithEvents EditBTN As Button
    Friend WithEvents AddBTN As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CatTB As TextBox
    Friend WithEvents ResetBTN As Button
    Friend WithEvents ExitButton2 As Button
End Class
