using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ToDoShared;

public partial class Hue06Context : DbContext
{
    public Hue06Context()
    {
    }

    public Hue06Context(DbContextOptions<Hue06Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Priority> Priorities { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Task> Tasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Filename=../Hue06.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Task>(entity =>
        {
            entity.HasOne(d => d.PriorityNavigation).WithMany(p => p.Tasks).OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.Tasks).OnDelete(DeleteBehavior.SetNull);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
