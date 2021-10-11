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
    public class Create1Model : PageModel
    {
        private readonly IRepositorioGAmbiente _repoGAmbiente;

        public GAmbiente gambiente { get; set; }

        public Create1Model(IRepositorioGAmbiente repoGAmbiente)
        {
            _repoGAmbiente=repoGAmbiente;
        }

        public IActionResult OnPost(GAmbiente gambiente)
        {
            if (ModelState.IsValid)
            {
                _repoGAmbiente.AddGAmbiente(gambiente);
                return RedirectToPage("Index1");
            }
            else
            {
                return Page();
            }
        }


        public void OnGet()
        {
            gambiente = new GAmbiente();
        }
    }
}
