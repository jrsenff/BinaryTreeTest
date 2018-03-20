/****************************** Module Header ******************************\

Module Name:  Node.cs
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
using System.Linq;
using System.Text;

namespace BFS_Queue
{
    public class Node<T>
    {
        public Node() { }
        public Node(T data) : this(data, null) { }
        public Node(T data, NodeList<T> neighbors)
        {
            Value = data;
            Neighbors = neighbors;
        }

        public T Value { get; set; }

        protected NodeList<T> Neighbors { get; set; } = null;
    }
}
