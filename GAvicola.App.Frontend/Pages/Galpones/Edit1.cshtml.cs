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
    public class Edit1Model : PageModel
    {
        private readonly IRepositorioGalpon _repoGalpon;

        public Galpon galpon { get; set; }

        public Edit1Model(IRepositorioGalpon repoGalpon)
        {
            _repoGalpon=repoGalpon;
        }
        
        public IActionResult OnGet(int id)
        {
            galpon = _repoGalpon.GetGalpon(id);
            if (galpon == null)
            {
                return NotFound();
            
            }
            else
            {
                return Page();

            }
            
        }
        public IActionResult OnPost(Galpon galpon)
        {
            if (ModelState.IsValid)
            {
                _repoGalpon.UpdateGalpon(galpon);
                return RedirectToPage("Index1");
            }
            else
            {
                return Page();
            }
        }
    }
}
