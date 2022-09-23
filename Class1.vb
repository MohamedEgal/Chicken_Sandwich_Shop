Imports Microsoft.VisualBasic



'Class for the sandwiches
Public Class FoodItem
    Public Id As Integer
    Private _itemName As String
    Public calories As Integer
    Public price As Decimal
    Public Description As String
    Public CategoryId As Integer
    Public quantity As Integer


    Public Sub New(
                  ByVal itemid As Integer,
                  ByVal name As String,
                       ByVal colory As Integer,
                       ByVal priceperunit As Decimal,
                       ByVal desc As String,
                   ByVal category As Integer,
                  ByVal quant As Integer)
        itemName = name
        calories = colory
        price = priceperunit
        Description = desc
        CategoryId = category
        Id = itemid
        quantity = quant


    End Sub

    Public Property itemName() As String
        Get
            Return _itemName
        End Get
        Set(ByVal value As String)
            _itemName = value
        End Set
    End Property
    Public Sub New(ByVal itemName As String)

        Me._itemName = itemName
    End Sub
End Class



'Class for the categories of the products
Public Class Category

    Public _Description As String
    Public Id As Integer


    Public Property Description() As String
        Get
            Return _Description
        End Get
        Set(ByVal value As String)
            _Description = value
        End Set
    End Property
    Public Sub New(ByVal itemName As String)

        Me._Description = Description
    End Sub

    Public Sub New(
                  ByVal catid As Integer,
                   ByVal desc As String)

        Description = desc
        Id = catid




    End Sub


End Class



'Class for what the customer adds from the FoodItem class
Public Class Cart
    Public Id As Integer
    Public itemId As Integer
    Public _nameItem As String
    Public quantity As Integer
    Public price As Double




    Public Sub New(
                 ByVal cartId As Integer,
                 ByVal fooditemid As Integer,
                 ByVal name As String,
                 ByVal priceInput As Double,
                 ByVal quant As Integer)

        Id = cartId
        itemId = fooditemid
        _nameItem = name
        price = priceInput
        quantity = quant
    End Sub

    Public ReadOnly Property GetSubTotal() As Decimal
        Get
            Return quantity * price
        End Get
    End Property


    Public Sub New(ByVal qtn As Integer)

        Me.quantity = qtn
    End Sub

    Public Property cartName() As String
        Get
            Return _nameItem
        End Get
        Set(ByVal value As String)
            _nameItem = value
        End Set
    End Property
    Public Sub New(ByVal cartName As String)

        Me._nameItem = cartName
    End Sub

End Class