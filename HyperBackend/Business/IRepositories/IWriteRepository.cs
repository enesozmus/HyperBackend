using HyperBackend.Entities;

namespace HyperBackend.Business.IRepositories;

public interface IWriteRepository<T> : IRepository<T> where T : Vehicle
{
    // → Bir veri ekleme
    Task<bool> AddAsync(T model);
    // → Bir veriyi güncelleme
    bool Update(T model);
    // → Bir veriyi unique ID'sini kullanarak silme
    Task<bool> RemoveAsync(int id);
    // → İlgili işlemi kaydetme
    Task<int> SaveAsync();                                          // 
}