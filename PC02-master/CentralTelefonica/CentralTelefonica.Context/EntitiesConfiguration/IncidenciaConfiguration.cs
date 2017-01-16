using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CentralTelefonica.Entities;


namespace CentralTelefonica.Context.EntitiesConfiguration
{
    public class IncidenciaConfiguration : EntityTypeConfiguration<Incidencia>
    {

        public IncidenciaConfiguration()
        {

            //Configuro el nombre de la tabla en la base de datos
            ToTable("Incidencia");

            //Configuro la llave primaria de la tabla Incidencia
            HasKey(I => I.InidenciaId);

            //Configuro la longitud maxima del campo Descripcion
            Property(I => I.Descripcion).HasMaxLength(50);


            HasRequired(t => t.TipoIncidencia)
             .WithMany(b => b.Incidencia)
             .HasForeignKey(t => t.TipoIncidenciaId);

            HasRequired(t => t.Llamada)
            .WithMany(b => b.Incidencia)
            .HasForeignKey(t => t.LlamadaId);



        }
    }
}
