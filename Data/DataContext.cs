using Microsoft.EntityFrameworkCore;
using net.models;

namespace net.Data
{
    public class DataContext : DbContext
    {
       public DataContext(DbContextOptions<DataContext> options): base (options) { }

       public DbSet<Value> Values { get; set; }
    }
}