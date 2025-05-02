using FluentValidation.AspNetCore;
using LeadManagement.Infra.IoC;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddInfraStructure(builder.Configuration);

builder.Services.AddControllers().AddFluentValidation(config =>
{
    config.RegisterValidatorsFromAssembly(typeof(DependencyInjection).Assembly);
});

builder.Services.AddCors(opt =>
{
    opt.AddPolicy(name: "Leadfront", policy =>
    {
        policy.AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin();
    });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Lead Management API",
        Description = "API para gerenciamento de leads.",
        Contact = new OpenApiContact
        {
            Name = "Mateus Nascimento",
            Url = new Uri("https://www.linkedin.com/in/mateus-rodrigues-371920226/")
        }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("Leadfront");

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
