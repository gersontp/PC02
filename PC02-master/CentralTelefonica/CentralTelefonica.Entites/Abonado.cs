using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public class Abonado
    {
        public int AbonadoId { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }

        public List<Telefono> Telefono { get; set; }

        public Abonado()
        {
            Telefono = new List<Telefono>();
        }
    }
}
