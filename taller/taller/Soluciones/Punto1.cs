using System;

namespace taller.Soluciones
{
    public class Punto1
{
        public String solucion()
        {
            Console.Write("ingrese la primera nota: ");
            int  primera = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la segunda nota: ");
            int segunda = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la tercera nota: ");
            int tercera = Convert.ToInt32(Console.ReadLine());

            
            
            if ((primera + segunda + tercera) / 3 >= 3)
            {
                 
                return "el estudiante pudo pasar";
            }

            return "el estudiante no pudo pasar";

        }
    }
}