
using LOCADORABASE.Models;
using Microsoft.EntityFrameworkCore;

namespace LOCADORABASE.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public DbSet<LocadoraModel> LOCADORABASE { get; set; }

    }
}

