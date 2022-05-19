using System.Data;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.AspNetCore.Authorization;
using HotChocolate.Data;
using HotChocolate.Types;
using Limbo.Subscriptions.Categories.Services;
using Limbo.Subscriptions.Persistence.Categories.Models;

namespace Limbo.Subscriptions.Categories.Queries {
    /// <summary>
    /// Queries for categories
    /// </summary>
    public class CategoryQueriesBase {

        /// <summary>
        /// Gets categories
        /// </summary>
        /// <param name="categoryService"></param>
        /// <returns></returns>
        [Authorize]
        [UsePaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public virtual async Task<IQueryable<Category>> GetCategories([Service] ICategoryService categoryService) {
            var response = (await categoryService.QueryDbSet(IsolationLevel.ReadCommitted)).ResponseValue;
            if (response is not null) {
                return response;
            } else {
                return Enumerable.Empty<Category>().AsQueryable();
            }
        }

        /// <summary>
        /// Gets a category
        /// </summary>
        /// <param name="categoryService"></param>
        /// <returns></returns>
        [Authorize]
        [UseFirstOrDefault]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public virtual async Task<IQueryable<Category>?> GetCategory([Service] ICategoryService categoryService) {
            var response = (await categoryService.QueryDbSet(IsolationLevel.ReadCommitted)).ResponseValue;
            return response;
        }
    }
}