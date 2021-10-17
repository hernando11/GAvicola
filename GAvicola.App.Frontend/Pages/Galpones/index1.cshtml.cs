using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using GAvicola.App.Dominio;
using GAvicola.App.Persistencia;

namespace GAvicola.App.Frontend.Pages.Galpones
{
    public class index1Model : PageModel
    {   
        
        private readonly IRepositorioGalpon _repoGalpon;
        // Fecha 17 Octtubre 2021 - Login
        private readonly ILogger<index1Model> _logger;

        public IEnumerable<Galpon> galpones { get; set; }

        // Fecha 17 Octtubre 2021 - Login
        public index1Model(ILogger<index1Model> logger ,IRepositorioGalpon repoGalpon)
        {
            _logger = logger;
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
