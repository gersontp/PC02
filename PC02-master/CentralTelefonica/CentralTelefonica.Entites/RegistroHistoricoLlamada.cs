using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralTelefonica.Entities;

namespace CentralTelefonica.Entities
{
    public class RegistroHistoricoLlamada
    {
        public int HistoricoLlamadaId { get; set; }
        public int LlamadaId { get; set; }        
        public Llamada llamada { get; set; }

        public DateTime FechaRegistro { get; set; }
        public DateTime FechaLLamada { get; set; }
        public string Origen { get; set; }
        public double Duracion { get; set; }
        public double costoLLamada { get; set; }

        public RegistroHistoricoLlamada()
        {
           
        }
    }
}
