using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public class Reloj : Time
    {
        public List<Llamada> Llamada { get; set; }
        public int TimeId { get; set; }
        public Time Time { get; set; }

       
        public Reloj()
            :base()
        {
        }

        public int GetTime()
        {
            int horas;
            int minutos;
            int segundos;
            
            base.GetTime(out horas, out minutos, out segundos);
            
            return horas * 3600 + minutos * 60 + segundos;
        }
    }
}
