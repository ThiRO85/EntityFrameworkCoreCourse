using EntityFrameworkCoreCourse.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EntityFrameworkCoreCourse.Contexts
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        public async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync(); 
        }
    }
}
