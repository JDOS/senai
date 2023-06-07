using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.Classes
{
    public static class Utils
    {
        
        public static void BarraCarregamento(){
            Console.Write($"Carregando ");
            for(var contador=0; contador<30;contador++){
                Console.Write($"#");
                Thread.Sleep(20);
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}