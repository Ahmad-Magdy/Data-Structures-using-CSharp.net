using System;

class TNode
{
    public int value { get; set; }
    public TNode Right;
    public TNode Left;

    public TNode ()
    {
        Right = Left = null;
    }

    public TNode(int _value)
    {
        Right = Left = null;
        value = _value;
    }
}

class TTree
{
    TNode root;

    public TTree()
    {
        root = null;
    }

    public TNode getRoot()
    {
        return root;
    }

    public bool IsParent(TNode node)
    {
        if (node.Right != null || node.Left != null)
            return true;
        return false;
    }

    public bool IsEmpty()
    {
        return root == null ? true : false;
    }

    public void Insert(int number)
    {
        TNode node = new TNode(number);
        if (root == null)
        {
            root = node;
            Console.WriteLine("node with value '{0}' set as Root", node.value);
        }
        else
        {
            TNode current = root;
            while (true)
            {
                if (number < current.value)
                {
                    if (current.Left == null)
                    {
                        current.Left = node;
                        Console.WriteLine("node with value '{0}' added in the Left", node.value);
                        break;
                    }
                    else
                    {
                        current = current.Left;
                    }
                }
                else
                {
                    if (current.Right == null)
                    {
                        current.Right = node;
                        Console.WriteLine("node with value '{0}' added in the Right", node.value);
                        break;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }

            }
        }
    }

    public void PostOrder(TNode sub)
    {
        if (sub != null)
        {
            PostOrder(sub.Left);
            PostOrder(sub.Right);
            Console.WriteLine(sub.value);
        }
    }

    public void PreOrder(TNode sub)
    {
        if (sub != null)
        {
            Console.WriteLine(sub.value);
            PreOrder(sub.Left);
            PreOrder(sub.Right);
        }
    }

    public void InOrder(TNode sub)
    {
        if (sub != null)
        {
            InOrder(sub.Left);
            Console.WriteLine(sub.value);
            InOrder(sub.Right);
        }
    }

    public TNode Search(int value)
    {
        TNode current = root;
        while (true)
        {
            if (current.value == value)
                return current;
            else if (current.value < value)
                current = current.Right;
            else if (current.value > value)
                current = current.Left;
            else
                return null;
        }
    }

    public bool Search(int value, bool outBoolValue)
    {
        TNode current = root;
        while (current != null)
        {
            if (current.value == value)
                return true;
            else if (value < current.value)
                current = current.Left;
            else
                current = current.Right;
        }
        return false;
    }

    public void GetLargest()
    {
        int last = -1;
        for (TNode node = root; node != null; node = node.Right)
        {
            last = node.value;
        }
        Console.WriteLine("The largest element is {0}", last);
    }

    public void GetSmallest()
    {
        int val = 0;
        TNode current = root;
        while (current != null)
        {
            val = current.value;
            current = current.Left;
        }
        Console.WriteLine("The Smallest element is {0}", val);
    }
}
