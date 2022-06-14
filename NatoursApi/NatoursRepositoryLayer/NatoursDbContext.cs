using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using NatoursRepositoryLayer.Model;

namespace NatoursRepositoryLayer
{
    public class NatoursDbContext: DbContext
    {
        public NatoursDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Address> addresses { get; set; }
        public DbSet<Booking> bookings { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Difficulty> difficulties { get; set; }
        public DbSet<Package> packages { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<Status> statuses { get; set; }
    }
}
