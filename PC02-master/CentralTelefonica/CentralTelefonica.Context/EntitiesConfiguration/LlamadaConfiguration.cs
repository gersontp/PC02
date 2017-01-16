using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CentralTelefonica.Entities;

namespace CentralTelefonica.Context.EntitiesConfiguration
{
    class LlamadaConfiguration : EntityTypeConfiguration<Llamada>
    {   

        public LlamadaConfiguration ()
	{
        //Configuro el nombre de la tabla en la base de datos
        ToTable("Llamada");
        //Configuro la llave primaria de la tabla Llamada
        HasKey(Ll=> Ll.LlamadaId);

        HasRequired(t => t.Telefono)
            .WithMany(b => b.Llamada)
            .HasForeignKey(t => t.TelefonoId);

        HasRequired(R => R.Reloj)
            .WithMany(b => b.Llamada)
            .HasForeignKey(R => R.TimeId);

        HasRequired(a => a.Central)
           .WithMany(b => b._Llamadas)
           .HasForeignKey(R => R.CentralId);

    


	}
        

    }
}
