﻿using System;
using System.Collections.Generic;
using System.Text;

namespace snakeke
{
    class HorLine : Figure
    {
        

        public HorLine(int xLeft,int xRight,int y,char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x<=xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
                
            }
        }
        
    }
}
