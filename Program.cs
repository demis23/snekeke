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
            HorLine upLine = new HorLine(0, 78, 0, '*');
            upLine.Draw();

            HorLine downLine = new HorLine(0, 78, 24, '*');
            downLine.Draw();

            VertLine leftLine = new VertLine(0, 24, 0, '*');
            leftLine.Draw();
            
            VertLine rightLine = new VertLine(0, 24, 78, '*');
            rightLine.Draw();


            Console.ReadLine();
        }
    }
}
