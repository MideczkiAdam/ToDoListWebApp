using Microsoft.EntityFrameworkCore;
using ToDoListWebApp.Models;

namespace ToDoListWebApp.Data
{
    public class TeendokDbContext : DbContext
    {
        public TeendokDbContext(DbContextOptions<TeendokDbContext> options) : base(options)
        {
        }
        public DbSet<Teendo> Teendok { get; set; }
    }
}
