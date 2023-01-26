using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace apicovid.Models;

public partial class ApirestpruebaContext : DbContext
{
    public ApirestpruebaContext()
    {
    }

    public ApirestpruebaContext(DbContextOptions<ApirestpruebaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<HistoricAllStatesValue> HistoricAllStatesValues { get; set; }

    public virtual DbSet<HistoricUsvalue> HistoricUsvalues { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<Operation> Operations { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<RolOperation> RolOperations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=dperez.database.windows.net;Database=apirestprueba;User Id=dperez; password=Temporal_123;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HistoricAllStatesValue>(entity =>
        {
            entity.HasKey(e => e.HistoricAllStatesId);

            entity.Property(e => e.HistoricAllStatesId).HasColumnName("HistoricAllStates_id");
            entity.Property(e => e.CheckTimeEt)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("checkTimeEt");
            entity.Property(e => e.CommercialScore).HasColumnName("commercialScore");
            entity.Property(e => e.DataQualityGrade)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("dataQualityGrade");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.DateChecked)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("dateChecked");
            entity.Property(e => e.DateModified)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("dateModified");
            entity.Property(e => e.Death).HasColumnName("death");
            entity.Property(e => e.DeathConfirmed).HasColumnName("deathConfirmed");
            entity.Property(e => e.DeathIncrease).HasColumnName("deathIncrease");
            entity.Property(e => e.DeathProbable).HasColumnName("deathProbable");
            entity.Property(e => e.Fips).HasColumnName("fips");
            entity.Property(e => e.Grade)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("grade");
            entity.Property(e => e.Hash)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("hash");
            entity.Property(e => e.Hospitalized).HasColumnName("hospitalized");
            entity.Property(e => e.HospitalizedCumulative).HasColumnName("hospitalizedCumulative");
            entity.Property(e => e.HospitalizedCurrently).HasColumnName("hospitalizedCurrently");
            entity.Property(e => e.HospitalizedDischarged).HasColumnName("hospitalizedDischarged");
            entity.Property(e => e.HospitalizedIncrease).HasColumnName("hospitalizedIncrease");
            entity.Property(e => e.InIcuCumulative).HasColumnName("inIcuCumulative");
            entity.Property(e => e.InIcuCurrently).HasColumnName("inIcuCurrently");
            entity.Property(e => e.LastUpdateEt)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("lastUpdateEt");
            entity.Property(e => e.Negative).HasColumnName("negative");
            entity.Property(e => e.NegativeIncrease).HasColumnName("negativeIncrease");
            entity.Property(e => e.NegativeRegularScore).HasColumnName("negativeRegularScore");
            entity.Property(e => e.NegativeScore).HasColumnName("negativeScore");
            entity.Property(e => e.NegativeTestsAntibody).HasColumnName("negativeTestsAntibody");
            entity.Property(e => e.NegativeTestsPeopleAntibody).HasColumnName("negativeTestsPeopleAntibody");
            entity.Property(e => e.NegativeTestsViral).HasColumnName("negativeTestsViral");
            entity.Property(e => e.OnVentilatorCumulative).HasColumnName("onVentilatorCumulative");
            entity.Property(e => e.OnVentilatorCurrently).HasColumnName("onVentilatorCurrently");
            entity.Property(e => e.Pending).HasColumnName("pending");
            entity.Property(e => e.PosNeg).HasColumnName("posNeg");
            entity.Property(e => e.Positive).HasColumnName("positive");
            entity.Property(e => e.PositiveCasesViral).HasColumnName("positiveCasesViral");
            entity.Property(e => e.PositiveIncrease).HasColumnName("positiveIncrease");
            entity.Property(e => e.PositiveScore).HasColumnName("positiveScore");
            entity.Property(e => e.PositiveTestsAntibody).HasColumnName("positiveTestsAntibody");
            entity.Property(e => e.PositiveTestsAntigen).HasColumnName("positiveTestsAntigen");
            entity.Property(e => e.PositiveTestsPeopleAntibody).HasColumnName("positiveTestsPeopleAntibody");
            entity.Property(e => e.PositiveTestsPeopleAntigen).HasColumnName("positiveTestsPeopleAntigen");
            entity.Property(e => e.PositiveTestsViral).HasColumnName("positiveTestsViral");
            entity.Property(e => e.ProbableCases).HasColumnName("probableCases");
            entity.Property(e => e.Recovered).HasColumnName("recovered");
            entity.Property(e => e.Score).HasColumnName("score");
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("state");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalTestEncountersViral).HasColumnName("totalTestEncountersViral");
            entity.Property(e => e.TotalTestResults).HasColumnName("totalTestResults");
            entity.Property(e => e.TotalTestResultsIncrease).HasColumnName("totalTestResultsIncrease");
            entity.Property(e => e.TotalTestResultsSource)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("totalTestResultsSource");
            entity.Property(e => e.TotalTestsAntibody).HasColumnName("totalTestsAntibody");
            entity.Property(e => e.TotalTestsAntigen).HasColumnName("totalTestsAntigen");
            entity.Property(e => e.TotalTestsPeopleAntibody).HasColumnName("totalTestsPeopleAntibody");
            entity.Property(e => e.TotalTestsPeopleAntigen).HasColumnName("totalTestsPeopleAntigen");
            entity.Property(e => e.TotalTestsPeopleViral).HasColumnName("totalTestsPeopleViral");
            entity.Property(e => e.TotalTestsViral).HasColumnName("totalTestsViral");
        });

        modelBuilder.Entity<HistoricUsvalue>(entity =>
        {
            entity.ToTable("HistoricUSValues");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.DateChecked)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("dateChecked");
            entity.Property(e => e.Death).HasColumnName("death");
            entity.Property(e => e.DeathIncrease).HasColumnName("deathIncrease");
            entity.Property(e => e.Hash)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("hash");
            entity.Property(e => e.Hospitalized).HasColumnName("hospitalized");
            entity.Property(e => e.HospitalizedCumulative).HasColumnName("hospitalizedCumulative");
            entity.Property(e => e.HospitalizedCurrently).HasColumnName("hospitalizedCurrently");
            entity.Property(e => e.HospitalizedIncrease).HasColumnName("hospitalizedIncrease");
            entity.Property(e => e.InIcuCumulative).HasColumnName("inIcuCumulative");
            entity.Property(e => e.InIcuCurrently).HasColumnName("inIcuCurrently");
            entity.Property(e => e.LastModified)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("lastModified");
            entity.Property(e => e.Negative).HasColumnName("negative");
            entity.Property(e => e.NegativeIncrease).HasColumnName("negativeIncrease");
            entity.Property(e => e.OnVentilatorCumulative).HasColumnName("onVentilatorCumulative");
            entity.Property(e => e.OnVentilatorCurrently).HasColumnName("onVentilatorCurrently");
            entity.Property(e => e.Pending).HasColumnName("pending");
            entity.Property(e => e.PosNeg).HasColumnName("posNeg");
            entity.Property(e => e.Positive).HasColumnName("positive");
            entity.Property(e => e.PositiveIncrease).HasColumnName("positiveIncrease");
            entity.Property(e => e.Recovered).HasColumnName("recovered");
            entity.Property(e => e.States).HasColumnName("states");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalTestResults).HasColumnName("totalTestResults");
            entity.Property(e => e.TotalTestResultsIncrease).HasColumnName("totalTestResultsIncrease");
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.ToTable("module");

            entity.Property(e => e.ModuleId).HasColumnName("module_id");
            entity.Property(e => e.ModuleName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("module_name");
        });

        modelBuilder.Entity<Operation>(entity =>
        {
            entity.ToTable("operation");

            entity.Property(e => e.OperationId).HasColumnName("operation_id");
            entity.Property(e => e.ModuleId).HasColumnName("module_id");
            entity.Property(e => e.OperationName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("operation_name");

            entity.HasOne(d => d.Module).WithMany(p => p.Operations)
                .HasForeignKey(d => d.ModuleId)
                .HasConstraintName("FK_operation_module");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.PersonId).HasName("PK_user");

            entity.ToTable("person");

            entity.Property(e => e.PersonId)
                .ValueGeneratedNever()
                .HasColumnName("person_id");
            entity.Property(e => e.PersonName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("person_name");
            entity.Property(e => e.PersonPassword)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("person_password");
            entity.Property(e => e.PersonUsername)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("person_username");
            entity.Property(e => e.RolId).HasColumnName("rol_id");

            entity.HasOne(d => d.Rol).WithMany(p => p.People)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_user_rol");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.ToTable("rol");

            entity.Property(e => e.RolId).HasColumnName("rol_id");
            entity.Property(e => e.RolName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rol_name");
        });

        modelBuilder.Entity<RolOperation>(entity =>
        {
            entity.ToTable("rol_operation");

            entity.Property(e => e.RolOperationId).HasColumnName("rol_operation_id");
            entity.Property(e => e.OperationId).HasColumnName("operation_id");
            entity.Property(e => e.RolId).HasColumnName("rol_id");

            entity.HasOne(d => d.Operation).WithMany(p => p.RolOperations)
                .HasForeignKey(d => d.OperationId)
                .HasConstraintName("FK_rol_operation_operation");

            entity.HasOne(d => d.Rol).WithMany(p => p.RolOperations)
                .HasForeignKey(d => d.RolId)
                .HasConstraintName("FK_rol_operation_rol");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
