using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Linear.Deque
{
    public interface AbstractDeque<T>
    {
        public abstract void Push(T newData, IOType type);

        public abstract CustomLinkedListNode<T>? Pop(IOType type);

        public bool IsEmpty();
    }
}
