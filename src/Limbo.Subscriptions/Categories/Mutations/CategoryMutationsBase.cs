using System.Threading.Tasks;
using AutoMapper;
using HotChocolate;
using HotChocolate.AspNetCore.Authorization;
using Limbo.Subscriptions.Bases.GraphQL.Responses;
using Limbo.Subscriptions.Categories.Models;
using Limbo.Subscriptions.Categories.Services;
using Limbo.Subscriptions.Persistence.Categories.Models;

namespace Limbo.Subscriptions.Categories.Mutations {
    /// <summary>
    /// Mutations for categories
    /// </summary>
    public class CategoryMutationsBase {

        /// <summary>
        /// Adds subscribers to a category
        /// </summary>
        /// <param name="categoryService"></param>
        /// <param name="id"></param>
        /// <param name="subscriberIds"></param>
        /// <returns></returns>
        [Authorize]
        public virtual async Task<Category?> AddSubscribersToCategory([Service] ICategoryService categoryService, int id, int[] subscriberIds) {
            var response = await categoryService.AddSubscribers(id, subscriberIds);
            return Response.CreateResponse(response);
        }

        /// <summary>
        /// Adds subscription items to a category
        /// </summary>
        /// <param name="categoryService"></param>
        /// <param name="id"></param>
        /// <param name="subscriptionItemIds"></param>
        /// <returns></returns>
        [Authorize]
        public virtual async Task<Category?> AddSubscriptionItemsToCategory([Service] ICategoryService categoryService, int id, int[] subscriptionItemIds) {
            var response = await categoryService.AddSubscriptionItems(id, subscriptionItemIds);
            return Response.CreateResponse(response);
        }

        /// <summary>
        /// Creates a category
        /// </summary>
        /// <param name="categoryService"></param>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        [Authorize]
        public virtual async Task<Category?> CreateCategory([Service] ICategoryService categoryService, string categoryName) {
            var response = await categoryService.Add(new Category { Name = categoryName });
            return Response.CreateResponse(response);
        }

        /// <summary>
        /// Deletes a category
        /// </summary>
        /// <param name="categoryService"></param>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        [Authorize]
        public virtual async Task<Category?> DeleteCategoryById([Service] ICategoryService categoryService, int categoryId) {
            var response = await categoryService.DeleteById(categoryId);
            return Response.CreateResponse(response);
        }

        /// <summary>
        /// Removes subscription items from a category
        /// </summary>
        /// <param name="categoryService"></param>
        /// <param name="id"></param>
        /// <param name="subscriptionItemIds"></param>
        /// <returns></returns>
        [Authorize]
        public virtual async Task<Category?> RemoveSubcriptionItemsFromCategory([Service] ICategoryService categoryService, int id, int[] subscriptionItemIds) {
            var response = await categoryService.RemoveSubscriptionItems(id, subscriptionItemIds);
            return Response.CreateResponse(response);
        }

        /// <summary>
        /// Removes subscribers to a category
        /// </summary>
        /// <param name="categoryService"></param>
        /// <param name="id"></param>
        /// <param name="subscriberIds"></param>
        /// <returns></returns>
        [Authorize]
        public virtual async Task<Category?> RemoveSubscribersFromCategory([Service] ICategoryService categoryService, int id, int[] subscriberIds) {
            var response = await categoryService.RemoveSubscribers(id, subscriberIds);
            return Response.CreateResponse(response);
        }

        /// <summary>
        /// Updates a category
        /// </summary>
        /// <param name="categoryService"></param>
        /// <param name="mapper"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        [Authorize]
        public virtual async Task<Category?> UpdateCategory([Service] ICategoryService categoryService, [Service] IMapper mapper, CategoryUpdateInput category) {
            var response = await categoryService.Update(mapper.Map<Category>(category));
            return Response.CreateResponse(response);
        }
    }
}