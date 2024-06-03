using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace RoleBasedAccessManagement.Infrastructure.Models;

public partial class RaoMitContext : DbContext
{
   

    public RaoMitContext(DbContextOptions options)
        : base(options)
    {
    }
    //public RaoMitContext()
    //{

    //}

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RolesMenu> RolesMenus { get; set; }

    public virtual DbSet<RolesUser> RolesUsers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    

    //protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(configurationManager.GetConnectionString("DefaultConnection"));

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Menu>(entity =>
    //    {
    //        entity.HasKey(e => e.MenuId).HasName("PK__Menu__3B4071749EA46975");

    //        entity.ToTable("Menu");

    //        entity.Property(e => e.MenuId).HasColumnName("menuId");
    //        entity.Property(e => e.MenuNavigationLink)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasDefaultValue("/NonAdminUsers/Index")
    //            .HasColumnName("menuNavigationLink");
    //        entity.Property(e => e.MenuType)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("menuType");
    //    });

    //    modelBuilder.Entity<Role>(entity =>
    //    {
    //        entity.HasKey(e => e.RoleId).HasName("PK__Role__CD98462A4A6C716D");

    //        entity.ToTable("Role");

    //        entity.Property(e => e.RoleId).HasColumnName("roleId");
    //        entity.Property(e => e.RoleType)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("roleType");
    //    });

    //    modelBuilder.Entity<RolesMenu>(entity =>
    //    {
    //        entity.HasKey(e => e.Id).HasName("PK__RolesMen__3213E83F24C66C8D");

    //        entity.Property(e => e.Id).HasColumnName("id");
    //        entity.Property(e => e.MenuId).HasColumnName("menuId");
    //        entity.Property(e => e.RoleId).HasColumnName("roleId");

    //        entity.HasOne(d => d.Menu).WithMany(p => p.RolesMenus)
    //            .HasForeignKey(d => d.MenuId)
    //            .HasConstraintName("FK__RolesMenu__menuI__440B1D61");

    //        entity.HasOne(d => d.Role).WithMany(p => p.RolesMenus)
    //            .HasForeignKey(d => d.RoleId)
    //            .HasConstraintName("FK__RolesMenu__roleI__4316F928");
    //    });

    //    modelBuilder.Entity<RolesUser>(entity =>
    //    {
    //        entity.HasKey(e => e.Id).HasName("PK__RolesUse__3213E83FD080215B");

    //        entity.Property(e => e.Id).HasColumnName("id");
    //        entity.Property(e => e.RoleId).HasColumnName("roleId");
    //        entity.Property(e => e.UserId).HasColumnName("userId");

    //        entity.HasOne(d => d.Role).WithMany(p => p.RolesUsers)
    //            .HasForeignKey(d => d.RoleId)
    //            .HasConstraintName("FK__RolesUser__roleI__3F466844");

    //        entity.HasOne(d => d.User).WithMany(p => p.RolesUsers)
    //            .HasForeignKey(d => d.UserId)
    //            .OnDelete(DeleteBehavior.SetNull)
    //            .HasConstraintName("FK_RolesUsers_Users");
    //    });

    //    modelBuilder.Entity<User>(entity =>
    //    {
    //        entity.HasKey(e => e.UserId).HasName("PK__Users__CB9A1CFFEDF9B8A9");

    //        entity.Property(e => e.UserId).HasColumnName("userId");
    //        entity.Property(e => e.BirthDate)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("birthDate");
    //        entity.Property(e => e.ContactNo)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("contactNo");
    //        entity.Property(e => e.Email)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("email");
    //        entity.Property(e => e.FullName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("fullName");
    //        entity.Property(e => e.Password)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("password");
    //        entity.Property(e => e.Type)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("type");
    //    });

    //    OnModelCreatingPartial(modelBuilder);
    //}

    //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
