using MechanicApp.Application.Common.Interfaces;

namespace MechanicApp.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
