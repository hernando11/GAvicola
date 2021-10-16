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
    public class Create1Model : PageModel
    {
        // Fecha 12 Octubre 2021 - Explicacion
        // Con esto traemos la Interface "IrepositoropGalpon"
        // y traemos el objeto de la clase Galpon
        private readonly IRepositorioSugerencia _repoSugerencia;

        public Sugerencia sugerencia { get; set; }

        public Create1Model(IRepositorioSugerencia repoSugerencia)
        {
            // Fecha 12 Octubre 2021 - Explicacion
            // Con el guion bejo"_" lo identificamos como el 
            // AppContext para poder utilizar.
            _repoSugerencia=repoSugerencia;
        }

        public IActionResult OnPost(Sugerencia sugerencia)
        {
            if (ModelState.IsValid)
            {
                _repoSugerencia.AddSugerencia(sugerencia);
                return RedirectToPage("Index1");
            }
            else
            {
                return Page();
            }
        }


        public void OnGet()
        {
            sugerencia = new Sugerencia();
        }
    }
}
