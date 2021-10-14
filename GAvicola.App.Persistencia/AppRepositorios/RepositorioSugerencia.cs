using System.Collections.Generic;
using System.Linq;
using GAvicola.App.Dominio;

namespace GAvicola.App.Persistencia
{
    public class RepositorioSugerencia : IRepositorioSugerencia
    {

        private readonly AppContext _appContext;
        // 07 Sept 2021
        // Es indispensable para "Singleton" Funcione correctmente
        public RepositorioSugerencia(){
            _appContext = new AppContext();
        }

        public RepositorioSugerencia(AppContext appContext)
        {
            _appContext=appContext;
        }


        Sugerencia IRepositorioSugerencia.AddSugerencia(Sugerencia sugerencia)
        {
            var sugerenciaAdicionada= _appContext.Sugerencias.Add(sugerencia);
            _appContext.SaveChanges();
            return sugerenciaAdicionada.Entity;

        }

        /*
        void IRepositorioGalpon.DeleteGalpon(int idGalpon)
        {
            var galponEncontrado=_appContext.Galpones.FirstOrDefault(p => p.Id==idGalpon);
            if (galponEncontrado==null)
            {
                return;
            }
            _appContext.Galpones.Remove(galponEncontrado);
            _appContext.SaveChanges();
        }
        */
        
        /*
        IEnumerable<Galpon> IRepositorioGalpon.GetAllGalpones()
        {
            return _appContext.Galpones;
        }
        */
         IEnumerable<Sugerencia> IRepositorioSugerencia.GetAllSugerencias()
        {
            return _appContext.Sugerencias;
        }



        Sugerencia IRepositorioSugerencia.GetSugerencia(int idSugerencia)
        {
            return _appContext.Sugerencias.FirstOrDefault(p => p.Id==idSugerencia);

        }

        Sugerencia IRepositorioSugerencia.UpdateSugerencia(Sugerencia sugerencia)
        {
            var sugerenciaEncontrada=_appContext.Sugerencias.FirstOrDefault(p => p.Id==sugerencia.Id);
            if (sugerenciaEncontrada != null)
            {
                sugerenciaEncontrada.Descripcion=sugerencia.Descripcion;
                sugerenciaEncontrada.Fecha=sugerencia.Fecha;
                _appContext.SaveChanges();
                
            }
            return sugerenciaEncontrada;

        }

        // ASIGNA un Veterinario a un Galpon
        // 07 Septiembre 2021
        /*
        Veterinario IRepositorioGalpon.AsignarVeterinario(int IdGalpon, int IdVeterinario)
        {
            var galponEncontrado = _appContext.Galpones.Find(IdGalpon);
            if ( galponEncontrado != null)
            {
                var veterinarioEncontrado = _appContext.Veterinarios.Find(IdVeterinario);
                if ( veterinarioEncontrado != null)
                {
                    //galponEncontrado.VeterinarioId = veterinarioEncontrado;
                    galponEncontrado.Veterinario = veterinarioEncontrado; //IdVeterinario;
                    _appContext.SaveChanges();
                }
                return veterinarioEncontrado;
            }
            // Yo colo que sto para solucionar un error 06 Sept 2021
            return null;
        }
        */

        // ASIGNA un Operario a un Galpon
        // 07 Septiembre 2021
        /*
        Operario IRepositorioGalpon.AsignarOperario(int IdGalpon, int IdOperario)
        {
            var galponEncontrado = _appContext.Galpones.Find(IdGalpon);
            if ( galponEncontrado != null)
            {
                var operarioEncontrado = _appContext.Operarios.Find(IdOperario);
                if ( operarioEncontrado != null)
                {
                    //galponEncontrado.VeterinarioId = veterinarioEncontrado;
                    galponEncontrado.Operario = operarioEncontrado; //IdVeterinario;
                    _appContext.SaveChanges();
                }
                return operarioEncontrado;
            }
            // Yo colo que sto para solucionar un error 06 Sept 2021
            return null;
        }
        */
        



    }

}