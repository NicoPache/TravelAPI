using Models.context;
using Models.Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.services
{
    public class GestorTour : IGestorTour
    {
        private readonly TourContext _context;

        public GestorTour()
        {
            _context = new TourContext();
        }

        public IEnumerable<Tour> GetAllTours()
        {
            return _context.Tours.ToList();
        }

        public void AddTour(Tour tour)
        {
            _context.Tours.Add(tour);
            _context.SaveChanges();
        }
    }
}
