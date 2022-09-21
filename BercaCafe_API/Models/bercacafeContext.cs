using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BercaCafe_API.Models
{
    public partial class bercacafeContext : DbContext
    {
        public bercacafeContext()
        {
        }

        public bercacafeContext(DbContextOptions<bercacafeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AttrepApplyException> AttrepApplyExceptions { get; set; }
        public virtual DbSet<AttrepChangesBf4d335d7a4fd2c7> AttrepChangesBf4d335d7a4fd2c7s { get; set; }
        public virtual DbSet<MsEmployee> MsEmployees { get; set; }
        public virtual DbSet<MsEmployeeBackup> MsEmployeeBackups { get; set; }
        public virtual DbSet<MsUdc> MsUdcs { get; set; }
        public virtual DbSet<PsJob> PsJobs { get; set; }
        public virtual DbSet<ScAbsen> ScAbsens { get; set; }
        public virtual DbSet<TrAbsenHistory> TrAbsenHistories { get; set; }
        public virtual DbSet<VTest> VTests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=PDEV-Rifqi;database=bercacafe;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AttrepApplyException>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("attrep_apply_exceptions");

                entity.Property(e => e.Error)
                    .IsUnicode(false)
                    .HasColumnName("ERROR");

                entity.Property(e => e.ErrorTime)
                    .HasPrecision(3)
                    .HasColumnName("ERROR_TIME");

                entity.Property(e => e.Statement)
                    .IsUnicode(false)
                    .HasColumnName("STATEMENT");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("TABLE_NAME");

                entity.Property(e => e.TableOwner)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("TABLE_OWNER");

                entity.Property(e => e.TaskName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("TASK_NAME");
            });

            modelBuilder.Entity<AttrepChangesBf4d335d7a4fd2c7>(entity =>
            {
                entity.HasKey(e => e.Seq)
                    .HasName("PK__attrep_c__DDDFBCBE6E11CA64");

                entity.ToTable("attrep_changesBF4D335D7A4FD2C7");

                entity.Property(e => e.Seq)
                    .ValueGeneratedNever()
                    .HasColumnName("seq");

                entity.Property(e => e.Col1)
                    .HasMaxLength(24)
                    .HasColumnName("col1");

                entity.Property(e => e.Col2)
                    .HasMaxLength(24)
                    .HasColumnName("col2");

                entity.Property(e => e.Col3)
                    .HasMaxLength(20)
                    .HasColumnName("col3");

                entity.Property(e => e.Col4)
                    .HasMaxLength(20)
                    .HasColumnName("col4");

                entity.Property(e => e.Col5)
                    .HasMaxLength(20)
                    .HasColumnName("col5");

                entity.Property(e => e.Seg1)
                    .HasMaxLength(20)
                    .HasColumnName("seg1");
            });

            modelBuilder.Entity<MsEmployee>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.EmployeeKey, e.CardNo })
                    .HasName("PK__Ms_Emplo__5FA9ADD9F6496EE9");

                entity.ToTable("Ms_Employee");

                entity.HasIndex(e => e.EmployeeFlag, "emplflag");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CardNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Dept)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EffDt).HasColumnType("date");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HireDt)
                    .HasColumnType("date")
                    .HasColumnName("Hire_DT");

                entity.Property(e => e.TerminationDt).HasColumnType("date");
            });

            modelBuilder.Entity<MsEmployeeBackup>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.EmployeeKey, e.CardNo })
                    .HasName("PK__Ms_Emplo__5FA9ADD9F6496EE9_copy17");

                entity.ToTable("Ms_Employee_backup");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CardNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Dept)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EffDt).HasColumnType("date");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HireDt)
                    .HasColumnType("date")
                    .HasColumnName("Hire_DT");

                entity.Property(e => e.TerminationDt).HasColumnType("date");
            });

            modelBuilder.Entity<MsUdc>(entity =>
            {
                entity.HasKey(e => e.Idudc)
                    .HasName("PK__Ms_UDC__A648B076151FBEB3");

                entity.ToTable("Ms_UDC");

                entity.Property(e => e.Idudc).HasColumnName("IDUDC");

                entity.Property(e => e.Date1)
                    .HasColumnType("date")
                    .HasColumnName("DATE1");

                entity.Property(e => e.Desc1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DESC1");

                entity.Property(e => e.Desc2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DESC2");

                entity.Property(e => e.Desc3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DESC3");

                entity.Property(e => e.Int1).HasColumnName("INT1");

                entity.Property(e => e.Int2).HasColumnName("INT2");

                entity.Property(e => e.Int3).HasColumnName("INT3");

                entity.Property(e => e.Mnum1)
                    .HasColumnType("money")
                    .HasColumnName("MNUM1");

                entity.Property(e => e.Mnum2)
                    .HasColumnType("money")
                    .HasColumnName("MNUM2");

                entity.Property(e => e.TypeUdc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TypeUDC");
            });

            modelBuilder.Entity<PsJob>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PS_JOB");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ACTION");

                entity.Property(e => e.ActionDt)
                    .HasPrecision(0)
                    .HasColumnName("ACTION_DT");

                entity.Property(e => e.ActionReason)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ACTION_REASON");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.Deptid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DEPTID");

                entity.Property(e => e.Effdt)
                    .HasPrecision(0)
                    .HasColumnName("EFFDT");

                entity.Property(e => e.Effseq)
                    .HasColumnType("numeric(38, 0)")
                    .HasColumnName("EFFSEQ");

                entity.Property(e => e.EmplClass)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("EMPL_CLASS");

                entity.Property(e => e.EmplRcd)
                    .HasColumnType("numeric(38, 0)")
                    .HasColumnName("EMPL_RCD");

                entity.Property(e => e.EmplStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EMPL_STATUS");

                entity.Property(e => e.EmplType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EMPL_TYPE");

                entity.Property(e => e.Emplid)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("EMPLID");

                entity.Property(e => e.FlgKuponMakan)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLG_KUPON_MAKAN");

                entity.Property(e => e.HireDt)
                    .HasPrecision(0)
                    .HasColumnName("HIRE_DT");

                entity.Property(e => e.HrStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HR_STATUS");

                entity.Property(e => e.JamKerja)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("JAM_KERJA");

                entity.Property(e => e.LastHireDt)
                    .HasPrecision(0)
                    .HasColumnName("LAST_HIRE_DT");

                entity.Property(e => e.Paygroup)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PAYGROUP");

                entity.Property(e => e.TerminationDt)
                    .HasPrecision(0)
                    .HasColumnName("TERMINATION_DT");

                entity.Property(e => e.WorkLocation)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("WORK_LOCATION");
            });

            modelBuilder.Entity<ScAbsen>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK__USERINFO__7B9E7F355D31AC51");

                entity.ToTable("Sc_Absen");

                entity.Property(e => e.Userid)
                    .ValueGeneratedNever()
                    .HasColumnName("USERID");

                entity.Property(e => e.Badgenumber)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("BADGENUMBER");

                entity.Property(e => e.CardNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SSN");
            });

            modelBuilder.Entity<TrAbsenHistory>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeKey, e.UserId, e.LogTime })
                    .HasName("PK__Tr_Absen__0DD50A096FDFF59E");

                entity.ToTable("Tr_Absen_history");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.LogTime).HasColumnType("datetime");

                entity.Property(e => e.CupId).HasColumnName("CupID");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.TypeMenu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");
            });

            modelBuilder.Entity<VTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_test");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LogTime).HasColumnType("datetime");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
