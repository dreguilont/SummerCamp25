using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMaquinaExpendedoraProyecto
{
    public class Monedero
    {
        public float Saldo { get; private set; }

        public void AgregarSaldo(float monto)
        {
            Saldo += monto;
        }

        public bool RetirarSaldo(float monto)
        {
            if (Saldo >= monto)
            {
                Saldo -= monto;
                return true;
            }
            return false;
        }
    }
}
