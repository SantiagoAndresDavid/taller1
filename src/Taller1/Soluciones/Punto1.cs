using System;
using System.Globalization;

namespace Taller1.Soluciones
{
    public class Punto1
    {
        public string Solucion()
        {
            Console.Write("ingrese la primera nota: ");
            int primeraNota = Convert.ToInt32(Console.ReadLine(),
                CultureInfo.InvariantCulture);
            Console.Write("Ingrese la segunda nota: ");
            int segundaNota = Convert.ToInt32(Console.ReadLine(),
                CultureInfo.InvariantCulture);
            Console.Write("Ingrese la tercera nota: ");
            int terceraNota = Convert.ToInt32(Console.ReadLine(),
                CultureInfo.InvariantCulture);

            if ((primeraNota + segundaNota + terceraNota) / 3 >= 3)
            {
                return "el estudiante pudo pasar";
            }

            return "el estudiante no pudo pasar";
        }
    }
}
