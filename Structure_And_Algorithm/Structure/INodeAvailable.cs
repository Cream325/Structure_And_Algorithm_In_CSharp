using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure
{
    public interface INodeAvailable<T>
    {
        /// <summary>
        /// 단일 노드 검색
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public AbstractNode<T>? SearchNode(int index);

        /// <summary>
        /// 단일 노드 삭제
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public AbstractNode<T>? DeleteNode(int index);

        /// <summary>
        /// Header null여부 검사
        /// </summary>
        /// <returns></returns>
        public bool CheckIsHeaderNull(AbstractNode<T>? header);
    }
}
