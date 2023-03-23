using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IClientService
    {
        IEnumerable<Clients> Get();

        Clients GetDetails(int id);
        Task Save(Clients client);
        Task Update(Clients client, int id);
        Task Delete(int id);
    }
}
