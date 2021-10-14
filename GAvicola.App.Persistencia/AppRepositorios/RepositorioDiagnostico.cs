using System.Collections.Generic;
using System.Linq;
using GAvicola.App.Dominio;

namespace GAvicola.App.Persistencia
{
    public class RepositorioDiagnostico : IRepositorioDiagnostico
    {

        private readonly AppContext _appContext;
        // 07 Sept 2021
        // Es indispensable para "Singleton" Funcione correctmente
        public RepositorioDiagnostico(){
            _appContext = new AppContext();
        }

        public RepositorioDiagnostico(AppContext appContext)
        {
            _appContext=appContext;
        }


        Diagnostico IRepositorioDiagnostico.AddDiagnostico(Diagnostico diagnostico)
        {
            var diagnosticoAdicionado= _appContext.Diagnosticos.Add(diagnostico);
            _appContext.SaveChanges();
            return diagnosticoAdicionado.Entity;

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
         IEnumerable<Diagnostico> IRepositorioDiagnostico.GetAllDiagnosticos()
        {
            return _appContext.Diagnosticos;
        }



        Diagnostico IRepositorioDiagnostico.GetDiagnostico(int idDiagnostico)
        {
            return _appContext.Diagnosticos.FirstOrDefault(p => p.Id==idDiagnostico);

        }

        Diagnostico IRepositorioDiagnostico.UpdateDiagnostico(Diagnostico diagnostico)
        {
            var diagnosticoEncontrada=_appContext.Diagnosticos.FirstOrDefault(p => p.Id==diagnostico.Id);
            if (diagnosticoEncontrada != null)
            {
                diagnosticoEncontrada.Descripcion=diagnostico.Descripcion;
                diagnosticoEncontrada.Fecha=diagnostico.Fecha;
                _appContext.SaveChanges();
                
            }
            return diagnosticoEncontrada;

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