using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.Queue
{
    public interface AbstractQueue
    {
        public abstract void Enqueue(object newData);

        public abstract Node? Dequeue();
    }
}
