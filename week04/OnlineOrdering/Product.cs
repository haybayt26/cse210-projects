


public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public Product()
    {
        
    }


    public double GetCost()
    ///Multiply price per unit and quantity
    {
        return _price * _quantity;
    }

    public string GetProductPackInfo()
    {
        return $"\n{_productId}: {_name}\n\t{_quantity} x ${_price} = {GetCost()}";
    }

    
}