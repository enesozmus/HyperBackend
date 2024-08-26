using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using HyperBackend.Business.IRepositories;
using HyperBackend.Database.Context;
using HyperBackend.ViewModels;
using HyperBackend.Enums;

namespace HyperBackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CarsController : ControllerBase
{
    readonly private ICarReadRepository _carReadRepository;
    readonly private ICarWriteRepository _carWriteRepository;
    private readonly HyperBackendDbContext _context;
    private readonly IMapper _mapper;

    public CarsController(
        HyperBackendDbContext context,
        IMapper mapper,
        ICarReadRepository carReadRepository,
        ICarWriteRepository carWriteRepository)
    {
        _context = context;
        _mapper = mapper;
        _carReadRepository = carReadRepository;
        _carWriteRepository = carWriteRepository;
    }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<CarsVM>>> GetCars()
    {
        var cars = await _carReadRepository.GetAllAsync();
        var vmCars = _mapper.Map<List<CarsVM>>(cars);
        return Ok(vmCars);
    }

    [HttpGet]
    [Route("GetCarsByColor")]
    public ActionResult<IQueryable<CarsVM>> GetCarsByColor(Color color)
    {
        var cars = _carReadRepository.GetWhere(x => x.Color == color);
        var vmCars = _mapper.Map<List<CarsVM>>(cars);
        return Ok(vmCars);
    }

    [HttpPost(Name = "TurnOnOff")]
    public async Task TurnOnOff(int id)
    {
        var car = await _carReadRepository.GetByIdAsync(id);
        // Console.WriteLine(car.Id);
        // Console.WriteLine(car.IsHeadlights);
        car.IsHeadlights = !car.IsHeadlights;
        await _context.SaveChangesAsync();
        // Console.WriteLine(car.IsHeadlights);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCar(int id)
    {
        await _carWriteRepository.RemoveAsync(id);
        return Ok();
    }
}