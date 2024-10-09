using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.Linear.Stack
{
    public interface AbstractStack<T>
    {
        public abstract void Push(T newData);
        public abstract CustomLinkedListNode<T>? Peek();
        public abstract CustomLinkedListNode<T>? Pop();
        public abstract bool IsEmpty();
    }
}
