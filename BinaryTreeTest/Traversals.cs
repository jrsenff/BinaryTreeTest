/****************************** Module Header ******************************\

Module Name:  Traversals.cs
Project:      BFS-Queue
Author:       Jerold Senff
Created:      09/15/2015
Updated:      12/12/2016

BFS-Queue:
Project creates an integer binary tree to test the output from four
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
            Queue<BinaryTreeNode<int>> queue1 = new Queue<BinaryTreeNode<int>>();
            Queue<BinaryTreeNode<int>> queue2 = new Queue<BinaryTreeNode<int>>();

            queue1.Enqueue(root);

            while (queue1.Count != 0 || queue2.Count != 0)
            {
                while (queue1.Count != 0)
                {
                    BinaryTreeNode<int> u = queue1.Dequeue();

                    Console.Write(u.Value + " ");
                    result.Append(u.Value + " ");

                    if (u.Left != null)
                        queue2.Enqueue(u.Left);
                    if (u.Right != null)
                        queue2.Enqueue(u.Right);

                    while (queue2.Count != 0)
                    {
                        BinaryTreeNode<int> v = queue2.Dequeue();

                        Console.Write(v.Value + " ");
                        result.Append(v.Value + " ");

                        if (v.Left != null)
                            queue1.Enqueue(v.Left);
                        if (v.Right != null)
                            queue1.Enqueue(v.Right);
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
