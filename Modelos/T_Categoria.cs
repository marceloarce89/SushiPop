using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiPop.Modelos
{
    internal class T_Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        /*
         * Relaciones:
         */
        public ICollection<T_Producto> Producto { get; set; }
    }
}
