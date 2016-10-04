using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases
{
    public class Producto
    {
        protected int _codigoBarra;
        protected EMarcaProducto _marca;
        public EMarcaProducto Marca
        {
            get
            {
                return this._marca;
            }
        }
        protected float _precio;
        public float Precio
        {
            get
            {
                return this._precio;
            }
        }

        public static explicit operator int(Producto prod)
        {
            return prod._codigoBarra;
        }

        protected string MostrarProducto(Producto prod)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Codigo: " + this._codigoBarra);           
            sb.AppendLine("Marca: " + this._marca);          
            sb.AppendLine("Precio: " + this._precio);

            return sb.ToString();
        }

        public static bool operator !=(Producto prodUno, EMarcaProducto marca)
        {
            if (prodUno.Marca == marca)
                return false;

            return true;
        }


        public static bool operator !=(Producto prodUno, Producto prodDos)
        {
            if (prodUno.Marca == prodDos.Marca && prodUno._codigoBarra == prodDos._codigoBarra)
                return false;
            return true;
        }


        public static bool operator ==(Producto prodUno, EMarcaProducto marca)
        {
            if (prodUno.Marca == marca)
            return true;

            return false;
            
        }


        public static bool operator ==(Producto prodUno, Producto prodDos)
        {
            if (prodUno.Marca == prodDos.Marca && prodUno._codigoBarra == prodDos._codigoBarra)
                return true;
            return false;

            
        }

        public Producto(int codigo, EMarcaProducto marca, float precio)
        {
            this._codigoBarra = codigo;
            this._marca = marca;
            this._precio = precio;
        }

        public static int ordenarXCodigo(Producto prod1, Producto prod2)
        {
            return string.Compare(prod1._codigoBarra.ToString(), prod2._codigoBarra.ToString());
        }


    }
}
