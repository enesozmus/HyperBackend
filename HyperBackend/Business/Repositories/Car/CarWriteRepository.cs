using HyperBackend.Business.IRepositories;
using HyperBackend.Database.Context;
using HyperBackend.Entities;

namespace HyperBackend.Business.Repositories;

public class CarWriteRepository : WriteRepository<Car>, ICarWriteRepository
{
    public CarWriteRepository(HyperBackendDbContext dbcontext) : base(dbcontext)
    {
    }
}