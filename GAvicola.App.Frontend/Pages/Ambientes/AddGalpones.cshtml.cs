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
    public class AddGalponesModel : PageModel
    {
        // Los campos _repoGalpom y _repoOperario  viene del "Appcontext"
        private readonly IRepositorioGAmbiente _repoGAmbiente;
        private readonly IRepositorioGalpon _repoGalpon;

        public GAmbiente gambiente { get; set; }
        public IEnumerable<Galpon> galpones { get; set; }

        public AddGalponesModel(IRepositorioGAmbiente repoGAmbiente, IRepositorioGalpon repoGalpon)
        {
            _repoGAmbiente=repoGAmbiente;
            _repoGalpon=repoGalpon;
        }


        // Esto se ejecuta cuando el ingresa a "AddOperario.cshtml"
        public void OnGet(int id)
        {
            gambiente=_repoGAmbiente.GetGAmbiente(id);
            galpones=_repoGalpon.GetAllGalpones();
        }
        public IActionResult OnPost(int idAmbiente, int idGalpon)
        {
            _repoGAmbiente.AsignarGalpon(idAmbiente, idGalpon);
            return RedirectToPage("Details1", new {id=idAmbiente});
        }
    }
}