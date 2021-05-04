using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace GolfStats.Models
{
    public partial class GolfStatsContext : DbContext
    {
        public GolfStatsContext()
        {
        }

        public GolfStatsContext(DbContextOptions<GolfStatsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TCourse> TCourse { get; set; }
        public virtual DbSet<TPlayer> TPlayer { get; set; }
        public virtual DbSet<TScore> TScore { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TCourse>(entity =>
            {
                entity.ToTable("t_course");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Hole10Par).HasColumnName("hole_10_par");

                entity.Property(e => e.Hole11Par).HasColumnName("hole_11_par");

                entity.Property(e => e.Hole12Par).HasColumnName("hole_12_par");

                entity.Property(e => e.Hole13Par).HasColumnName("hole_13_par");

                entity.Property(e => e.Hole14Par).HasColumnName("hole_14_par");

                entity.Property(e => e.Hole15Par).HasColumnName("hole_15_par");

                entity.Property(e => e.Hole16Par).HasColumnName("hole_16_par");

                entity.Property(e => e.Hole17Par).HasColumnName("hole_17_par");

                entity.Property(e => e.Hole18Par).HasColumnName("hole_18_par");

                entity.Property(e => e.Hole1Par).HasColumnName("hole_1_par");

                entity.Property(e => e.Hole2Par).HasColumnName("hole_2_par");

                entity.Property(e => e.Hole3Par).HasColumnName("hole_3_par");

                entity.Property(e => e.Hole4Par).HasColumnName("hole_4_par");

                entity.Property(e => e.Hole5Par).HasColumnName("hole_5_par");

                entity.Property(e => e.Hole6Par).HasColumnName("hole_6_par");

                entity.Property(e => e.Hole7Par).HasColumnName("hole_7_par");

                entity.Property(e => e.Hole8Par).HasColumnName("hole_8_par");

                entity.Property(e => e.Hole9Par).HasColumnName("hole_9_par");
            });

            modelBuilder.Entity<TPlayer>(entity =>
            {
                entity.ToTable("t_player");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(50);

                entity.Property(e => e.Handicap)
                    .HasColumnName("handicap")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TScore>(entity =>
            {
                entity.ToTable("t_score");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Hole1).HasColumnName("hole_1");

                entity.Property(e => e.Hole10).HasColumnName("hole_10");

                entity.Property(e => e.Hole11).HasColumnName("hole_11");

                entity.Property(e => e.Hole12).HasColumnName("hole_12");

                entity.Property(e => e.Hole13).HasColumnName("hole_13");

                entity.Property(e => e.Hole14).HasColumnName("hole_14");

                entity.Property(e => e.Hole15).HasColumnName("hole_15");

                entity.Property(e => e.Hole16).HasColumnName("hole_16");

                entity.Property(e => e.Hole17).HasColumnName("hole_17");

                entity.Property(e => e.Hole18).HasColumnName("hole_18");

                entity.Property(e => e.Hole2).HasColumnName("hole_2");

                entity.Property(e => e.Hole3).HasColumnName("hole_3");

                entity.Property(e => e.Hole4).HasColumnName("hole_4");

                entity.Property(e => e.Hole5).HasColumnName("hole_5");

                entity.Property(e => e.Hole6).HasColumnName("hole_6");

                entity.Property(e => e.Hole7).HasColumnName("hole_7");

                entity.Property(e => e.Hole8).HasColumnName("hole_8");

                entity.Property(e => e.Hole9).HasColumnName("hole_9");

                entity.Property(e => e.Score).HasColumnName("score");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
