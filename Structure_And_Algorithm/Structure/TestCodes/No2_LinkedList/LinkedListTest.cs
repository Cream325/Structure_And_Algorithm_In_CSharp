using Structure_And_Algorithm.Structure.Linear.LinkedList;
using Structure_And_Algorithm.Structure.Linear.Queue;
using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;

namespace Structure_And_Algorithm.Structure.TestCodes.No2_LinkedList
{
    /// <summary>
    /// 링크드 리스트 타입
    /// </summary>
    public enum LinkedListType
    {
        SinglyLinkedList,
        DoublyLinkedList,
        CircularLinkedList
    }

    /// <summary>
    /// 링크드 리스트 테스트코드 클래스
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedListTest<T> : ILinkedListTest<T>
    {
        #region Member Fields
        private AbstractLinkedList<T> list;
        private LinkedListType linkedListType;
        #endregion

        #region Constructors
        public LinkedListTest(LinkedListType linkedListType)
        {
            this.linkedListType = linkedListType;
            string typeInitial = linkedListType == LinkedListType.SinglyLinkedList ? "단일" :
                                 linkedListType == LinkedListType.DoublyLinkedList ? "이중" : "순환";

            Console.WriteLine($"[<{typeInitial} 연결 리스트 테스트>]\n");
        }
        #endregion

        #region Overrides

        public void ConstructorTest(T? initialData = default)
        {
            #region Function 1-1. 매개변수가 없을 경우
            if (initialData == null)
            {
                Console.WriteLine("-> Function 1-1. 매개변수가 없을 경우");
                switch (linkedListType)
                {
                    case LinkedListType.SinglyLinkedList:
                        list = new SinglyLinkedList<T>();
                        break;
                    case LinkedListType.DoublyLinkedList:
                        list = new DoublyLinkedList<T>();
                        break;
                    case LinkedListType.CircularLinkedList:
                        list = new CircularLinkedList<T>();
                        break;
                }
            }
            #endregion

            #region Function 1-2. 매개변수가 있을 경우
            if (initialData != null)
            {
                Console.WriteLine("-> Function 1-2. 매개변수가 있을 경우");
                switch (linkedListType)
                {
                    case LinkedListType.SinglyLinkedList:
                        list = new SinglyLinkedList<T>(initialData);
                        break;
                    case LinkedListType.DoublyLinkedList:
                        list = new DoublyLinkedList<T>(initialData);
                        break;
                    case LinkedListType.CircularLinkedList:
                        list = new CircularLinkedList<T>(initialData);
                        break;
                }
            }
            #endregion

            Console.WriteLine($"초기 헤더값: {(initialData != null ? list.HeadNode.Data : null)}");
        }

        #region Append

        #region Function 1. 단일 추가
        public void AppendTest(T newData)
        {
            Console.WriteLine("-> Function 1. 단일 추가");

            list.Append(newData);
            Console.WriteLine($"추가된 값: {newData}");
        }
        #endregion

        #region Function 2-1. 전체 추가(배열)
        public void AppendTest(T[] newArrayData)
        {
            Console.WriteLine("-> Function 2-1. 전체 추가(배열)");

            list.AppendAll(newArrayData);
            Console.Write($"추가된 값: [ ");
            foreach (T newData in newArrayData)
                Console.Write($"{newData} ");

            Console.WriteLine("]");
        }
        #endregion

        #endregion

        public void InsertTest(T newData, int index)
        {
            #region 동작 테스트
            if (index >= 0 && index <= list.Length-1)
            {
                //Console.WriteLine("-> 동작 테스트");

                #region Function 1-1. 인덱스가 0초과 Length-1미만일 때
                if (index > 0 && index < list.Length - 1)
                    Console.WriteLine("-> Function 1-1. 인덱스가 0초과 Length-1미만일 때");
                #endregion

                #region Function 1-2. 인덱스가 0일 때
                if (index == 0)
                    Console.WriteLine("-> Function 1-2. 인덱스가 0일 때");
                #endregion

                #region Function 1-3. 인덱스가 Length-1일 때
                if (index == list.Length - 1)
                    Console.WriteLine("-> Function 1-3. 인덱스가 Length-1일 때");
                #endregion
            }

            #endregion

            #region 예외처리 테스트
            //Console.WriteLine("-> 예외처리 테스트");

            #region Exception 1. 헤더가 null일 때
            if (list.HeadNode == null)
                Console.WriteLine("-> Exception 1. 헤더가 null일 때");
            #endregion

            #region Exception 2-1. 인덱스가 0미만일 때
            if (index < 0)
                Console.WriteLine("-> Exception 2-1. 인덱스가 0미만일 때");
            #endregion

            #region Exception 2-2. 인덱스가 Length-1초과일 때
            if (index > list.Length - 1)
                Console.WriteLine("-> Exception 2-2. 인덱스가 Length-1초과일 때");
            #endregion

            #endregion

            list.Insert(newData, index);
            Console.WriteLine($"인덱스: {index}");
            Console.WriteLine($"삽입된 값: {newData}");
        }

        public void SearchTest(int index)
        {
            #region 동작 테스트
            if (index >= 0 && index <= list.Length-1)
            {
                //Console.WriteLine("-> 동작 테스트");

                #region Function 1-1. 인덱스가 0초과 Length-1미만일 때
                if (index > 0 && index < list.Length - 1)
                    Console.WriteLine("-> Function 1-1. 인덱스가 0초과 Length-1미만일 때");
                #endregion

                #region Function 1-2. 인덱스가 0일 때
                if (index == 0)
                    Console.WriteLine("-> Function 1-2. 인덱스가 0일 때");
                #endregion

                #region Function 1-3. 인덱스가 Length-1일 때
                if (index == list.Length - 1)
                    Console.WriteLine("-> Function 1-3. 인덱스가 Length-1일 때");
                #endregion
            }

            #endregion

            #region 예외처리 테스트
            //Console.WriteLine("-> 예외처리 테스트");

            #region Exception 1. 헤더가 null일 때
            if (list.HeadNode == null)
                Console.WriteLine("-> Exception 1. 헤더가 null일 때");
            #endregion

            #region Exception 2-1. 인덱스가 0미만일 때
            if (index < 0)
                Console.WriteLine("-> Exception 2-1. 인덱스가 0미만일 때");
            #endregion

            #region Exception 2-2. 인덱스가 Length-1초과일 때
            if (index > list.Length-1)
                Console.WriteLine("-> Exception 2-2. 인덱스가 Length-1초과일 때");
            #endregion

            #endregion

            CustomLinkedListNode<T>? searchedNode = list.Search(index);
            Console.Write($"검색된 노드 값: {(searchedNode != null ? searchedNode.Data : null)}");
            Console.WriteLine();
        }

        public void DeleteTest(int index)
        {
            #region 동작 테스트
            if (index >= 0 && index <= list.Length - 1)
            {
                //Console.WriteLine("-> 동작 테스트");

                #region Function 1-1. 인덱스가 0초과 Length-1미만일 때
                if (index > 0 && index < list.Length - 1)
                    Console.WriteLine("-> Function 1-1. 인덱스가 0초과 Length-1미만일 때");
                #endregion

                #region Function 1-2. 인덱스가 0일 때
                if (index == 0)
                    Console.WriteLine("-> Function 1-2. 인덱스가 0일 때");
                #endregion

                #region Function 1-3. 인덱스가 Length-1일 때
                if (index == list.Length-1)
                    Console.WriteLine("-> Function 1-3. 인덱스가 Length-1일 때");
                #endregion

            }
            #endregion

            #region 예외처리 테스트
            //Console.WriteLine("-> 예외처리 테스트");

            #region Exception 1. 헤더가 null일 때
            if (list.HeadNode == null)
                Console.WriteLine("-> Exception 1. Header가 null일 때");
            #endregion

            #region Exception 2-1. 인덱스가 0미만일 때
            if (index < 0)
                Console.WriteLine("-> Exception 2-1. 인덱스가 0미만일 때");
            #endregion

            #region Exception 2-2. 인덱스가 Length-1초과일 때
            if (index > list.Length-1)
                Console.WriteLine("-> Exception 2-2. 인덱스가 Length-1초과일 때");
            #endregion

            #endregion

            CustomLinkedListNode<T>? deletedNode = list.Delete(index);
            Console.WriteLine($"인덱스: {index}");
            Console.WriteLine($"삭제된 노드 값: {(deletedNode != null ? deletedNode.Data : null)}");
        }

        public void PrintTest()
        {
            #region 예외처리 테스트

            #region Exception 1. 헤더가 null일 때
            if (list.HeadNode == null)
                Console.WriteLine("-> Exception 1. Header가 null일 때");
            #endregion

            #endregion

            Console.Write("현재 리스트: ");
            list.Traversal();
            Console.WriteLine();
        }

        #endregion
    }

    /// <summary>
    /// 링크드 리스트 테스트코드 빌더
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedListTestBuilder<T>
    {
        #region Member Fields
        private static LinkedListTest<T>? testCodes;

        /// <summary>
        /// 테스트코드를 담는 큐
        /// </summary>
        private static LinkedQueue<Action>? actions;
        #endregion

        #region Public Functions

        /// <summary>
        /// 테스트코드 생성
        /// </summary>
        /// <param name="type"></param>
        /// <param name="initialData"></param>
        /// <returns></returns>
        public static LinkedListTestBuilder<T> CreateTest(LinkedListType type, T? initialData = default)
        {
            LinkedListTestBuilder<T> builder = new();
            testCodes = new(type);
            actions = new();

            actions.Enqueue(() =>
            {
                testCodes.ConstructorTest(initialData);
            });

            return builder;
        }

        #region Append
        /// <summary>
        /// 추가(Append) 테스트코드 추가
        /// </summary>
        /// <param name="newData"></param>
        /// <returns></returns>
        public LinkedListTestBuilder<T> AddAppendTest(T newData)
        {
            actions.Enqueue(() =>
            {
                testCodes.AppendTest(newData);
            });

            return this;
        }

        /// <summary>
        /// 추가(Append) 테스트코드 추가
        /// </summary>
        /// <param name="newDatas"></param>
        /// <returns></returns>
        public LinkedListTestBuilder<T> AddAppendTest(T[] newDatas)
        {
            actions.Enqueue(() =>
            {
                testCodes.AppendTest(newDatas);
            });

            return this;
        }
        #endregion

        /// <summary>
        /// 삽입(Insert) 테스트코드 추가
        /// </summary>
        /// <param name="newData"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public LinkedListTestBuilder<T> AddInsertTest(T newData, int index)
        {
            actions.Enqueue(() =>
            {
                testCodes.InsertTest(newData, index);
            });

            return this;
        }

        /// <summary>
        /// 검색(Search) 테스트코드 추가
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public LinkedListTestBuilder<T> AddSearchTest(int index)
        {
            actions.Enqueue(() =>
            {
                testCodes.SearchTest(index);
            });

            return this;
        }

        /// <summary>
        /// 삭제(Delete) 테스트코드 추가
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public LinkedListTestBuilder<T> AddDeleteTest(int index)
        {
            actions.Enqueue(() =>
            {
                testCodes.DeleteTest(index);
            });

            return this;
        }

        /// <summary>
        /// 출력(Print) 테스트코드 추가
        /// </summary>
        /// <returns></returns>
        public LinkedListTestBuilder<T> AddPrintTest()
        {
            actions.Enqueue(() =>
            {
                testCodes.PrintTest();
            });

            return this;
        }

        /// <summary>
        /// 테스트
        /// </summary>
        public void Test()
        {
            if (actions.Peek() != null)
            {
                int length = actions.Length;
                Action? lastAction = null;

                for(int i = 0; i < length; i++)
                {
                    Action item = actions.Dequeue().Data;

                    if (!string.Equals(item?.Method.Name, lastAction?.Method.Name))
                    {
                        if(lastAction != null)
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

            else if (methodName.Contains("AddAppendTest"))
                Console.WriteLine("[추가(Append) 테스트]");
            
            else if (methodName.Contains("AddInsertTest"))
                Console.WriteLine("[삽입(Insert) 테스트]");
            
            else if (methodName.Contains("AddSearchTest"))
                Console.WriteLine("[검색(Search) 테스트]");
            
            else if (methodName.Contains("AddDeleteTest"))
                Console.WriteLine("[삭제(Delete) 테스트]");
            
            else if (methodName.Contains("AddPrintTest"))
                Console.WriteLine("[출력(Print) 테스트]");
            }
        #endregion
    }
}
