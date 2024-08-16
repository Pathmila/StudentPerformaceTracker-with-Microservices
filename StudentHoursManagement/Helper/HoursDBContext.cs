using Microsoft.EntityFrameworkCore;
using StudentHoursManagement.Models;

namespace StudentHoursManagement.Helper
{
    public class HoursDBContext : DbContext
    {
        public HoursDBContext(DbContextOptions<HoursDBContext> options)
            : base(options)
        {
        }

        public DbSet<Hours> Hours { get; set; }
    }
}
