using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public class Central
    {
        public int CentralId { get; set; }
        public List<Telefono> _Telefonos;
        public List<Llamada> _Llamadas;

        public Central()
        {
            _Telefonos = new List<Telefono>();
            _Llamadas = new List<Llamada>();
        }

        public void Agregar(string numero)
        {
            if (_Telefonos.Count == 100)
                return;
            
            if (numero[0] == '9')
                _Telefonos.Add(new Celular(numero));
            else
                _Telefonos.Add(new Fijo(numero));
        }

        public void Eliminar(string numero)
        {
            if (numero[0] == '9')
                _Telefonos.Remove(new Celular(numero));
            else
                _Telefonos.Remove(new Fijo(numero));
        }

        public void IniciarLlamada(string numero)
        {
            if (_Llamadas.Count == 50)
                return;
            
            var llamada = new Llamada(numero);

            _Llamadas.Add(llamada);

            Console.WriteLine("Iniciando Llamada al [{0}]", numero);
        }

        public double FinalizarLlamada(string numero)
        {
            var telefono = _Telefonos.Find(t => t.Numero == numero);

            if (telefono == null)
                return 0;

            var llamada = _Llamadas.Find(ll => ll.Telefono.Numero == numero);

            if (llamada == null)
                return 0;
            
            //duracion = tiempo actual en segundos - tiempo de inicio en segundos
            var duracion = new Reloj().GetTime() - llamada.Reloj.GetTime();
            var costoLamada = duracion * llamada.Tarifa();

            _Llamadas.Remove(llamada);

            Console.WriteLine("Finalizando llamada al [{0}]", numero);
            Console.WriteLine("Costo de la llamada [S/ {0}]", costoLamada.ToString());
            Console.WriteLine();
           
            return costoLamada;
        }
    }
}
