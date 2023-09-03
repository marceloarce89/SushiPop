using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiPop.Modelos
{
    internal class T_Reclamo
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string DetalleReclamo { get; set; }

        /*
         * Relaciones:
         */
        public int PedidoId { get; set; }
        public T_Pedido Pedido { get; set; }
    }
}
