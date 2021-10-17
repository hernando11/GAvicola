using System;
//using System.ComponentModel.DataAnnotations; //Para generar otra PK
using System.ComponentModel.DataAnnotations;

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
        public Operario Operario{get;set;}

        public double Temperatura {get;set;}
        public double Agua {get;set;}
        public double Alimento {get;set;}
        public int Huevos {get;set;}
        public int Enfermas{get;set;}
        [Display (Name="Fecha de la medicion")]
        [Range(typeof(DateTime), "1/1/2021", "1/2/2099", ErrorMessage = "El valor de {0} debe estar entre {1} y {2}")]
        public DateTime Fecha {get;set;}
        public int Activo {get;set;}
    }
}