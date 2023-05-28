using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FarmerShared;

public partial class FirstSqliteContext : DbContext
{
    public FirstSqliteContext()
    {
    }

    public FirstSqliteContext(DbContextOptions<FirstSqliteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Farmer> Farmers { get; set; }

    public virtual DbSet<Field> Fields { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Filename=db/firstSqlite.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Field>(entity =>
        {
            entity.HasOne(d => d.Farmer).WithMany(p => p.Fields).OnDelete(DeleteBehavior.ClientSetNull);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
