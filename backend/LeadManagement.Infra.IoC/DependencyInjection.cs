using LeadManagement.Application.Interfaces;
using LeadManagement.Application.Mappings;
using LeadManagement.Application.Services;
using LeadManagement.Domain.Interfaces;
using LeadManagement.Infra.Data.Context;
using LeadManagement.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace LeadManagement.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraStructure(this IServiceCollection services, 
            IConfiguration configuration) 
        {
            services.AddDbContext<ApplicationDbContext>(options => 
             options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"
             ), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<ILeadRepository,LeadRepository>();
            services.AddScoped<IEmailService, EmailService>();

            services.AddAutoMapper(typeof(LeadMappingProfile));

            services.AddMediatR(config => config.RegisterServicesFromAssembly
                (Assembly.Load("LeadManagement.Application")));

            return services;
        }

    }
}
