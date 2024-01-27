using Anemic_DomainModel.Domain.Anemic.Orders;

namespace Anemic_DomainModel.Application.Anemic.Orders;

public interface IOrderRepository
{
    Task<Order> GetByIdAsync(Guid orderId, CancellationToken cancellationToken = default);

    void Add(Order order);
}