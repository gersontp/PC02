using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public interface Telefono
    {
        public int TelefonoId { get; set; }
        public List<Llamada> Llamada { get; set; }

        public List<Celular> Celular { get; set; }
        public List<Fijo> Fijo { get; set; }

        public int CentralId { get; set; }
        public Central Central { get; set; }

        string Numero {get;}

        double Tarifa(int hora);
    }
}
