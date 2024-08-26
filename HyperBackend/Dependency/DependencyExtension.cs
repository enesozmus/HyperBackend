using AutoMapper;
using Microsoft.EntityFrameworkCore;
using HyperBackend.Business.IRepositories;
using HyperBackend.Business.Repositories;
using HyperBackend.Database.Context;
using HyperBackend.Mappings;

namespace HyperBackend.Dependency;

public static class DependencyExtension
{
    public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        /// <summary>
        /// Entity Framework & Microsoft SQL Server
        /// </summary>
        services.AddDbContext<HyperBackendDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        /// <summary>
        /// Generic Repository
        /// </summary>
        services.AddScoped<ICarReadRepository, CarReadRepository>();
        services.AddScoped<ICarWriteRepository, CarWriteRepository>();
        services.AddScoped<IBusReadRepository, BusReadRepository>();
        services.AddScoped<IBusWriteRepository, BusWriteRepository>();
        services.AddScoped<IBoatReadRepository, BoatReadRepository>();
        services.AddScoped<IBoatWriteRepository, BoatWriteRepository>();

        /// <summary>
        /// AutoMapper Kütüphanesi
        /// </summary>
        var profiles = MappingProfile.GetProfiles();
        var mapConfiguration = new MapperConfiguration(opt =>
        {
            opt.AddProfiles(profiles);
        });
        var mapper = mapConfiguration.CreateMapper();
        services.AddSingleton(mapper);
    }
}