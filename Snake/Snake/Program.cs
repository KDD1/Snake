using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            HorizontalLine HLine = new HorizontalLine(5, 10, 8, '+');

            VerticalLine VLine = new VerticalLine(5, 10, 17, '+');

            Console.ReadLine();

        }
    }
}
