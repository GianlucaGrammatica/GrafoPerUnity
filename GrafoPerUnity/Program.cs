﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafoPerUnity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(6);
            graph.GenerateMatrix();
            graph.Stampa();
            Console.ReadKey();
        }
    }
}
