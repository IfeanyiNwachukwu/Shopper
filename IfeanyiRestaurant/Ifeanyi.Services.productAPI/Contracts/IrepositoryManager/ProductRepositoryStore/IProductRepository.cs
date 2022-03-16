using Ifeanyi.Services.productAPI.DataTransferObjects.Readable;
using Ifeanyi.Services.productAPI.Models;

namespace Ifeanyi.Services.productAPI.RepositoryManager.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProductById(int productId);
        void CreateUpdateProduct(Product product);
        Task<bool> DeleteProduct(int productId);

    }
}
