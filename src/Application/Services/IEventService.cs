using Inventory.Application.Commands;
using Inventory.Application.DTOs;

namespace Inventory.Application.Services;

public interface IEventService
{
    Task<EventDto> AddEventAsync(AddEventCommand command, CancellationToken cancellationToken);
    Task ExpireEventAsync(ExpireEventCommand command, CancellationToken cancellationToken);
    Task CloseEventAsync(CloseEventCommand command, CancellationToken cancellationToken);
}
