using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Categories.Extensions {
    /// <inheritdoc/>
    public static class CategoryExtensions {
        /// <summary>
        /// Adds category services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddCategories(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
