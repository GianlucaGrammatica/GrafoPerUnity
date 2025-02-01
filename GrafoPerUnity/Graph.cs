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

        // Stampa della matrice
        public void Stampa()
        {
            for (int i = 0; i < VerticesNumber; i++)
            {
                for (int j = 0; j < VerticesNumber; j++)
                {
                    Console.Write(BaseMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        // nella matrice segnero che 00 e nn sono i finali e iniziali quindi 
        //ci saranno n-2 nodi che creero

        /*
         inizio e fine non possono essere direttamente collegati
    non posso avere due porte che portano allo stesso posto, gli archi detti N12 devono essere univoci, quindi nell’inserimento guardo metà della matrice di adiacenza  perché speculare sulla diagonale
    dev’esserci più di un percorso possibile che porti allo stesso posto
    la differenza tra i vari percorsi dev’essere minore di 3, la differenza maggiore e il minore deve essere maggiore di 3
    per il maggiore tolgo i noti 

    creare i e b, che non si colleghino, fai il dijkstra

        */
    }
}
