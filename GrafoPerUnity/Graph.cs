using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafoPerUnity
{
    internal class Graph
    {
        public int VerticesNumber { get; set; }
        private int[,] BaseMatrix;

        private Random random;

        public Graph(int vertices) {
            VerticesNumber = vertices;

            BaseMatrix = new int[VerticesNumber, VerticesNumber];

            for(int i = 0; i < VerticesNumber; i++)
            {
                for(int j = 0; j < VerticesNumber; j++)
                {
                    BaseMatrix[i, j] = 0;
                }
            }

            random = new Random();
        }

        public void GeneraDiBase()
        {
            for (int i = 0; i < VerticesNumber; i++)
            {
                for (int j = 0; j < VerticesNumber; j++)
                {
                    BaseMatrix[i, j] = random.NextDouble() < 0.5? 1: 0;

                    BaseMatrix[j, i] = BaseMatrix[i, j];
                }
            }
        }


    }
}
