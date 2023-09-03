using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiPop.Modelos
{
    internal class T_Descuento
    {
        public int Id { get; set; }
        public int Dia { get; set; }
        public int Porcentaje { get; set; }
        public int DescuentoMax { get; set; }
        public bool Activo { get; set; }

        /*
         * Relaciones:
         */

        public int ProductoId { get; set; }
        public T_Producto producto { get; set; }
    }
}
