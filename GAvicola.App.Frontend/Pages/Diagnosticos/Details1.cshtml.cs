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
    public class Details1Model : PageModel
    {
        private readonly IRepositorioDiagnostico _repoDiagnostico;

        public Diagnostico diagnostico { get; set; }

        public Details1Model(IRepositorioDiagnostico repoDiagnostico)
        {
            _repoDiagnostico=repoDiagnostico;
        }


        public IActionResult OnGet(int id)
        {
            diagnostico = _repoDiagnostico.GetDiagnostico(id);
            if (diagnostico == null)
            {
                return NotFound();
            }else
            {
                return Page();
            }
        }
    }
}


