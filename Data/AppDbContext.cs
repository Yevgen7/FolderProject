using FolderProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FolderProject.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Folder> Folders { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Data/folders.db");
        }
    }
}
