using Structure_And_Algorithm.Structure.LinkedList;
using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SinglyLinkedList list = new();
            //Console.WriteLine("Hello World!");

            object[] objects = new object[5] { 1, 2, 3, 4, 5 };

            // 특정 값 삽입
            list.AppendAll(objects);

            // 특정 값 삽입
            //list.Insert(10, 0);
            //list.Insert(100, 3);
            list.Insert(10, 5);

            // 특정 값 검색
            LinkedListNode searchedNode = (LinkedListNode)list.Search(0);
            Console.WriteLine($"{searchedNode.Data}");

            // 특정 값 삭제
            list.Delete(0);

            // 리스트 출력
            list.Traversal();
        }
    }
}
