using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GAvicola.App.Dominio;
using GAvicola.App.Persistencia;

namespace GAvicola.App.Frontend.Pages.Operarios
{
    public class Create1Model : PageModel
    {
        private readonly IRepositorioOperario _repoOperario;

        public Operario operario { get; set; }

        public Create1Model(IRepositorioOperario repoOperario)
        {
            _repoOperario=repoOperario;
        }

        public IActionResult OnPost(Operario operario)
        {
            if (ModelState.IsValid)
            {
                _repoOperario.AddOperario(operario);
                return RedirectToPage("Index1");
            }
            else
            {
                return Page();
            }
        }


        public void OnGet()
        {
            operario = new Operario();
        }
    }
}
