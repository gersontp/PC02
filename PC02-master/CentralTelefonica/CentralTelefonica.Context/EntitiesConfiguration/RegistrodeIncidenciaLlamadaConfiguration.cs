using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CentralTelefonica.Entities;

namespace CentralTelefonica.Context.EntitiesConfiguration
{
    public class RegistrodeIncidenciaLlamadaConfiguration : EntityTypeConfiguration<RegistrodeIncidenciaLlamada>
    {
        public RegistrodeIncidenciaLlamadaConfiguration()
        {
            //Configuro el nombre de la tabla en la base de datos
            ToTable("RegistroIncidenciaLlamada");

            //Configuro la llave primaria de la tabla RegistrodeIncidencia
            HasKey(I => I.RegistroIncidenciaId);

            //Configuro la longitud maxima del campo Descripcion
            Property(I => I.FechaLLamada);

            //Configuro la longitud maxima del campo Descripcion
            Property(I => I.Origen);

            //Configuro la longitud maxima del campo Descripcion
            Property(I => I.Destino);

            //Configuro la longitud maxima del campo tipo
            Property(I => I.Tipo).HasMaxLength(10);

            //Configuro la longitud maxima del campo Descripcion
            Property(I => I.Descripcion).HasMaxLength(50);

            HasRequired(t => t.Incidencia)
               .WithMany(b => b.RegistrodeIncidenciaLlamada)
               .HasForeignKey(t => t.RegistroIncidenciaId);

        }
    }
}
