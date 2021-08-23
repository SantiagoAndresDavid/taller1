using System;
using Taller1.Soluciones;

namespace Taller1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("selecione el ejerccio que desea resolver");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Punto1 punto1 = new Punto1();
                    Console.WriteLine(punto1.Solucion());
                    break;

                case 2:
                    Punto2 punto2 = new Punto2();
                    Console.WriteLine(
                        "las pulsaciones durante 10 segundos de ejercicio: " +
                        punto2.Solucion() + "/s");
                    break;

                case 3:
                    Punto3 punto3 = new Punto3();
                    Console.WriteLine("el saldo acutual es: " +
                                      punto3.Solucion());
                    break;

                default:
                    Console.WriteLine(
                        "Error la opcion que escogio no corresponde al problema");
                    break;
            }
        }
    }
}
