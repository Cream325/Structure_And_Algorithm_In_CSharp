using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.LinearStructures
{
    public interface IFindable<T>
    {
        T? Search(int index);
        T? Delete(int index);
    }
}
