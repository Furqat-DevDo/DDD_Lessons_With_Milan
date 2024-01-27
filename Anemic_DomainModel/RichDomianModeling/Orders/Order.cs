﻿using Anemic_DomainModel.RichDomianModeling.Customers;
using Anemic_DomainModel.RichDomianModeling.Products;

namespace Anemic_DomainModel.RichDomianModeling.Orders;

public class Order
{
    private readonly HashSet<LineItem> _items = new();
    private Order()
    {
        
    }
    public OrderId Id { get; private set; }
    public CustomerId CustomerId { get; private set; }
    public List<LineItem> Items { get; private set; }

    public static Order Craete(Customer customer)
    {
        var order = new Order
        {
            Id = new OrderId(Guid.NewGuid()),
            CustomerId = customer.Id
        };
        
        return order;
    }
    
    public void Add(Product product)
    {
        var lineItem = new LineItem(new LineItemId(Guid.NewGuid()),Id, product.Id, product.Price);
        _items.Add(lineItem);
    }
}