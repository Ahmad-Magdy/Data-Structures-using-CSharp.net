using System;

class SNode
{
    public object value { get; set; }
    public SNode next;
    public SNode()
    {
        next = null;
    }
}

class MyStack
{
    public SNode Top;
    public int count;

    public MyStack()
    {
        Top = null;
        count = 0;
    }

    public void Push(object value)
    {
        SNode node = new SNode();
        node.value = value;
        if (Top == null)
        {
            Top = node;
            node.next = null;
        }
        else
        {
            node.next = Top;
            Top = node;
        }
        count++;
    }

    public object POP()
    {
        SNode node = null;
        if (Top == null)
        {
            Console.WriteLine("Stack is Empty");
        }
        else
        {
            node = Top;
            Top = Top.next;
            count--;
        }
        return node.value;
    }

    public object Peek()
    {
        if (Top == null)
        {
            Console.WriteLine("Stack is empty");
            return null;
        }
        else
            return Top.value;
    }
    
    public void PrintAll()
    {
        if (Top == null)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            SNode current=Top;

            while(current!=null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }

    }

    public bool isEmpty()
    {
        if (Top == null)
            return true;
        else
            return false;
    }
}