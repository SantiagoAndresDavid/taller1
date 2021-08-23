using System;
using System.Globalization;

namespace Taller1.Soluciones
{
    public class Punto3
    {
        public int Solucion()
        {
            Console.WriteLine("cual es el nombre del usuario: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("numero de cuenta: ");
            int nuneroCuenta = Convert.ToInt32(Console.ReadLine(),
                CultureInfo.InvariantCulture);
            Console.WriteLine("ingrese el saldo de apertura: ");
            int saldo = Convert.ToInt32(Console.ReadLine(),
                CultureInfo.InvariantCulture);
            Console.WriteLine("desea 1.abonar o 2.retirar: ");
            int opcion = Convert.ToInt32(Console.ReadLine(),
                CultureInfo.InvariantCulture);

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("cuanto desea abonar?: ");
                    int abono = Convert.ToInt32(Console.ReadLine());
                    return saldo + abono;
                case 2:
                    Console.WriteLine("cuanto desea retirar?: ");
                    int retiro = Convert.ToInt32(Console.ReadLine());
                    return saldo + retiro;
            }

            return 0;
        }
    }
}
