﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralTelefonica.Entities;
using CentralTelefonica.Context.EntitiesConfiguration;

namespace CentralTelefonica.Context
{
    public class CentralTelefonicaDbContext  : DbContext

    {
        public DbSet<Celular> Celular { get; set; }
        public DbSet<Central> Central { get; set; }
        public DbSet<Fijo> Fijo { get; set; }
        public DbSet<Llamada> Llamada { get; set; }
        public DbSet<Reloj> Reloj { get; set; }
        public DbSet<Telefono> Telefono { get; set; }
        public DbSet<Time> Time { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder) {

            modelBuilder.Configurations.Add(new TimeConfiguration());

            modelBuilder.Configurations.Add(new TelefonoConfiguration());

            modelBuilder.Configurations.Add(new RelojConfiguration());

            modelBuilder.Configurations.Add(new LlamadaConfiguration());

            modelBuilder.Configurations.Add(new FijoConfiguration());

            modelBuilder.Configurations.Add(new CentralConfiguration());

            modelBuilder.Configurations.Add(new CelularConfiguration());

            base.OnModelCreating(modelBuilder);

        }




    }
}