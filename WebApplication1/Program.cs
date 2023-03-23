using WebApplication1.Controllers;
using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy("NewPolicy", app =>
    {
        app.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSqlServer<DataContext>("Data Source=LAPTOP-VJFIIV5N\\SQLEXPRESS;Initial Catalog=Portflio;user id=sa;password=Y3n2izzf; TrustServerCertificate=True");
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IGeneralInfo, GeneralInfoService>();
builder.Services.AddScoped<IContacto, ContactoService>();
builder.Services.AddScoped<IProjects, ProjectsService>();

var app = builder.Build();
//builder.Services.AddScoped<ICategoriaService, CategoriaService>();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.UseCors("NewPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
