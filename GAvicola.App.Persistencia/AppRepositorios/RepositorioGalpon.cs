using System.Collections.Generic;
using System.Linq;
using GAvicola.App.Dominio;

namespace GAvicola.App.Persistencia
{
    public class RepositorioGalpon : IRepositorioGalpon
    {

        private readonly AppContext _appContext;
        // 07 Sept 2021
        // Es indispensable para "Singleton" Funcione correctmente
        public RepositorioGalpon(){
            _appContext = new AppContext();
        }

        public RepositorioGalpon(AppContext appContext)
        {
            _appContext=appContext;
        }


        Galpon IRepositorioGalpon.AddGalpon(Galpon galpon)
        {
            var galponAdicionado= _appContext.Galpones.Add(galpon);
            _appContext.SaveChanges();
            return galponAdicionado.Entity;

        }

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
        
        IEnumerable<Galpon> IRepositorioGalpon.GetAllGalpones()
        {
            return _appContext.Galpones;
        }

        Galpon IRepositorioGalpon.GetGalpon(int idGalpon)
        {
            /* Cometariado el 11 Octubre 2021
            return _appContext.Galpones.FirstOrDefault(p => p.Id==idGalpon);
            */
            return _appContext.Galpones.Find(idGalpon);

        }

        Galpon IRepositorioGalpon.UpdateGalpon(Galpon galpon)
        {
            var galponEncontrado=_appContext.Galpones.FirstOrDefault(p => p.Id==galpon.Id);
            if (galponEncontrado != null)
            {
                galponEncontrado.Nombre=galpon.Nombre;
                galponEncontrado.NumAves=galpon.NumAves;
                galponEncontrado.FechaIngreso=galpon.FechaIngreso;
                galponEncontrado.FechaEgreso=galpon.FechaEgreso;
                galponEncontrado.Latitud=galpon.Latitud;
                galponEncontrado.Longitud=galpon.Longitud;

                _appContext.SaveChanges();
                
            }
            return galponEncontrado;

        }

        // ASIGNA un Veterinario a un Galpon
        // 07 Septiembre 2021
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

        // ASIGNA un Operario a un Galpon
        // 07 Septiembre 2021
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
        



    }

}