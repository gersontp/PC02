using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralTelefonica.Entities;
using System.Threading;

namespace CentralTelefonica.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var central = new Central();

            var fono1 = "4234567";
            var fono2 = "4238888";

            var fono3 = "958756555";
            var fono4 = "944785623";
            var fono5 = "966455801";

            central.Agregar(fono1);
            central.Agregar(fono2);
            central.Agregar(fono3);
            central.Agregar(fono4);
            central.Agregar(fono5);

            central.IniciarLlamada(fono1);
            Thread.Sleep(5500);
            central.FinalizarLlamada(fono1);

            central.IniciarLlamada(fono3);
            Thread.Sleep(3500);
            central.FinalizarLlamada(fono3);

            central.IniciarLlamada(fono2);
            Thread.Sleep(4000);
            central.FinalizarLlamada(fono2);

            central.IniciarLlamada(fono5);
            Thread.Sleep(2500);
            central.FinalizarLlamada(fono5);

            central.IniciarLlamada(fono4);
            Thread.Sleep(3000);
            central.FinalizarLlamada(fono4);

        }
    }
}
