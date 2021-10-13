using System;
// Fecha 12 Octubre 2021 - para los campos "Datetime"
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GAvicola.App.Dominio
{
    ///<summary>Class <c>Galpon</c>
    /// Modelando el Galpon que resguardara las aves
    ///<summary>

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
        [Required]
        [StringLength(50,MinimumLength=3, ErrorMessage="Campo obligatorio, logitud maxima 50")]
        //[Required(ErrorMessage="Campo obligatorio")]
        public string Nombre {get;set;}
        public double Longitud {get;set;}
        public double Latitud {get;set;}
        public string Tipo {get; set;}
        public int NumAves {get;set;}
        [Display (Name="Fecha de Ingreso de las Aves")]
        [Range(typeof(DateTime), "1/1/2021", "1/2/2099", ErrorMessage = "El valor de {0} debe estar entre {1} y {2}")]
        public DateTime FechaIngreso{get; set;}
        [Display (Name="Fecha de Egreso de las Aves")]
        [Range(typeof(DateTime), "1/1/2021", "1/2/2099", ErrorMessage = "El valor de {0} debe estar entre {1} y {2}")]
        public DateTime FechaEgreso {get;set;}
        public int Activo {get;set;}
    }
}