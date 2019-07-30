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
            HorLine hLine = new HorLine(5, 10, 9, '*');
            hLine.Draw();

            VertLine vLine = new VertLine(0, 9, 11, '*');
            vLine.Draw();

            
            Console.ReadLine();
        }
    }
}
