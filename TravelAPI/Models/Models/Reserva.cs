using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Reserva : IClaseBase
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public DateTime FechaReserva { get; set; }
        public int TourId { get; set; }

        public virtual Tour Tour { get; set; }
        public string MostrarInformacion()
        {
            return $"Reserva ID: {Id}, Cliente: {Cliente?.MostrarInformacion()}, Tour: {Tour?.MostrarInformacion()}, Fecha de Reserva: {FechaReserva.ToShortDateString()}";
        }
    }

}
