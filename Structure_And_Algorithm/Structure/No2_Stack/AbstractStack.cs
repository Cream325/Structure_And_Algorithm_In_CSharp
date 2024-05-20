using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.Stack
{
    public interface AbstractStack
    {
        public abstract void Push(object newData);
        public abstract Node? Peek();
        public abstract Node? Pop();
        public abstract bool IsEmpty();
    }
}
