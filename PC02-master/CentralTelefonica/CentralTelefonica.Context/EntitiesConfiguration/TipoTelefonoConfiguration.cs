using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CentralTelefonica.Entities;


namespace CentralTelefonica.Context.EntitiesConfiguration
{
    public class TipoTelefonoConfiguration : EntityTypeConfiguration<TipoTelefono>
    {
        public TipoTelefonoConfiguration()
        {
            ToTable("TipoTelefono");

            //Configuro la llave primaria de la tabla Tipo Incidencia
            HasKey(Tt => Tt.TipoTelefonoId);

            //Configuro la longitud maxima del campo Tipo
            Property(Tt => Tt.Descripcion).HasMaxLength(50);
        }

    }
}
