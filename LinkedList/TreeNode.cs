using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class TreeNode
    {
        public int? Value {  get; set; }

        public TreeNode left { get; set; }

        public TreeNode right { get; set; }

        public TreeNode(int value)
        {
            Value = value;
            left = null;
            right = null;
        }
    }
}
