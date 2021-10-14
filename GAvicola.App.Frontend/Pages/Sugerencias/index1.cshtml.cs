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
    public class index1Model : PageModel
    {   
        
        private readonly IRepositorioSugerencia _repoSugerencia;

        public IEnumerable<Sugerencia> sugerencias { get; set; }

        public index1Model(IRepositorioSugerencia repoSugerencia)
        {
            _repoSugerencia=repoSugerencia;
        }

        public void OnGet()
        {
            sugerencias=_repoSugerencia.GetAllSugerencias();
        }
        

        /*

        public void OnGet()
        {
            
        }
        */


    }
}