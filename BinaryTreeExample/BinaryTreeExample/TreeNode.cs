using System;
using System.Collections.Generic;

namespace BinaryTreeExample
{
    public class TreeNode<T>
    {
        public T value;
        public List<TreeNode<T>> children;

        public TreeNode(T value)
        {
            this.value = value;
            children = new List<TreeNode<T>>();
        }
        public void addChild(TreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }
            children.Add(node);
        }
        public void traverse()
        {
            if (value == null)
            {
                return;
            }
            Console.WriteLine(value.ToString());
            foreach (var child in children)
            {
                child.traverse();
            }
        }
        public void search(string str)
        {
            if (value.Equals(str))
            {
                Console.WriteLine("Value found");
                return;
            }
            foreach(var child in children)
            {
                if (child.value.Equals(str))
                {
                    Console.WriteLine("Value found");
                    return;
                }
            }
            Console.WriteLine("Not found");
        }

        public void Delete(TreeNode<T> node)
        {
            if (value == null)
            {
                return;
            }
            children.Remove(node);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            TreeNode<string> root = new TreeNode<string>("Root");
            TreeNode<string> child1 = new TreeNode<string>("Child1");
            TreeNode<string> child2= new TreeNode<string>("Child2");
            root.addChild(child1);
            root.addChild(child2);
            root.traverse();
            TreeNode<string> child3 = new TreeNode<string>("Child3");
            TreeNode<string> child4 = new TreeNode<string>("Child4");
            child2.addChild(child3);
            child2.addChild(child4);
            root.traverse();
            child2.Delete(child3);
            root.traverse();
            root.search("Child2");
        }
    }
}

