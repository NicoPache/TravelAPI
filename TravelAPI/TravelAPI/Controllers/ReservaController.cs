using System;
using System.Collections.Generic;
using System.Web.Http;
using Models.Models;
using Models.Models.DTO;
using Services.Interfaces;

namespace MyTourApp.Controllers
{
    public class ReservaController : ApiController
    {
        private readonly IGestorReserva _reservaService;

        public ReservaController(IGestorReserva reservaService)
        {
            _reservaService = reservaService;
        }

        [HttpGet]
        [Route("api/reservas")]
        public  IHttpActionResult GetReservas()
        {
            try
            {
                return Ok(_reservaService.GetAllReservas());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("api/reservas")]
        public IHttpActionResult AddReserva(AddReservaRequest request)
        {
            try
            {
                var existingReserva = _reservaService.GetReservaByClienteIdAndTourId(request.ClienteId, request.TourId);
                if (existingReserva != null)
                {
                    return BadRequest("Ya existe una reserva para este cliente y tour.");
                }


                var reserva = new Reserva
                {
                    ClienteId = request.ClienteId,
                    TourId = request.TourId,
                    FechaReserva = DateTime.Now // Establecer la fecha actual como FechaReserva
                };
                _reservaService.AddReserva(reserva);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        [Route("api/reservas/{id}")]
        public IHttpActionResult DeleteReserva(int id)
        {
            try
            {
                _reservaService.DeleteReserva(id);
            return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}