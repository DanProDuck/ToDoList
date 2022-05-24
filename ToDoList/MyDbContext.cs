using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList
{
    public class MyDbContext : DbContext
    {
        public virtual DbSet<Goal>? Goals { get; set; }
        public virtual DbSet<Tag>? Tags { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
