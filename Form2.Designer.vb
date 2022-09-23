<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblCheckout = New System.Windows.Forms.Label()
        Me.lblTotPay = New System.Windows.Forms.Label()
        Me.lblCardName = New System.Windows.Forms.Label()
        Me.lblCardNum = New System.Windows.Forms.Label()
        Me.lblCVC = New System.Windows.Forms.Label()
        Me.lblPay = New System.Windows.Forms.Button()
        Me.lblCancel = New System.Windows.Forms.Button()
        Me.txtCardName = New System.Windows.Forms.TextBox()
        Me.txtCardNum = New System.Windows.Forms.TextBox()
        Me.txtCVC = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.CartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        CType(Me.CartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCheckout
        '
        Me.lblCheckout.AutoSize = True
        Me.lblCheckout.Font = New System.Drawing.Font("Segoe UI", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCheckout.Location = New System.Drawing.Point(393, 9)
        Me.lblCheckout.Name = "lblCheckout"
        Me.lblCheckout.Size = New System.Drawing.Size(154, 45)
        Me.lblCheckout.TabIndex = 0
        Me.lblCheckout.Text = "Checkout"
        '
        'lblTotPay
        '
        Me.lblTotPay.AutoSize = True
        Me.lblTotPay.Location = New System.Drawing.Point(12, 75)
        Me.lblTotPay.Name = "lblTotPay"
        Me.lblTotPay.Size = New System.Drawing.Size(109, 20)
        Me.lblTotPay.TabIndex = 2
        Me.lblTotPay.Text = "Total Payment: "
        '
        'lblCardName
        '
        Me.lblCardName.AutoSize = True
        Me.lblCardName.Location = New System.Drawing.Point(12, 188)
        Me.lblCardName.Name = "lblCardName"
        Me.lblCardName.Size = New System.Drawing.Size(134, 20)
        Me.lblCardName.TabIndex = 3
        Me.lblCardName.Text = "Cardholder Name: "
        '
        'lblCardNum
        '
        Me.lblCardNum.AutoSize = True
        Me.lblCardNum.Location = New System.Drawing.Point(12, 248)
        Me.lblCardNum.Name = "lblCardNum"
        Me.lblCardNum.Size = New System.Drawing.Size(105, 20)
        Me.lblCardNum.TabIndex = 4
        Me.lblCardNum.Text = "Card Number: "
        '
        'lblCVC
        '
        Me.lblCVC.AutoSize = True
        Me.lblCVC.Location = New System.Drawing.Point(12, 298)
        Me.lblCVC.Name = "lblCVC"
        Me.lblCVC.Size = New System.Drawing.Size(43, 20)
        Me.lblCVC.TabIndex = 5
        Me.lblCVC.Text = "CVC: "
        '
        'lblPay
        '
        Me.lblPay.Location = New System.Drawing.Point(310, 462)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(94, 29)
        Me.lblPay.TabIndex = 6
        Me.lblPay.Text = "Pay"
        Me.lblPay.UseVisualStyleBackColor = True
        '
        'lblCancel
        '
        Me.lblCancel.Location = New System.Drawing.Point(559, 462)
        Me.lblCancel.Name = "lblCancel"
        Me.lblCancel.Size = New System.Drawing.Size(94, 29)
        Me.lblCancel.TabIndex = 7
        Me.lblCancel.Text = "Cancel"
        Me.lblCancel.UseVisualStyleBackColor = True
        '
        'txtCardName
        '
        Me.txtCardName.Location = New System.Drawing.Point(152, 188)
        Me.txtCardName.Name = "txtCardName"
        Me.txtCardName.Size = New System.Drawing.Size(222, 27)
        Me.txtCardName.TabIndex = 8
        '
        'txtCardNum
        '
        Me.txtCardNum.Location = New System.Drawing.Point(152, 241)
        Me.txtCardNum.Name = "txtCardNum"
        Me.txtCardNum.Size = New System.Drawing.Size(222, 27)
        Me.txtCardNum.TabIndex = 9
        '
        'txtCVC
        '
        Me.txtCVC.Location = New System.Drawing.Point(152, 291)
        Me.txtCVC.Name = "txtCVC"
        Me.txtCVC.Size = New System.Drawing.Size(222, 27)
        Me.txtCVC.TabIndex = 10
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(127, 75)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 20)
        Me.lblTotal.TabIndex = 11
        '
        'CartBindingSource
        '
        Me.CartBindingSource.DataSource = GetType(NEW_Store_App.Cart)
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(520, 75)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(409, 348)
        Me.ListView1.TabIndex = 12
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 512)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtCVC)
        Me.Controls.Add(Me.txtCardNum)
        Me.Controls.Add(Me.txtCardName)
        Me.Controls.Add(Me.lblCancel)
        Me.Controls.Add(Me.lblPay)
        Me.Controls.Add(Me.lblCVC)
        Me.Controls.Add(Me.lblCardNum)
        Me.Controls.Add(Me.lblCardName)
        Me.Controls.Add(Me.lblTotPay)
        Me.Controls.Add(Me.lblCheckout)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.CartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCheckout As Label
    Friend WithEvents lblTotPay As Label
    Friend WithEvents lblCardName As Label
    Friend WithEvents lblCardNum As Label
    Friend WithEvents lblCVC As Label
    Friend WithEvents lblPay As Button
    Friend WithEvents lblCancel As Button
    Friend WithEvents txtCardName As TextBox
    Friend WithEvents txtCardNum As TextBox
    Friend WithEvents txtCVC As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents CartBindingSource As BindingSource
    Friend WithEvents ListView1 As ListView
End Class
