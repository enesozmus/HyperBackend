using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using HyperBackend.Business.IRepositories;
using HyperBackend.Database.Context;
using HyperBackend.ViewModels;
using HyperBackend.Enums;

namespace HyperBackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BusesController : ControllerBase
{
    readonly private IBusReadRepository _busReadRepository;
    private readonly HyperBackendDbContext _context;
    private readonly IMapper _mapper;

    public BusesController(
        HyperBackendDbContext context,
        IMapper mapper,
        IBusReadRepository busReadRepository)
    {
        _context = context;
        _mapper = mapper;
        _busReadRepository = busReadRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<BusesVM>>> GetBuses()
    {
        var buses = await _busReadRepository.GetAllAsync();
        var vmBuses = _mapper.Map<List<BusesVM>>(buses);
        return Ok(vmBuses);
    }

    [HttpGet]
    [Route("GetBusesByColor")]
    public ActionResult<IQueryable<BusesVM>> GetBusesByColor(Color color)
    {
        var buses = _busReadRepository.GetWhere(x => x.Color == color);
        var vmBuses = _mapper.Map<List<BusesVM>>(buses);
        return Ok(vmBuses);
    }
}