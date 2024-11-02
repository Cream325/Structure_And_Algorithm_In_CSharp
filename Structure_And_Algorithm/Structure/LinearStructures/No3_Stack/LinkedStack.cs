using Structure_And_Algorithm.Structure.Linear.LinkedList;
using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Linear.Stack
{
    /// <summary>
    /// 링크드 리스트 기반 스택
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SinglyLinkedStack<T> : AbstractStack<T, SinglyLinkedList<T>> {
        public SinglyLinkedStack(int i) : base(i) { }
        public SinglyLinkedStack() {}
    }
    public class DoublyLinkedStack<T> : AbstractStack<T, DoublyLinkedList<T>> {
        public DoublyLinkedStack(int i) : base(i) { }
        public DoublyLinkedStack() : base() {}
    }
}
