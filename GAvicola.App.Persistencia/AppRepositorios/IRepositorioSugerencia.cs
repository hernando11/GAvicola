using System.Collections.Generic;
using System.Linq;  // 05 Septiembre 2021
using GAvicola.App.Dominio;

namespace GAvicola.App.Persistencia
{
    public interface IRepositorioSugerencia
    {
        IEnumerable<Sugerencia> GetAllSugerencias();
        Sugerencia AddSugerencia(Sugerencia sugerencia);
        Sugerencia UpdateSugerencia(Sugerencia sugerencia);
        //void DeleteGalpon(int idGalpon);
        Sugerencia GetSugerencia(int idSugerencia);
        // Comentariado 07 Sept 2021
        //Veterinario AsignarVeterinario(int IdGalpon, int IdVeterinario);
        //Operario AsignarOperario(int IdGalpon, int IdOperario);

    }
}