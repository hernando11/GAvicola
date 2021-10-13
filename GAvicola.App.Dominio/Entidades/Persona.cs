using System;
using System.ComponentModel.DataAnnotations;

namespace GAvicola.App.Dominio
{
    public class Persona
    {
        public int Id {get;set;}
        //public int IdPersona {get;set;}

        public int IdRol {get;set;}
        //public Rol IdRol{get;set;}
        public string Usuario {get;set;}
        public string Clave {get;set;}
        [Required]
        [StringLength(50,MinimumLength=2, ErrorMessage="Campo obligatorio, logitud mínima 2 y maxima 50")]
        public string Nombre {get;set;}
        public int Documento {get;set;}
        public string Telefono {get; set;}
        public string Direccion {get;set;}
        [DataType(DataType.EmailAddress)]
        public string Correo {get;set;}
        public int IdVeterinario{get; set;}
        //public Persona IdVeterinario{get;set;}
        public int IdOperario {get;set;}
        //public Persona IdOperario{get;set;}
        public int IdAuxiliar {get;set;}
        //public Persona IdAuxiliar{get;set;}
        public string Tipo {get;set;}
        public int Activo {get;set;}

    }
}