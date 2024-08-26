#nullable disable
using HyperBackend.Database.Context;
using HyperBackend.Entities;
using HyperBackend.Enums;
using Microsoft.EntityFrameworkCore;

namespace HyperBackend.Database.SeedData;

public class DataGenerator
{
    public static void Initialize(IApplicationBuilder applicationBuilder)
    {
        using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        {
            var context = serviceScope.ServiceProvider.GetService<HyperBackendDbContext>();

            // → migration varsa veri tabanını tohumlar
            context.Database.Migrate();


            // ***** Cars ***** //
            if (!context.Cars.Any())
            {
                context.Cars.AddRange(new List<Car>()
                {
                    new Car() {
                        VIN = 10101,
                        Brand = "SEAT",
                        Color = Color.Red,
                        CreatedDate = DateTime.Now,
                        Wheels = 4,
                        IsHeadlights = false
                    },
                    new Car() {
                        VIN = 20202,
                        Brand = "DODGE",
                        Color = Color.Blue,
                        CreatedDate = DateTime.Now,
                        Wheels = 4,
                        IsHeadlights = false
                    },
                    new Car() {
                        VIN = 30303,
                        Brand = "SKODA",
                        Color = Color.Black,
                        CreatedDate = DateTime.Now,
                        Wheels = 4,
                        IsHeadlights = false
                    },
                    new Car() {
                        VIN = 40404,
                        Brand = "VOLVO",
                        Color = Color.White,
                        CreatedDate = DateTime.Now,
                        Wheels = 4,
                        IsHeadlights = false
                    },
                    new Car() {
                        VIN = 50505,
                        Brand = "BMW",
                        Color = Color.Black,
                        CreatedDate = DateTime.Now,
                        Wheels = 4,
                        IsHeadlights = false
                    },
                    new Car() {
                        VIN = 60606,
                        Brand = "HONDA",
                        Color = Color.Red,
                        CreatedDate = DateTime.Now,
                        Wheels = 4,
                        IsHeadlights = false
                    }
                }
            );
                context.SaveChanges();
            }


            // ***** Buses ***** //
            if (!context.Buses.Any())
            {
                context.Buses.AddRange(new List<Bus>()
                {
                    new Bus() {
                        Brand = "BMC",
                        Color = Color.Red,
                        CreatedDate = DateTime.Now,
                    },
                    new Bus() {
                        Brand = "Mercedes-Benz",
                        Color = Color.Black,
                        CreatedDate = DateTime.Now,
                    },
                    new Bus() {
                        Brand = "Marcopolo S.A.",
                        Color = Color.Red,
                        CreatedDate = DateTime.Now,
                    },
                    new Bus() {
                        Brand = "Volkswagen AG",
                        Color = Color.Black,
                        CreatedDate = DateTime.Now,
                    },
                    new Bus() {
                        Brand = "Toyota Motors",
                        Color = Color.Blue,
                        CreatedDate = DateTime.Now,
                    },
                    new Bus() {
                        Brand = "Scania AB",
                        Color = Color.White,
                        CreatedDate = DateTime.Now,
                    }
                }
            );
                context.SaveChanges();
            }


            // ***** Boats ***** //
            if (!context.Boats.Any())
            {
                context.Boats.AddRange(new List<Boat>()
                {
                    new Boat() {
                        Brand = "Azuree Yachts",
                        Color = Color.Blue,
                        CreatedDate = DateTime.Now,
                    },
                    new Boat() {
                        Brand = "Dufour Yachts",
                        Color = Color.Black,
                        CreatedDate = DateTime.Now,
                    },
                    new Boat() {
                        Brand = "Chaparral Boats",
                        Color = Color.Blue,
                        CreatedDate = DateTime.Now,
                    },
                    new Boat() {
                        Brand = "Azimut",
                        Color = Color.Black,
                        CreatedDate = DateTime.Now,
                    },
                    new Boat() {
                        Brand = "Cruisers Yachts",
                        Color = Color.Red,
                        CreatedDate = DateTime.Now,
                    },
                    new Boat() {
                        Brand = "Benetti",
                        Color = Color.White,
                        CreatedDate = DateTime.Now,
                    }
                }
            );
                context.SaveChanges();
            }
        }
    }
}