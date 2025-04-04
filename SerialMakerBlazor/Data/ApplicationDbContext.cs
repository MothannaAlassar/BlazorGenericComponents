using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SerialMakerBlazor.Models;
using SerialMakerBlazor.Models.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace SerialMakerBlazor.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        private readonly IConfiguration _configuration;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }
        public ApplicationDbContext(IConfiguration configuration):base()
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"), option =>
                {
                    option.CommandTimeout(300);

                });
            }
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientMachine> ClientMachines { get; set; }
        public DbSet<SystemType> SystemTypes { get; set; }
        public DbSet<SysVersion> SysVersions { get; set; }
        public DbSet<ClientVersion> ClientVersions { get; set; }
        public DbSet<VClientVersion> VClientVersions { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Governorate> Governorates { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<VClientMachine> VClientMachines { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<VClientMachine>().ToView("VClientMachines");
            builder.Entity<VClientVersion>(entity =>
            {
                entity.ToView("VClientVersions");
            });
            builder.Entity<Country>(entity =>
            {
                entity.Property(p => p.Id).ValueGeneratedNever();
            });
            builder.Entity<Governorate>(entity =>
            {
                entity.Property(p => p.Id).ValueGeneratedNever();
            });
            builder.Entity<City>(entity =>
            {
                entity.Property(p => p.Id).ValueGeneratedNever();
            });
            base.OnModelCreating(builder);

        }
    }
}
