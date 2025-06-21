using System;
using System.Xml.Linq;

namespace Graph
{
	public static class LowestCommonAncestor
    {

        //Given a binary tree and two nodes p and q, return their lowest common ancestor(LCA).
        //The LCA of two nodes is the lowest node in the tree that has both p and q as descendants.

        //       3
        //      / \
        //     5   1
        //    / \ / \
        //   6  2 0  8
        //     / \
        //    7   4
        //❓ ex:
        //p = 5, q = 1 → LCA = 3

        //p = 5, q = 4 → LCA = 5

        //TreeNode root = new TreeNode(3);
        //TreeNode p = new TreeNode(5);
        //TreeNode q = new TreeNode(4);

        public static TreeNode GetLowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null) return new TreeNode();
            if (root == p || root == q) return root;

            var left = GetLowestCommonAncestor(root.left, p, q);
            var right = GetLowestCommonAncestor(root.right, p, q);

            if(left != null && right != null)
            {
                return root;
            }

            return left ?? right;
        }
    }
}

