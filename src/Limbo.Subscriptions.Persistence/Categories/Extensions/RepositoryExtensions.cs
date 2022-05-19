using Limbo.Subscriptions.Persistence.Categories.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.Categories.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class RepositoryExtensions {
        /// <summary>
        /// Adds repositories
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddRepositories(this IServiceCollection services) {
            services
                .AddScoped<ICategoryRepository, CategoryRepository>();

            return services;
        }
    }
}
