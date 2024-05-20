using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Tree
{
    public class LCRSTree : AbstractLCRSTree
    {
        public LCRSTree(TreeNode rootNode)
        {
            RootNode = rootNode;
        }

        public override void Insert(TreeNode parentNode, TreeNode newNode)
        {
            if(parentNode.ChildNode == null)
            {
                parentNode.ChildNode = newNode;
            }
            else
            {
                TreeNode tempNode = parentNode.ChildNode;
                while(tempNode.SiblingNode != null)
                {
                    tempNode = tempNode.SiblingNode;
                }

                tempNode.SiblingNode = newNode;
            }
        }

        public override void Delete()
        {
            Delete(RootNode);
        }

        private void Delete(TreeNode node)
        {
            if(node.ChildNode != null)
            {
                Delete(node.ChildNode);
            }

            if(node.SiblingNode != null)
            {
                Delete(node.SiblingNode);
            }

            node.ChildNode = null;
            node.SiblingNode = null;

            Console.WriteLine("Deleted: " + node.Data);
        }

        public override void Traversal()
        {
            int depth = 0;
            Traversal(RootNode, depth);
        }

        private void Traversal(TreeNode node, int depth)
        {
            for(int i = 0; i < depth - 1; i++)
            {
                Console.Write("    ");
            }

            if(depth > 0)
            {
                Console.Write("+--");
            }

            Console.WriteLine(node.Data);

            if(node.ChildNode != null)
            {
                Traversal(node.ChildNode, depth + 1);
            }

            if(node.SiblingNode != null)
            {
                Traversal(node.SiblingNode, depth);
            }
        }
    }
}
