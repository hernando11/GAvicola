using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GAvicola.App.Dominio;
using GAvicola.App.Persistencia;

namespace GAvicola.App.Frontend.Pages.Sugerencias
{
    public class Edit1Model : PageModel
    {
        private readonly IRepositorioSugerencia _repoSugerencia;

        public Sugerencia sugerencia { get; set; }

        public Edit1Model(IRepositorioSugerencia repoSugerencia)
        {
            _repoSugerencia=repoSugerencia;
        }
        
        public IActionResult OnGet(int id)
        {
            sugerencia = _repoSugerencia.GetSugerencia(id);
            if (sugerencia == null)
            {
                return NotFound();
            
            }
            else
            {
                return Page();

            }
            
        }
        public IActionResult OnPost(Sugerencia sugerencia)
        {
           _repoSugerencia.UpdateSugerencia(sugerencia);
            return RedirectToPage("index1");
        }
    }
}
