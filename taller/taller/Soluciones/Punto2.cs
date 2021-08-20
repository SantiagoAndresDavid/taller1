using System;

namespace taller.Soluciones
{
    public class Punto2
    {
        public int solucion()
        {
            Console.Write("es hombre o mujer: ");
            String sexo = Console.ReadLine();
            Console.Write("cual es la edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            if (sexo.ToLower().Equals("hombre"))
            { 
                return (210 - edad) / 10;
            }
            return (220 - edad)/10;
        }
    }
}