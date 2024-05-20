using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Nodes
{
    public class TreeNode : Node
    {
        #region Member Fields
        private TreeNode childNode;
        private TreeNode siblingNode;
        #endregion

        #region Properties
        public TreeNode ChildNode { get => childNode; set => childNode = value; }
        public TreeNode SiblingNode { get => siblingNode; set => siblingNode = value; }
        #endregion

        public TreeNode(object data) : base(data) { }
    }
}
