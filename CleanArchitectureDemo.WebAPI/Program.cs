using CleanArchitectureDemo.Application.Extensions;
using CleanArchitectureDemo.Infrastructure.Extensions;
using CleanArchitectureDemo.Persistence.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApplicationLayer();
builder.Services.AddInfrastructureLayer();
builder.Services.AddPersistenceLayer(builder.Configuration);

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); 
}

app.MapControllers();

app.Run();
 