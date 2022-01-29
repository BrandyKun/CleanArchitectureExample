using BaseArchitecture.Domain.Common;

namespace BaseArchitecture.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
