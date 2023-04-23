using CleanArchitectureDemo.Application.Interfaces;
using CleanArchitectureDemo.Domain.Common;
using CleanArchitectureDemo.Domain.Common.Interfaces;
using CleanArchitectureDemo.Infrastructure.Services;

using MediatR;

using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureDemo.Infrastructure.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddInfrastructureLayer(this IServiceCollection services)
        {
            services.AddServices();
        }

        private static void AddServices(this IServiceCollection services)
        {
            services
                .AddTransient<IMediator, Mediator>()
                .AddTransient<IDomainEventDispatcher, DomainEventDispatcher>()
                .AddTransient<IDateTimeService, DateTimeService>()
                .AddTransient<IEmailService, EmailService>();
        }
    }
}
