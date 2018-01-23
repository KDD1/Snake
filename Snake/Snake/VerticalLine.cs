using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        public VerticalLine(int x, int yUp, int yDown, char symb)
        {

            List<Point> pList;

            pList = new List<Point>();

            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, symb);
                pList.Add(p);

            }

            foreach (Point p in pList)
            {
                p.Draw();
            }

        }
    }
}
