using Mapping.DDD.ToDb.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mapping.DDD.ToDb.Persistance.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id).HasConversion(
            productId => productId.Value,
            value => new ProductId(value));
        
        builder.Property(p => p.Sku).HasConversion(
            productId => productId.Value,
            value => Sku.Create(value)!);

        builder.OwnsOne(p => p.Price, priceBuilder =>
        {
            priceBuilder.Property(m => m.Currency).HasMaxLength(3);
        });
    }
}