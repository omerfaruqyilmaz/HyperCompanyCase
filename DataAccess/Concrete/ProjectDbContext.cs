using HyperCompanyCase.Entities.Entity;
using Microsoft.EntityFrameworkCore;

namespace HyperCompanyCase.DataAccess.Concrete
{

    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Boat> Boats { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Color> Colors { get; set; }
    }

}
