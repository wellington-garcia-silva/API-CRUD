using Person.Data;
using Person.Routes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<PersonContext>();


var app = builder.Build(); // ← Faltava essa linha para construir o app

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.PersonRoutes(); // ← Faltava ponto e vírgula

app.UseHttpsRedirection();

app.Run();
