using HyperBackend.Business.IRepositories;
using HyperBackend.Database.Context;
using HyperBackend.Entities;

namespace HyperBackend.Business.Repositories;

public class CarReadRepository : ReadRepository<Car>, ICarReadRepository
{
    public CarReadRepository(HyperBackendDbContext dbcontext) : base(dbcontext)
    {
    }
}