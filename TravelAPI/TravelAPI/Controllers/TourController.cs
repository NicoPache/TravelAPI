using Models.context;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace TravelAPI.Controllers
{
    public class TourController : ApiController
    {
        private TourContext db = new TourContext();

        [HttpGet]
        [Route("api/tours")]
        public IHttpActionResult GetTours(string destino = null)
        {
            try
            {
                List<Tour> tours;

                if (string.IsNullOrEmpty(destino))
                {
                    tours = db.Tours.ToList();
                }
                else
                {
                    tours = db.Tours.Where(t => t.Destino.Contains(destino)).ToList();
                }
                return Ok(tours);
            }
            catch (Exception ex)
            {
                    return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("api/tours")]
        public IHttpActionResult AddTour(Tour tour)
        {
            try
            {
                if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Tours.Add(tour);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tour.Id }, tour);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}