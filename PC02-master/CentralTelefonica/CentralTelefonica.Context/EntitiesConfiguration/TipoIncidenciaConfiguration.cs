using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CentralTelefonica.Entities;


namespace CentralTelefonica.Context.EntitiesConfiguration
{
    public class TipoIncidenciaConfiguration : EntityTypeConfiguration<TipoIncidencia>
    {

        public TipoIncidenciaConfiguration()
        {
            ToTable("TipoIncidencia");

            //Configuro la llave primaria de la tabla Tipo Incidencia
            HasKey(Ti => Ti.TipoIncidenciaId);

            //Configuro la longitud maxima del campo Tipo
            Property(Ti => Ti.Tipo).HasMaxLength(20);
        }
    }
}
