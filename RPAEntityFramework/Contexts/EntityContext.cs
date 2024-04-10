using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RPAEntityFramework.EntityModels;
using RPAEntityFramework.EntityTypeConfigs;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace RPAEntityFramework.Contexts
{
    public class EntityContext : DbContext
    {
        public EntityContext() { }

        public EntityContext(DbContextOptions<EntityContext> options) : base(options)
        {
        }

        public DbSet<AccountInfo> AccountInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new AccountInfoTypeConfig().Configure(modelBuilder.Entity<AccountInfo>());
        }

    }
}
