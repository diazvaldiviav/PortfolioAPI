using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IContacto
    {
        IEnumerable<Contacto> Get();
        Contacto GetDetails(int id);
        Task Save(Contacto contacto);
        Task Update(Contacto contacto, int id);
        Task Delete(int id);
    }
}
