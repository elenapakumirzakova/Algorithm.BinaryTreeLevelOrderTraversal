using System;
using System.Collections.Generic;

namespace Algorithm.BinaryTreeLevelOrderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TreeNode tree3 = new TreeNode(3, null, null);
            TreeNode tree6 = new TreeNode(6, null, null);
            TreeNode tree4 = new TreeNode(4, tree3, tree6);
            TreeNode tree1 = new TreeNode(1, null, null);
            TreeNode tree5 = new TreeNode(5, tree1, tree6);

            LevelOrder(tree5);
        }
        static List<IList<int>> ListNodes = new List<IList<int>>();
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null) return ListNodes;
            ListNodes.Add(new List<int> { root.val });
            AddNodes(root);
            return ListNodes;
        }

        static void AddNodes(TreeNode root)
        {
            if(root != null && (root.left != null || root.right != null))
            {
                var dummyList = new List<int>();

                if (root.left != null) dummyList.Add(root.left.val);
                if (root.right != null) dummyList.Add(root.right.val);
                 
                ListNodes.Add(dummyList);
                AddNodes(root.right);
                AddNodes(root.left);
            }
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
