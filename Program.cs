﻿using System;

namespace snakeke
{
    class Program
    {
        static void Draw (int x,int y,int sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char sym1 = '*';

            Draw(x1, y1, sym1);
            
            Console.ReadLine();
        }
    }
}