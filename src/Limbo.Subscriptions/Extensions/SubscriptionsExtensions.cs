using Limbo.Subscriptions.Persistence.Extensions;
using Limbo.Subscriptions.Bases.Automapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Limbo.MailSystem.Extensions;
using Limbo.Subscriptions.Extensions.Options;

namespace Limbo.Subscriptions.Extensions {
    /// <inheritdoc/>
    public static class SubscriptionsExtensions {

        /// <summary>
        /// Adds subscription
        /// </summary>
        /// <param name="services"></param>
        /// <param name="subscriptionOptions"></param>
        /// <returns></returns>
        public static IServiceCollection AddSubscriptions(this IServiceCollection services, SubscriptionOptions subscriptionOptions) {
            services
                .AddPersistence(subscriptionOptions.SubscriptionPersistenceOptions)
                .AddSubscriptionServices()
                .AddSubscriptionsGraphQL(subscriptionOptions.GraphQLOptions)
                .AddMailSystem(subscriptionOptions.MailSystemOptions);

            return services;
        }

        /// <summary>
        /// Adds a graphql endpoint
        /// </summary>
        /// <param name="app"></param>
        /// <param name="subscriptionGraphQlEndpointOptions"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseSubscriptionsGraphQLEndpoint(this IApplicationBuilder app, SubscriptionGraphQlEndpointOptions subscriptionGraphQlEndpointOptions) {
            app.UseRouting();

            if (subscriptionGraphQlEndpointOptions.AddCors) {
                app.UseCors(options => options.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            }

            if (subscriptionGraphQlEndpointOptions.UseSecurity) {
                app
                    .UseAuthentication()
                    .UseAuthorization();
            }

            app.UseEndpoints(endpoints => {
                endpoints.MapGraphQL();
            });

            return app;
        }

        /// <summary>
        /// Adds automapper setup
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddSubscriptionAutomapper(this IServiceCollection services) {
            services
                .AddAutoMapper(typeof(AutomapperReference));

            return services;
        }
    }
}
