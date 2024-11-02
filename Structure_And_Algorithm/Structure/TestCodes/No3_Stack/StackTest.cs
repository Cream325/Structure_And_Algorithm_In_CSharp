using Structure_And_Algorithm.Structure.Linear.Queue;
using Structure_And_Algorithm.Structure.Linear.Stack;
using Structure_And_Algorithm.Structure.Nodes;
using System.Reflection;

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
        public void ConstructorTest(T? initialData, int capacity)
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
            T? pushedData = default;

            #region 동작 테스트
            //Console.WriteLine("-> 동작 테스트");

            if (!stack.IsFull())
            {
                Console.WriteLine("-> Function 1. 단일 추가");
                pushedData = newData;
            }
            #endregion

            #region 예외처리 테스트
            //Console.WriteLine("-> 예외처리 테스트");

            #region Exception 1. 스택이 가득 차있을 때
            if (stack.IsFull())
                Console.WriteLine("-> Exception 1. 스택이 가득 차있을 때");
            #endregion

            #endregion

            stack.Push(newData);
            Console.WriteLine($"추가된 값: {pushedData}");
        }

        public void PeekTest()
        {
            #region 동작 테스트
            //Console.WriteLine("-> 동작 테스트");

            if(!stack.IsEmpty())
                Console.WriteLine("-> Function 1. 단일 검색");
            #endregion

            #region 예외처리 테스트
            //Console.WriteLine("-> 예외처리 테스트");

            #region Exception 1. 스택이 비어있을 때
            if (stack.IsEmpty())
                Console.WriteLine("-> Exception 1. 스택이 비어있을 때");
            #endregion

            #endregion

            CustomLinkedListNode<T>? searchedNode = stack.Peek();
            Console.WriteLine($"검색된 노드 값: {(searchedNode != null ? searchedNode.Data : null)}");
        }

        public void PopTest()
        {
            #region 동작 테스트
            //Console.WriteLine("-> 동작 테스트");

            if(!stack.IsEmpty())
                Console.WriteLine("-> Function 1. 단일 삭제");
            #endregion

            #region 예외처리 테스트
            //Console.WriteLine("-> 예외처리 테스트");

            #region Exception 1. 스택이 비어있을 때
            if (stack.IsEmpty())
                Console.WriteLine("-> Exception 1. 스택이 비어있을 때");
            #endregion

            #endregion

            CustomLinkedListNode<T>? deletedNode = stack.Pop();
            Console.WriteLine($"삭제된 노드 값: {(deletedNode != null ? deletedNode.Data : null)}");
        }
        #endregion
    }

    public class StackTestBuilder<T>
    {
        #region Member Fields
        private static StackTest<T>? testCodes;

        /// <summary>
        /// 테스트코드를 담는 큐
        /// </summary>
        private static LinkedQueue<Action>? actions;
        #endregion

        #region Public Functions

        #region CreateTest
        /// <summary>
        /// 테스트코드 생성
        /// </summary>
        /// <param name="type"></param>
        /// <param name="initialData"></param>
        /// <param name="capacity"></param>
        /// <returns></returns>
        public static StackTestBuilder<T> CreateTest(StackType type, T? initialData = default, int capacity = 10)
        {
            StackTestBuilder<T> builder = new();
            testCodes = new(type);
            actions = new();

            actions.Enqueue(() =>
            {
                testCodes.ConstructorTest(initialData, capacity);
            });

            return builder;
        }

        /// <summary>
        /// 테스트코드 생성
        /// </summary>
        /// <param name="type"></param>
        /// <param name="capacity"></param>
        /// <returns></returns>
        public static StackTestBuilder<T> CreateTest(StackType type, int capacity = 10)
        {
            return CreateTest(type, default, capacity);
        }
        #endregion

        /// <summary>
        /// 추가(Push) 테스트코드 추가
        /// </summary>
        /// <param name="newData"></param>
        /// <returns></returns>
        public StackTestBuilder<T> AddPushTest(T newData)
        {
            actions.Enqueue(() =>
            {
                testCodes.PushTest(newData);
            });

            return this;
        }

        /// <summary>
        /// 검색(Peek) 테스트코드 추가
        /// </summary>
        /// <returns></returns>
        public StackTestBuilder<T> AddPeekTest()
        {
            actions.Enqueue(() =>
            {
                testCodes.PeekTest();
            });

            return this;
        }

        /// <summary>
        /// 삭제(Pop_ 테스트코드 추가
        /// </summary>
        /// <returns></returns>
        public StackTestBuilder<T> AddPopTest()
        {
            actions.Enqueue(() =>
            {
                testCodes.PopTest();
            });

            return this;
        }

        public void Test()
        {
            if(actions.Peek() != null)
            {
                int length = actions.Length;
                Action? lastAction = null;

                for(int i = 0; i < length; i++)
                {
                    Action item = actions.Dequeue().Data;

                    if(!string.Equals(item?.Method.Name, lastAction?.Method.Name))
                    {
                        if (lastAction != null)
                            Console.WriteLine("\n\n");

                        ShowTestMessage(item?.Method.Name);
                    }

                    item.Invoke();
                    lastAction = item;
                    Console.WriteLine();
                }
            }
        }

        #endregion

        #region Private Functions
        /// <summary>
        /// 테스트 타이틀 출력
        /// </summary>
        /// <param name="methodName"></param>
        private void ShowTestMessage(string methodName)
        {
            if (methodName.Contains("CreateTest"))
                Console.WriteLine("[생성자 테스트]");

            else if (methodName.Contains("AddPushTest"))
                Console.WriteLine("[추가(Push) 테스트]");

            else if (methodName.Contains("AddPeekTest"))
                Console.WriteLine("[검색(Peek) 테스트]");

            else if (methodName.Contains("AddPopTest"))
                Console.WriteLine("[삭제(Pop) 테스트]");
        }
        #endregion
    }
}
