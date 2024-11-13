using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.LinearStructures
{
    /// <summary>
    /// 선형 자료구조 인터페이스
    /// </summary>
    /// <typeparam name="T">매개 타입</typeparam>
    public interface ILinearable<T>
    {
        /// <summary>
        /// 단일 삽입
        /// </summary>
        /// <param name="newData"></param>
        /// <param name="index"></param>
        public void Insert(T newData, int index);

        /// <summary>
        /// 단일 검색
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T Search(int index);

        /// <summary>
        /// 단일 삭제
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T Delete(int index);

        /// <summary>
        /// 인덱스 유효성 검사
        /// </summary>
        /// <returns></returns>
        public bool CheckIndex(int index);
    }

    public interface INodeAvailable<T>
    {
        /// <summary>
        /// 단일 검색
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public AbstractNode<T> SearchNode(int index);

        /// <summary>
        /// Header null여부 검사
        /// </summary>
        /// <returns></returns>
        public bool CheckIsHeaderNull(AbstractNode<T>? header);
    }
}
