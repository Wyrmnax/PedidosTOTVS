﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly PedidosTOTVS.Models.PedidosContext _context;

        public DetailsModel(PedidosTOTVS.Models.PedidosContext context)
        {
            _context = context;
        }

        public Cliente Cliente { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cliente = await _context.Cliente.FirstOrDefaultAsync(m => m.ID == id);

            if (Cliente == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
