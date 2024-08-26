using HyperBackend.Entities;
using Microsoft.EntityFrameworkCore;

namespace HyperBackend.Business.IRepositories;

public interface IRepository<T> where T : Vehicle
{
    DbSet<T> Table { get; }
}