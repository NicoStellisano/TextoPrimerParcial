using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases
{
    public class Gaseosa:Producto
    {
        private float _litros;

        public Gaseosa(int codigo, float precio, EMarcaProducto marca, float litros):base(codigo,marca,precio)
        {
            this._litros = litros;
        }

        public Gaseosa(Producto producto, float litros):this((int)producto,producto.Precio,producto.Marca,litros)
        {

        }

        public string MostrarGasesosa()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.MostrarProducto(this));
            sb.AppendLine("Litros: " + this._litros);
            return sb.ToString();
        }
    }
}
