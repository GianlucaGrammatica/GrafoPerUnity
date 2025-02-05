using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafoPerUnity
{
    internal class Node
    {
        public int ID;
        public Node[] nodes = new Node[4] {null,null,null,null};

        public Node(int id) {
            ID = id;

        }
    }
}
