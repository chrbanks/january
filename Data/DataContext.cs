using January.Models;
using Microsoft.EntityFrameworkCore;

namespace January.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }

        public DbSet<Topic> Topics { get; set; }
    }
}