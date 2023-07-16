using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Entities
{
    public  class EmployeDbContext:DbContext
    {
        public EmployeDbContext(DbContextOptions<EmployeDbContext> options) : base(options)
        {

        }
        public DbSet<Employe> Employes { get; set; }
    }
}

