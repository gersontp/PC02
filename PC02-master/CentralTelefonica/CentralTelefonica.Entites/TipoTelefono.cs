using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public class TipoTelefono
    {
        public int TipoTelefonoId { get; set; }
        public string Descripcion { get; set; }

        public List<Telefono> Telefono { get; set; }
        public TipoTelefono()
        {
            Telefono = new List<Telefono>();
        }
    }
}
