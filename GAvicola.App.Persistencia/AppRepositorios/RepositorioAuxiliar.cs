using System.Collections.Generic;
using System.Linq;
using GAvicola.App.Dominio;

namespace GAvicola.App.Persistencia
{
    public class RepositorioAuxiliar : IRepositorioAuxiliar
    {

        private readonly AppContext _appContext = new AppContext();

        //public RepositorioGalpon(AppContext appContext)
        //{
        //    _appContext=appContext;
        //}


        Auxiliar IRepositorioAuxiliar.AddAuxiliar(Auxiliar auxiliar)
        {
            var auxiliarAdicionado= _appContext.Auxiliares.Add(auxiliar);
            _appContext.SaveChanges();
            return auxiliarAdicionado.Entity;

        }

        void IRepositorioAuxiliar.DeleteAuxiliar(int idAuxiliar)
        {
            var auxiliarEncontrado=_appContext.Auxiliares.FirstOrDefault(p => p.Id==idAuxiliar);
            if (auxiliarEncontrado==null)
            {
                return;
            }
            _appContext.Auxiliares.Remove(auxiliarEncontrado);
            _appContext.SaveChanges();
        }


        IEnumerable<Auxiliar> IRepositorioAuxiliar.GetAllAuxiliar()
        {
            return _appContext.Auxiliares;
        }

        Auxiliar IRepositorioAuxiliar.GetAuxiliar(int idAuxiliar)
        {
            return _appContext.Auxiliares.FirstOrDefault(p => p.Id==idAuxiliar);

        }

        Auxiliar IRepositorioAuxiliar.UpdateAuxiliar(Auxiliar auxiliar)
        {
            var auxiliarEncontrado=_appContext.Auxiliares.FirstOrDefault(p => p.Id==auxiliar.Id);
            if (auxiliarEncontrado != null)
            {
                auxiliarEncontrado.Nombre=auxiliar.Nombre;
                //veterinarioEncontrado.Latitud=veterinario.Latitud;
                //veterinarioEncontrado.Longitud=veterinario.Longitud;

                _appContext.SaveChanges();
                
            }
            return auxiliarEncontrado;

        }



    }

}