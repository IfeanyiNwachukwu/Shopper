using Ifeanyi.Web.Models;

namespace Ifeanyi.Web.ServicesStore.IServices
{
    public interface IProductService : IBaseService
    {
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetProductsByIdAsync<T>(int id);
        Task<T> CreateProductAsync<T>(ProductDTO model);
        Task<T> UpdateProductAsync<T>(ProductDTO model);
        Task<T> DeleteProductAsync<T>(int id);

    }
}
