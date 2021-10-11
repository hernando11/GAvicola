using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GAvicola.App.Dominio;
using GAvicola.App.Persistencia;

namespace GAvicola.App.Frontend.Pages.Veterinarios
{
    public class Create1Model : PageModel
    {
        private readonly IRepositorioVeterinario _repoVeterinario;

        public Veterinario veterinario { get; set; }

        public Create1Model(IRepositorioVeterinario repoVeterinario)
        {
            _repoVeterinario=repoVeterinario;
        }

        public IActionResult OnPost(Veterinario veterinario)
        {
            if (ModelState.IsValid)
            {
                _repoVeterinario.AddVeterinario(veterinario);
                return RedirectToPage("Index1");
            }
            else
            {
                return Page();
            }
        }


        public void OnGet()
        {
            veterinario = new Veterinario();
        }
    }
}
