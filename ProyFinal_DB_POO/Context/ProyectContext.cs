using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ProyFinal_DB_POO.Models
{
    public partial class ProyectContext : DbContext
    {
        public ProyectContext()
        {
        }

        public ProyectContext(DbContextOptions<ProyectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<AppointmentxSideEffect> AppointmentxSideEffects { get; set; }
        public virtual DbSet<Booth> Booths { get; set; }
        public virtual DbSet<Citizen> Citizens { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<Diseasexcitizen> Diseasexcitizens { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employeexappointment> Employeexappointments { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<SideEffect> SideEffects { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<VaccinationCenter> VaccinationCenters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=MAJOM\\SQLEXPRESS;Database=ProyectoFinal;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("APPOINTMENT");

                entity.Property(e => e.AppointmentId).HasColumnName("appointment_id");

                entity.Property(e => e.CenterId).HasColumnName("center_id");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time");

                entity.Property(e => e.Dui).HasColumnName("dui");

                entity.Property(e => e.QueueStart)
                    .HasColumnType("datetime")
                    .HasColumnName("queue_start");

                entity.Property(e => e.VaccinationTime)
                    .HasColumnType("datetime")
                    .HasColumnName("vaccination_time");

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.CenterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VACCINATION_CENTER");

                entity.HasOne(d => d.DuiNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.Dui)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CITIZEN_ID");
            });

            modelBuilder.Entity<AppointmentxSideEffect>(entity =>
            {
                entity.ToTable("APPOINTMENTxSIDE_EFFECT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppointmentId).HasColumnName("appointment_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.EffectId).HasColumnName("effect_id");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.AppointmentxSideEffects)
                    .HasForeignKey(d => d.AppointmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_APPOINTMENTxSIDE_EFFECT_APPOINTMENT");

                entity.HasOne(d => d.Effect)
                    .WithMany(p => p.AppointmentxSideEffects)
                    .HasForeignKey(d => d.EffectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_APPOINTMENTxSIDE_EFFECT");
            });

            modelBuilder.Entity<Booth>(entity =>
            {
                entity.ToTable("BOOTH");

                entity.Property(e => e.BoothId).HasColumnName("booth_id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EmployeeInChargeId).HasColumnName("employee_in_charge_id");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.HasOne(d => d.EmployeeInCharge)
                    .WithMany(p => p.Booths)
                    .HasForeignKey(d => d.EmployeeInChargeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMPLOYEE_IN_CHARGE");
            });

            modelBuilder.Entity<Citizen>(entity =>
            {
                entity.HasKey(e => e.Dui)
                    .HasName("PK__CITIZEN__D876F1BE53EF805B");

                entity.ToTable("CITIZEN");

                entity.Property(e => e.Dui)
                    .ValueGeneratedNever()
                    .HasColumnName("dui");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EssentialJob).HasColumnName("essential_job");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<Disease>(entity =>
            {
                entity.ToTable("DISEASE");

                entity.Property(e => e.DiseaseId).HasColumnName("disease_id");

                entity.Property(e => e.Disease1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("disease");
            });

            modelBuilder.Entity<Diseasexcitizen>(entity =>
            {
                entity.ToTable("DISEASEXCITIZEN");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CitizenId).HasColumnName("citizen_id");

                entity.Property(e => e.DiseaseId).HasColumnName("disease_id");

                entity.HasOne(d => d.Citizen)
                    .WithMany(p => p.Diseasexcitizens)
                    .HasForeignKey(d => d.CitizenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DISEASEXCITIZEN_CITIZEN");

                entity.HasOne(d => d.Disease)
                    .WithMany(p => p.Diseasexcitizens)
                    .HasForeignKey(d => d.DiseaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DISEASEXCITIZEN_DISEASE");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("EMPLOYEE");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.BoothId).HasColumnName("booth_id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.HasOne(d => d.Booth)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.BoothId)
                    .HasConstraintName("FK_BOOTH_ID");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TYPE_ID");
            });

            modelBuilder.Entity<Employeexappointment>(entity =>
            {
                entity.ToTable("EMPLOYEEXAPPOINTMENT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppointmentId).HasColumnName("appointment_id");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.Employeexappointments)
                    .HasForeignKey(d => d.AppointmentId)
                    .HasConstraintName("FK_EMPLOYEEXAPPOINTMENT_APPOINTMENT");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Employeexappointments)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_EMPLOYEEXAPPOINTMENT_EMPLOYEE");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("LOG");

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.BoothId).HasColumnName("booth_id");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.LogIn)
                    .HasColumnType("datetime")
                    .HasColumnName("log_in");

                entity.Property(e => e.LogOut)
                    .HasColumnType("datetime")
                    .HasColumnName("log_out");

                entity.HasOne(d => d.Booth)
                    .WithMany(p => p.Logs)
                    .HasForeignKey(d => d.BoothId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LOG_BOOTH_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Logs)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LOG_EMPLOYEE_ID");
            });

            modelBuilder.Entity<SideEffect>(entity =>
            {
                entity.HasKey(e => e.EffectId)
                    .HasName("PK__SIDE_EFF__AC79D23B31753083");

                entity.ToTable("SIDE_EFFECT");

                entity.Property(e => e.EffectId).HasColumnName("effect_id");

                entity.Property(e => e.SideEffect1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("side_effect");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.ToTable("TYPE");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.Type1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<VaccinationCenter>(entity =>
            {
                entity.HasKey(e => e.CenterId)
                    .HasName("PK__VACCINAT__290A2887EF0E078B");

                entity.ToTable("VACCINATION_CENTER");

                entity.Property(e => e.CenterId).HasColumnName("center_id");

                entity.Property(e => e.VaccinationCenter1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vaccination_center");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
