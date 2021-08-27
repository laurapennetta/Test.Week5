using Microsoft.EntityFrameworkCore;
using Risto.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Risto.EF
{
    public class RistoContext : DbContext
    {
        public DbSet<Piatto> Piatti { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public RistoContext(DbContextOptions<RistoContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Piatto>().ToTable("Piatto")
                                           .HasKey(k => k.ID);
            modelBuilder.Entity<Piatto>().Property(f => f.Nome).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Piatto>().Property(l => l.Descrizione).IsRequired().HasMaxLength(500);
            modelBuilder.Entity<Piatto>().Property(d => d.Tipologia).IsRequired();
            modelBuilder.Entity<Piatto>().Property(a => a.Prezzo).IsRequired();

            modelBuilder.Entity<Account>().ToTable("Users").HasKey(k => k.Id);
            modelBuilder.Entity<Account>().Property(u => u.Username).IsRequired();
            modelBuilder.Entity<Account>().Property(p => p.Password).IsRequired();
            modelBuilder.Entity<Account>().Property(r => r.Ruolo).IsRequired();

            modelBuilder.Entity<Account>().HasData(
                new Account { Id = 1, Username = "ristoratore.official@gmail.com", Password = "risto.5898", Ruolo = Ruolo.Ristoratore },
                new Account { Id = 2, Username = "lau.penni@gmail.com", Password = "1234", Ruolo = Ruolo.Cliente }
            );
        }
    }
}
