using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Nodes
{
    public class LinkedListNode : Node
    {
        #region Member Fields
        private LinkedListNode nextNode;
        private LinkedListNode previousNode;
        #endregion

        #region Properties
        public LinkedListNode NextNode { get => nextNode; set => nextNode = value; }
        public LinkedListNode PreviousNode { get => previousNode; set => previousNode = value; }
        #endregion

        public LinkedListNode(object data) : base(data) { }
    }
}
