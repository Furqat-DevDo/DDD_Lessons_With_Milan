namespace Anemic_DomainModel.Application.Anemic.Orders;

public interface IUnitOfWork
{
    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}