using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IUser
    {
        IEnumerable<Users> Get();
        Task Save(Users user);
        Task Update(Users user, int id);
        Task Delete(int id);
    }
}
