using System.Collections.Generic;
using System.Linq;  // 05 Septiembre 2021
using GAvicola.App.Dominio;

namespace GAvicola.App.Persistencia
{
    public interface IRepositorioOperario
    {
        IEnumerable<Operario> GetAllOperarios();
        Operario AddOperario(Operario operario);
        Operario UpdateOperario(Operario opearario);
        void DeleteOperario(int IdOperario);
        Operario GetOperario(int IdOperario);

    }
}