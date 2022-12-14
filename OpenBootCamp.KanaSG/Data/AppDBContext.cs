using Microsoft.EntityFrameworkCore;
using OpenBootCamp.KanaSG.Models.Entities;

namespace OpenBootCamp.KanaSG.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Chapter> Chapters{ get; set; }
    
    }
}
