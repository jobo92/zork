using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>(8);
            TreeNode<int> three = new TreeNode<int>(3);
            TreeNode<int> ten = new TreeNode<int>(10);
            TreeNode<int> one = new TreeNode<int>(1);
            TreeNode<int> six = new TreeNode<int>(6);
            TreeNode<int> fourteen = new TreeNode<int>(14);
            TreeNode<int> four = new TreeNode<int>(4);
            TreeNode<int> seven = new TreeNode<int>(7);
            TreeNode<int> thirteen = new TreeNode<int>(13);

            tree.root.AddChild(three);
            tree.root.AddChild(ten);
            three.AddChild(one);
            three.AddChild(six);
            six.AddChild(four);
            six.AddChild(seven);
            ten.AddChild(fourteen);
            fourteen.AddChild(thirteen);

            tree.BreadthFirstSearch();
            Console.ReadLine();
        }
    }
}
