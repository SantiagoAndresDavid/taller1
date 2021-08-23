using System;

namespace taller.Soluciones
{
    public class Punto2
    {
        public int Solucion()
        {
            Console.Write("es hombre o mujer: ");
            string sexo = Console.ReadLine();
            Console.Write("cual es la edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (sexo.ToLower().Equals("hombre"))
            {
                return (210 - edad) / 10;
            }

            return (220 - edad) / 10;
        }
    }
}