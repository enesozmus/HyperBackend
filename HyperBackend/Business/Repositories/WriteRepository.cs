#nullable disable
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using HyperBackend.Entities;
using HyperBackend.Business.IRepositories;
using HyperBackend.Database.Context;

namespace HyperBackend.Business.Repositories;

public class WriteRepository<T> : IWriteRepository<T> where T : Vehicle
{
    private readonly HyperBackendDbContext _dbcontext;

    public WriteRepository(HyperBackendDbContext dbcontext)
    {
        _dbcontext = dbcontext;
    }

    public DbSet<T> Table => _dbcontext.Set<T>();
    public async Task<int> SaveAsync() => await _dbcontext.SaveChangesAsync();

    public async Task<bool> AddAsync(T model)
    {
        EntityEntry<T> entityEntry = await Table.AddAsync(model);
        await _dbcontext.SaveChangesAsync();
        return entityEntry.State == EntityState.Added;
    }

    public bool Update(T model)
    {
        EntityEntry entityEntry = Table.Update(model);
        return entityEntry.State == EntityState.Modified;
    }

    public async Task<bool> RemoveAsync(int id)
    {
        if (id <= 0) throw new InvalidOperationException();
        T model = await Table.FirstOrDefaultAsync(x => x.Id == id);
        if (model == null) throw new InvalidOperationException();
        Table.Remove(model);
        await _dbcontext.SaveChangesAsync();
        return true;
    }
}