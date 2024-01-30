namespace Mapping.DDD.ToDb.Customers;

public interface ICustomerRepository
{
    Task<Customer?> GetByIdAsync(CustomerId id);
}