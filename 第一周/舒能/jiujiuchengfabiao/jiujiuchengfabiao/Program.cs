﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jiujiuchengfabiao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================九九乘法表==============================");
            
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}×{1}={2}  ", j, i, j * i);
                    if (i * j < 10)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
