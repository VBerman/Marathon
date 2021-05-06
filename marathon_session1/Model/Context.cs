using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace marathon_session1.Model
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<Charity> Charities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventType> EventTypes { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Marathon> Marathons { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<RaceKitOption> RaceKitOptions { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<RegistrationEvent> RegistrationEvents { get; set; }
        public virtual DbSet<RegistrationStatu> RegistrationStatus { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Runner> Runners { get; set; }
        public virtual DbSet<Sponsorship> Sponsorships { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Volunteer> Volunteers { get; set; }
        public virtual DbSet<Timesheet> Timesheets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .Property(e => e.CountryCode)
                .IsFixedLength();

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Runners)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Volunteers)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.EventId)
                .IsFixedLength();

            modelBuilder.Entity<Event>()
                .Property(e => e.EventTypeId)
                .IsFixedLength();

            modelBuilder.Entity<Event>()
                .Property(e => e.Cost)
                .HasPrecision(10, 2);

            modelBuilder.Entity<EventType>()
                .Property(e => e.EventTypeId)
                .IsFixedLength();

            modelBuilder.Entity<Gender>()
                .HasMany(e => e.Runners)
                .WithRequired(e => e.Gender1)
                .HasForeignKey(e => e.Gender)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gender>()
                .HasMany(e => e.Volunteers)
                .WithRequired(e => e.Gender1)
                .HasForeignKey(e => e.Gender)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Marathon>()
                .Property(e => e.CountryCode)
                .IsFixedLength();

            modelBuilder.Entity<Position>()
                .Property(e => e.PositionName)
                .IsUnicode(false);

            modelBuilder.Entity<Position>()
                .Property(e => e.PostitionDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Position>()
                .Property(e => e.PayPeriod)
                .IsUnicode(false);

            modelBuilder.Entity<Position>()
                .Property(e => e.PayRate)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Position>()
                .HasMany(e => e.Staffs)
                .WithRequired(e => e.Position)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RaceKitOption>()
                .Property(e => e.RaceKitOptionId)
                .IsFixedLength();

            modelBuilder.Entity<RaceKitOption>()
                .Property(e => e.Cost)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Registration>()
                .Property(e => e.RaceKitOptionId)
                .IsFixedLength();

            modelBuilder.Entity<Registration>()
                .Property(e => e.Cost)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Registration>()
                .Property(e => e.SponsorshipTarget)
                .HasPrecision(10, 2);

            modelBuilder.Entity<RegistrationEvent>()
                .Property(e => e.EventId)
                .IsFixedLength();

            modelBuilder.Entity<Role>()
                .Property(e => e.RoleId)
                .IsFixedLength();

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Runner>()
                .Property(e => e.CountryCode)
                .IsFixedLength();

            modelBuilder.Entity<Sponsorship>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Staff>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Timesheets)
                .WithRequired(e => e.Staff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.RoleId)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .HasMany(e => e.Runners)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Volunteer>()
                .Property(e => e.CountryCode)
                .IsFixedLength();

            modelBuilder.Entity<Timesheet>()
                .Property(e => e.PayAmount)
                .HasPrecision(10, 2);
        }
    }
}
