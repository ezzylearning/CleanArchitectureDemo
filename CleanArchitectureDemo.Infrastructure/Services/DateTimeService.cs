using CleanArchitectureDemo.Application.Interfaces;

namespace CleanArchitectureDemo.Infrastructure.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}