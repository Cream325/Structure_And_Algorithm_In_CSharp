using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Tree
{
    public abstract class AbstractLCRSTree
    {
        private TreeNode rootNode;

        public TreeNode RootNode { get => rootNode; set => rootNode = value; }

        #region Abstract Methods

        #region Insert
        public abstract void Insert(TreeNode parentNode, TreeNode newNode);
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
