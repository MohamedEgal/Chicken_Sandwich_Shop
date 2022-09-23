<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstbCategory = New System.Windows.Forms.ListBox()
        Me.lstbProduct = New System.Windows.Forms.ListBox()
        Me.imgItem = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstCart = New System.Windows.Forms.ListBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblCalories = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblPriceTotal = New System.Windows.Forms.Label()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.lblShoppingCart = New System.Windows.Forms.Label()
        CType(Me.imgItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(2, 63)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(72, 20)
        Me.lblCategory.TabIndex = 0
        Me.lblCategory.Text = "Category:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product:"
        '
        'lstbCategory
        '
        Me.lstbCategory.FormattingEnabled = True
        Me.lstbCategory.ItemHeight = 20
        Me.lstbCategory.Location = New System.Drawing.Point(71, 63)
        Me.lstbCategory.Name = "lstbCategory"
        Me.lstbCategory.Size = New System.Drawing.Size(191, 84)
        Me.lstbCategory.TabIndex = 2
        '
        'lstbProduct
        '
        Me.lstbProduct.FormattingEnabled = True
        Me.lstbProduct.ItemHeight = 20
        Me.lstbProduct.Location = New System.Drawing.Point(71, 285)
        Me.lstbProduct.Name = "lstbProduct"
        Me.lstbProduct.Size = New System.Drawing.Size(191, 304)
        Me.lstbProduct.TabIndex = 3
        '
        'imgItem
        '
        Me.imgItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgItem.Location = New System.Drawing.Point(345, 82)
        Me.imgItem.Name = "imgItem"
        Me.imgItem.Size = New System.Drawing.Size(334, 263)
        Me.imgItem.TabIndex = 4
        Me.imgItem.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(71, 669)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(94, 29)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(230, 669)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(94, 29)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(611, 669)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(94, 29)
        Me.btnOrder.TabIndex = 7
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(950, 669)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 29)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstCart
        '
        Me.lstCart.FormattingEnabled = True
        Me.lstCart.ItemHeight = 20
        Me.lstCart.Location = New System.Drawing.Point(761, 176)
        Me.lstCart.Name = "lstCart"
        Me.lstCart.Size = New System.Drawing.Size(283, 244)
        Me.lstCart.TabIndex = 9
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(291, 365)
        Me.lblDescription.MaximumSize = New System.Drawing.Size(300, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(88, 20)
        Me.lblDescription.TabIndex = 10
        Me.lblDescription.Text = "Description:"
        '
        'lblCalories
        '
        Me.lblCalories.AutoSize = True
        Me.lblCalories.Location = New System.Drawing.Point(291, 476)
        Me.lblCalories.Name = "lblCalories"
        Me.lblCalories.Size = New System.Drawing.Size(65, 20)
        Me.lblCalories.TabIndex = 11
        Me.lblCalories.Text = "Calories:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(291, 545)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(44, 20)
        Me.lblPrice.TabIndex = 12
        Me.lblPrice.Text = "Price:"
        '
        'lblPriceTotal
        '
        Me.lblPriceTotal.AutoSize = True
        Me.lblPriceTotal.Location = New System.Drawing.Point(341, 545)
        Me.lblPriceTotal.Name = "lblPriceTotal"
        Me.lblPriceTotal.Size = New System.Drawing.Size(0, 20)
        Me.lblPriceTotal.TabIndex = 13
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.BackColor = System.Drawing.Color.MintCream
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe Script", 16.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblFormTitle.Location = New System.Drawing.Point(345, 9)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(334, 44)
        Me.lblFormTitle.TabIndex = 14
        Me.lblFormTitle.Text = "Mia's Sandwich Shop"
        '
        'lblShoppingCart
        '
        Me.lblShoppingCart.AutoSize = True
        Me.lblShoppingCart.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblShoppingCart.Location = New System.Drawing.Point(819, 125)
        Me.lblShoppingCart.Name = "lblShoppingCart"
        Me.lblShoppingCart.Size = New System.Drawing.Size(161, 31)
        Me.lblShoppingCart.TabIndex = 15
        Me.lblShoppingCart.Text = "Shopping Cart"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(1068, 746)
        Me.Controls.Add(Me.lblShoppingCart)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Controls.Add(Me.lblPriceTotal)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblCalories)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lstCart)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.imgItem)
        Me.Controls.Add(Me.lstbProduct)
        Me.Controls.Add(Me.lstbCategory)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCategory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.imgItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCategory As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lstbCategory As ListBox
    Friend WithEvents lstbProduct As ListBox
    Friend WithEvents imgItem As PictureBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblCalories As Label
    Friend WithEvents lblPrice As Label
    Public WithEvents lstCart As ListBox
    Friend WithEvents lblPriceTotal As Label
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents lblShoppingCart As Label
End Class
