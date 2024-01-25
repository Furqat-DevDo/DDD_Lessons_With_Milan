namespace StronglyTyped_Id.Customers;

public interface ICustomerRepository
{
    Task<Customer?> GetByIdAsync(CustomerId id);
}