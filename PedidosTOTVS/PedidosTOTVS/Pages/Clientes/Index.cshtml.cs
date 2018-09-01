using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PedidosTOTVS.Model;
using PedidosTOTVS.Models;

namespace PedidosTOTVS.Pages.Clientes
{
    public class IndexModel : PageModel
    {
        private readonly PedidosTOTVS.Models.PedidosContext _context;

        public IndexModel(PedidosTOTVS.Models.PedidosContext context)
        {
            _context = context;
        }

        public IList<Cliente> Cliente { get;set; }

        public async Task OnGetAsync()
        {
            Cliente = await _context.Cliente.ToListAsync();
        }
    }
}
