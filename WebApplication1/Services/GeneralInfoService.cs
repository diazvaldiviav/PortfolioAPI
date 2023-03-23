using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class GeneralInfoService : IGeneralInfo
    {
        DataContext context;

        public GeneralInfoService(DataContext context)
        {
            this.context = context;
        }

        
        public async Task Delete(int id)
        {
            var InfoActual = context.Informations.Find(id);

             if(InfoActual != null)
            {
                context.Informations.Remove(InfoActual);
                await context.SaveChangesAsync();

            }
        }

        public IEnumerable<GeneralInfo> Get()
        {
            return context.Informations;
        }

        public GeneralInfo GetDetails(int id)
        {
            return context.Informations.Find(id);
        }

        public async Task Save(GeneralInfo info)
        {
            context.Add(info);
            await context.SaveChangesAsync();
        }

        public async Task Update(GeneralInfo info, int id)
        {
            var InfoActual = context.Informations.Find(id);

            if(InfoActual != null)
            {
                InfoActual.FirstName = info.FirstName;
                InfoActual.Email = info.Email;
                InfoActual.Message = info.Message;

                await context.SaveChangesAsync();
            }
        }
    }
}
