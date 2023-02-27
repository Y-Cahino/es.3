using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es._3
{
    internal class Program
    {
        public struct struttura
        {
            public string n;
            public float p;
        }
        static void scrittura(struttura struttura, int x, int []a, ref int d)
        {
            foreach(a)
            {
                if (struttura.p > x)
                {
                    Console.WriteLine(struttura.n);
                }
            }
        }
        static void Main(string[] args)
        {
            struttura struttura = new struttura();
            Console.WriteLine("Inserire n prodotti");
            int d=int.Parse(Console.ReadLine());
            int []a = new int[d];
            for (int i=0; i<d; i++)
            {
                Console.WriteLine("Inserire nome");
                struttura.n = Console.ReadLine();
                Console.WriteLine("Inserire prezzo");
                struttura.p= int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Dichiarare prezzo prefissato");
            int x=int.Parse(Console.ReadLine());
            scrittura(struttura,x);
        }
    }
}
