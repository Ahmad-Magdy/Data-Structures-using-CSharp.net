public class Node<T>
{
    public T data;
    public Node<T> Next;
    public Node()
    {
        Next = null;
    }
    public Node(T _data)
    {
        data = _data;
        Next = null;
    }
}


class MyLinkedList<T>
{
    Node<T> Head, Tail;
    int elementsCount;
    MyLinkedList()
    {
        Head = Tail = null;
        elementsCount = 0;
    }
    ~MyLinkedList()
    {
        Console.Beep();
        Clear();
    }

    private void Clear()
    {
        Head = Tail = null;
    }

    public bool isEmpty()
    {
        //if (Head == null)
        //    return true;
        //else
        //{
        //    return false;
        //}
        return elementsCount == 0;
    }

    public int Count()
    {
        return elementsCount;
    }
    public T at(int pos)
    {
        Node<T> temp = Head;
        for (int i = 0; i < pos; i++)
        {
            temp = temp.Next;
        }
        return temp.data;
    }

    public void Append(T val)
    {
        Node<T> inserted = new Node<T>(val);
        if (isEmpty())
            Head = Tail = inserted;
        else
        {
            Tail.Next = inserted;
            Tail = inserted;
        }
        elementsCount++;
    }

    public void insertAt(int index, T val)
    {
        if (index < 0 || index > elementsCount)
        {
            Console.WriteLine("Error");
            return;
        }

        Node<T> inserted = new Node<T>(val);

        if (index == 0)
        {
            inserted.Next = Head;
            Head = inserted;
        }
        else
        {
            Node<T> Temp = Head;
            for (int i = 0; i < index - 1; i++)
            {
                Temp = Temp.Next;
            }
            Temp.Next = inserted.Next;
            Temp.Next = inserted;
        }
        elementsCount++;
    }

    public void DeleteAt(int index)
    {
        if (index < 0 || index > elementsCount)
        {
            Console.WriteLine("Error");
            return;
        }

        Node<T> deleted;
        T val;
        if (index == 0)
        {
            deleted = Head;
            val = deleted.data;
            Head = Head.Next;
        }
        else
        {
            Node<T> temp = Head;

            for (int i = 0; i < index - 1; i++)
            {
                temp = temp.Next;
            }
            deleted = temp.Next;
            temp.Next = deleted.Next;
            val = deleted.data;
        }
        elementsCount--;

    }
}