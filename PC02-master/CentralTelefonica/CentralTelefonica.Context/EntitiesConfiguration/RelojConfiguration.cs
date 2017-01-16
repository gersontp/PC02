using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CentralTelefonica.Entities;

namespace CentralTelefonica.Context.EntitiesConfiguration
{
    class RelojConfiguration : EntityTypeConfiguration<Reloj>
    {

        public RelojConfiguration ()
	{
        //Configuro el nombre de la tabla en la base de datos
        ToTable("Reloj");
        //Configuro la llave primaria de la tabla Reloj
        HasKey(R => R.TimeId);


        //Configuro relacion Reloj - Time
            HasRequired(r => r.Time)  
                .WithMany(b => b.Reloj)
                .HasForeignKey(r => r.TimeId);

        

	}
         

    }
}
