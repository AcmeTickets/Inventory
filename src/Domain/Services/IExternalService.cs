namespace Inventory.Domain.Services;

public interface IExternalService
{
    Task NotifyEventStatusAsync(Guid eventId, string status, CancellationToken cancellationToken);
}
