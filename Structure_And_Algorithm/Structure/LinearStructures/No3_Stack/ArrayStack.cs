using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_And_Algorithm.Structure.LinearStructures.No1_Array;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.Linear.Stack
{
    /// <summary>
    /// 배열 기반 스택
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ArrayStack<T> : AbstractStack<T, ArrayDynamic<T>> {
        public ArrayStack(int i) : base(i) { }
        public ArrayStack() : base() { }
    }
}
