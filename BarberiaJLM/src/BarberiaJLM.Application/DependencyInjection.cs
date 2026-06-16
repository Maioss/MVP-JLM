using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace BarberiaJLM.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddValidatorsFromAssemblyContaining<Marker>();
            return services;
        }
    }
}
