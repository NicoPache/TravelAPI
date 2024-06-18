using Models.Models;
using Models.context;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.services
{
    public class GestorReserva : IGestorReserva
    {
        private readonly TourContext _context;

        public GestorReserva()
        {
            _context = new TourContext();
        }

        public IEnumerable<Reserva> GetAllReservas()
        {
            return _context.Reservas.Include("Tour").Include("cliente").ToList();
        }

        public void AddReserva(Reserva reserva)
        {
            _context.Reservas.Add(reserva);
            _context.SaveChanges();
        }

        public void DeleteReserva(int id)
        {
            var reserva = _context.Reservas.Find(id);
            if (reserva != null)
            {
                _context.Reservas.Remove(reserva);
                _context.SaveChanges();
            }
        }
        public Reserva GetReservaByClienteIdAndTourId(int clienteId, int tourId)
        {
            return _context.Reservas.FirstOrDefault(r => r.ClienteId == clienteId && r.TourId == tourId);
        }
    }
}
