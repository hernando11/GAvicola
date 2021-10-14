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
        // Fecha 12 Octubre 2021 - Explicacion
        // Con esto traemos del "AppContext" la Interface "IrepositoropOperario"
        // y traemos el objeto "_repoOperario" de la clase Operario
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
                // Fecha 12 Octubre 2021 - Explicacion
                // Esto viene de la "Persistencia" del "Repositorio"
                // "RepositorioOperario", alli esta e Metodo "AddOperario"
                _repoOperario.AddOperario(operario);
                return RedirectToPage("Index1");
            }
            else
            {
                return Page();
            }
        }

        // Fecha 12 Octubre 2021 - Explicacion
        // No lleva parametros, porque lo que necesitamos es 
        // que nos traiga la toda la informacion del Operario
        // que se Caragara en el Formulario de la PANTALLA.
        // es decir, que e Usuario Digitará.
        public void OnGet()
        {
            operario = new Operario();
        }
    }
}
