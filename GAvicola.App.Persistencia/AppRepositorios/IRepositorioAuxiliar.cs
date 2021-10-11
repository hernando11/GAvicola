using System.Collections.Generic;
using System.Linq;  // 05 Septiembre 2021
using GAvicola.App.Dominio;

namespace GAvicola.App.Persistencia
{
    public interface IRepositorioAuxiliar
    {
        IEnumerable<Auxiliar> GetAllAuxiliar();
        Auxiliar AddAuxiliar(Auxiliar auxiliar);
        Auxiliar UpdateAuxiliar(Auxiliar auxiliar);
        void DeleteAuxiliar(int IdAuxiliar);
        Auxiliar GetAuxiliar(int IdAuxiliar);

    }
}