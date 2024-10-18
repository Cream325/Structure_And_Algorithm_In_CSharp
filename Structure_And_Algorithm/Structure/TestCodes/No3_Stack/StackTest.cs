using Structure_And_Algorithm.Structure.Linear.LinkedList;
using Structure_And_Algorithm.Structure.Linear.Stack;
using Structure_And_Algorithm.Structure.TestCodes.No2_LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.TestCodes.No3_Stack
{
    /// <summary>
    /// 스택 타입
    /// </summary>
    public enum StackType
    {
        ArrayStack,
        LinkedStack
    }

    /// <summary>
    /// 스탯 테스트코드 클래스
    /// </summary>
    public class StackTest<T> : IStackTest<T>
    {
        #region Member Fields
        private AbstractStack<T> stack;
        private StackType stackType;
        #endregion

        #region Constructors
        public StackTest(StackType stackType)
        {
            this.stackType = stackType;
            string typeInitial = stackType == StackType.ArrayStack ? "배열 기반" : "링크드 리스트 기반";

            Console.WriteLine($"[<{typeInitial} 스택 테스트>]\n");
        }
        #endregion

        #region Overrides
        public void ConstructorTest(T? initialData = default, int capacity = 10)
        {
            #region Function 1-1. 매개변수가 없을 경우
            if (initialData == null)
            {
                Console.WriteLine("-> Function 1-1. 매개변수가 없을 경우");
                switch (stackType)
                {
                    case StackType.ArrayStack:
                        stack = new ArrayStack<T>(capacity);
                        break;
                    case StackType.LinkedStack:
                        stack = new LinkedStack<T>();
                        break;
                }
            }
            #endregion

            #region Function 1-2. 매개변수가 있을 경우
            if (initialData != null)
            {
                Console.WriteLine("-> Function 1-2. 매개변수가 있을 경우");
                switch (stackType)
                {
                    case StackType.ArrayStack:
                        stack = new ArrayStack<T>(capacity, initialData);
                        break;
                    case StackType.LinkedStack:
                        stack = new LinkedStack<T>(initialData);
                        break;
                }
            }
            #endregion

            Console.WriteLine($"초기 헤더값: {(initialData != null ? initialData : null)}");
        }

        public void PushTest(T newData)
        {
            Console.WriteLine("-> Function 1. 단일 추가");

            stack.Push(newData);
            Console.WriteLine($"추가된 값: {newData}");
        }

        [Obsolete("미구현")]
        public void PeekTest()
        {
            return;
        }

        [Obsolete("미구현")]
        public void PopTest()
        {
            return;
        }
        #endregion
    }
}
