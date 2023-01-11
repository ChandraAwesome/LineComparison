using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public static class Equalsmethod
    {
        public static void Equalss()
        {
            Random random = new Random();
            //
            int x1 = random.Next(0, 10);
            int y1 = random.Next(0, 10);
            int x2 = random.Next(0, 10);
            int y2 = random.Next(0, 10);
            //
            double LENGTH = Math.Sqrt(((x2 - x1) ^ 2) + ((y2 - y1) ^ 2));
            double LENGTH1 = Math.Sqrt(((x2 - x1) ^ 2) + ((y2 - y1) ^ 2));
            Console.WriteLine("length of line :" + LENGTH);
            Console.WriteLine("length1 of line :" + LENGTH1);
            Console.WriteLine("Are they equal="+(LENGTH.Equals(LENGTH1)));
        }
    }
}
