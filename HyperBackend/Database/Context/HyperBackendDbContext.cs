#nullable disable
using HyperBackend.Entities;
using Microsoft.EntityFrameworkCore;

namespace HyperBackend.Database.Context;

public class HyperBackendDbContext : DbContext
{
    public HyperBackendDbContext(DbContextOptions<HyperBackendDbContext> options) : base(options) { }

    // ***** Entities ***** //
    public DbSet<Car> Cars { get; set; }
    public DbSet<Bus> Buses { get; set; }
    public DbSet<Boat> Boats { get; set; }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        // ChangeTracker : Entityler üzerinden yapılan değişiklerin ya da yeni eklenen verinin yakalanmasını sağlayan property'dir.
        // Update operasyonlarında Track edilen verileri yakalayıp elde etmemizi sağlar.

        var datas = ChangeTracker.Entries<Vehicle>();

        foreach (var data in datas)
        {
            _ = data.State switch
            {
                EntityState.Added => data.Entity.CreatedDate = DateTime.Now,
                EntityState.Modified => data.Entity.LastModifiedDate = DateTime.Now,
                _ => DateTime.UtcNow
            };
        }

        return await base.SaveChangesAsync(cancellationToken);
    }
}