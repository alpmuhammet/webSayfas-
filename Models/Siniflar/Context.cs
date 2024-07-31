using System.Data.Entity;

namespace Web_Ödevii.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Kategori> Kategories { get; set; }
        

    }
}