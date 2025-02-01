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

        // Costruttore
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

        // Matrice Casuale
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

        // Aggiunta
        public void AddEdge(int Vertex1, int Vertex2)
        {
            if(isValidVertex(Vertex1) && isValidVertex(Vertex2))
            {
                this.BaseMatrix[Vertex1, Vertex2] = 1;
                this.BaseMatrix[Vertex2, Vertex1] = 1;
            }
        }

        // Rimozione
        public void RemoveEdge(int Vertex1, int Vertex2)
        {
            if (isValidVertex(Vertex1) && isValidVertex(Vertex2))
            {
                this.BaseMatrix[Vertex1, Vertex2] = 0;
                this.BaseMatrix[Vertex2, Vertex1] = 0;
            }
        }


        // Validazione
        private bool isValidVertex(int Vertex)
        {
            return (Vertex > 0 && Vertex < this.VerticesNumber);
        }
    }
}
