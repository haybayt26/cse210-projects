



public class Order
{
    private string _customer;
    private List<Product> _productList;
    private int _shippingCost;


    public double GetTotalCost()
    /// Sum of total cost of each product plus one time shipping cost
    {
        
    }

    public string GetPackingLabel()
    ///List name and product ID of each product in the order
    {
        
    }

    public string GetShippingLabel()
    /// List name and address of the customer
    {
        
    }
}