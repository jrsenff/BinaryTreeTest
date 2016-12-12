/****************************** Module Header ******************************\

Module Name:  Node.cs
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
using System.Linq;
using System.Text;

namespace BFS_Queue
{
    public class Node<T>
    {
        private T data;
        private NodeList<T> neighbors = null;

        public Node() { }
        public Node(T data) : this(data, null) { }
        public Node(T data, NodeList<T> neighbors)
        {
            this.data = data;
            this.neighbors = neighbors;
        }

        public T Value
        {
            get { return data; }
            set { data = value; }
        }

        protected NodeList<T> Neighbors
        {
            get { return neighbors; }
            set { neighbors = value; }
        }
    }
}
