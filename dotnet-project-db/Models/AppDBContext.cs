using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace dotnet_project_db.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
        public DbSet<Vehicle> Vehicles { get; set; }
        


    }
}
