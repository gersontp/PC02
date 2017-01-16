using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CentralTelefonica.Entities;

namespace CentralTelefonica.Context.EntitiesConfiguration
{
    class CelularConfiguration : EntityTypeConfiguration<Celular>
    {
        public CelularConfiguration()
        {
            //Configuro el nombre de la tabla en la base de datos
            ToTable("Celular");
            //Configuro la llave primaria de la tabla Celular
            HasKey(c => c.TelefonoId);
            //Configuro la longitud maxima del campo Numero
            Property(c => c.Numero).HasMaxLength(9);
            //Configuro relacion Telefono - Celular
            HasRequired(a => a.Telefono)
                 .WithMany(b => b.Celular)
                 .HasForeignKey(R => R.TelefonoId);


        }
    }
}
