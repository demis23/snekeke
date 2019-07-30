using System;
using System.Collections.Generic;
using System.Text;

namespace snakeke
{
    class VertLine : Figure
    {
        

        public VertLine(int yTop, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yTop; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);

            }
        }
        
    }
}
