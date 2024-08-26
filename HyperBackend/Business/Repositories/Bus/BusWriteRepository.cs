using HyperBackend.Business.IRepositories;
using HyperBackend.Database.Context;
using HyperBackend.Entities;

namespace HyperBackend.Business.Repositories;

public class BusWriteRepository : WriteRepository<Bus>, IBusWriteRepository
{
    public BusWriteRepository(HyperBackendDbContext dbcontext) : base(dbcontext)
    {
    }
}