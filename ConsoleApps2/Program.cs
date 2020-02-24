using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrarys1;

namespace ConsoleApps2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dammi un numero");
            int n = int.Parse(Console.ReadLine());
            bool risposta = Calcoli.QuadratoPerfetto(n);
            if (risposta)
            {
                Console.WriteLine("il numero è un quadrato perfetto ");

            }
            else
                Console.WriteLine("il numero non è un quadrato perfetto");
            Console.ReadLine();
        }
        
    }
}
