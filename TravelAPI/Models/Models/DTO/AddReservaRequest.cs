using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.DTO
{
    public class AddReservaRequest
    {
        public int ClienteId { get; set; }
        public int TourId { get; set; }
    }
}
