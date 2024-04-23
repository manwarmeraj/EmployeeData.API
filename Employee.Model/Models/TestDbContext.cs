using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Employee.Entity.Models;

public partial class TestDbContext : DbContext
{
    public TestDbContext()
    {
    }

    public TestDbContext(DbContextOptions<TestDbContext> options, IConfiguration configuration)
        : base(options)
    {
    }

    public virtual DbSet<AddressMaster> AddressMasters { get; set; }
    public virtual DbSet<EmployeeMaster> EmployeeMasters { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AddressMaster>(entity =>
        {
            entity.HasKey(e => e.AddressId);

            entity.ToTable("AddressMaster");

            entity.Property(e => e.AddressId).ValueGeneratedNever();
            entity.Property(e => e.Address).HasMaxLength(350);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Employee).WithMany(p => p.AddressMasters)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_AddressMaster_EmployeeMaster");
        });

        modelBuilder.Entity<EmployeeMaster>(entity =>
        {
            entity.HasKey(e => e.EmployeeId);

            entity.ToTable("EmployeeMaster");

            entity.Property(e => e.EmployeeId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Designation).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(150);
        });
    }
}
