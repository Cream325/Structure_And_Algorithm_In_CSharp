using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.TestCodes.No2_LinkedList
{
    /// <summary>
    /// 링크드 리스트 테스트코드 인터페이스
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ILinkedListTest<T>
    {
        /// <summary>
        /// 생성자(Constructor) 테스트
        /// </summary>
        /// <param name="initialData"></param>
        public void ConstructorTest(T? initialData);

        /// <summary>
        /// 추가(Append) 테스트
        /// </summary>
        /// <param name="newData"></param>
        public void AppendTest(T newData);

        /// <summary>
        /// 삽입(Insert) 테스트
        /// </summary>
        /// <param name="newData"></param>
        /// <param name="index"></param>
        public void InsertTest(T newData, int index);

        /// <summary>
        /// 검색(Search) 테스트
        /// </summary>
        /// <param name="index"></param>
        public void SearchTest(int index);

        /// <summary>
        /// 삭제(Delete) 테스트
        /// </summary>
        /// <param name="index"></param>
        public void DeleteTest(int index);

        /// <summary>
        /// 출력(Print) 테스트
        /// </summary>
        public void PrintTest();
    }
}
