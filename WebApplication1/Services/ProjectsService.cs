using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class ProjectsService : IProjects
    {

        DataContext context;

        public ProjectsService(DataContext context)
        {
            this.context = context;
        }

        public async Task Delete(int id)
        {
            var ProjectActual = context.projects.Find(id);

            if (ProjectActual != null)
            {
                context.projects.Remove(ProjectActual);
                await context.SaveChangesAsync();
            }
        }

        public IEnumerable<Projects> Get()
        {
            return context.projects;
        }

        public Projects GetDetails(int id)
        {
            return (context.projects.Find(id));
        }

        public async Task Save(Projects project)
        {
            context.projects.Add(project);
            await context.SaveChangesAsync();
        }

        public async Task Update(Projects project, int id)
        {
            var projectActual = context.projects.Find(id);
            if (projectActual != null)
            {
                projectActual.ContactoId = project.ContactoId;
                projectActual.description = project.description;
                projectActual.name = project.name;
                
                await context.SaveChangesAsync();
            }
        }
    }
}
