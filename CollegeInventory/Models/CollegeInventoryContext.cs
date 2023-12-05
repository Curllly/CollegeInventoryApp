using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CollegeInventory.Models;

public partial class CollegeInventoryContext : DbContext
{
    public CollegeInventoryContext()
    {
    }

    public CollegeInventoryContext(DbContextOptions<CollegeInventoryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Equipment> Equipments { get; set; }

    public virtual DbSet<EquipmentType> EquipmentTypes { get; set; }

    public virtual DbSet<Matrix> Matrices { get; set; }

    public virtual DbSet<ObjectType> ObjectTypes { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<RoomType> RoomTypes { get; set; }

    public virtual DbSet<RoomsEquipment> RoomsEquipments { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server = DESKTOP-8CP2VS3\\SQLEXPRESS; Database = CollegeInventory; TrustServerCertificate=True; Integrated Security = true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Equipment>(entity =>
        {
            entity.HasOne(d => d.Matrix).WithMany(p => p.Equipment)
                .HasForeignKey(d => d.MatrixId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Equipments_Matrix");

            entity.HasOne(d => d.Status).WithMany(p => p.Equipment)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Equipments_Statuses1");
        });

        modelBuilder.Entity<EquipmentType>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.ObjectType).WithMany(p => p.EquipmentTypes)
                .HasForeignKey(d => d.ObjectTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EquipmentTypes_ObjectTypes");
        });

        modelBuilder.Entity<Matrix>(entity =>
        {
            entity.ToTable("Matrix");

            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.EquipmentType).WithMany(p => p.Matrices)
                .HasForeignKey(d => d.EquipmentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Matrix_EquipmentTypes");
        });

        modelBuilder.Entity<ObjectType>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.Property(e => e.Information).HasMaxLength(150);
            entity.Property(e => e.Responsible).HasMaxLength(50);

            entity.HasOne(d => d.RoomType).WithMany(p => p.Rooms)
                .HasForeignKey(d => d.RoomTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rooms_RoomTypes1");
        });

        modelBuilder.Entity<RoomType>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<RoomsEquipment>(entity =>
        {
            entity.HasOne(d => d.Equipment).WithMany(p => p.RoomsEquipments)
                .HasForeignKey(d => d.EquipmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoomsEquipments_Equipments1");

            entity.HasOne(d => d.Room).WithMany(p => p.RoomsEquipments)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoomsEquipments_Rooms1");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
