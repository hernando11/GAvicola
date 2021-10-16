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
        public DbSet<Sugerencia> Sugerencias{get;set;}
        public DbSet<Diagnostico> Diagnosticos{get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            
            //.UseSQLServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =GAvicolaData");
            
            // Fecha 15 Octubre 2021 - Comentariado para conectarse a la NUBE de AZURE
            // Es decir, no se hara conexion LOCAL a la Base de Datso
            //optionsBuilder
            //.UseSqlServer("Initial Catalog=GAvicoladata; Data Source=DESKTOP-R4IP09K; Integrated Security=true");

            optionsBuilder.UseSqlServer("Server=tcp:gavicola.database.windows.net,1433;Database=GAvicoladata;User ID=GAvicola;Password=Nosfera11;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        }
    }
    }

}