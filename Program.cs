using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght;
            Console.WriteLine("valeur de BC");
            int BC = int.Parse(Console.ReadLine());
            Console.WriteLine("valeur de CA");
            int CA = int.Parse(Console.ReadLine());
            lenght = (BC * BC) + (CA * CA);   //Math.Pow(BC, 2) + Math.Pow(CA, 2);
            Console.WriteLine(Math.Sqrt(lenght));

        }
    }
}
