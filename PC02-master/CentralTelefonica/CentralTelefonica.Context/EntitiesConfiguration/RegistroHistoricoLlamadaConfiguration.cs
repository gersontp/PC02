using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CentralTelefonica.Entities;

namespace CentralTelefonica.Context.EntitiesConfiguration
{
    public class RegistroHistoricoLlamadaConfiguration : EntityTypeConfiguration<RegistroHistoricoLlamada>
    {

        public RegistroHistoricoLlamadaConfiguration()
        {
            //Configuro el nombre de la tabla en la base de datos
            ToTable("RegistroHistoricoLlamada");

            //Configuro la llave primaria de la tabla Incidencia
            HasKey(I => I.HistoricoLlamadaId);

            //Configuro la longitud maxima del campo Descripcion
            Property(I => I.FechaRegistro);

            //Configuro la longitud maxima del campo Descripcion
            Property(I => I.FechaLLamada);

            //Configuro la longitud maxima del campo Descripcion
            Property(I => I.Origen).HasMaxLength(50);

            //Configuro la longitud maxima del campo Descripcion
            Property(I => I.Duracion);

            //Configuro la longitud maxima del campo Descripcion
            Property(I => I.costoLLamada);

            HasRequired(t => t.llamada)
                 .WithMany(b => b.RegistroHistoricoLlamada)
                 .HasForeignKey(t => t.LlamadaId);


        }
    }
}
