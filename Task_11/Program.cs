using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = Convert.ToDouble(Console.ReadLine());
            double k = Convert.ToDouble(Console.ReadLine());

            Ur ur = new Ur(b, k);
            Console.WriteLine(ur.Root());
            Console.ReadKey();
        }
    }
}
