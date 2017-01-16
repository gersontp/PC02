using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CentralTelefonica.Entities;

namespace CentralTelefonica.Context.EntitiesConfiguration
{
    class CentralConfiguration : EntityTypeConfiguration<Central>
    {
        public CentralConfiguration()
        {
            //Configuro el nombre de la tabla en la base de datos
            ToTable("Central");

            //Configuro la llave primaria de la tabla Central
            HasKey(c=> c.CentralId);

           
        }
    }
}
