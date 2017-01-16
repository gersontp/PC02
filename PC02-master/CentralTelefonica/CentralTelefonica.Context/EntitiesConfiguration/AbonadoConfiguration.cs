using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CentralTelefonica.Entities;

namespace CentralTelefonica.Context.EntitiesConfiguration
{
    public class AbonadoConfiguration : EntityTypeConfiguration<Abonado>
    {

        public AbonadoConfiguration()
        {
            //Configuro el nombre de la tabla en la base de datos
            ToTable("Abonado");

            //Configuro la llave primaria de la tabla Abonado
            HasKey(a => a.AbonadoId);

            //Configuro la longitud maxima del campo Numero
            Property( a=> a.Apellidos).HasMaxLength(70);

            //Configuro la longitud maxima del campo Numero
            Property(a => a.Nombres).HasMaxLength(70);

            //Configuro la longitud maxima del campo Numero
            Property(a => a.Direccion).HasMaxLength(70);
        }
    }
}
