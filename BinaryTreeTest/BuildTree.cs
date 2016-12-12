/****************************** Module Header ******************************\

Module Name:  BuildTree.cs
Project:      BFS-Queue
Author:       Jerold Senff
Created:      09/15/2015
Updated:      12/12/2016

BFS-Queue:
Project creates an integer binary tree to test the output from four
tree traversal methods against expected values.

Builds the following integer binary tree structure:

           1
          / \
         2   3
        / \   \
       4   5   6

\***************************************************************************/

namespace BFS_Queue
{
    class BuildTree
    {
        public static BinaryTree<int> CreateTestTree()
        {
            BinaryTree<int> btree = new BinaryTree<int>();
            btree.Root = new BinaryTreeNode<int>(1);
            btree.Root.Left = new BinaryTreeNode<int>(2);
            btree.Root.Right = new BinaryTreeNode<int>(3);

            btree.Root.Left.Left = new BinaryTreeNode<int>(4);
            btree.Root.Left.Right = new BinaryTreeNode<int>(5);

            btree.Root.Right.Right = new BinaryTreeNode<int>(6);
            return btree;
        }
    }
}
