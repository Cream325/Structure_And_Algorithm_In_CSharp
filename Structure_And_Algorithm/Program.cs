using Structure_And_Algorithm.Structure.LinearStructures.No1_Array;
using Structure_And_Algorithm.Structure.TestCodes.No2_LinkedList;
using System;

namespace Structure_And_Algorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedListExample();
        }

        private static void LinkedListExample()
        {
            LinkedListTestBuilder<int?>.CreateTest(LinkedListType.SinglyLinkedList, 0)
                                       .AddAppendTest(1)
                                       .AddAppendTest(new int?[] { 2, 3, 4, 5, 6, 7, 8, 9 })

                                       .AddInsertTest(10, 5)
                                       .AddInsertTest(20, 0)
                                       .AddInsertTest(30, 11)
                                       .AddInsertTest(40, -10)
                                       .AddInsertTest(50, 42)

                                       .AddSearchTest(7)
                                       .AddSearchTest(0)
                                       .AddSearchTest(14)
                                       .AddSearchTest(-6)
                                       .AddSearchTest(27)

                                       .AddDeleteTest(3)
                                       .AddDeleteTest(0)
                                       .AddDeleteTest(12)
                                       .AddDeleteTest(-17)
                                       .AddDeleteTest(34)

                                       .AddPrintTest()
                                       .Test();
        }
    }
}
