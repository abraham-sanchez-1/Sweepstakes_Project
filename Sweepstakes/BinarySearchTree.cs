using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class BinarySearchTree
    {
        //member variable
        Node root;

        //constructor
        public BinarySearchTree()
        {
            root = null;

        }
        //member method
        public void Insert(int data)
        {
            if (root == null)
            {
                root = new Node(data);
                return;
            }

            InsertChooseEnd(data);

        }
        private void InsertChooseEnd(int data)
        {
            Node current = root;
            while (true)
            {
                if (data > current.data)
                {
                    if (current.right == null)
                    {
                        current.right = new Node(data);
                        break;
                    }
                    else
                    {
                        current = current.right;
                    }
                }
                else
                {
                    if (current.left == null)
                    {
                        current.left = new Node(data);
                        break;
                    }
                    else
                    {
                        current = current.left;
                    }
                }
            }

        }
        public void Search(int data)
        {
            if (root == null)
            {
                Console.WriteLine("Value {0} was not found", data);
            }
            else if (root.data == data)
            {
                Console.WriteLine("Value {0} can be found within the binary tree", data);
            }
            else
            {
                SearchSides(data);
            }

        }
        private void SearchSides(int data)
        {
            Node current = root;
            while (true)
            {
                if (data > current.data)
                {
                    if (current.right == null)
                    {
                        Console.WriteLine("Value {0} was not found", data);
                        break;
                    }
                    else if (data == current.right.data)
                    {
                        Console.WriteLine("Value {0} can be found within the binary tree", data);
                        break;
                    }
                    else
                    {
                        current = current.right;
                    }

                }
                else if (data < current.data)
                {
                    if (current.left == null)
                    {
                        Console.WriteLine("Value {0} was not found", data);
                        break;
                    }
                    else if (data == current.left.data)
                    {
                        Console.WriteLine("Value {0} can be found within the binary tree", data);
                        break;
                    }
                    else
                    {
                        current = current.left;
                    }
                }
            }
        }
    }
}
