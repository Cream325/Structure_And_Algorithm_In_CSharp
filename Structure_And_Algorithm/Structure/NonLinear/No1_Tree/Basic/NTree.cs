using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.NonLinear.Tree.Basic
{
    public class NTree<T> : AbstractNTree<T>
    {
        public NTree(CustomTreeNode<T> rootNode)
        {
            RootNode = rootNode;
        }

        public override void Insert(CustomTreeNode<T> parentNode, CustomTreeNode<T> newNode)
        {
            if (parentNode.LeftNode == null)
            {
                parentNode.LeftNode = newNode;
            }
            else
            {
                CustomTreeNode<T>? tempNode = parentNode.LeftNode;
                while (tempNode.RightNode != null)
                {
                    tempNode = tempNode.RightNode;
                }

                tempNode.RightNode = newNode;
            }
        }

        public override void Delete()
        {
            Delete(RootNode);
        }

        private void Delete(CustomTreeNode<T>? node)
        {
            if (node != null)
            {
                if (node.LeftNode != null)
                {
                    Delete(node.LeftNode);
                }

                if (node.RightNode != null)
                {
                    Delete(node.RightNode);
                }

                node.LeftNode = null;
                node.RightNode = null;

                Console.WriteLine("Deleted: " + node.Data);
            }
        }

        public override void Traversal()
        {
            int depth = 0;
            Traversal(RootNode, depth);
        }

        private void Traversal(CustomTreeNode<T>? node, int depth)
        {
            if (node != null)
            {
                for (int i = 0; i < depth - 1; i++)
                {
                    Console.Write("    ");
                }

                if (depth > 0)
                {
                    Console.Write("+--");
                }

                Console.WriteLine(node.Data);

                if (node.LeftNode != null)
                {
                    Traversal(node.LeftNode, depth + 1);
                }

                if (node.RightNode != null)
                {
                    Traversal(node.RightNode, depth);
                }
            }
        }
    }
}
