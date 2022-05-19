using System;
using Limbo.DataAccess.Services.Models;

namespace Limbo.Subscriptions.Bases.GraphQL.Responses {
    /// <summary>
    /// Methods for responses
    /// </summary>
    public static class Response {

        /// <summary>
        /// Creates a response based on a <see cref="IServiceResponse{T}"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="response"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static T? CreateResponse<T>(IServiceResponse<T> response)
            where T : class, new() {
            return response.StatusCode switch {
                System.Net.HttpStatusCode.InternalServerError => throw new Exception("Internal server error"),
                System.Net.HttpStatusCode.NoContent => null,
                _ => response.ResponseValue,
            };
        }
    }
}
