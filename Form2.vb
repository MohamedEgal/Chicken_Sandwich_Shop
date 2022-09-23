Imports System.Reflection

Public Class Form2


    'Variables
    Dim ListOfFoodItems As New List(Of FoodItem)()
    Dim TotalItemsInCart = Form1.ListOfCartItems.Sum(Function(gp) gp.GetSubTotal)

    'Closes the form 
    Private Sub lblCancel_Click(sender As Object, e As EventArgs) Handles lblCancel.Click
        Me.Close()
    End Sub


    'Comfirms order for customer and gives them a summary, plus a receipt
    Private Sub lblPay_Click(sender As Object, e As EventArgs) Handles lblPay.Click
        createReceipt()
        receiptMessage()
        Me.Close()
    End Sub



    'Loads up the total cost and items in the cart
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer



        Dim dataTableOfCarts = ConvertToDataTable(Form1.ListOfCartItems)

        lblTotal.Text = "£" & TotalItemsInCart

        ListView1.View = View.Details
        ListView1.GridLines = False
        ListView1.Columns.Clear()
        ListView1.Items.Clear()
        For Each col As DataColumn In dataTableOfCarts.Columns
            ListView1.Columns.Add(col.ToString)
        Next
        For Each row As DataRow In dataTableOfCarts.Rows
            Dim lst As ListViewItem
            lst = ListView1.Items.Add(If(row(0) IsNot Nothing, row(0).ToString, ""))
            For a As Integer = 1 To dataTableOfCarts.Columns.Count - 1
                lst.SubItems.Add(If(row(i) IsNot Nothing, row(a).ToString, ""))
            Next
        Next


        ListView1.Columns.RemoveAt(0)
        ListView1.Columns.RemoveAt(0)
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        ListView1.Columns(0).Text = "Product Name"
        ListView1.Columns(1).Text = "Quantity"
        ListView1.Columns(2).Text = "Price (£)"


    End Sub


    'Converts the cart items into a datatable which will be shown to the customer on what product, quantity and price each item is.
    Public Function ConvertToDataTable(Of T)(ByVal list As IList(Of T)) As DataTable
        Dim table As New DataTable()
        Dim fields() As FieldInfo = GetType(T).GetFields()
        For Each field As FieldInfo In fields
            table.Columns.Add(field.Name, field.FieldType)
        Next
        For Each item As T In list
            Dim row As DataRow = table.NewRow()
            For Each field As FieldInfo In fields
                row(field.Name) = field.GetValue(item)
            Next
            table.Rows.Add(row)
        Next
        Return table
    End Function








    '''''''''''REUSABLE CODE'''''''''' 
    '''



    'Creates the receipt for the customer
    Private Sub createReceipt()
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("myFile.txt", True)
        file.WriteLine("MIA'S SANDWICH SHOP" & Environment.NewLine & "Date of purchase: " &
                       Date.Now.ToString("yyyy/MM/dd") & Environment.NewLine &
                       "Time of purchase: " & DateTime.Now.ToString("HH:mm:ss") &
                       Environment.NewLine &
                       Environment.NewLine &
                       "Total payment was: £" &
                      TotalItemsInCart &
                       Environment.NewLine & Environment.NewLine &
                       "Thank you for shopping with us! Hope to see you soon again!")

        file.Close()
    End Sub



    'Gives a summary for the customer on their order
    Private Sub receiptMessage()
        MessageBox.Show("Your purchase went through! Thank you for ordering with us!" & Environment.NewLine & Environment.NewLine & "MIA'S SANDWICH SHOP" & Environment.NewLine & "Date of purchase: " &
                      Date.Now.ToString("yyyy/MM/dd") & Environment.NewLine &
                      "Time of purchase: " & DateTime.Now.ToString("HH:mm:ss") &
                      Environment.NewLine &
                      Environment.NewLine &
                      "Total payment was: £" &
                      TotalItemsInCart &
                      Environment.NewLine &
                      "Thank you for shopping with us! Hope to see you soon again!", "Order confirmed!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


End Class