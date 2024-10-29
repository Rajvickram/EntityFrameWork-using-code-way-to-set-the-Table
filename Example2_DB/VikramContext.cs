using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Example2_DB;

public partial class VikramContext : DbContext
{
    public VikramContext()
    {
    }

    public VikramContext(DbContextOptions<VikramContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Branch> Branches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server = RAJ_VICKRAM\\SQLEXPRESS;Database = Vikram;Trusted_Connection = True;TrustServerCertificate = True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Branch>(entity =>
        {
            entity.ToTable("Branch");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
