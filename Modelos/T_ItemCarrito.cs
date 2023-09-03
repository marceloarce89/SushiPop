using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiPop.Modelos
{
    internal class T_ItemCarrito
    {
        public int Id { get; set; }
        public int PrecioUnitConDto { get; set; }
        public int Cantidad { get; set; }

        /*
         *Relaciones: 
         */

        public int CarritoId { get; set; }
        public T_Carrito Carrito { get; set; }
        public int ProductoId { get; set; }
        public T_Producto Producto { get; set; }

    }
}
