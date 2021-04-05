using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Sous_Cloud_Pantry.Models
{
    public partial class SousDataContext : DbContext
    {
        public SousDataContext()
        {
        }

        public SousDataContext(DbContextOptions<SousDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Calendar> Calendars { get; set; }
        public virtual DbSet<GroceryList> GroceryLists { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<Measurement> Measurements { get; set; }
        public virtual DbSet<Pantry> Pantries { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<UserTable> UserTables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SousData;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Calendar");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<GroceryList>(entity =>
            {
                entity.HasKey(e => e.ListItem)
                    .HasName("PK__Grocery___6A960799FB7A4F71");

                entity.ToTable("Grocery_List");

                entity.Property(e => e.ListItem).HasMaxLength(80);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Ingredient>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IngredientName)
                    .HasMaxLength(80)
                    .HasColumnName("ingredient_name");

                entity.Property(e => e.MeasurementId).HasColumnName("measurementID");
            });

            modelBuilder.Entity<Measurement>(entity =>
            {
                entity.Property(e => e.MeasurementId)
                    .ValueGeneratedNever()
                    .HasColumnName("measurementID");

                entity.Property(e => e.MeasurementMethod)
                    .HasMaxLength(40)
                    .HasColumnName("measurementMethod");
            });

            modelBuilder.Entity<Pantry>(entity =>
            {
                entity.HasKey(e => e.PantryLocation)
                    .HasName("PK__Pantry__5BD4FA589195CAA0");

                entity.ToTable("Pantry");

                entity.Property(e => e.PantryLocation).HasMaxLength(40);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Recipe>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IngredientList)
                    .HasMaxLength(80)
                    .HasColumnName("Ingredient_List");

                entity.Property(e => e.Title).HasMaxLength(40);
            });

            modelBuilder.Entity<UserTable>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserTabl__1788CCAC12164DC6");

                entity.ToTable("UserTable");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("UserID");

                entity.Property(e => e.EmailAddress).HasMaxLength(40);

                entity.Property(e => e.UserName).HasMaxLength(40);

                entity.Property(e => e.UserPw)
                    .HasMaxLength(40)
                    .HasColumnName("User_PW");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
