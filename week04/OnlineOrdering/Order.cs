



public class Order
{
    private Customer _customer;
    private List<Product> _productList = new List<Product>();
    private int _shippingCost;

    public Order(Customer customer)
    {
        _customer = customer;

    }

    public Order()
    {
        
    }


    public double GetTotalCost()
    /// Sum of total cost of each product plus one time shipping cost
    /// If USA shipping cost is $5, Not it is $35
    {
        double totalCost = _shippingCost;
        foreach (Product product in _productList)
        {
            totalCost += product.GetCost();
        }
        return totalCost;
    }

    public string GetPackingLabel()
    ///List name and product ID of each product in the order
    {
        string packingLabel = "[Packing Label] \n";
        foreach (Product product in _productList)
        {
            packingLabel += product.GetProductPackInfo();
        }
        
        if (_customer.IsAddressUSA() == true)
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }
        packingLabel += $"\nShipping: ${_shippingCost}";
        packingLabel += $"\n\n\t\tTotal: ${GetTotalCost()}\n";

        return packingLabel;

    }

    public string GetShippingLabel()
    /// List name and address of the customer
    {
        return $"[Shipping Label] \n{_customer.GetShippingInfo()}\n";
    }

    public void AddProduct(Product product)
    {
        _productList.Add(product);
    }
}