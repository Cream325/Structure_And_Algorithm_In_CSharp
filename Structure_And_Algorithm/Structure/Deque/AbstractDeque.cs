using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Deque
{
    public interface AbstractDeque
    {
        public abstract void Push(object newData, IOType type);

        public abstract Node? Pop(IOType type);

        public bool IsEmpty();
    }
}
