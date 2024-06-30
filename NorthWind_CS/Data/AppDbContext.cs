using Microsoft.EntityFrameworkCore;

namespace NorthWind_CS.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }


}
