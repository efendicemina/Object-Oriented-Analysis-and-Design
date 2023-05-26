using LV5.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LV5.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Predmet> Predmet { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<UpisNaPredmet> UpisNaPredmet { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<UpisNaPredmet>().ToTable("UpisNaPredmet");
            modelBuilder.Entity<Predmet>().ToTable("Predmet");
            base.OnModelCreating(modelBuilder);
        }

    }
}
