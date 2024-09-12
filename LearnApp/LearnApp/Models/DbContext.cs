using Microsoft.EntityFrameworkCore;
using LearnApp.Models;

namespace LearnApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Car> Car { get; set; }


    }
}
