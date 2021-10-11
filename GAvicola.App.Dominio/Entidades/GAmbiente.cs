using System;
//using System.ComponentModel.DataAnnotations; //Para generar otra PK

namespace GAvicola.App.Dominio
{
    public class GAmbiente
    {
        //[key]  //Para generar otra PK
        public int Id {get;set;}
        //public int AmbienteId {get;set;}  //Para generar otra PK
        //public int IdAmbiente{get;set;}   //Para generar otra PK

        //public int IdGalpon{get;set;}
        // Llave Foranea del Operario para relacionar con el Galpon - 3/Sept/2021
        public Galpon Galpon{get;set;}

        // Llave Foranea del Operario para relacionar con el Galpon - 3/Sept/2021
        //public int IdOperario {get;set;}
        public Galpon Operario{get;set;}

        public double Temperatura {get;set;}
        public double Agua {get;set;}
        public double Alimento {get;set;}
        public int Huevos {get;set;}
        public int Enfermas{get;set;}
        public DateTime Fecha {get;set;}
        public int Activo {get;set;}
    }
}