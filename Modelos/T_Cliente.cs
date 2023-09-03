using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiPop.Modelos
{
    internal class T_Cliente : T_Usuario
    {
        public int Id { get; set; }
        public int NumeroCliente { get; set; }

        /*
         * Relaciones:
         */

        public ICollection<T_Carrito> Carrito { get; set; }
        public ICollection<T_Reserva> Reservas { get; set; }



    }
}
