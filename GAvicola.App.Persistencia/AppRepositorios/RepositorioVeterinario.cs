using System.Collections.Generic;
using System.Linq;
using GAvicola.App.Dominio;

namespace GAvicola.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {

        //private readonly AppContext _appContext = new AppContext();  // 06 Sept 2021

        // Estas 4 lines deben estar para que funcione la conexion desde la "Consola" para cada
        // Repositorio ( Galpon, Veterinario, Operario,etc). 
        private readonly AppContext _appContext;

        // 07 Sept 2021 El "Singleton" utilizado en "Startup" requiere un contructor SIN PARAMETROS
        // que son las siguientes 3 lineas.
        public RepositorioVeterinario(){
            _appContext = new AppContext();
        }

        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext=appContext;
        }


        Veterinario IRepositorioVeterinario.AddVeterinario(Veterinario veterinario)
        {
            var veterinarioAdicionado= _appContext.Veterinarios.Add(veterinario);
            _appContext.SaveChanges();
            return veterinarioAdicionado.Entity;

        }

        void IRepositorioVeterinario.DeleteVeterinario(int idVeterinario)
        {
            var veterinarioEncontrado=_appContext.Veterinarios.FirstOrDefault(p => p.Id==idVeterinario);
            if (veterinarioEncontrado==null)
            {
                return;
            }
            _appContext.Veterinarios.Remove(veterinarioEncontrado);
            _appContext.SaveChanges();
        }


        IEnumerable<Veterinario> IRepositorioVeterinario.GetAllVeterinarios()
        {
            return _appContext.Veterinarios;
        }

        Veterinario IRepositorioVeterinario.GetVeterinario(int idVeterinario)
        {
            return _appContext.Veterinarios.FirstOrDefault(p => p.Id==idVeterinario);

        }

        Veterinario IRepositorioVeterinario.UpdateVeterinario(Veterinario veterinario)
        {
            var veterinarioEncontrado=_appContext.Veterinarios.FirstOrDefault(p => p.Id==veterinario.Id);
            if (veterinarioEncontrado != null)
            {
                veterinarioEncontrado.Nombre=veterinario.Nombre;
                veterinarioEncontrado.Documento=veterinario.Documento;
                veterinarioEncontrado.Usuario=veterinario.Usuario;
                veterinarioEncontrado.Clave=veterinario.Clave;
                veterinarioEncontrado.Telefono=veterinario.Telefono;
                veterinarioEncontrado.Direccion=veterinario.Direccion;
                veterinarioEncontrado.Correo=veterinario.Correo;
                // veterinarioEncontrado.Usuario=veterinario.Usuario;

                _appContext.SaveChanges();
                
            }
            return veterinarioEncontrado;

        }



    }

}