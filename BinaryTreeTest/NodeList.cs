/****************************** Module Header ******************************\

Module Name:  NodeList.cs
Project:      BFS-Queue
Author:       Jerold Senff
Created:      09/15/2015
Updated:      03/20/2018

BFS-Queue:
Project creates an integer binary tree to test the output from five
tree traversal methods against expected values.

\***************************************************************************/

using System.Collections.ObjectModel;

namespace BFS_Queue
{
    public class NodeList<T> : Collection<Node<T>>
    {
        public NodeList() : base() { }

        public NodeList(int initialSize)
        {
            for (int i = 0; i < initialSize; i++)
                Items.Add(default(Node<T>));
        }
    }
}
