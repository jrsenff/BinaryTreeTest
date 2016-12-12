/****************************** Module Header ******************************\

Module Name:  BinaryTreeNode.cs
Project:      BFS-Queue
Author:       Jerold Senff
Created:      09/15/2015
Updated:      12/12/2016

BFS-Queue:
Project creates an integer binary tree to test the output from four
tree traversal methods against expected values.

\***************************************************************************/

namespace BFS_Queue
{
    public class BinaryTreeNode<T> : Node<T>
    {
        public BinaryTreeNode() : base() { }
        public BinaryTreeNode(T data) : base(data, null) { }
        public BinaryTreeNode(T data, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            Value = data;
            NodeList<T> children = new NodeList<T>(2);
            children[0] = left;
            children[1] = right;

            Neighbors = children;
        }

        public BinaryTreeNode<T> Left
        {
            get
            {
                if (Neighbors == null)
                    return null;
                else
                    return (BinaryTreeNode<T>)Neighbors[0];
            }
            set
            {
                if (Neighbors == null)
                    Neighbors = new NodeList<T>(2);

                Neighbors[0] = value;
            }
        }

        public BinaryTreeNode<T> Right
        {
            get
            {
                if (Neighbors == null)
                    return null;
                else
                    return (BinaryTreeNode<T>)Neighbors[1];
            }
            set
            {
                if (Neighbors == null)
                    Neighbors = new NodeList<T>(2);

                Neighbors[1] = value;
            }
        }
    }
}
