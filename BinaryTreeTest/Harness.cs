/****************************** Module Header ******************************\

Module Name:  Harness.cs
Project:      BFS-Queue
Author:       Jerold Senff
Created:      09/15/2015
Updated:      03/20/2018

BFS-Queue:
Project creates an integer binary tree to test the output from five
tree traversal methods against expected values.

\***************************************************************************/

using System;
using System.Text;

namespace BFS_Queue
{
    class Harness
    {
        static void Main(string[] args)
        {
            int selection = 0;

            BinaryTree<int> btree = BuildTree.CreateTestTree();

            do
            {
                Console.Clear();
                Console.WriteLine("\n\nWelcome to Binary Tree Traversals!");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("\n    For a sample binary tree of shape:");
                Console.WriteLine("");
                Console.WriteLine("                  1");
                Console.WriteLine("                 / \\");
                Console.WriteLine("                2   3");
                Console.WriteLine("               / \\   \\");
                Console.WriteLine("              4   5   6");
                Console.WriteLine("");
                Console.WriteLine("\n\t Traversal Test Menu");
                Console.WriteLine("\t------------------------");
                Console.WriteLine("\n\t 1. Level-by-level");
                Console.WriteLine("\n\t 2. Depth-first");
                Console.WriteLine("\n\t 3. Preorder");
                Console.WriteLine("\n\t 4. Inorder");
                Console.WriteLine("\n\t 5. Postorder");
                Console.WriteLine("\n\nPlease enter your choice (1-4) or 9 to exit...\n");

                if (Int32.TryParse(Console.ReadLine(), out selection))
                {
                    SwitchToSelection(selection, btree);
                }
                else
                {
                    Console.WriteLine("Please enter a number...");
                }
            } while (selection != 9);
        }

        public static void SwitchToSelection(int input, BinaryTree<int> btree)
        {
            try
            {
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\nBeginning Level-By-Level Traversal test...\n\n");
                        Console.WriteLine("\nMethod output: \n");

                        StringBuilder levelResult = new StringBuilder();
                        Traversals.LevelByLevelTraversal(btree.Root, levelResult);

                        string levelExpected = "1 2 3 4 5 6";
                        Console.WriteLine("\n\n\nExpected output: \n");
                        Console.WriteLine(levelExpected);

                        if (levelExpected.ToString() == levelResult.ToString().Trim(' '))
                            Console.WriteLine("\n\nPASS! Outputs match!!");
                        else
                            Console.WriteLine("\n\nFAIL! Outputs do not match!!");

                        Continue();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("\nBeginning Depth-First Traversal test...\n\n");
                        Console.WriteLine("\nTest method output: \n");

                        StringBuilder depthResult = new StringBuilder();
                        Traversals.PreorderTraversal(btree.Root, depthResult);

                        string depthExpected = "1 2 4 5 3 6";
                        Console.WriteLine("\n\n\nExpected output: \n");
                        Console.WriteLine(depthExpected);

                        if (depthExpected.ToString() == depthResult.ToString().Trim(' '))
                            Console.WriteLine("\n\nPASS! Outputs match!!");
                        else
                            Console.WriteLine("\n\nFAIL! Outputs do not match!!");

                        Continue();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("\nBeginning Preorder Traversal test...\n\n");
                        Console.WriteLine("\nTest method output: \n");

                        StringBuilder preResult = new StringBuilder();
                        Traversals.PreorderTraversal(btree.Root, preResult);

                        string preExpected = "1 2 4 5 3 6";
                        Console.WriteLine("\n\n\nExpected output: \n");
                        Console.WriteLine(preExpected);

                        if (preExpected.ToString() == preResult.ToString().Trim(' '))
                            Console.WriteLine("\n\nPASS! Outputs match!!");
                        else
                            Console.WriteLine("\n\nFAIL! Outputs do not match!!");

                        Continue();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("\nBeginning Inorder Traversal test...\n\n");
                        Console.WriteLine("\nTest method output: \n");

                        StringBuilder inResult = new StringBuilder();
                        Traversals.InorderTraversal(btree.Root, inResult);

                        string inExpected = "4 2 5 1 3 6";
                        Console.WriteLine("\n\n\nExpected output: \n");
                        Console.WriteLine(inExpected);

                        if (inExpected.ToString() == inResult.ToString().Trim(' '))
                            Console.WriteLine("\n\nPASS! Outputs match!!");
                        else
                            Console.WriteLine("\n\nFAIL! Outputs do not match!!");

                        Continue();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("\nBeginning Postorder Traversal test...\n\n");
                        Console.WriteLine("\nTest method output: \n");

                        StringBuilder postResult = new StringBuilder();
                        Traversals.PostorderTraversal(btree.Root, postResult);

                        string postExpected = "4 5 2 6 3 1";
                        Console.WriteLine("\n\n\nExpected output: \n");
                        Console.WriteLine(postExpected);

                        if (postExpected.ToString() == postResult.ToString().Trim(' '))
                            Console.WriteLine("\n\nPASS! Outputs match!!");
                        else
                            Console.WriteLine("\n\nFAIL! Outputs do not match!!");

                        Continue();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nFatal error: " + ex.Message);
                Console.WriteLine("  Error data: " + ex.Data);
                Console.WriteLine("  Error source: " + ex.Source);
                Console.WriteLine("\n\nDone!");
                Console.WriteLine("\nPress Enter to exit...");
                Console.ReadLine();
            }
        }

        private static void Continue()
        {
            Console.WriteLine("\n\n\nDone!");
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
