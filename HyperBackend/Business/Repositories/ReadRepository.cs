#nullable disable
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using HyperBackend.Entities;
using HyperBackend.Business.IRepositories;
using HyperBackend.Database.Context;


namespace HyperBackend.Business.Repositories;

public class ReadRepository<T> : IReadRepository<T> where T : Vehicle
{
    private readonly HyperBackendDbContext _dbcontext;

    public ReadRepository(HyperBackendDbContext dbcontext)
    {
        _dbcontext = dbcontext;
    }

    public DbSet<T> Table => _dbcontext.Set<T>();

    // → İlgili tüm verileri elde etme
    public async Task<IReadOnlyList<T>> GetAllAsync()
    {
        return await Table.ToListAsync();
    }

    // → Unique bir ID'ye uyan veriyi elde etme
    public async Task<T> GetByIdAsync(int id, bool tracking = true)
    {
        var query = Table.AsQueryable();
        if (!tracking)
            query = Table.AsNoTracking();
        return await query.FirstOrDefaultAsync(data => data.Id == id);
    }

    // → Bir şarta uyan tüm verileri elde etme
    public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
    {
        var query = Table.Where(method);
        if (!tracking)
            query = query.AsNoTracking();       // tracking true değilse maliyeti düşür!
        return query;
    }

    // → Bir şarta uyan tek bir veriyi elde etme
    public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
    {
        var query = Table.AsQueryable();
        if (!tracking)
            query = Table.AsNoTracking();
        return await query.FirstOrDefaultAsync(method);
    }
}