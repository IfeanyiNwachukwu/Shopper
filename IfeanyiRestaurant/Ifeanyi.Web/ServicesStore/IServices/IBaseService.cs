using Ifeanyi.Web.Models;

namespace Ifeanyi.Web.ServicesStore.IServices
{
    public interface IBaseService : IDisposable
    {
        ResponseDTO responseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
