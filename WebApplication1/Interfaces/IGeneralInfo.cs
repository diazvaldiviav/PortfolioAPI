using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IGeneralInfo
    {
        IEnumerable<GeneralInfo> Get();
        GeneralInfo GetDetails(int id);
        Task Save(GeneralInfo info);
        Task Update(GeneralInfo info, int id);
        Task Delete(int id);
    }
}
