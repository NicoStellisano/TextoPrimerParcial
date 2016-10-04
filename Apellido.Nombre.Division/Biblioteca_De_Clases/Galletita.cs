using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases
{
    public class Galletita:Producto
    {
        private float _peso;

        public Galletita(int codigo, float precio, EMarcaProducto marca, float peso):base(codigo,marca,precio)
        {
            this._peso = peso;
        }

        public static string MostrarGalletita(Galletita galleta)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(galleta.MostrarProducto(galleta));
            sb.AppendLine("Peso: " + galleta._peso);
            return sb.ToString();

        }
    }

}
