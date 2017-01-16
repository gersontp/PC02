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

        public int TipoTelefonoId { get; set; }
        public TipoTelefono TipoTelefono { get; set; }


        public int AbonadoId { get; set; }
        public Abonado Abonado { get; set; }
        string Numero {get;}

        double Tarifa(int hora);

        public Telefono ()
	{
        Llamada = new List<Llamada>();
        Celular = new List<Celular>();
        Fijo = new List<Fijo>();
	}

    }
}
