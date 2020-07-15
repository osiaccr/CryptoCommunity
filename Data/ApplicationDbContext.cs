using System;
using System.Collections.Generic;
using System.Text;
using CryptoCommunity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CryptoCommunity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ListingType> ListingTypes { get; set; }
        public DbSet<Listing> Listings { get; set; }
        public DbSet<Socialmedia> Socialmedias { get; set; }

        public DbSet<SocialmediaType> SocialmediaTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ListingType>().ToTable("ListingType");
            builder.Entity<Listing>().ToTable("Listing");
            builder.Entity<Socialmedia>().ToTable("Socialmedia");
            builder.Entity<SocialmediaType>().ToTable("SocialmediaType");
        }
    }
}
