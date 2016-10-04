using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEstante
{
    public class Ordenar
    {
        public static Biblioteca_De_Clases.Estante Orden(Biblioteca_De_Clases.Estante est)
        {
            est.GetProductos().Sort(Biblioteca_De_Clases.Producto.ordenarXCodigo);
            return est;
        }
    }
}
