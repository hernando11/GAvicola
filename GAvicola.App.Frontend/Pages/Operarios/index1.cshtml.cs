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
    public class index1Model : PageModel
    {

        private readonly IRepositorioOperario _repoOperario;

        public IEnumerable<Operario> operarios {get; set; }

        public index1Model(IRepositorioOperario repoOperario)
        {
            _repoOperario=repoOperario;
        }

        public void OnGet()
        {
            operarios=_repoOperario.GetAllOperarios();
        }
    }
}
