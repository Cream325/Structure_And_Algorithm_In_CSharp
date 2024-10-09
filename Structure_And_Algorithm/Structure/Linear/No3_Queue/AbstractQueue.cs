using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.Linear.Queue
{
    public interface AbstractQueue<T>
    {
        public abstract void Enqueue(T newData);

        public abstract CustomLinkedListNode<T>? Dequeue();
    }
}
