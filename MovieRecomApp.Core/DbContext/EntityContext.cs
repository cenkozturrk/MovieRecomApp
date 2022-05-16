﻿using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MovieRecommendation.Core
{
    public class EntityContext : DbContext
    {
        public EntityContext()
        {
        }

        //internal readonly object Configuration;
        //protected readonly IConfiguration Configuration;

        public EntityContext(DbContextOptions<EntityContext> options)
            : base(options)
        {

        }
        public virtual DbSet<Movie> MovieLists { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Movie>();

        //    OnModelCreatingPartial(modelBuilder);

        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    // connect to sql server with connection string from app settings
        //    options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        //}

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}