using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMaquinaExpendedoraProyecto
{
    public class VendingMachine
    {
        
        public List<Slot> Slots;
        public bool encendido { get; set; } = true;
        public double dinero { get; set; } = 0;//Para las vueltas

        public List<Slot> getSlots()
        {
            return Slots;
        }

        private void setSlots(List<Slot> Slots)
        {
            this.Slots = Slots;
        }

        internal void encender()
        {
            this.encendido = true;
        }

        internal void apagar()
        {
            this.encendido = false;
        }

        public VendingMachine(List<Slot> Slots)
        {
            this.Slots = Slots;
            this.encendido = true;
            this.dinero = 0;
        }

        private int buscarSlot(int id)
        {
            for (int i = 0; i < this.Slots.Count; i++)
            {
                if (this.Slots[i].id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public int comprarSlot(int id, Monedero monedero)
        {
            int index = this.buscarSlot(id);
            if (index == -1)
            {
                return -1;
            }
            else if (this.Slots[index].cantidad != 0 && monedero.Saldo >= this.Slots[index].producto.Precio)
            {
                this.Slots[index].cantidad -= 1;
                return index;
            }
            else
            {
                return -1;
            }
            
        }
    }
}
