
Public Class Form1
    'Variables for the list of products, category and cart items.
    Dim ListCatgories As New List(Of Category)()
    Public ListOfCartItems As New List(Of Cart)()
    Dim ListOfFoodItems As New List(Of FoodItem)()






    'Preload of the category and products
    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadProducts()
        loadCategories()
    End Sub


    'Changes what products to display if the category index is changed.
    Public Sub lstbCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstbCategory.SelectedIndexChanged
        If lstbCategory.SelectedIndex <> -1 Then
            Dim LnewFilteredListFoodItems As New List(Of FoodItem)()
            Dim catogaryId = lstbCategory.SelectedItem.Id

            For Each item In ListOfFoodItems
                If item.CategoryId = catogaryId Then
                    LnewFilteredListFoodItems.Add(item)

                End If
            Next
            lstbProduct.DisplayMember = "itemName"
            lstbProduct.DataSource = LnewFilteredListFoodItems
        End If

    End Sub




    Private Sub lstbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstbProduct.SelectedIndexChanged
        If lstbProduct.SelectedIndex <> -1 Then
            Dim selectedItem = lstbProduct.SelectedItem
            update(selectedItem)
        End If

        showImages()

    End Sub







    'Exits the program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'Opens the 'Checkout' form
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Dim MyForm As New Form2
        MyForm.Show()
    End Sub




    'Adds product to the cart
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        addItems()
    End Sub


    'Removes item from cart
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        removeItems()
    End Sub






    '''''''''''''''REUSABLE CODE''''''''''''''


    'Updates the label when product has changed
    Private Sub update(ByRef item As FoodItem)
        If lstbProduct.SelectedIndex <> -1 Then
            lblPrice.Text = "Price: £" & item.price
            lblDescription.Text = "Description: " & item.Description
            lblCalories.Text = "Calories: " & item.calories
        End If
    End Sub


    'Add items to the Cart, increased quantity and calculates the subtotal
    Private Sub addItems()
        Dim selectedItem = lstbProduct.SelectedItem
        Dim quantity = selectedItem.quantity

        If lstbProduct.SelectedIndex <> -1 Then

            If ListOfCartItems.Count < 1 Then
                ListOfCartItems.Add(New Cart(1, selectedItem.Id, selectedItem.itemName, selectedItem.Price, 1))
            Else
                Dim cartfortheSelectedItem As Cart = ListOfCartItems.Find(Function(cart As Cart)
                                                                              Return cart.itemId = selectedItem.Id
                                                                          End Function)

                If cartfortheSelectedItem IsNot Nothing Then

                    cartfortheSelectedItem.quantity += 1
                    MessageBox.Show("You have increased the product: " & selectedItem.itemName & Environment.NewLine & "Quantity: " & cartfortheSelectedItem.quantity)
                Else
                    Dim lastCartAdded As Cart = ListOfCartItems.OrderByDescending(Function(m) m.Id).FirstOrDefault

                    Dim newId As Integer = lastCartAdded.Id + 1
                    ListOfCartItems.Add(New Cart(newId, selectedItem.Id, selectedItem.itemName, selectedItem.Price, 1))

                End If

            End If


            calculateCost()

            lstCart.DataSource = Nothing

            lstCart.DataSource = ListOfCartItems
            lstCart.DisplayMember = "cartName"

        End If
    End Sub



    'Removes item from the cart list and reduces quantity if neccesary.
    Private Sub removeItems()
        Dim selectedItem = lstbProduct.SelectedItem
        Dim cartfortheSelectedItem As Cart = ListOfCartItems.Find(Function(cart As Cart)
                                                                      Return cart.itemId = selectedItem.Id
                                                                  End Function)
        If lstCart.SelectedIndex <> -1 Then
            Dim cartitem = lstCart.SelectedItem

            If (cartitem.quantity > 1) Then
                cartitem.quantity -= 1
                MessageBox.Show("You have reduced the product: " & selectedItem.itemName & Environment.NewLine & "Quantity: " & cartfortheSelectedItem.quantity)
            Else
                ListOfCartItems.Remove(lstCart.SelectedItem)
                lstCart.DataSource = Nothing

                lstCart.DataSource = ListOfCartItems
                lstCart.DisplayMember = "cartName"
            End If

        End If
    End Sub



    'Displays images related to the specific product id
    Private Sub showImages()
        Dim productID = lstbProduct.SelectedItem.Id
        If productID = 1 Then
            imgItem.BackgroundImage = Image.FromFile("C:\Users\sabir\Documents\Store\NEW Store App\bin\images\CrispyChicken.jpg")

        ElseIf productID = 2 Then
            imgItem.BackgroundImage = Image.FromFile("C:\Users\sabir\Documents\Store\NEW Store App\bin\images\ChickenCaeser.jpg")

        ElseIf productID = 3 Then
            imgItem.BackgroundImage = Image.FromFile("C:\Users\sabir\Documents\Store\NEW Store App\bin\images\chickenBBQ.jpg")

        ElseIf productID = 4 Then
            imgItem.BackgroundImage = Image.FromFile("C:\Users\sabir\Documents\Store\NEW Store App\bin\images\Waldorf.jpg")

        ElseIf productID = 5 Then
            imgItem.BackgroundImage = Image.FromFile("C:\Users\sabir\Documents\Store\NEW Store App\bin\images\CreamySandwich.jpg")

        Else
            imgItem.BackgroundImage = Nothing


        End If
    End Sub



    'Loads up the products that will be used
    Private Sub loadProducts()


        ListOfFoodItems.Add(New FoodItem(1, "Crispy Chicken Sandwich", 515, 3.39, "Crispy Chicken Sandwich with mayonaise as a base spread, with tomato, iceberg salad and fried crispy chicken as a protein", 1, 0))
        ListOfFoodItems.Add(New FoodItem(2, "Chicken Caesar Sandwiches", 428, 4.12, "The original Waldorf salad was invented at the Waldorf-Astoria Hotel as a simple combination of chopped apples, celery, and a mayonnaise dressing.", 1, 0))
        ListOfFoodItems.Add(New FoodItem(3, "BBQ Chicken Sandwich", 532, 4.99, "Cooked chicken with barbecue sauce and crunchy carrots for a quick and healthy lunch.", 3, 0))
        ListOfFoodItems.Add(New FoodItem(4, "Chicken Waldorf Sandwich", 659, 3.99, "Waldorf salad typically contains chopped apples, celery, and walnuts in a mayonnaise dressing and is served as a side dish. This sandwich takes the salad and puts it between two pieces of raisin bread to make a wonderful and different sandwich.", 1, 0))
        ListOfFoodItems.Add(New FoodItem(5, "Creamy Vegetable Sandwich", 266, 2.99, "Vegetable Sandwich is the perfect choice for people who has dietary needs, or just wanting a creamy sandwich to try out! it is made of peas, tomato, red onion and sweet corn.", 2, 0))


    End Sub


    'Loads up the categories for the sandwiches
    Private Sub loadCategories()
        ListCatgories.Add(New Category(1, "Chicken"))
        ListCatgories.Add(New Category(2, "Vegetarian"))
        ListCatgories.Add(New Category(3, "BBQ"))

        lstbCategory.DisplayMember = "Description"
        lstbCategory.DataSource = ListCatgories
    End Sub



    'Calculates the final cost
    Private Sub calculateCost()
        Dim TotalItemsInCart = ListOfCartItems.Sum(Function(gp) gp.GetSubTotal)
    End Sub
End Class
