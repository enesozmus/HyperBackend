using AutoMapper;
using HyperBackend.Entities;
using HyperBackend.ViewModels;

namespace HyperBackend.Mappings;

public class BusProfile : Profile
{
    public BusProfile()
    {
        CreateMap<Bus, BusesVM>();
    }
}