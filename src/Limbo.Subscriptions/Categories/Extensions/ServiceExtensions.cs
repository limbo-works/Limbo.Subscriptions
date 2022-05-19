using Limbo.Subscriptions.Categories.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Categories.Extensions {
    /// <inheritdoc/>
    public static class ServiceExtensions {
        /// <summary>
        /// Adds category services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddScoped<ICategoryService, CategoryService>();

            return services;
        }
    }
}
