using Ifeanyi.Services.productAPI.Contracts.IrepositoryManager;
using Ifeanyi.Services.productAPI.DbContexts;
using Ifeanyi.Services.productAPI.RepositoryManager.Interfaces;
using Ifeanyi.Services.productAPI.RepositoryManager.ProductRepositoryStore;

namespace Ifeanyi.Services.productAPI.RepositoryManager
{
    public class RepositoryManager : IRepositoryManager
    {
        private ApplicationDbContext _repositoryContext;
        private IProductRepository _productRepository;

        public RepositoryManager(ApplicationDbContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IProductRepository Product
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new ProductRepository(_repositoryContext);
                }
                return _productRepository;
            }
        }

        public Task SaveAsync() => _repositoryContext.SaveChangesAsync();
    }
}
