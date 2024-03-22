using API_Aula_2.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Aula_2.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }
    }
}
