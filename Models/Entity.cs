using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ExchangeOffice
{
    public partial class Entity : DbContext
    {
        public Entity()
            : base("name=Entity")
        {
        }

        public virtual DbSet<CLS_Currency> CLS_Currency { get; set; }
        public virtual DbSet<CLS_OperationType> CLS_OperationType { get; set; }
        public virtual DbSet<ExchangeRate> ExchangeRates { get; set; }
        public virtual DbSet<OfficialRate> OfficialRates { get; set; }
        public virtual DbSet<Operation> Operations { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CLS_Currency>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<CLS_Currency>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CLS_Currency>()
                .HasMany(e => e.ExchangeRates)
                .WithOptional(e => e.CLS_Currency)
                .HasForeignKey(e => e.CurrencyFrom);

            modelBuilder.Entity<CLS_Currency>()
                .HasMany(e => e.ExchangeRates1)
                .WithOptional(e => e.CLS_Currency1)
                .HasForeignKey(e => e.CurrencyTo);

            modelBuilder.Entity<CLS_Currency>()
                .HasMany(e => e.OfficialRates)
                .WithOptional(e => e.CLS_Currency)
                .HasForeignKey(e => e.Currency);

            modelBuilder.Entity<CLS_Currency>()
                .HasMany(e => e.Operations)
                .WithOptional(e => e.CLS_Currency)
                .HasForeignKey(e => e.CurrencyFrom);

            modelBuilder.Entity<CLS_Currency>()
                .HasMany(e => e.Operations1)
                .WithOptional(e => e.CLS_Currency1)
                .HasForeignKey(e => e.CurrencyTo);

            modelBuilder.Entity<CLS_OperationType>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<CLS_OperationType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Operations)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.UserId);
        }
    }
}
