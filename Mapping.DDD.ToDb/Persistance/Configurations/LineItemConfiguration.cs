using Mapping.DDD.ToDb.Orders;
using Mapping.DDD.ToDb.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mapping.DDD.ToDb.Persistance.Configurations;

public class LineItemConfiguration : IEntityTypeConfiguration<LineItem>
{
    public void Configure(EntityTypeBuilder<LineItem> builder)
    {
        builder.HasKey(li => li.Id);

        builder.Property(li => li.Id).HasConversion(
                itemId => itemId.Value,
                value => new LineItemId(value));
        
        builder.HasOne<Product>()
            .WithMany()
            .HasForeignKey(li => li.ProductId);
        
        builder.HasOne<Order>()
            .WithMany()
            .HasForeignKey(li => li.OrderId);

        builder.OwnsOne(li => li.Price);
    }
}