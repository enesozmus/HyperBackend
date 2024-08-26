using AutoMapper;

namespace HyperBackend.Mappings;

public static class MappingProfile
{
    public static List<Profile> GetProfiles()
    {
        return new List<Profile>
            {
                new CarProfile(),
                new BusProfile(),
                new BoatProfile()
            };
    }
}