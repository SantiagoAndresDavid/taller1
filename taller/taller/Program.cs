using System;
using taller.Soluciones;
using static System.Console;

namespace taller
{
       class Program
    {
        static void Main(string[] args)
        {
            WriteLine("selecione el ejerccio que desea resolver");
            int  num = Convert.ToInt32(Console.ReadLine());
            
            switch (num)
            {
                
                case 1: 
                    Punto1 punto1 = new Punto1();
                    WriteLine(punto1.solucion());
                    break;
                
                case 2:
                    Punto2 punto2 = new Punto2();
                    WriteLine("las pulsaciones durante 10 segundos de ejercicio: " + punto2.solucion() + "/s");
                    break;
                
                case 3:
                    Punto3 punto3 = new Punto3();
                    WriteLine("el saldo acutual es: " + punto3.solucion());
                    break;
                
                default:
                    WriteLine("Error la opcion que escogio no corresponde al problema");
                    break;
            }
          
            
        }
    }
}