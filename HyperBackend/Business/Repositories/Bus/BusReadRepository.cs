using HyperBackend.Business.IRepositories;
using HyperBackend.Database.Context;
using HyperBackend.Entities;

namespace HyperBackend.Business.Repositories;

public class BusReadRepository : ReadRepository<Bus>, IBusReadRepository
{
    public BusReadRepository(HyperBackendDbContext dbcontext) : base(dbcontext)
    {
    }
}