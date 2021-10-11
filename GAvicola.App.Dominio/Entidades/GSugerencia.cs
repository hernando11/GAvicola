using System;
namespace GAvicola.App.Dominio
{
    public class GSugerencia
    {
        public int Id {get;set;}
        //public int IdSugerencia {get;set;}

        // Llave Foranea del Operario para relacionar con el Galpon - 3/Sept/2021
        //public int IdGalpon {get;set;}
        public Galpon Galpon{get;set;}

        // Llave Foranea del Operario para relacionar con el Galpon - 3/Sept/2021
        //public int IdVeterinario {get;set;}
        public Persona Veterinario{get;set;}

        public string Diagnostico {get;set;}
        public string Sugenrecia {get;set;}
        public DateTime Fecha {get; set;}
        public string tipo {get;set;}
        public int Activo {get;set;}
    }
}