using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GAvicola.App.Dominio;
using GAvicola.App.Persistencia;

namespace GAvicola.App.Frontend.Pages.Galpones
{
    public class Details1Model : PageModel
    {
        private readonly IRepositorioGalpon _repoGalpon;
        // Adicioando 12 Octubre 2021
        private readonly IRepositorioOperario _repoOperario;

        public Galpon galpon { get; set; }
        // Adicioando 12 Octubre 2021
        public IEnumerable<Operario> operarios { get; set; }

        public Details1Model(IRepositorioGalpon repoGalpon)
        {
            _repoGalpon=repoGalpon;
            // Adicioando 12 Octubre 2021
            //_repoOperario=repoOperario;
        }


        public IActionResult OnGet(int id)
        {
            galpon = _repoGalpon.GetGalpon(id);
            if (galpon == null)
            {
                return NotFound();
            }else
            {
                return Page();
            }
        }
    }
}
