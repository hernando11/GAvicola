using System.Collections.Generic;
using System.Linq;
using GAvicola.App.Dominio;

namespace GAvicola.App.Persistencia
{
    public class RepositorioOperario : IRepositorioOperario
    {

        
        private readonly AppContext _appContext;

        // 07 Sept 2021
        public RepositorioOperario(){
            _appContext = new AppContext();
        }

        public RepositorioOperario(AppContext appContext)
        {
            _appContext=appContext;
        }


        Operario IRepositorioOperario.AddOperario(Operario operario)
        {
            var operarioAdicionado= _appContext.Operarios.Add(operario);
            _appContext.SaveChanges();
            return operarioAdicionado.Entity;

        }

        void IRepositorioOperario.DeleteOperario(int idOperario)
        {
            var operarioEncontrado=_appContext.Operarios.FirstOrDefault(p => p.Id==idOperario);
            if (operarioEncontrado==null)
            {
                return;
            }
            _appContext.Operarios.Remove(operarioEncontrado);
            _appContext.SaveChanges();
        }


        IEnumerable<Operario> IRepositorioOperario.GetAllOperarios()
        {
            return _appContext.Operarios;
        }

        Operario IRepositorioOperario.GetOperario(int idOperario)
        {
            return _appContext.Operarios.FirstOrDefault(p => p.Id==idOperario);

        }

        Operario IRepositorioOperario.UpdateOperario(Operario operario)
        {
            var operarioEncontrado=_appContext.Operarios.FirstOrDefault(p => p.Id==operario.Id);
            if (operarioEncontrado != null)
            {
                operarioEncontrado.Nombre=operario.Nombre;
                operarioEncontrado.Documento=operario.Documento;
                operarioEncontrado.Usuario=operario.Usuario;
                operarioEncontrado.Clave=operario.Clave;
                operarioEncontrado.Telefono=operario.Telefono;
                operarioEncontrado.Direccion=operario.Direccion;
                operarioEncontrado.Correo=operario.Correo;
                _appContext.SaveChanges();
                
            }
            return operarioEncontrado;

        }



    }

}