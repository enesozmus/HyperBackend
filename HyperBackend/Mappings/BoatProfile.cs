using AutoMapper;
using HyperBackend.Entities;
using HyperBackend.ViewModels;

namespace HyperBackend.Mappings;

public class BoatProfile : Profile
{
    public BoatProfile()
    {
        CreateMap<Boat, BoatsVM>();
    }
}