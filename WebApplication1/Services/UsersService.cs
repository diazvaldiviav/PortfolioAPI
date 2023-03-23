using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class UsersService : IUser
    {

        DataContext context;

        public UsersService(DataContext context)
        {
            this.context = context;
        }

        public async Task Delete(int id)
        {
            var UserActual = context.users.Find(id);
            if(UserActual != null)
            {
                context.users.Remove(UserActual);
                await context.SaveChangesAsync();
            }
        }

        public IEnumerable<Users> Get()
        {
            return context.users;
        }

        public async Task Save(Users user)
        {
            context.users.Add(user);    
            await context.SaveChangesAsync();
        }

        public async Task Update(Users user, int id)
        {
            var UserActual = context.users.Find(id);
            if(UserActual != null)
            {
                UserActual.UserName = user.UserName;
                UserActual.Name = user.Name;
                UserActual.Email = user.Email;
                UserActual.Password = user.Password;
                UserActual.VerifyPassword = user.VerifyPassword;
                UserActual.Name = UserActual.Name;
                
                await context.SaveChangesAsync();
              
            }
        }
    }
}
