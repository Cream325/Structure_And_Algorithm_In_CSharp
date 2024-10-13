using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.NonLinear.Tree.Basic
{
    public abstract class AbstractTree<T>
    {
        private CustomTreeNode<T>? rootNode;

        public CustomTreeNode<T>? RootNode { get => rootNode; set => rootNode = value; }

        #region Abstract Methods

        #region Insert
        /// <summary>
        /// 트리 - 단일 삽입
        /// </summary>
        /// <param name="parentNode"></param>
        /// <param name="newNode"></param>
        public abstract void Insert(CustomTreeNode<T> parentNode, CustomTreeNode<T> newNode);
        #endregion

        #region Delete
        /// <summary>
        /// 트리 - 단일 삭제
        /// </summary>
        public abstract void Delete();
        #endregion

        #region Traversal
        /// <summary>
        /// 트리 - 순회
        /// </summary>
        public abstract void Traversal();
        #endregion

        #endregion
    }
}
