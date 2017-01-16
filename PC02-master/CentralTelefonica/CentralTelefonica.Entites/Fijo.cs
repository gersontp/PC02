using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public class Fijo : Telefono
    {
        public int TelefonoId { get; set; }
        public Telefono Telefono { get; set; }
        private string _Numero;
        
        public Fijo(string numero)
        {
            _Numero = numero;
        }

        public string Numero { get { return _Numero; } }


        public double Tarifa(int hora)
        {
            return 0.02;  
        }
    }
}
