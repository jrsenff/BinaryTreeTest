/****************************** Module Header ******************************\

Module Name:  Traversals.cs
Project:      BFS-Queue
Author:       Jerold Senff
Created:      09/15/2015
Updated:      03/20/2018

BFS-Queue:
Project creates an integer binary tree to test the output from five
tree traversal methods against expected values.

\***************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace BFS_Queue
{
    class Traversals
    {
        public static StringBuilder LevelByLevelTraversal(BinaryTreeNode<int> root, StringBuilder result)
        {
            Queue<BinaryTreeNode<int>> queue = new Queue<BinaryTreeNode<int>>();

            if (root != null)
            {
                queue.Enqueue(root);

                while (queue.Count > 0)
                {
                    BinaryTreeNode<int> node = queue.Dequeue();

                    Console.Write(node.Value + " ");
                    result.Append(node.Value + " ");

                    if (node.Left != null)
                    {
                        queue.Enqueue(node.Left);
                    }

                    if (node.Right != null)
                    {
                        queue.Enqueue(node.Right);
                    }
                }
            }

            return result;
        }

        public static StringBuilder DepthFirstTraversal(BinaryTreeNode<int> root, StringBuilder result)
        {
            Stack<BinaryTreeNode<int>> stack = new Stack<BinaryTreeNode<int>>();

            if (root != null)
            {
                stack.Push(root);

                while (stack.Count > 0)
                {
                    BinaryTreeNode<int> node = stack.Pop();

                    Console.Write(node.Value + " ");
                    result.Append(node.Value + " ");

                    if (node.Left != null)
                    {
                        stack.Push(node.Left);
                    }

                    if (node.Right != null)
                    {
                        stack.Push(node.Right);
                    }
                }
            }

            return result;
        }

        public static void PostorderTraversal(BinaryTreeNode<int> current, StringBuilder result)
        {
            if (current != null)
            {
                if (current.Left != null)
                {
                    PostorderTraversal(current.Left, result);
                }
                if (current.Right != null)
                {
                    PostorderTraversal(current.Right, result);
                }

                Console.Write(current.Value + " ");
                result.Append(current.Value + " ");
            }
        }

        public static void InorderTraversal(BinaryTreeNode<int> current, StringBuilder result)
        {
            if (current != null)
            {
                if (current.Left != null)
                {
                    InorderTraversal(current.Left, result);
                }

                Console.Write(current.Value + " ");
                result.Append(current.Value + " ");

                if (current.Right != null)
                {
                    InorderTraversal(current.Right, result);
                }
            }
        }

        public static void PreorderTraversal(BinaryTreeNode<int> current, StringBuilder result)
        {
            if (current != null)
            {
                Console.Write(current.Value + " ");
                result.Append(current.Value + " ");

                if (current.Left != null)
                {
                    PreorderTraversal(current.Left, result);
                }
                if (current.Right != null)
                {
                    PreorderTraversal(current.Right, result);
                }
            }
        }
    }
}
