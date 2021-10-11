using System.Collections.Generic;
using System.Linq;
using GAvicola.App.Dominio;

namespace GAvicola.App.Persistencia
{
    public class RepositorioGAmbiente : IRepositorioGAmbiente
    {

        private readonly AppContext _appContext;
        // 07 Sept 2021
        // Es indispensable para "Singleton" Funcione correctmente
        public RepositorioGAmbiente(){
            _appContext = new AppContext();
        }

        public RepositorioGAmbiente(AppContext appContext)
        {
            _appContext=appContext;
        }


        GAmbiente IRepositorioGAmbiente.AddGAmbiente(GAmbiente gambiente)
        {
            var gambienteAdicionado= _appContext.GAmbientes.Add(gambiente);
            _appContext.SaveChanges();
            return gambienteAdicionado.Entity;

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
         IEnumerable<GAmbiente> IRepositorioGAmbiente.GetAllGAmbientes()
        {
            return _appContext.GAmbientes;
        }



        GAmbiente IRepositorioGAmbiente.GetGAmbiente(int idAmbiente)
        {
            return _appContext.GAmbientes.FirstOrDefault(p => p.Id==idAmbiente);

        }

        GAmbiente IRepositorioGAmbiente.UpdateGAmbiente(GAmbiente gambiente)
        {
            var gambienteEncontrado=_appContext.GAmbientes.FirstOrDefault(p => p.Id==gambiente.Id);
            if (gambienteEncontrado != null)
            {
                gambienteEncontrado.Temperatura=gambiente.Temperatura;
                gambienteEncontrado.Agua=gambiente.Agua;
                gambienteEncontrado.Alimento=gambiente.Alimento;
                gambienteEncontrado.Huevos=gambiente.Huevos;
                gambienteEncontrado.Enfermas=gambiente.Enfermas;
                gambienteEncontrado.Fecha=gambiente.Fecha;

                _appContext.SaveChanges();
                
            }
            return gambienteEncontrado;

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