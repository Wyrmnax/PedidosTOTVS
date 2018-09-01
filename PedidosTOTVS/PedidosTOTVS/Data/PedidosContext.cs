using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PedidosTOTVS.Model;

namespace PedidosTOTVS.Models
{
    public class PedidosContext : DbContext
    {
        public PedidosContext (DbContextOptions<PedidosContext> options)
            : base(options)
        {
        }

        public DbSet<PedidosTOTVS.Model.Cliente> Cliente { get; set; }
        public DbSet<PedidosTOTVS.Model.Produto> Produto { get; set; }
        public DbSet<PedidosTOTVS.Model.Pedido> Pedido { get; set; }
    }
}
