using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public class TipoIncidencia
    {
        public int TipoIncidenciaId { get; set; }
        public string Tipo { get; set; }

        public List<Incidencia> Incidencia { get; set; }

        public TipoIncidencia()
        {
            Incidencia = new List<Incidencia>();
        }

    }
}
