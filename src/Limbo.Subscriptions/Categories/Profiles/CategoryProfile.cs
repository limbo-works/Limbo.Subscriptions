using AutoMapper;
using Limbo.Subscriptions.Persistence.Categories.Models;
using Limbo.Subscriptions.Categories.Models;

namespace Limbo.Subscriptions.Categories.Profiles {
    /// <inheritdoc/>
    public class CategoryProfile : Profile {
        /// <inheritdoc/>
        public CategoryProfile() {
            CreateMap<Category, CategoryUpdateInput>();
            CreateMap<CategoryUpdateInput, Category>();
        }
    }
}
