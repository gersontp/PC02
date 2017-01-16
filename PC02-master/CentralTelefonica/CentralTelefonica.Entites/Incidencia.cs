using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public class Incidencia
    {
        public int InidenciaId { get; set; }
        public string Descripcion { get; set; }

        public int TipoIncidenciaId { get; set; }
        public TipoIncidencia TipoIncidencia { get; set; }

        public int LlamadaId { get; set; }
        public Llamada Llamada { get; set; }

        public List<RegistrodeIncidenciaLlamada> RegistrodeIncidenciaLlamada { get; set; }
    }

}
