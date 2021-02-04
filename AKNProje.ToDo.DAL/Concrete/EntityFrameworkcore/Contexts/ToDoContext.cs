using AKNProje.ToDo.DAL.Concrete.EntityFrameworkcore.Mapping;
using AKNProje.ToDo.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.DAL.Concrete.EntityFrameworkcore.Contexts
{
    public class ToDoContext:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-DL4OHAC; database=ToDo; user id=sa; password=1234;");
            base.OnConfiguring(optionsBuilder);
        }
       
        public DbSet<Gorev> Gorevler { get; set; }
        public DbSet<Aciliyet> Aciliyetler { get; set; }

        public DbSet<Rapor> Raporlar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserMapping());
            modelBuilder.ApplyConfiguration(new RaporMap());
            modelBuilder.ApplyConfiguration(new AciliyetMapping());
            modelBuilder.ApplyConfiguration(new GorevMap());
            base.OnModelCreating(modelBuilder);
        }
    }

}
