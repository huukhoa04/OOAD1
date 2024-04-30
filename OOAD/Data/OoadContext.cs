using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OOAD.Data;

public partial class OoadContext : DbContext
{
    public OoadContext()
    {
    }

    public OoadContext(DbContextOptions<OoadContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<Reminder> Reminders { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-V3LDFHK\\RESOLVED;Initial Catalog=OOAD;User ID=khoa;Password=huukhoa1+2;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.AptId).HasName("PK_APT");

            entity.ToTable("APPOINTMENT");

            entity.Property(e => e.AptId)
                .ValueGeneratedNever()
                .HasColumnName("APT_ID");
            entity.Property(e => e.AptEndTime)
                .HasColumnType("datetime")
                .HasColumnName("APT_END_TIME");
            entity.Property(e => e.AptLocation)
                .HasMaxLength(200)
                .HasColumnName("APT_LOCATION");
            entity.Property(e => e.AptName)
                .HasMaxLength(50)
                .HasColumnName("APT_NAME");
            entity.Property(e => e.AptStartTime)
                .HasColumnType("datetime")
                .HasColumnName("APT_START_TIME");
            entity.Property(e => e.Userid).HasColumnName("USERID");

            entity.HasOne(d => d.User).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.Userid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_APT");

            entity.HasMany(d => d.Users).WithMany(p => p.Apts)
                .UsingEntity<Dictionary<string, object>>(
                    "Groupmeeting",
                    r => r.HasOne<User>().WithMany()
                        .HasForeignKey("Userid")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_USER_GM"),
                    l => l.HasOne<Appointment>().WithMany()
                        .HasForeignKey("AptId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_APT_GM"),
                    j =>
                    {
                        j.HasKey("AptId", "Userid");
                        j.ToTable("GROUPMEETING");
                        j.IndexerProperty<int>("AptId").HasColumnName("APT_ID");
                        j.IndexerProperty<int>("Userid").HasColumnName("USERID");
                    });
        });

        modelBuilder.Entity<Reminder>(entity =>
        {
            entity.HasKey(e => new { e.AptId, e.RmdTime }).HasName("FK_RMD_APT_ID");

            entity.ToTable("REMINDER");

            entity.Property(e => e.AptId).HasColumnName("APT_ID");
            entity.Property(e => e.RmdTime)
                .HasColumnType("datetime")
                .HasColumnName("RMD_TIME");

            entity.HasOne(d => d.Apt).WithMany(p => p.Reminders)
                .HasForeignKey(d => d.AptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APT_REMINDER");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Userid).HasName("PK_USERID");

            entity.ToTable("USER");

            entity.Property(e => e.Userid)
                .ValueGeneratedNever()
                .HasColumnName("USERID");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("USERNAME");
            entity.Property(e => e.UsernameLog)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USERNAME_LOG");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
