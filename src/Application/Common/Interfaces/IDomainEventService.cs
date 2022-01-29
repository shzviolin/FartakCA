using FartakCA.Domain.Common;

namespace FartakCA.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
