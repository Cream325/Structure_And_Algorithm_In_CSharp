using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Nodes
{
    public abstract class AbstractNode<T>
    {
        #region Member Fields
        private T? data;

        /// <summary>
        /// 노드들을 담아둔 리스트
        /// </summary>
        protected AbstractNode<T>?[] nodes;
        #endregion

        #region Properties
        /// <summary>
        /// 노드 데이터
        /// </summary>
        public T? Data { get => data; }
        #endregion

        #region Constructors
        public AbstractNode(T newData)
        {
            data = newData;
        }
        #endregion
    }
}
