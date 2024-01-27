namespace Anemic_DomainModel.RichDomianModeling.Customers;

public interface ICustomerRepository
{
    Task<Customer?> GetByIdAsync(CustomerId id);
}