/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GAvicola.App.Frontend.Pages
{
    public class AddOperariosModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GAvicola.App.Dominio;
using GAvicola.App.Persistencia;

namespace GAvicola.App.Frontend.Pages.Ambientes
{
    public class AddOperariosModel : PageModel
    {
        // Los campos _repoGalpom y _repoOperario  viene del "Appcontext"
        private readonly IRepositorioGAmbiente _repoGAmbiente;
        private readonly IRepositorioOperario _repoOperario;

        public GAmbiente gambiente { get; set; }
        public IEnumerable<Operario> operarios { get; set; }

        public AddOperariosModel(IRepositorioGAmbiente repoGAmbiente, IRepositorioOperario repoOperario)
        {
            _repoGAmbiente=repoGAmbiente;
            _repoOperario=repoOperario;
        }


        // Esto se ejecuta cuando el ingresa a "AddOperario.cshtml"
        public void OnGet(int id)
        {
            gambiente=_repoGAmbiente.GetGAmbiente(id);
            operarios=_repoOperario.GetAllOperarios();
        }
        public IActionResult OnPost(int idAmbiente, int idOperario )
        {
            _repoGAmbiente.AsignarOperario(idAmbiente, idOperario);
            return RedirectToPage("Details1", new {id=idAmbiente});
        }
    }
}