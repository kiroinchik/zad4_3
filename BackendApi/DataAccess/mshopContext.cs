using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace Domain.Models
{
    public partial class mshopContext : DbContext
    {
        public mshopContext()
        {
        }

        public mshopContext(DbContextOptions<mshopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; } = null!;
        public virtual DbSet<CartCompound> CartCompounds { get; set; } = null!;
        public virtual DbSet<CartInf> CartInfs { get; set; } = null!;
        public virtual DbSet<Filter> Filters { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Booking");

                entity.Property(e => e.Adress)
                    .HasColumnType("text")
                    .HasColumnName("adress");

                entity.Property(e => e.BId).HasColumnName("b_id");

                entity.Property(e => e.BStatus).HasColumnName("b_status");

                entity.Property(e => e.CId).HasColumnName("c_id");

                entity.Property(e => e.Delivery).HasColumnName("delivery");

                entity.Property(e => e.Pickup).HasColumnName("pickup");

                entity.Property(e => e.TotalPrice).HasColumnName("total_price");

                entity.Property(e => e.UId).HasColumnName("u_id");
            });

            modelBuilder.Entity<CartCompound>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CartCompound");

                entity.Property(e => e.CId).HasColumnName("c_id");

                entity.Property(e => e.PId).HasColumnName("p_id");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<CartInf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cart_inf");

                entity.Property(e => e.CId).HasColumnName("c_id");

                entity.Property(e => e.UId).HasColumnName("u_id");
            });

            modelBuilder.Entity<Filter>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Color)
                    .HasColumnType("text")
                    .HasColumnName("color");

                entity.Property(e => e.PId).HasColumnName("p_id");

                entity.Property(e => e.PType)
                    .HasColumnType("text")
                    .HasColumnName("p_type");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Shiny).HasColumnName("shiny");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Product");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Color)
                    .HasColumnType("text")
                    .HasColumnName("color");

                entity.Property(e => e.PDesc)
                    .HasColumnType("text")
                    .HasColumnName("p_desc");

                entity.Property(e => e.PId).HasColumnName("p_id");

                entity.Property(e => e.PName)
                    .HasColumnType("text")
                    .HasColumnName("p_name");

                entity.Property(e => e.PType)
                    .HasColumnType("text")
                    .HasColumnName("p_type");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Shiny).HasColumnName("shiny");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.UEmail)
                    .HasColumnType("text")
                    .HasColumnName("u_email");

                entity.Property(e => e.UId).HasColumnName("u_id");

                entity.Property(e => e.UName)
                    .HasColumnType("text")
                    .HasColumnName("u_name");

                entity.Property(e => e.UPassword)
                    .HasColumnType("text")
                    .HasColumnName("u_password");

                entity.Property(e => e.UPhNumber)
                    .HasColumnType("text")
                    .HasColumnName("u_ph_number");

                entity.Property(e => e.URole)
                    .HasColumnType("text")
                    .HasColumnName("u_role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
