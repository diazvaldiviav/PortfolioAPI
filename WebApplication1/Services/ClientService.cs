using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class ClientService : IClientService
    {
        DataContext context;

        public ClientService(DataContext context)
        {
            this.context = context;
        }

        public IEnumerable<Clients> Get()
        {
            return context.Clients;
        }

        public Clients GetDetails(int id)
        {
            return context.Clients.Find(id);
        }

        public async Task Save(Clients client)
        {
            context.Clients.Add(client);
            await context.SaveChangesAsync();
        }

        public async Task Update(Clients client, int id)
        {
            var clientActual = context.Clients.Find(id);
            if (clientActual != null)
            {
                clientActual.Name = client.Name;
                clientActual.PhoneNumber = client.PhoneNumber;
                clientActual.Email = client.Email;
                clientActual.Description = client.Description;
                await context.SaveChangesAsync();
            }
        }

        public async Task Delete(int id)
        {
            var clientActual = context.Clients.Find(id);
            if (clientActual != null)
            {
                context.Clients.Remove(clientActual);
                await context.SaveChangesAsync();
            }
        }
    }
}



