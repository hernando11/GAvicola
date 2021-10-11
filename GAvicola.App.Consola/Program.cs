using System;
using System.Collections.Generic;
using GAvicola.App.Dominio;
using GAvicola.App.Persistencia;

namespace GAvicola.App.Consola
{
    class Program
    {

        //private static IRepositorioGalpon _repoGalpon= new RepositorioGalpon();

        //private static IRepositorioGalpon _repoGalpon= new RepositorioGalpon(new Persistencia.AppContext());
        
        // Fecha 7 Octuvre 2021
        // De esta forma funciona la conexion con los "RepositoriosXXXX.cs" ubicados en "Persietencia"  Fecha 06 Sept 2021
        private static IRepositorioGalpon _repoGalpon= new RepositorioGalpon(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario= new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioOperario _repoOperario= new RepositorioOperario(new Persistencia.AppContext());
        /* En cada uno de los "RepositoriosXXXX.cs" de "Persistencia" deben de ir estass 4 lineas.  - Fecha 06 Sept 2021
        private readonly AppContext _appContext;
        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext=appContext;
        }
        */

        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! HGP ENTIDADES");
            //AddGalpon();
            //BuscarGalpon(2);
            //EliminarGalpon(2);
            MostrarGalpones();

            //AddVeterinario();
            MostrarVeterinarios();
            //AddOperario();
            //MostrarOperarios();
            AsignarVeterinario();
            //AsignarOperario();
        }
        

        private static void AddGalpon()
        {
            var galpon = new Galpon{
                Nombre="Galpon2_HGP",
                Longitud= 2.23,
                Latitud = 75.66,
                FechaEgreso = new DateTime(2021,07,11),
                FechaIngreso = new DateTime(2021,01,01),
                NumAves = 2500
            };
            _repoGalpon.AddGalpon(galpon);
        }

        private static void BuscarGalpon(int idGalpon)
        {
            var galpon = _repoGalpon.GetGalpon(idGalpon);
            Console.WriteLine(galpon.Nombre+" - "+galpon.Id);
        }

        private static void EliminarGalpon(int IdGalpon)
        {
            _repoGalpon.DeleteGalpon(IdGalpon);
            Console.WriteLine(" Galpon Eliminado");
        }

        private static void MostrarGalpones()
        {
            IEnumerable<Galpon> galpones = _repoGalpon.GetAllGalpones();
            foreach ( var galpon in galpones)
            {
                Console.WriteLine(galpon.Nombre+" -Id : "+galpon.Id+" Veterinario "+galpon.Veterinario);
                Console.WriteLine(" *************** ");
            }
        }
        // ASIGNA un Veterinario a un Galpon.
        private static void AsignarVeterinario()
        {
            var veterinario = _repoGalpon.AsignarVeterinario(5,4);
            Console.WriteLine("Asignar Veterinario"+veterinario.Nombre+" Id : "+veterinario.Id);
        }

        // ASIGNA un Operario a un Galpon.
        private static void AsignarOperario()
        {
            var operario = _repoGalpon.AsignarOperario(1,3);
            Console.WriteLine(operario.Nombre+" Id : "+operario.Id);
        }

        
        // VETERINARIO

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {               
               Usuario="CataGP_usu",
               Clave="CataGP_clave",
               Nombre="Vet Catalina",
               Documento=15,
               Telefono="315",
               Direccion="Cra 85",
               Correo="catagp@"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

          private static void MostrarVeterinarios()
        {
            IEnumerable<Veterinario> veterinarios = _repoVeterinario.GetAllVeterinarios();
            foreach ( var veterinario in veterinarios)
            {
                Console.WriteLine(veterinario.Nombre+" - Id : "+veterinario.Id);
            }
        }


        // OPERARIO

        private static void AddOperario()
        {
            var operario = new Operario
            {               
               Usuario="Nando_usu",
               Clave="Nando_clave",
               Nombre="Ope Nando",
               Documento=52,
               Telefono="320",
               Direccion="Cra 86",
               Correo="nando@"
            };
            _repoOperario.AddOperario(operario);
        }

        private static void MostrarOperarios()
        {
            IEnumerable<Operario> operarios = _repoOperario.GetAllOperarios();
            foreach ( var operario in operarios)
            {
                Console.WriteLine(operario.Nombre+" - Id : "+operario.Id);
            }
        }

        //private static void AsignarVeterinarioGalpon(1,2);
        //{


        //}
        


    }
}
