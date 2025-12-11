using FrontToBackSqlConnection.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontToBackSqlConnection.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Home { get; set; }
    }
}