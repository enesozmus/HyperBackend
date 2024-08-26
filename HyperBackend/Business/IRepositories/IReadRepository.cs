using HyperBackend.Entities;
using System.Linq.Expressions;

namespace HyperBackend.Business.IRepositories;

public interface IReadRepository<T> : IRepository<T> where T : Vehicle
{
    // → İlgili tüm verileri elde etme
    Task<IReadOnlyList<T>> GetAllAsync();
    // → Unique bir ID'ye uyan veriyi elde etme
    Task<T> GetByIdAsync(int id, bool tracking = true);
    // → Bir şarta uyan tüm verileri elde etme
    IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true);
    // → Bir şarta uyan tek bir veriyi elde etme
    Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true);
}