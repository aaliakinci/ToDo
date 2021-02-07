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
       
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Urgency> Urgencys { get; set; }

        public DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserMapping());
            modelBuilder.ApplyConfiguration(new ReportMap());
            modelBuilder.ApplyConfiguration(new UrgencyMapping());
            modelBuilder.ApplyConfiguration(new JobMap());
            base.OnModelCreating(modelBuilder);
        }
    }

}
