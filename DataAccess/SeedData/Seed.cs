using HyperCompanyCase.DataAccess.Concrete;
using HyperCompanyCase.Entities.Entity;
using Microsoft.EntityFrameworkCore;

namespace HyperCompanyCase.DataAccess.SeedData
{
    public static class Seed
    {
        public static void Init(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<ProjectDbContext>();
            context.Database.Migrate();

            if (!context.Colors.Any())
            {
                context.Colors.AddRange(
                    new List<Color>()
                {
                    new Color() { Name = "Red" },
                    new Color() { Name = "Blue" },
                    new Color() { Name = "Black" },
                    new Color() { Name = "White" }
                });
            }

            if (!context.Boats.Any())
            {
                context.Boats.AddRange(
                    new List<Boat>()
                    {
                        new Boat() { Name = "SpeedBoat", IsStatus = true, CreatedAt = DateTime.Now, ColorId = 2 },
                        new Boat() { Name = "Sailboat", IsStatus = true, CreatedAt = DateTime.Now, ColorId = 3 },
                        new Boat() { Name = "FishingBoat", IsStatus = true, CreatedAt = DateTime.Now, ColorId = 4 },
                        new Boat() { Name = "Yacht", IsStatus = true, CreatedAt = DateTime.Now, ColorId = 4 }
                    }
                );
            }

            context.SaveChanges();

            if (!context.Buses.Any())
            {
                context.Buses.AddRange(
                    new List<Bus>()
                {
                    new Bus() { Name = "CityBus", IsStatus = true, CreatedAt = DateTime.Now, ColorId = 1 },
                    new Bus() { Name = "SchoolBus", IsStatus = true, CreatedAt = DateTime.Now, ColorId = 4 },
                    new Bus() { Name = "DoubleDecker", IsStatus = true, CreatedAt = DateTime.Now, ColorId = 2 },
                    new Bus() { Name = "TouristBus", IsStatus = true, CreatedAt = DateTime.Now, ColorId = 2 }
                });
            }

            context.SaveChanges();

            if (!context.Cars.Any())
            {
                context.Cars.AddRange(
                    new List<Car>()
                {
                    new Car() { Name = "Sedan", Wheel = 4, HeadLigths = true, IsStatus = true, CreatedAt = DateTime.Now, ColorId = 1 },
                    new Car() { Name = "SUV", Wheel = 4, HeadLigths = true, IsStatus = true, CreatedAt = DateTime.Now, ColorId = 2 },
                    new Car() { Name = "Convertible", Wheel = 4, HeadLigths = true, IsStatus = true, CreatedAt = DateTime.Now, ColorId = 3 },
                    new Car() { Name = "Hatchback", Wheel = 4, HeadLigths = true, IsStatus = true, CreatedAt = DateTime.Now, ColorId = 1 }
                });
            }

            context.SaveChanges();
        }
    }
}
