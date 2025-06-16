    using Inventory.Application.Services;

namespace Inventory.Infrastructure.Services
{
    public static class NServiceBusEventPublisherAccessor
    {
        public static ISenderService? Instance { get; set; }
    }
}
