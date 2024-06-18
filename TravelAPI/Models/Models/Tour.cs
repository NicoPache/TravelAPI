using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Tour : IClaseBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Destino { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal Precio { get; set; }

        public string MostrarInformacion()
        {
            return $"Tour: {Nombre}, Destino: {Destino}, FechaInicio: {FechaInicio.ToShortDateString()} , FechaFin: {FechaFin.ToShortDateString()}, Precio: {Precio}";
        }

    }
}
