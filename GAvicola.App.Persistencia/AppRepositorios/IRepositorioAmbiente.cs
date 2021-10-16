using System.Collections.Generic;
using System.Linq;  // 05 Septiembre 2021
using GAvicola.App.Dominio;

namespace GAvicola.App.Persistencia
{
    public interface IRepositorioGAmbiente
    {
        IEnumerable<GAmbiente> GetAllGAmbientes();
        GAmbiente AddGAmbiente(GAmbiente gambiente);
        GAmbiente UpdateGAmbiente(GAmbiente gaambiente);
        //void DeleteGalpon(int idGalpon);
        GAmbiente GetGAmbiente(int idAmbiente);
        // Comentariado 07 Sept 2021
        //Veterinario AsignarVeterinario(int IdGalpon, int IdVeterinario);
        Operario AsignarOperario(int IdAmbiente, int IdOperario);
        Galpon AsignarGalpon(int IdAmbiente, int IdGalpon);

    }
}