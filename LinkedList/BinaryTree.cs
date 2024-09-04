using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class BinaryTree
    {
        private TreeNode root;

        public BinaryTree()
        {
            root = null;
        }

        public void Insert(int value)
        { 
            root = InserRec(root, value);
        }
        private TreeNode InserRec(TreeNode node, int value)
        { 
            if(node == null)
            {
                node = new TreeNode(value);
                return node;
            }

            if(value < node.Value)
            {
                node.left = InserRec(node.left, value);
            }
            else
            {
                node.right = InserRec(node.right, value);
            }
            return node;
        }


        public bool Find(int value)
        {
            return FindRec(root, value);
        }
        private bool FindRec(TreeNode node, int value)
        {
            if (node == null)
            {
                return false;
            }
            if (value == root.Value)
            {
                return true;
            }
            if(value < node.Value)
            {
                return FindRec(node.left, value);
            }
            else
            {
                return FindRec(node.right, value);
            }

        }

        
        public int? getMin()
        {
           return getMin(root);
        }
        private int? getMin(TreeNode node)
        {
            if(node == null) { return null; }

            int? min = node.Value;

            while (node.left != null)
            {
                min = node.left.Value;
                node = node.left;
            }
            return min;
        }


        public int? getMax()
        {
            return getMax(root);
        }
        private int? getMax(TreeNode node)
        {
            if (node == null) { return null; }

            int? max = node.Value;

            while (node.right != null)
            {
                max = node.right.Value;
                node = node.right;
            }
            return max;
        }
    }
}
