using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;

namespace StudentManagement.Helper
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options)
        {
        }

        public DbSet<Students> Students { get; set; }
    }
}
