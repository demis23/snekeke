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
            HorLine line = new HorLine(5, 10, 9, '%');
            line.Draw();

            
            Console.ReadLine();
        }
    }
}
