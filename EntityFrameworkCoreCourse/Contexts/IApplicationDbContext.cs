using EntityFrameworkCoreCourse.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EntityFrameworkCoreCourse.Contexts
{
    public interface IApplicationDbContext
    {
        DbSet<Student> Students { get; set; }

        Task<int> SaveChanges();
    }
}