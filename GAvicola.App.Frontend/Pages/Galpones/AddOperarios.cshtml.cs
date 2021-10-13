using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GAvicola.App.Dominio;
using GAvicola.App.Persistencia;

namespace GAvicola.App.Frontend.Pages.Galpones
{
    public class AddOperariosModel : PageModel
    {
        // Los campos _repoGalpom y _repoOperario  viene del "Appcontext"
        private readonly IRepositorioGalpon _repoGalpon;
        private readonly IRepositorioOperario _repoOperario;

        public Galpon galpon { get; set; }
        public IEnumerable<Operario> operarios { get; set; }

        public AddOperariosModel(IRepositorioGalpon repoGalpon, IRepositorioOperario repoOperario)
        {
            _repoGalpon=repoGalpon;
            _repoOperario=repoOperario;
        }


        // Esto se ejecuta cuando el ingresa a "AddOperario.cshtml"
        public void OnGet(int id)
        {
            galpon=_repoGalpon.GetGalpon(id);
            operarios=_repoOperario.GetAllOperarios();
        }
        public IActionResult OnPost(int idGalpon, int idOperario )
        {
            _repoGalpon.AsignarOperario(idGalpon, idOperario);
            return RedirectToPage("Details1", new {id=idGalpon});
        }
    }
}
