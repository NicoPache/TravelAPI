using Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Models.context
{
    public class TourContext : DbContext
    {
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

        public DbSet<Cliente> Clientes { get; set; }
        public TourContext() : base("name=TourContext")
        {
            // por si no existe la base
            Database.SetInitializer(new TourContextInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Reserva>()
                 .HasRequired(r => r.Cliente)
                 .WithMany()
                 .HasForeignKey(r => r.ClienteId);
        }

    }
}
