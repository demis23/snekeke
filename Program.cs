using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeke
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4,5,'#');
            p2.Draw();

            List<Point> pointList = new List<Point>();
            pointList.Add(p1);
            pointList.Add(p2);
            Console.ReadLine();
        }
    }
}
