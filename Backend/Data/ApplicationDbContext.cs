using Backend.Model;
using Backend.Model.Entitys;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<SystemDataEntity> SystemData { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }


    }
}
