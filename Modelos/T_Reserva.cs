using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiPop.Modelos
{
    internal class T_Reserva
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public DateTime FechaHora { get; set; }
        public bool Confirmada { get; set; }

        /*
         * Relaciones:
         */
        public int ClienteId { get; set; }
        public T_Cliente Cliente { get; set; }
    }
}
