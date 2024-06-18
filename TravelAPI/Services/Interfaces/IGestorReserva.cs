using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IGestorReserva
    {
        IEnumerable<Reserva> GetAllReservas();
        void AddReserva(Reserva reserva);
        void DeleteReserva(int id);
        Reserva GetReservaByClienteIdAndTourId(int clienteId, int tourId);
    }
}
