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
    public class Edit1Model : PageModel
    {
        private readonly IRepositorioVeterinario _repoVeterinario;

        public Veterinario veterinario { get; set; }

        public Edit1Model(IRepositorioVeterinario repoVeterinario)
        {
            _repoVeterinario=repoVeterinario;
        }
        
        public IActionResult OnGet(int id)
        {
            veterinario = _repoVeterinario.GetVeterinario(id);
            if (veterinario == null)
            {
                return NotFound();
            
            }
            else
            {
                return Page();

            }
            
        }
        public IActionResult OnPost(Veterinario veterinario)
        {
           _repoVeterinario.UpdateVeterinario(veterinario);
            return RedirectToPage("index1");
        }
    }
}
