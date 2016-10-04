using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases
{
    public class Estante
    {
        protected sbyte _capacidad;
        protected List<Producto> _productos;
        private float _precioEstante;

        public float ValorEstanteTotal
        {
            get
            {
                return GetValorEstante();
            }
        }

        private Estante()
        {
            _productos = new List<Producto>();
            _precioEstante = 0;
        }

        public Estante(sbyte capacidad):this()
        {
            this._capacidad = capacidad;
        }

        public List<Producto> GetProductos()
        {
            return this._productos;
        }

        private float GetValorEstante()
        {
            
            foreach (var item in this._productos)
            {
                _precioEstante += item.Precio; 
            }
            return _precioEstante;
        }

        public float GetValorEstante(ETipoProducto tipo)
        {
            
            foreach (var item in this._productos)
            {
                if (tipo == ETipoProducto.Jugo)
                {
                    _precioEstante += item.Precio;
                }
                else if (tipo == ETipoProducto.Galletita)
                {
                    _precioEstante += item.Precio;

                }
                else if (tipo == ETipoProducto.Gaseosa)
                {
                    _precioEstante += item.Precio;

                }
                else 
                {
                    _precioEstante += item.Precio;

                }

            }
            return _precioEstante;
        }

        public static string MostrarEstante(Estante est)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Contenido Estante: ");
            sb.AppendLine("Capacidad: " + est._capacidad);
            sb.AppendLine("Listado de Productos: ");
            foreach (var item in est._productos)
            {
                if(item is Jugo)
                {
                  sb.AppendLine(((Jugo)item).MostrarJugo());
                }else if(item is Galletita)
                {
                    sb.AppendLine(Galletita.MostrarGalletita((Galletita)item));
            }else if(item is Gaseosa)
                {
                  sb.AppendLine(((Gaseosa)item).MostrarGasesosa());

                }

            }

            return sb.ToString();
        }

        public static bool operator !=(Estante est, Producto prod)
        {
            foreach (Producto item in est._productos)
            {
                if (item == prod)
                    return false;
            }
            return true;
        }

        public static Estante operator -(Estante est, ETipoProducto tipo)
        {
            Estante estAux = est;
            foreach (Producto item in estAux._productos)
            {
                if (item.GetType().ToString() == tipo.ToString())
                {
                    estAux._productos.Remove(item);
                }
            }

            return estAux;
        }

        public static Estante operator -(Estante est, Producto prod)
        {
            Estante estAux = est;

            if (estAux == prod)
                estAux._productos.Remove(prod);

            return estAux;
                
            
        }

        public static bool operator +(Estante est, Producto prod)
        {
            if (est._capacidad > est._productos.Count)
            {
                if (est == prod)
                    return false;

                est._productos.Add(prod);
                return true;

            }
            else
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
                return false;
            }
        }

        public static bool operator ==(Estante est, Producto prod)
        {
            foreach (Producto item in est._productos)
            {
                if (item == prod)
                    return true;
            }
            return false;
        }

    }
}
