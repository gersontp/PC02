using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CentralTelefonica.Entities;

namespace CentralTelefonica.Context.EntitiesConfiguration
{
    class FijoConfiguration : EntityTypeConfiguration<Fijo>
    {   
    
        public FijoConfiguration()
        {
            //Configuro el nombre de la tabla en la base de datos
            ToTable("Fijo");

            //Configuro la llave primaria de la tabla Fijo
            HasKey(f => f.TelefonoId);
            //Configuro la longitud maxima del campo Numero
            Property(f => f.Numero).HasMaxLength(7);


            HasRequired(a => a.Telefono)
              .WithMany(b => b.Fijo)
              .HasForeignKey(R => R.TelefonoId);
        }
    }
}
