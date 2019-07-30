using System;
using System.Collections.Generic;
using System.Text;

namespace snakeke
{
    class VertLine
    {
        List<Point> pList;

        public VertLine(int yTop, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yTop; y <= yDown; y++)
            {
                Point p = new Point(y, y, sym);
                pList.Add(p);

            }
        }
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
