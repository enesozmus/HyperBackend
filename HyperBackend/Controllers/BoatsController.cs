using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using HyperBackend.Business.IRepositories;
using HyperBackend.Database.Context;
using HyperBackend.ViewModels;
using HyperBackend.Enums;

namespace HyperBackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BoatsController : ControllerBase
{
    readonly private IBoatReadRepository _boatReadRepository;
    private readonly HyperBackendDbContext _context;
    private readonly IMapper _mapper;

    public BoatsController(
        HyperBackendDbContext context,
        IMapper mapper,
        IBoatReadRepository boatReadRepository)
    {
        _context = context;
        _mapper = mapper;
        _boatReadRepository = boatReadRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<BoatsVM>>> GetBoats()
    {
        var boats = await _boatReadRepository.GetAllAsync();
        var vmBoats = _mapper.Map<List<BoatsVM>>(boats);
        return Ok(vmBoats);
    }

    [HttpGet]
    [Route("GetBoatsByColor")]
    public ActionResult<IQueryable<BoatsVM>> GetBoatsByColor(Color color)
    {
        var boats = _boatReadRepository.GetWhere(x => x.Color == color);
        var vmBoats = _mapper.Map<List<BoatsVM>>(boats);
        return Ok(vmBoats);
    }
}