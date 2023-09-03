using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiPop.Modelos
{
    internal class T_Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descipcion { get; set; }
        public int Precio { get; set; }
        public string Foto { get; set; }
        public int Stock { get; set; }
        public int Costo { get; set; }

        /*
         * Relaciones:
         */
        public ICollection<T_Descuento> Descuento { get; set; }
        public ICollection<T_ItemCarrito> ItemCarrito { get; set; }

        public int CategoriaId { get; set; }
        public T_Categoria Categoria { get; set; }


    }
}
