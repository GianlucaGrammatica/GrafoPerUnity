using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GrafoPerUnity
{
    internal class Graph
    {
        public int VerticesNumber { get; set; }
        private int[,] BaseMatrix;
        private List<Node> Grafo;

        public Node FirstNode;
        public Node LastNode;

        private Random random;

        // Costruttore
        public Graph(int vertices) {

            VerticesNumber = vertices;
            BaseMatrix = new int[VerticesNumber, VerticesNumber];
            

            for(int i = 0; i < VerticesNumber; i++)
            {
                //Grafo.Add(new Node());

                for(int j = 0; j < VerticesNumber; j++)
                {
                    BaseMatrix[i, j] = 0;
                }
            }

            //FirstNode = Grafo[0];
            //LastNode = Grafo[VerticesNumber];

            random = new Random();
        }

        // Matrice Casuale
        public void GenerateMatrix()
        {
            int[] connections = new int[VerticesNumber];

            for (int i = 0; i < VerticesNumber; i++)
            {
                for (int j = 0; j < VerticesNumber; j++)
                {
                    // Salta collegamento tra inizio e fine
                    if(i == 0 && j == VerticesNumber - 1)
                    {
                        continue;
                    }

                    // Salta collegamento a se stesso
                    if (i == j)
                    {
                        continue;
                    }

                    // Controlla se non ci sono troppe connessioni e genera casualmente 0 o 1 -> se 1 inserisci
                    if (connections[i] < 4 && connections[j] < 4 && random.NextDouble() < 0.5)
                    {
                        BaseMatrix[i, j] = 1;
                        BaseMatrix[j, i] = 1;

                        // Aumento counter connessioni
                        connections[i]++;
                        connections[j]++;
                    }
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
            return (Vertex >= 0 && Vertex < this.VerticesNumber);
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
        la lista dei nodi, sarà una list, sarà all

        */
    }
}
