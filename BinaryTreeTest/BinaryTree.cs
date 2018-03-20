/****************************** Module Header ******************************\

Module Name:  BinaryTree.cs
Project:      BFS-Queue
Author:       Jerold Senff
Created:      09/15/2015
Updated:      03/20/2018

BFS-Queue:
Project creates an integer binary tree to test the output from five
tree traversal methods against expected values.

\***************************************************************************/

namespace BFS_Queue
{
    public class BinaryTree<T>
    {
        public BinaryTree()
        {
            Root = null;
        }

        public virtual void Clear()
        {
            Root = null;
        }

        public BinaryTreeNode<T> Root { get; set; }
    }
}
