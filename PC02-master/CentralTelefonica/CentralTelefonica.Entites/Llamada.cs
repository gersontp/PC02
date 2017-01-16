using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public class Llamada
    {
        public int LlamadaId { get; set; }

        public int TelefonoId { get; set; }
        public  Telefono _Telefono;

        public int TimeId { get; set; }
        public Reloj _Reloj;

        public int CentralId { get; set; }
        public Central Central { get; set; }
        public List<Incidencia> Incidencia { get; set; }
        public List<RegistroHistoricoLlamada> RegistroHistoricoLlamada { get; set; }
        

        public Llamada(string numero)
        {
            if (numero[0] == '9')
                _Telefono = new Celular(numero);
            else
                _Telefono = new Fijo(numero);

            _Reloj = new Reloj();
        }

        public Llamada()
        {

        }
        public Telefono Telefono { get { return _Telefono; } }

        public Reloj Reloj { get { return _Reloj; } }

        public double Tarifa()
        {
            return _Telefono.Tarifa(DateTime.Now.Hour);
        }

    }
}
