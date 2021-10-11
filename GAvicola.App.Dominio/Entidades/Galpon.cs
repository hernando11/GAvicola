using System;
namespace GAvicola.App.Dominio
{
    public class Galpon
    {
        public int Id {get;set;}
        //public int IdGalpon {get;set;}

        //public int IdOperario {get;set;}
        // Llave Foranea del Operario para relacionar con el Galpon - 3/Sept/2021
        //public Persona Operario {get;set;}
        //**********************************
        // Lo anterior estaba MAL Definido, se corrige asi.
        // Llave Foranea del Operario para relacionar con el Galpon - 9/Sept/2021
        public Operario Operario {get;set;}

        //public int IdVeterinario {get;set;}
        // Llave Foranea del Veterianario para relacionar con el Galpon - 3/Sept/2021
        //public Persona Veterinario {get;set;}
        //**********************************
        // Lo anterior estaba MAL Definido, se corrige asi.
        // Llave Foranea del Operario para relacionar con el Galpon - 9/Sept/2021
        public Veterinario Veterinario {get;set;}

        public string Nombre {get;set;}
        public double Longitud {get;set;}
        public double Latitud {get;set;}
        public string Tipo {get; set;}
        public int NumAves {get;set;}
        public DateTime FechaIngreso{get; set;}
        public DateTime FechaEgreso {get;set;}
        public int Activo {get;set;}
    }
}