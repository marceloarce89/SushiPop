using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiPop.Modelos
{
    internal class T_Pedido
    {
        public int Id { get; set; }
        public int NroPedido { get; set; }
        public DateTime FechaCompra { get; set; }
        public int Subtotal { get; set; }
        public int GastoEnvio { get; set; }
        public int Total { get; set; }
        public int Estado { get; set; }

        /*
         * Relaciones:
         */
        public int CarritoId { get; set; }
        public T_Carrito Carrito { get; set; }
        public virtual T_Reclamo Reclamo { get; set; }

    }
}
