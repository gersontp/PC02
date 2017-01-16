using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CentralTelefonica.Entities;

namespace CentralTelefonica.Context.EntitiesConfiguration
{
    class TelefonoConfiguration : EntityTypeConfiguration<Telefono>
    {
       public TelefonoConfiguration ()
	        {

                //Configuro el nombre de la tabla en la base de datos
                ToTable("Telefono");

                //Configuro la llave primaria de la tabla Authors
                HasKey(t => t.TelefonoId);

                //Configuro la longitud maxima del campo Numero
                Property(t => t.Numero).HasMaxLength(10);

                HasRequired(a => a.Central)
                    .WithMany(b => b._Telefonos)
                    .HasForeignKey(R => R.CentralId);



	        }
     
        


    }
}
