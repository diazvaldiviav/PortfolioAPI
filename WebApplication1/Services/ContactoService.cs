using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class ContactoService : IContacto
    {

        DataContext context;

        public ContactoService(DataContext context)
        {
            this.context = context;
        }

        public async Task Delete(int id)
        {
            var ContactoActual = context.contacto.Find(id);
            if (ContactoActual != null) 
            {
                context.Remove(ContactoActual);
                await context.SaveChangesAsync();
            }
        }

        public IEnumerable<Contacto> Get()
        {
            return context.contacto;
        }

        public Contacto GetDetails(int id)
        {
            return context.contacto.Find(id);
        }

        public async Task Save(Contacto contacto)
        {
            context.Add(contacto);
            await context.SaveChangesAsync();
        }

        public async Task Update(Contacto contacto, int id)
        {
            var ContactoActual = context.contacto.Find(id);
            if (ContactoActual != null)
            {
                ContactoActual.Name = contacto.Name;
                ContactoActual.Email = contacto.Email;
                ContactoActual.Phone = contacto.Phone;
                ContactoActual.Description = contacto.Description;
                ContactoActual.Picture= contacto.Picture;
                ContactoActual.GitHub = contacto.GitHub;
                ContactoActual.Linkdin = contacto.Linkdin;
           
                await context.SaveChangesAsync();
            }
        }
    }


public static class ContactoEndpoints
{
	public static void MapContactoEndpoints (this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/api/Contacto", () =>
        {
            return new [] { new Contacto() };
        })
        .WithName("GetAllContactos");

        routes.MapGet("/api/Contacto/{id}", (int id) =>
        {
            //return new Contacto { ID = id };
        })
        .WithName("GetContactoById");

        routes.MapPut("/api/Contacto/{id}", (int id, Contacto input) =>
        {
            return Results.NoContent();
        })
        .WithName("UpdateContacto");

        routes.MapPost("/api/Contacto/", (Contacto model) =>
        {
            //return Results.Created($"/Contactos/{model.ID}", model);
        })
        .WithName("CreateContacto");

        routes.MapDelete("/api/Contacto/{id}", (int id) =>
        {
            //return Results.Ok(new Contacto { ID = id });
        })
        .WithName("DeleteContacto");
    }
}}
