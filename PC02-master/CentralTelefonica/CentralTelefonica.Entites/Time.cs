using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public class Time
    {

        public int TimeId { get; set; }
        public List<Reloj> Reloj { get; set; }

        DateTime _HoraActual;
        
        public Time()
        {
            _HoraActual = DateTime.Now;
            Reloj = new List<Reloj>();
        }

        public void GetTime(out int horas, out int minutos, out int segundos)
        {
            horas = _HoraActual.Hour;
            minutos = _HoraActual.Minute;
            segundos = _HoraActual.Second;
        }
    }
}
