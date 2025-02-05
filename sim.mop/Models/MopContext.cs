using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace sim.mop.Models;

public partial class MopContext : DbContext
{
    public MopContext()
    {
    }

    public MopContext(DbContextOptions<MopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dlib> Dlibs { get; set; }

    public virtual DbSet<Glib> Glibs { get; set; }

    public virtual DbSet<Nlib> Nlibs { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<Rlib> Rlibs { get; set; }

    public virtual DbSet<Slib> Slibs { get; set; }

    public virtual DbSet<TblCertificated> TblCertificateds { get; set; }

    public virtual DbSet<TblConstructPlan> TblConstructPlans { get; set; }

    public virtual DbSet<TblInternalConstruct> TblInternalConstructs { get; set; }

    public virtual DbSet<TblMainCompany> TblMainCompanies { get; set; }

    public virtual DbSet<TblMginfo> TblMginfos { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    public virtual DbSet<VwDataTable> VwDataTables { get; set; }

    public virtual DbSet<VwIntenalConstructionIndex> VwIntenalConstructionIndexes { get; set; }

    public virtual DbSet<VwInternalConstruct> VwInternalConstructs { get; set; }

    public virtual DbSet<VwInternalConstructionIndexesReport> VwInternalConstructionIndexesReports { get; set; }

    public virtual DbSet<VwMginfo> VwMginfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.; Database=Mop; Persist Security Info=True;User ID=sa;Password=saMaster1819!@;Trusted_Connection=True;TrustServerCertificate=True;timeout=100;Integrated Security=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<Dlib>(entity =>
        {
            entity.HasKey(e => e.FldId);

            entity.ToTable("DLib");

            entity.Property(e => e.FldId).HasColumnName("fldID");
            entity.Property(e => e.FldDesc).HasColumnName("fldDesc");
            entity.Property(e => e.FldDescHeader).HasColumnName("fldDescHeader");
            entity.Property(e => e.FldDescItem).HasColumnName("fldDescItem");
            entity.Property(e => e.FldDescSubHeader).HasColumnName("fldDescSubHeader");
            entity.Property(e => e.FldIndecator)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldIndecator");
            entity.Property(e => e.FldMainGroup)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldMainGroup");
            entity.Property(e => e.FldMesc)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldMESC");
            entity.Property(e => e.FldMesccenter)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("fldMESCCenter");
            entity.Property(e => e.FldMescfull)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("fldMESCFull");
            entity.Property(e => e.FldMeschasInventory).HasColumnName("fldMESCHasInventory");
            entity.Property(e => e.FldPartNo)
                .HasMaxLength(50)
                .HasColumnName("fldPartNo");
            entity.Property(e => e.FldStandardCode)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("fldStandardCode");
            entity.Property(e => e.FldUnit)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("fldUnit");
        });

        modelBuilder.Entity<Glib>(entity =>
        {
            entity.HasKey(e => e.FldId);

            entity.ToTable("GLib");

            entity.Property(e => e.FldId).HasColumnName("fldID");
            entity.Property(e => e.FldDesc).HasColumnName("fldDesc");
            entity.Property(e => e.FldDescHeader).HasColumnName("fldDescHeader");
            entity.Property(e => e.FldDescItem).HasColumnName("fldDescItem");
            entity.Property(e => e.FldDescSubHeader).HasColumnName("fldDescSubHeader");
            entity.Property(e => e.FldIndecator)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldIndecator");
            entity.Property(e => e.FldMainGroup)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldMainGroup");
            entity.Property(e => e.FldMesc)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldMESC");
            entity.Property(e => e.FldMesccenter)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("fldMESCCenter");
            entity.Property(e => e.FldMescfull)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("fldMESCFull");
            entity.Property(e => e.FldMeschasInventory).HasColumnName("fldMESCHasInventory");
            entity.Property(e => e.FldPartNo)
                .HasMaxLength(50)
                .HasColumnName("fldPartNo");
            entity.Property(e => e.FldStandardCode)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("fldStandardCode");
            entity.Property(e => e.FldUnit)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("fldUnit");
        });

        modelBuilder.Entity<Nlib>(entity =>
        {
            entity.HasKey(e => e.FldId);

            entity.ToTable("NLib");

            entity.Property(e => e.FldId).HasColumnName("fldID");
            entity.Property(e => e.FldDesc).HasColumnName("fldDesc");
            entity.Property(e => e.FldDescHeader).HasColumnName("fldDescHeader");
            entity.Property(e => e.FldDescItem).HasColumnName("fldDescItem");
            entity.Property(e => e.FldDescSubHeader).HasColumnName("fldDescSubHeader");
            entity.Property(e => e.FldIndecator)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldIndecator");
            entity.Property(e => e.FldMainGroup)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldMainGroup");
            entity.Property(e => e.FldMesc)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldMESC");
            entity.Property(e => e.FldMesccenter)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("fldMESCCenter");
            entity.Property(e => e.FldMescfull)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("fldMESCFull");
            entity.Property(e => e.FldMeschasInventory).HasColumnName("fldMESCHasInventory");
            entity.Property(e => e.FldPartNo)
                .HasMaxLength(50)
                .HasColumnName("fldPartNo");
            entity.Property(e => e.FldStandardCode)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("fldStandardCode");
            entity.Property(e => e.FldUnit)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("fldUnit");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasKey(e => e.FldId);

            entity.ToTable("report");

            entity.Property(e => e.FldId).HasColumnName("fldID");
            entity.Property(e => e.FldCertPlanYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldCertPlanYear");
            entity.Property(e => e.FldCertRefrence)
                .HasMaxLength(100)
                .HasColumnName("fldCertRefrence");
            entity.Property(e => e.FldConstructPlanYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldConstructPlanYear");
            entity.Property(e => e.FldConstructorId)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("fldConstructorID");
            entity.Property(e => e.FldConstructorName)
                .HasMaxLength(50)
                .HasColumnName("fldConstructorName");
            entity.Property(e => e.FldDepth).HasColumnName("fldDepth");
            entity.Property(e => e.FldDescHeader).HasColumnName("fldDescHeader");
            entity.Property(e => e.FldHasCert).HasColumnName("fldHasCert");
            entity.Property(e => e.FldInternalConstruct).HasColumnName("fldInternalConstruct");
            entity.Property(e => e.FldMesc)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldMESC");
            entity.Property(e => e.FldMesccenter)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("fldMESCCenter");
            entity.Property(e => e.FldMgcode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldMGCode");
            entity.Property(e => e.FldNeedOfYear).HasColumnName("fldNeedOfYear");
            entity.Property(e => e.FldPorMasraf).HasColumnName("fldPorMasraf");
            entity.Property(e => e.FldRahbordi).HasColumnName("fldRahbordi");
            entity.Property(e => e.FldRegUser)
                .HasMaxLength(50)
                .HasColumnName("fldRegUser");
            entity.Property(e => e.FldRegisterDate)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldRegisterDate");
            entity.Property(e => e.FldType)
                .HasMaxLength(20)
                .HasColumnName("fldType");
            entity.Property(e => e.FldUnit)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldUnit");
            entity.Property(e => e.FldValue)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("fldValue");
        });

        modelBuilder.Entity<Rlib>(entity =>
        {
            entity.HasKey(e => e.FldId);

            entity.ToTable("RLib");

            entity.Property(e => e.FldId).HasColumnName("fldID");
            entity.Property(e => e.FldDesc).HasColumnName("fldDesc");
            entity.Property(e => e.FldDescHeader).HasColumnName("fldDescHeader");
            entity.Property(e => e.FldDescItem).HasColumnName("fldDescItem");
            entity.Property(e => e.FldDescSubHeader).HasColumnName("fldDescSubHeader");
            entity.Property(e => e.FldIndecator)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldIndecator");
            entity.Property(e => e.FldMainGroup)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldMainGroup");
            entity.Property(e => e.FldMesc)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldMESC");
            entity.Property(e => e.FldMesccenter)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("fldMESCCenter");
            entity.Property(e => e.FldMescfull)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("fldMESCFull");
            entity.Property(e => e.FldMeschasInventory).HasColumnName("fldMESCHasInventory");
            entity.Property(e => e.FldPartNo)
                .HasMaxLength(50)
                .HasColumnName("fldPartNo");
            entity.Property(e => e.FldStandardCode)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("fldStandardCode");
            entity.Property(e => e.FldUnit)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("fldUnit");
        });

        modelBuilder.Entity<Slib>(entity =>
        {
            entity.HasKey(e => e.FldId);

            entity.ToTable("SLib");

            entity.Property(e => e.FldId).HasColumnName("fldID");
            entity.Property(e => e.FldDesc).HasColumnName("fldDesc");
            entity.Property(e => e.FldDescHeader).HasColumnName("fldDescHeader");
            entity.Property(e => e.FldDescItem).HasColumnName("fldDescItem");
            entity.Property(e => e.FldDescSubHeader).HasColumnName("fldDescSubHeader");
            entity.Property(e => e.FldIndecator)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldIndecator");
            entity.Property(e => e.FldMainGroup)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldMainGroup");
            entity.Property(e => e.FldMesc)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldMESC");
            entity.Property(e => e.FldMesccenter)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("fldMESCCenter");
            entity.Property(e => e.FldMescfull)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("fldMESCFull");
            entity.Property(e => e.FldMeschasInventory).HasColumnName("fldMESCHasInventory");
            entity.Property(e => e.FldPartNo)
                .HasMaxLength(50)
                .HasColumnName("fldPartNo");
            entity.Property(e => e.FldStandardCode)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("fldStandardCode");
            entity.Property(e => e.FldUnit)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("fldUnit");
        });

        modelBuilder.Entity<TblCertificated>(entity =>
        {
            entity.HasKey(e => e.FldId);

            entity.ToTable("tblCertificated");

            entity.Property(e => e.FldId).HasColumnName("fldID");
            entity.Property(e => e.FldCertPlanYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldCertPlanYear");
            entity.Property(e => e.FldCertRefrence)
                .HasMaxLength(100)
                .HasColumnName("fldCertRefrence");
            entity.Property(e => e.FldDescHeader).HasColumnName("fldDescHeader");
            entity.Property(e => e.FldHasCert).HasColumnName("fldHasCert");
            entity.Property(e => e.FldMesc)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldMESC");
            entity.Property(e => e.FldMesccenter)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("fldMESCCenter");
            entity.Property(e => e.FldMgcode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldMGCode");
            entity.Property(e => e.FldRegUser)
                .HasMaxLength(50)
                .HasColumnName("fldRegUser");
            entity.Property(e => e.FldRegisterDate)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldRegisterDate");
            entity.Property(e => e.FldUnit)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldUnit");
        });

        modelBuilder.Entity<TblConstructPlan>(entity =>
        {
            entity.HasKey(e => e.FldId);

            entity.ToTable("tblConstructPlan");

            entity.Property(e => e.FldId).HasColumnName("fldId");
            entity.Property(e => e.FldMesc)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldMESC");
            entity.Property(e => e.FldMesccenter)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldMESCCenter");
            entity.Property(e => e.FldMgCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldMgCode");
            entity.Property(e => e.FldRegisterUser)
                .HasMaxLength(50)
                .HasColumnName("fldRegisterUser");
            entity.Property(e => e.FldRegsiterDate)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldRegsiterDate");
            entity.Property(e => e.FldUnit)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldUnit");
            entity.Property(e => e.FldYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldYear");
        });

        modelBuilder.Entity<TblInternalConstruct>(entity =>
        {
            entity.HasKey(e => e.fldID);

            entity.ToTable("tblInternalConstruct");

            entity.Property(e => e.fldID).HasColumnName("fldID");
            entity.Property(e => e.fldCertPlanYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldCertPlanYear");
            entity.Property(e => e.fldCertRefrence)
                .HasMaxLength(100)
                .HasColumnName("fldCertRefrence");
            entity.Property(e => e.fldConstructPlanYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldConstructPlanYear");
            entity.Property(e => e.fldConstructorId)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("fldConstructorID");
            entity.Property(e => e.fldConstructorName)
                .HasMaxLength(50)
                .HasColumnName("fldConstructorName");
            entity.Property(e => e.fldDepth).HasColumnName("fldDepth");
            entity.Property(e => e.fldDescHeader).HasColumnName("fldDescHeader");
            entity.Property(e => e.fldHasCert).HasColumnName("fldHasCert");
            entity.Property(e => e.fldInternalConstruct).HasColumnName("fldInternalConstruct");
            entity.Property(e => e.fldMesc)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldMESC");
            entity.Property(e => e.fldMesccenter)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("fldMESCCenter");
            entity.Property(e => e.fldMgcode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldMGCode");
            entity.Property(e => e.fldNeedOfYear).HasColumnName("fldNeedOfYear");
            entity.Property(e => e.fldPorMasraf).HasColumnName("fldPorMasraf");
            entity.Property(e => e.fldRahbordi).HasColumnName("fldRahbordi");
            entity.Property(e => e.fldRegUser)
                .HasMaxLength(50)
                .HasColumnName("fldRegUser");
            entity.Property(e => e.fldRegisterDate)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldRegisterDate");
            entity.Property(e => e.fldType)
                .HasMaxLength(20)
                .HasColumnName("fldType");
            entity.Property(e => e.fldUnit)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldUnit");
            entity.Property(e => e.fldValue)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("fldValue");
        });

        modelBuilder.Entity<TblMainCompany>(entity =>
        {
            entity.HasKey(e => e.FldId);

            entity.ToTable("tblMainCompanies");

            entity.Property(e => e.FldId).HasColumnName("fldId");
            entity.Property(e => e.FldName)
                .HasMaxLength(100)
                .HasColumnName("fldName");
        });

        modelBuilder.Entity<TblMginfo>(entity =>
        {
            entity.HasKey(e => e.FldId);

            entity.ToTable("tblMGInfo");

            entity.Property(e => e.FldId).HasColumnName("fldID");
            entity.Property(e => e.FldMgCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldMgCode");
            entity.Property(e => e.FldMgName)
                .HasMaxLength(100)
                .HasColumnName("fldMgName");
            entity.Property(e => e.FldParentId).HasColumnName("fldParentId");
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.HasKey(e => e.fldId);

            entity.ToTable("tblUser");

            entity.Property(e => e.fldId)
                .ValueGeneratedNever()
                .HasColumnName("fldId");
            entity.Property(e => e.fldIsActive).HasColumnName("fldIsActive");
            entity.Property(e => e.fldMGCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldMGCode");
            entity.Property(e => e.fldName)
                .HasMaxLength(50)
                .HasColumnName("fldName");
            entity.Property(e => e.fldPassword)
                .HasMaxLength(20)
                .HasColumnName("fldPassword");
            entity.Property(e => e.fldPermission)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldPermission");
            entity.Property(e => e.fldUserName)
                .HasMaxLength(20)
                .HasColumnName("fldUserName");
        });

        modelBuilder.Entity<VwDataTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwDataTable");

            entity.Property(e => e.Expr1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.fldCertPlanYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldCertPlanYear");
            entity.Property(e => e.fldCertRefrence)
                .HasMaxLength(100)
                .HasColumnName("fldCertRefrence");
            entity.Property(e => e.fldConstructPlanYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldConstructPlanYear");
            entity.Property(e => e.fldConstructorID)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("fldConstructorID");
            entity.Property(e => e.fldConstructorName)
                .HasMaxLength(50)
                .HasColumnName("fldConstructorName");
            entity.Property(e => e.fldDepth).HasColumnName("fldDepth");
            entity.Property(e => e.fldDescHeader).HasColumnName("fldDescHeader");
            entity.Property(e => e.fldHasCert).HasColumnName("fldHasCert");
            entity.Property(e => e.fldID).HasColumnName("fldID");
            entity.Property(e => e.fldInternalConstruct).HasColumnName("fldInternalConstruct");
            entity.Property(e => e.fldMESC)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldMESC");
            entity.Property(e => e.fldMesccenter)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("fldMESCCenter");
            entity.Property(e => e.fldMGCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldMGCode");
            entity.Property(e => e.fldName)
                .HasMaxLength(50)
                .HasColumnName("fldName");
            entity.Property(e => e.fldNeedOfYear).HasColumnName("fldNeedOfYear");
            entity.Property(e => e.fldPorMasraf).HasColumnName("fldPorMasraf");
            entity.Property(e => e.fldRahbordi).HasColumnName("fldRahbordi");
            entity.Property(e => e.fldRegUser)
                .HasMaxLength(50)
                .HasColumnName("fldRegUser");
            entity.Property(e => e.fldRegisterDate)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldRegisterDate");
            entity.Property(e => e.fldType)
                .HasMaxLength(20)
                .HasColumnName("fldType");
            entity.Property(e => e.fldUnit)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldUnit");
            entity.Property(e => e.fldUserName)
                .HasMaxLength(20)
                .HasColumnName("fldUserName");
            entity.Property(e => e.fldValue)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("fldValue");
        });

        modelBuilder.Entity<VwIntenalConstructionIndex>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwIntenalConstructionIndexes");

            entity.Property(e => e.FldMgcode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldMGCode");
            entity.Property(e => e.InternalConstCountIndex).HasColumnName("internalConstCountIndex");
            entity.Property(e => e.InternalConstValueIndex).HasColumnName("internalConstValueIndex");
            entity.Property(e => e.InternalConstructItemCount).HasColumnName("internalConstructItemCount");
            entity.Property(e => e.InternalConstructItemsValue)
                .HasColumnType("decimal(38, 0)")
                .HasColumnName("internalConstructItemsValue");
            entity.Property(e => e.ItemCount).HasColumnName("itemCount");
            entity.Property(e => e.ItemsValue)
                .HasColumnType("decimal(38, 0)")
                .HasColumnName("itemsValue");
            entity.Property(e => e.TargetConstCount).HasColumnName("targetConstCount");
            entity.Property(e => e.TargetConstValue)
                .HasColumnType("decimal(38, 0)")
                .HasColumnName("targetConstValue");
        });

        modelBuilder.Entity<VwInternalConstruct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwInternalConstruct");

            entity.Property(e => e.FldCertPlanYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldCertPlanYear");
            entity.Property(e => e.FldCertRefrence)
                .HasMaxLength(100)
                .HasColumnName("fldCertRefrence");
            entity.Property(e => e.FldConstructPlanYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldConstructPlanYear");
            entity.Property(e => e.FldConstructorId)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("fldConstructorID");
            entity.Property(e => e.FldConstructorName)
                .HasMaxLength(50)
                .HasColumnName("fldConstructorName");
            entity.Property(e => e.FldDepth).HasColumnName("fldDepth");
            entity.Property(e => e.FldDescHeader).HasColumnName("fldDescHeader");
            entity.Property(e => e.FldHasCert).HasColumnName("fldHasCert");
            entity.Property(e => e.FldId).HasColumnName("fldID");
            entity.Property(e => e.FldInternalConstruct).HasColumnName("fldInternalConstruct");
            entity.Property(e => e.FldMesc)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldMESC");
            entity.Property(e => e.FldMesccenter)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("fldMESCCenter");
            entity.Property(e => e.FldMgName)
                .HasMaxLength(100)
                .HasColumnName("fldMgName");
            entity.Property(e => e.FldMgcode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldMGCode");
            entity.Property(e => e.FldNeedOfYear).HasColumnName("fldNeedOfYear");
            entity.Property(e => e.FldPorMasraf).HasColumnName("fldPorMasraf");
            entity.Property(e => e.FldRahbordi).HasColumnName("fldRahbordi");
            entity.Property(e => e.FldRegUser)
                .HasMaxLength(50)
                .HasColumnName("fldRegUser");
            entity.Property(e => e.FldRegisterDate)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldRegisterDate");
            entity.Property(e => e.FldType)
                .HasMaxLength(20)
                .HasColumnName("fldType");
            entity.Property(e => e.FldUnit)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fldUnit");
            entity.Property(e => e.FldValue)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("fldValue");
        });

        modelBuilder.Entity<VwInternalConstructionIndexesReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwInternalConstructionIndexesReport");

            entity.Property(e => e.FldMgName)
                .HasMaxLength(100)
                .HasColumnName("fldMgName");
            entity.Property(e => e.FldMgcode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldMGCode");
            entity.Property(e => e.InternalConstCountIndex).HasColumnName("internalConstCountIndex");
            entity.Property(e => e.InternalConstValueIndex).HasColumnName("internalConstValueIndex");
            entity.Property(e => e.InternalConstructItemCount).HasColumnName("internalConstructItemCount");
            entity.Property(e => e.InternalConstructItemsValue)
                .HasColumnType("decimal(38, 0)")
                .HasColumnName("internalConstructItemsValue");
            entity.Property(e => e.ItemCount).HasColumnName("itemCount");
            entity.Property(e => e.ItemsValue)
                .HasColumnType("decimal(38, 0)")
                .HasColumnName("itemsValue");
            entity.Property(e => e.TargetConstCount).HasColumnName("targetConstCount");
            entity.Property(e => e.TargetConstValue)
                .HasColumnType("decimal(38, 0)")
                .HasColumnName("targetConstValue");
        });

        modelBuilder.Entity<VwMginfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMGInfo");

            entity.Property(e => e.FldId).HasColumnName("fldId");
            entity.Property(e => e.FldMgCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fldMgCode");
            entity.Property(e => e.FldMgName)
                .HasMaxLength(100)
                .HasColumnName("fldMgName");
            entity.Property(e => e.FldName)
                .HasMaxLength(100)
                .HasColumnName("fldName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
