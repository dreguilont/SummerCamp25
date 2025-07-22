using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMaquinaExpendedoraProyecto
{
    public class Slot
    {

        public int id { get; set; }
        public Producto producto { get; set; }

        public int capacidad { get; set; }
        public int cantidad { get; set; }

        public int stockMinimo { get; set; }
        public DateTime ultimaReposicion { get; set; }


        private int reponer(int cantidad)
        {
            try
            {
                this.cantidad += cantidad;
                this.ultimaReposicion = DateTime.Now;
                return 1;
            }
            catch {
                return -1;
            }
        }

        public void EstablecerProducto(Producto producto)
        {
            this.producto = producto;
            cantidad = 0;
        }

        public bool NecesitaReposicion()
        {
            return this.cantidad < this.stockMinimo;
        }

        public bool RetirarProducto()
        {
            if (this.cantidad > 0)
            {
                this.cantidad -= 1;
                return true;
            }
            return false;
        }

        public bool ContieneProducto(Producto producto)
        {
            return this.producto != null && this.producto.Nombre.Equals(producto.Nombre,StringComparison.OrdinalIgnoreCase);
        }

    }
}
