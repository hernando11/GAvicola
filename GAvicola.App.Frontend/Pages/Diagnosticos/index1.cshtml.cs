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
    public class index1Model : PageModel
    {   
        
        private readonly IRepositorioDiagnostico _repoDiagnostico;

        public IEnumerable<Diagnostico> diagnosticos { get; set; }

        public index1Model(IRepositorioDiagnostico repoDiagnostico)
        {
            _repoDiagnostico=repoDiagnostico;
        }

        public void OnGet()
        {
            diagnosticos=_repoDiagnostico.GetAllDiagnosticos();
        }
        

        /*

        public void OnGet()
        {
            
        }
        */


    }
}