using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.Categories.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class CategoryExtensions {
        /// <summary>
        /// Adds categories
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddCategories(this IServiceCollection services) {
            services
                .AddRepositories();

            return services;
        }
    }
}
