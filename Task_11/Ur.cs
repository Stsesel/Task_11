using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    struct Ur
    {
        double b;
        double k;

        public Ur (double b, double k)
        {
            this.b = b;
            this.k = k;
        }

        public string Root()
        {
            if (k == 0)
                return "Решений нет";

            double x = (-1 * b) / k;
            return $"Решение - {x}";
            

        }
    }
}
