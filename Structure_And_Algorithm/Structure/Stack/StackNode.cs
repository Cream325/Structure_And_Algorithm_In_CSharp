using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Stack
{
    public class StackNode : Node
    {
        public StackNode(int capacity)
        {
            this.capacity = capacity;
            array = new object[capacity];
        }

        #region Member Fields
        private object[] array;
        private int top = -1;
        private int capacity;
        #endregion

        #region Properties
        protected object[] Array { get => array; set => array = value; }
        protected int Top { get => top; set => top = value; }
        public int Capacity { get => capacity; }
        #endregion
    }
}
