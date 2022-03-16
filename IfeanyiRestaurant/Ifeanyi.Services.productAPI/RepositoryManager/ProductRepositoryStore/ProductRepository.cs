using Ifeanyi.Services.productAPI.DataTransferObjects.Readable;
using Ifeanyi.Services.productAPI.DbContexts;
using Ifeanyi.Services.productAPI.Models;
using Ifeanyi.Services.productAPI.RepositoryManager.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Ifeanyi.Services.productAPI.RepositoryManager.ProductRepositoryStore
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {

        }
        // use mapping to do the conversion for creation and returning
        // save changes
        //
        public void CreateUpdateProduct(Product product)
        {
            if(product.ProductId > 0)
            {
                Update(product);
            }
            else
            {
                Create(product);
            }
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            try
            {
                var productToDelete = await FindByCondition(p => p.ProductId == productId).SingleOrDefaultAsync();
                if(productToDelete == null)
                {
                    return false;
                }
                Delete(productToDelete);
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<Product> GetProductById(int productId) =>
            await FindByCondition(p => p.ProductId == productId)
            .SingleOrDefaultAsync();
        
           
           
           public async Task<IEnumerable<Product>> GetProducts() =>
            await FindAll()
            .OrderBy(p => p.ProductId)
            .ToListAsync();

    }
}
