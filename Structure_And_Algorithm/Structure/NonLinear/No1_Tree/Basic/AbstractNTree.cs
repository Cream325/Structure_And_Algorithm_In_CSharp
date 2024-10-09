using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.NonLinear.Tree.Basic
{
    public abstract class AbstractNTree<T>
    {
        private CustomTreeNode<T>? rootNode;

        public CustomTreeNode<T>? RootNode { get => rootNode; set => rootNode = value; }

        #region Abstract Methods

        #region Insert
        public abstract void Insert(CustomTreeNode<T> parentNode, CustomTreeNode<T> newNode);
        #endregion

        #region Delete
        public abstract void Delete();
        #endregion

        #region Traversal
        public abstract void Traversal();
        #endregion

        #endregion
    }
}
