﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sneke
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y=2;
            p1.sym = '&';
            Proba(p1.x, p1.y, p1.sym);
            
           /* int x1=1;
            int y1 = 3;
            char sym1 = '*';
            Proba(x1, y1, sym1);
           
            */
           
            int x2 = 2;
            int y2 = 5;
            char sym2 = '#';
            
            
            Proba(x2, y2, sym2);

            
            Console.ReadKey();

        }
        static void Proba(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }


    

    }
}
