using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMaquinaExpendedoraProyecto
{
    public class Producto
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Producto(int id, string Nombre, double Precio)
        {
            this.id = id;
            this.Nombre = Nombre;
            this.Precio = Precio;
        }
    }
}
