using Hamza_assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Hamza_assignment.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<customerMessage> messa { get; set; }
    }
}
