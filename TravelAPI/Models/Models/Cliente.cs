using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Cliente : IClaseBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string MostrarInformacion()
        {
            return $"Ciente Nombre: {Nombre}, Apellido: {Apellido}, ID: {Id}";
        }
    }
  
}
