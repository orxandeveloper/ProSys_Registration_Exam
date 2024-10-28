using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ER.Application.Registration
{
    public static class ServicesRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            var assm = Assembly.GetExecutingAssembly();
            services.AddMediatR(assm);
            services.AddAutoMapper(assm);

            return services;
        }
    }
}
