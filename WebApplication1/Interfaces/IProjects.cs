using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IProjects
    {
        IEnumerable<Projects> Get();
        Projects GetDetails(int id);
        Task Save(Projects project);
        Task Update(Projects project, int id);
        Task Delete(int id);
    }
}
