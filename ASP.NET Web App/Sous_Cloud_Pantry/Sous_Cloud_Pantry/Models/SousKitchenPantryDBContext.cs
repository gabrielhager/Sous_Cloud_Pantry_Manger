using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Sous_Cloud_Pantry.models
{
    public partial class SousKitchenPantryDBContext : DbContext
    {
        public SousKitchenPantryDBContext()
        {
        }

        public SousKitchenPantryDBContext(DbContextOptions<SousKitchenPantryDBContext> options)
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
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-TCAAKSU;Initial Catalog=SousKitchenPantryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
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

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Calendar__UserID__571DF1D5");
            });

            modelBuilder.Entity<GroceryList>(entity =>
            {
                entity.HasKey(e => e.ListItem)
                    .HasName("PK__Grocery___6A960799ED96A90F");

                entity.ToTable("Grocery_List");

                entity.Property(e => e.ListItem).HasMaxLength(80);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GroceryLists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Grocery_L__UserI__4F7CD00D");
            });

            modelBuilder.Entity<Ingredient>(entity =>
            {
                entity.Property(e => e.IngredientId).HasColumnName("ingredientID");

                entity.Property(e => e.IngredientName)
                    .HasMaxLength(80)
                    .HasColumnName("ingredient_name");

                entity.Property(e => e.MeasurementId).HasColumnName("measurementID");

                entity.HasOne(d => d.Measurement)
                    .WithMany(p => p.Ingredients)
                    .HasForeignKey(d => d.MeasurementId)
                    .HasConstraintName("FK__Ingredien__measu__5AEE82B9");
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
                    .HasName("PK__Pantry__5BD4FA581DF20CDE");

                entity.ToTable("Pantry");

                entity.Property(e => e.PantryLocation).HasMaxLength(40);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Pantries)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Pantry__UserID__5535A963");
            });

            modelBuilder.Entity<Recipe>(entity =>
            {
                entity.Property(e => e.RecipeId).HasColumnName("RecipeID");

                entity.Property(e => e.IngredientList)
                    .HasMaxLength(80)
                    .HasColumnName("Ingredient_List");

                entity.Property(e => e.Title).HasMaxLength(40);

                entity.HasOne(d => d.IngredientListNavigation)
                    .WithMany(p => p.Recipes)
                    .HasForeignKey(d => d.IngredientList)
                    .HasConstraintName("FK__Recipes__Ingredi__52593CB8");
            });

            modelBuilder.Entity<UserTable>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserTabl__1788CCAC312D29A2");

                entity.ToTable("UserTable");

                entity.Property(e => e.UserId).HasColumnName("UserID");

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
