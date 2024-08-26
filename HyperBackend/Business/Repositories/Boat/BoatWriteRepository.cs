using HyperBackend.Business.IRepositories;
using HyperBackend.Database.Context;
using HyperBackend.Entities;

namespace HyperBackend.Business.Repositories;

public class BoatWriteRepository : WriteRepository<Boat>, IBoatWriteRepository
{
    public BoatWriteRepository(HyperBackendDbContext dbcontext) : base(dbcontext)
    {
    }
}