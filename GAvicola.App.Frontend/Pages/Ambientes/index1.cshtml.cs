using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GAvicola.App.Dominio;
using GAvicola.App.Persistencia;

namespace GAvicola.App.Frontend.Pages.Ambientes
{
    public class index1Model : PageModel
    {   
        
        private readonly IRepositorioGAmbiente _repoGAmbiente;

        public IEnumerable<GAmbiente> gambientes { get; set; }

        public index1Model(IRepositorioGAmbiente repoGAmbiente)
        {
            _repoGAmbiente=repoGAmbiente;
        }

        public void OnGet()
        {
            gambientes=_repoGAmbiente.GetAllGAmbientes();
        }
        

        /*

        public void OnGet()
        {
            
        }
        */


    }
}

