using AutoMapper;
using Limbo.Subscriptions.Persistence.Subscribers.Models;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Models;
using Limbo.Subscriptions.Subscribers.Models;

namespace Limbo.Subscriptions.Subscribers.Profiles {
    /// <inheritdoc/>
    public class SubscriptionProfile : Profile {
        /// <inheritdoc/>
        public SubscriptionProfile() {
            CreateMap<Subscriber, SubscriberUpdateInput>()
                .ForMember(dest => dest.SubscriptionSystemId, opt => opt.MapFrom(src => src.SubscriptionSystem != null ? src.SubscriptionSystem.Id : 0));

            CreateMap<SubscriberUpdateInput, Subscriber>()
                .ForMember(dest => dest.SubscriptionSystem, opt => opt.MapFrom(src => new SubscriptionSystem { Id = src.SubscriptionSystemId }));
        }
    }
}
