using HyperBackend.Business.IRepositories;
using HyperBackend.Database.Context;
using HyperBackend.Entities;

namespace HyperBackend.Business.Repositories;

public class BoatReadRepository : ReadRepository<Boat>, IBoatReadRepository
{
    public BoatReadRepository(HyperBackendDbContext dbcontext) : base(dbcontext)
    {
    }
}