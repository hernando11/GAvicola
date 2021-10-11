using Microsoft.EntityFrameworkCore;
using GAvicola.App.Dominio;
using GAvicola.App.Persistencia;
using System;

namespace GAvicola.App.Persistencia
{
    public class AppContext : DbContext
    {

        public DbSet<Galpon> Galpones{get;set;}
        public DbSet<GAmbiente> GAmbientes{get;set;}
        public DbSet<GSugerencia> GSugerencias{get;set;}
        public DbSet<Perfil> Perfiles{get;set;}
        public DbSet<Persona> Personas{get;set;}
        public DbSet<Programa> Programas{get;set;}
        public DbSet<Rol> Roles{get;set;}
        public DbSet<Veterinario> Veterinarios{get;set;}
        public DbSet<Operario> Operarios{get;set;}
        public DbSet<Auxiliar> Auxiliares{get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder
            //.UseSQLServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =GAvicolaData");

            .UseSqlServer("Initial Catalog=GAvicoladata; Data Source=DESKTOP-R4IP09K; Integrated Security=true");

        }
    }
    }

}