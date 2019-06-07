﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace eTermin.Models {
    public class DatabaseContext : DbContext {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {
        }

        public DbSet<Administrator> Administrator { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Hall> Hall { get; set; }
        public DbSet<Log> Log { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<SportCentre> SportCentre { get; set; }
        public DbSet<Subscription> Subscription { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Administrator>().ToTable("Administrator");
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Hall>().ToTable("Hall");
            modelBuilder.Entity<Log>().ToTable("Log");
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Reservation>().ToTable("Reservation");
            modelBuilder.Entity<SportCentre>().ToTable("SportCentre");
            modelBuilder.Entity<Subscription>().ToTable("Subscription");
            modelBuilder.Entity<Transaction>().ToTable("Transaction");
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}