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
            Graph graph = new Graph(15);
            //graph.GenerateMatrix();
            //graph.Stampa();
            graph.TestGraph();
            Console.ReadKey();
        }
    }
}
