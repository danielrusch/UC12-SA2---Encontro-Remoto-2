using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encontro_Remoto_2.Classes
{
    public static class Utils
   
    {
        public static void BarraCarregamento(string texto)

        {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write($">>>>>{texto}");

                for (int i = 0; i < 10; i++)
                {
                    Console.Write("_");
                    Thread.Sleep(300);
                }

                Console.Write("!");
                Thread.Sleep(300);
                Console.ResetColor();
        }
    }
}