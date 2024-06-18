using Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.context
{
    public class TourContextInitializer : CreateDatabaseIfNotExists<TourContext>
    {
        protected override void Seed(TourContext context)
        {
            base.Seed(context);

            // añado unos datos por si no existe la base
            context.Tours.Add(new Tour { Nombre = "Tour Zona Oeste", Destino = "El Palomar", FechaInicio = DateTime.Now, FechaFin = DateTime.Now.AddDays(7), Precio = 3500 });
            context.Tours.Add(new Tour { Nombre = "Tour Zona Sur", Destino = "berazategui", FechaInicio = DateTime.Now, FechaFin = DateTime.Now.AddDays(7), Precio = 3000 });
            context.Tours.Add(new Tour { Nombre = "Tour Caba", Destino = "Almagro", FechaInicio = DateTime.Now, FechaFin = DateTime.Now.AddDays(7), Precio = 4000 });
            context.Clientes.Add(new Cliente {Apellido="Pacheco",Nombre="Nicolás"});
            context.Clientes.Add(new Cliente { Apellido = "Picapiedra", Nombre = "Pedro" });
            context.SaveChanges();
        }
    }
}
