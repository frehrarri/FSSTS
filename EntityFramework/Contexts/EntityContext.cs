﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EntityFramework.EntityModels;
using EntityFramework.EntityTypeConfigs;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace EntityFramework.Contexts
{
    public class EntityContext : DbContext
    {
        public EntityContext() { }

        public EntityContext(DbContextOptions<EntityContext> options) : base(options)
        {
        }

        public DbSet<AccountInfo> AccountInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSqlLocalDB;Initial Catalog=Development;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AccountInfoTypeConfig).Assembly);
        }

    }
}
