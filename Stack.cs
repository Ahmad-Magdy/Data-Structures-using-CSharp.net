using System;
//Node Class
class SNode
{
    public object value { get; set; } // property take the value from the user 
    public SNode next; // Pointer to the next element
    public SNode()
    {
        next = null;
    }
}

//Stack Class
class MyStack
{
    public SNode Top;
    public int count;
    //Contractor set Top = null and count=0
    public MyStack()
    {
        Top = null;
        count = 0;
    }

    //Push to add elements to Stack
    public void Push(object value)
    {
        //take value from user and add it to a new Node
        SNode node = new SNode();
        node.value = value;
        //if stack is empty
        if (Top == null)
        {
            //set top element is this inserted node
            Top = node;
            node.next = null;
        }
        else
        {
            //else make this element at the top and point the next element
            node.next = Top;
            Top = node;
        }
        //incease the counter by one
        count++;
    }

    //POP to remove elements and return its value
    public object POP()
    {
        //create object from SNode will contain the value of removed element
        SNode node = null;
        //if stack empty print message 
        if (Top == null)
        {
            Console.WriteLine("Stack is Empty");
        }
        else
        {
            /*
            else make node equal to top 
            and top = top.next this make the top elemetn is the next to the top
            and decrease count by one
            */
            node = Top;
            Top = Top.next;
            count--;
        }
        //return the value of removed node
        return node.value;
    }

    //peek return the top element
    public object Peek()
    {
        // if stack empty return null
        if (Top == null)
        {
            Console.WriteLine("Stack is empty");
            return null;
        }
        //else return the value of top
        else
            return Top.value;
    }
    
    //Method to Print all items in the stack
    public void PrintAll()
    {
        //check if stack empty
        if (Top == null)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            //create a new node and set it equal to the top element
            SNode current=Top;
            //while loop , will still work if current != null
            while(current!=null)
            {
                //print the value and every time move to next element
                Console.WriteLine(current.value);
                current = current.next;
            }
        }

    }
    //check if Stack empty or not
    public bool isEmpty()
    {
        if (Top == null)
            return true;
        else
            return false;
    }
}