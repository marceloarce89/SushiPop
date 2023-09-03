using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiPop.Modelos
{
    internal class T_Carrito
    {
        public int Id { get; set; }
        public bool Procesado { get; set; }
        public bool Cancelado { get; set; }

        /*
         * Relaciones
         */
        public int ClienteId { get; set; }
        public T_Cliente Cliente { get; set; }

        public ICollection<T_ItemCarrito> ItemsCarrito { get; set; }
        public virtual T_Pedido Pedido { get; set; }

    }
}
