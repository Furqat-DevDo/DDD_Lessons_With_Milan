using StronglyTyped_Id.Customers;
using StronglyTyped_Id.Products;

namespace StronglyTyped_Id.Orders;

public class Order
{
    private readonly HashSet<LineItem> _items = new();
    private Order()
    {
        
    }
    public Guid Id { get; private set; }
    public Guid CustomerId { get; private set; }
    public List<LineItem> Items { get; private set; }

    public static Order Craete(Customer customer)
    {
        var order = new Order
        {
            Id = Guid.NewGuid(),
            CustomerId = customer.Id
        };
        
        return order;
    }
    
    public void Add(Product product)
    {
        var lineItem = new LineItem(Guid.NewGuid(), Id, product.Id, product.Price);
        _items.Add(lineItem);
    }
}