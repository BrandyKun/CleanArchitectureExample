using BaseArchitecture.Application.Common.Interfaces;

namespace BaseArchitecture.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
