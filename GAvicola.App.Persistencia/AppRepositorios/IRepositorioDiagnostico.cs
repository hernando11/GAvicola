using System.Collections.Generic;
using System.Linq;  // 05 Septiembre 2021
using GAvicola.App.Dominio;

namespace GAvicola.App.Persistencia
{
    public interface IRepositorioDiagnostico
    {
        IEnumerable<Diagnostico> GetAllDiagnosticos();
        Diagnostico AddDiagnostico(Diagnostico diagnostico);
        Diagnostico UpdateDiagnostico(Diagnostico diagnostico);
        //void DeleteGalpon(int idGalpon);
        Diagnostico GetDiagnostico(int idDiagnostico);
        // Comentariado 07 Sept 2021
        //Veterinario AsignarVeterinario(int IdGalpon, int IdVeterinario);
        //Operario AsignarOperario(int IdGalpon, int IdOperario);

    }
}