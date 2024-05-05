using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Nodes
{
    public class Node
    {
        private object? data;

        public object? Data { get => data; set => data = value; }

        public Node(object data)
        {
            this.data = data;
        }
    }
}
