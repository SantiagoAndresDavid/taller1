using System;

namespace taller.Soluciones
{
    public class Punto3
    {
        public int solucion()
        {
            Console.WriteLine("cual es el nombre del usuario: ");
            String nombre = Console.ReadLine();
            Console.WriteLine("numero de cuenta: ");
            int nCuenta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el saldo de apertura: ");
            int saldo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("desea 1.abonar o 2.retirar: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("cuanto desea abonar?: ");
                    int abonar = Convert.ToInt32(Console.ReadLine());
                    return saldo + abonar;
                case 2:
                    Console.WriteLine("cuanto desea retirar?: ");
                    int retirar = Convert.ToInt32(Console.ReadLine());
                    return saldo + retirar;
            }
            return 0;
        }
    }
}