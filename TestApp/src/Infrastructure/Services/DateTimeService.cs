using TestApp.Application.Common.Interfaces;

namespace TestApp.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
