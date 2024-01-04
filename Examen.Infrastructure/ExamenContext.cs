
using Examen.ApplicationCore.Domain;
using Examen.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure
{
    public class ExamenContext:DbContext
    {
        public DbSet<Election> Elections{ get; set; }
        public DbSet<Electeur> Electeurs{ get; set; }
        public DbSet<PartiePolitique> PartiePolitiques{ get; set; }
        public DbSet<Vote> Votes{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies(); 

            optionsBuilder.UseSqlServer(@"Data Source=BLACKHORIZON\SQLEXPRESS;
                   Initial Catalog=ElectionDb;User ID=Kaycer Khouini;Password=its goddamn kay;TrustServerCertificate=True;
                   Integrated Security=true");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VoteConfiguration());
            modelBuilder.ApplyConfiguration(new ElectionConfiguration());
            modelBuilder.Entity<Electeur>().OwnsOne(e=>e.MonBureauVote, bureau =>
            {
                bureau.Property(p => p.Ville);
                bureau.Property(p => p.Gouvernerat);
                bureau.Property(p => p.Ecole);
                bureau.Property(p => p.NumSalle);
            });
            modelBuilder.Entity<Vote>().OwnsOne(v => v.MonBureauVote, bureau =>
            {
                bureau.Property(p => p.Ville);
                bureau.Property(p => p.Gouvernerat);
                bureau.Property(p => p.Ecole);
                bureau.Property(p => p.NumSalle);
            });
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(250);
        }
    }
}
