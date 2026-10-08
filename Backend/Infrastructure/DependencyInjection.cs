using Infrastructure.Repositories;
using Infrastructure.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Application.Interfaces;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<IRoleRepository, RoleRepository>();

            services.AddScoped<IUserRoleRepository, UserRoleRepository>();
            
            services.AddScoped<IActivityRepository, ActivityRepository>();

            services.AddScoped<
                IApplicationRequestRepository,
                ApplicationRequestRepository>();

            services.AddScoped<
                IActivityRepository,
                ActivityRepository>();

            services.AddScoped<
                IApplicationDocumentRepository,
                ApplicationDocumentRepository>();

            services.AddScoped<
                IAnnexRepository,
                AnnexRepository>();

            services.AddScoped<
                IAnnualPlanRepository,
                AnnualPlanRepository>();

            services.AddScoped<
                IAnnualPlanItemsRepository,
                AnnualPlanItemsRepository>();

            return services;
        }
    }
}