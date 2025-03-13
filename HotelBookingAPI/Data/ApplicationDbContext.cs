using Microsoft.EntityFrameworkCore;
using HotelBookingAPI.Models;
namespace HotelBookingAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor accepting DbContextOptions to configure the context
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        // Define a DbSet for each model (representing a table in the database)
        public DbSet<Employee> Employees { get; set; }
    }
}
