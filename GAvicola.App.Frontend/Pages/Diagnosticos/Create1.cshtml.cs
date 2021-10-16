using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GAvicola.App.Dominio;
using GAvicola.App.Persistencia;

namespace GAvicola.App.Frontend.Pages.Diagnosticos
{
    public class Create1Model : PageModel
    {
        // Fecha 12 Octubre 2021 - Explicacion
        // Con esto traemos la Interface "IrepositoropGalpon"
        // y traemos el objeto de la clase Galpon
        private readonly IRepositorioDiagnostico _repoDiagnostico;

        public Diagnostico diagnostico { get; set; }

        public Create1Model(IRepositorioDiagnostico repoDiagnostico)
        {
            // Fecha 12 Octubre 2021 - Explicacion
            // Con el guion bejo"_" lo identificamos como el 
            // AppContext para poder utilizar.
            _repoDiagnostico=repoDiagnostico;
        }

        public IActionResult OnPost(Diagnostico diagnostico)
        {
            if (ModelState.IsValid)
            {
                _repoDiagnostico.AddDiagnostico(diagnostico);
                return RedirectToPage("Index1");
            }
            else
            {
                return Page();
            }
        }


        public void OnGet()
        {
            diagnostico = new Diagnostico();
        }
    }
}
