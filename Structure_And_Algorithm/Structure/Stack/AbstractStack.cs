using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Stack
{
    public interface AbstractStack
    {
        public abstract void Push(object newData);
        public abstract object? Peek();
        public abstract object? Pop();
        public abstract bool IsEmpty();
    }
}
