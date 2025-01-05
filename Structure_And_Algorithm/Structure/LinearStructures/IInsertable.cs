using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.LinearStructures
{
    public interface IInsertable<T>
    {
        public void Insert(T newData, int index);
    }
}
