using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public class RegistrodeIncidenciaLlamada
    {
        public int RegistroIncidenciaId { get; set; }
        public DateTime FechaLLamada { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public int TipoIncidenciaId { get; set; }
        public string Tipo { get; set; }
        public TipoIncidencia TipoIncidencia { get; set; }
        public int IncidenciaId { get; set; }
        public string Descripcion { get; set; }
        public Incidencia Incidencia { get; set; }



        public RegistrodeIncidenciaLlamada()
        {

        }
    }
        
        
}
