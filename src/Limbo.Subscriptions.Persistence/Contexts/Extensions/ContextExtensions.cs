using System;
using Limbo.Subscriptions.Persistence.Contexts.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.Contexts.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class ContextExtensions {
        /// <summary>
        /// Adds contexts
        /// </summary>
        /// <param name="services"></param>
        /// <param name="contextOptions"></param>
        /// <returns></returns>
        public static IServiceCollection AddContexts(this IServiceCollection services, ContextOptions contextOptions) {
            services.AddPooledDbContextFactory<SubscriptionDbContext>(options =>
                options.UseSqlServer(contextOptions.Configuration.GetConnectionString(contextOptions.ConnectionStringKey)));

            services.AddScoped<ISubscriptionDbContext>(x => {
                var factory = x.GetRequiredService<IDbContextFactory<SubscriptionDbContext>>();
                return factory.CreateDbContext();
            });

            var context = services.BuildServiceProvider().GetRequiredService<ISubscriptionDbContext>();
            context.Context.Database.Migrate();

            return services;
        }
    }
}
