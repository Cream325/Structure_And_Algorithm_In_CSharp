﻿using Structure_And_Algorithm.Structure.LinearStructures.No1_Array;
using Structure_And_Algorithm.Structure.TestCodes.No2_LinkedList;
using System;

namespace Structure_And_Algorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            LinkedListTestBuilder<int?>.CreateTest(LinkedListType.SinglyLinkedList)
                                       .AddAppendTest(0)
                                       .AddAppendTest(new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })

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

                                       .AddDeleteTest(0)

                                       .AddPrintTest()
                                       .Test();
            */

            DynamicArray<int> array = new(10);
            array.Append(0);
            array.AppendAll(new int[] { 1, 2, 3, 4, 5, 6, 8, 9 });
            array.Insert(7, 7);
            Console.WriteLine($"Searching: {array.Search(9)}");
            array.Delete(0);
            array.Traversal();
        }
    }
}
