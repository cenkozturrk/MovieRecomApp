using Entities;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>(entity =>
            {
                base.OnModelCreating(modelBuilder);
                entity.HasNoKey();
                entity.ToTable("Movie");
                entity.Property(e => e.Id).HasColumnName("MovieId");
                entity.Property(e => e.Name).HasMaxLength(15).IsUnicode(false);
                entity.Property(e => e.Note).HasMaxLength(10).IsUnicode(false);


            });

            //protected override void OnConfiguring(DbContextOptionsBuilder options)
            //{
            //    // connect to sql server with connection string from app settings
            //    options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
            //}

            //OnModelCreatingPartial(modelBuilder); ;
        }

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}