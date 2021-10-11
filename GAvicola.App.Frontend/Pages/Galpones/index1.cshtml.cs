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
    public class index1Model : PageModel
    {   
        
        private readonly IRepositorioGalpon _repoGalpon;

        public IEnumerable<Galpon> galpones { get; set; }

        public index1Model(IRepositorioGalpon repoGalpon)
        {
            _repoGalpon=repoGalpon;
        }

        public void OnGet()
        {
            galpones=_repoGalpon.GetAllGalpones();
        }
        

        /*

        public void OnGet()
        {
            
        }
        */


    }
}
