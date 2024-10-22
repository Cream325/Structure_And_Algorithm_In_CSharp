namespace Structure_And_Algorithm.Structure.TestCodes.No3_Stack
{
    /// <summary>
    /// 스택 테스트코드 인터페이스
    /// </summary>
    public interface IStackTest<T>
    {
        /// <summary>
        /// 생성자(Constructor) 테스트
        /// </summary>
        /// <param name="initialData"></param>
        public void ConstructorTest(T? initialData, int capacity);

        /// <summary>
        /// 추가(Push) 테스트
        /// </summary>
        /// <param name="newData"></param>
        public void PushTest(T newData);

        /// <summary>
        /// 검색(Peek) 테스트
        /// </summary>
        public void PeekTest();

        /// <summary>
        /// 삭제(Pop) 테스트
        /// </summary>
        public void PopTest();
    }
}
