using AutoMapper;
using HyperBackend.Entities;
using HyperBackend.ViewModels;

namespace HyperBackend.Mappings;

public class CarProfile : Profile
{
    public CarProfile()
    {
        CreateMap<Car, CarsVM>();
    }
}