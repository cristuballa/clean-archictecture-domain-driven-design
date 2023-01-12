using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // services.AddScoped<IAuthenticationQueryService, AuthenticationQueryService>();
            // services.AddScoped<IAuthenticationCommandService, AuthenticationCommandService>();
            services.AddMediatR(typeof(DependencyInjection).Assembly);
            return services;
        }
    }
}