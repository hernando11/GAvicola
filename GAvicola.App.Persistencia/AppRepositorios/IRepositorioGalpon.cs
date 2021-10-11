using System.Collections.Generic;
using System.Linq;  // 05 Septiembre 2021
using GAvicola.App.Dominio;

namespace GAvicola.App.Persistencia
{
    public interface IRepositorioGalpon
    {
        IEnumerable<Galpon> GetAllGalpones();
        Galpon AddGalpon(Galpon galpon);
        Galpon UpdateGalpon(Galpon galpon);
        void DeleteGalpon(int idGalpon);
        Galpon GetGalpon(int idGalpon);
        // Comentariado 07 Sept 2021
        Veterinario AsignarVeterinario(int IdGalpon, int IdVeterinario);
        Operario AsignarOperario(int IdGalpon, int IdOperario);

    }
}