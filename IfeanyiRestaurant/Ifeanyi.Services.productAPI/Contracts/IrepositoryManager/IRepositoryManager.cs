using Ifeanyi.Services.productAPI.RepositoryManager.Interfaces;
using System.Threading.Tasks;

namespace Ifeanyi.Services.productAPI.Contracts.IrepositoryManager
{
    public interface IRepositoryManager
    {
        IProductRepository Product { get; }
        Task SaveAsync();
    }
}
