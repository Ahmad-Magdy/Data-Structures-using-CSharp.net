using System;

class QNode
{
    public QNode Next;
    public object Data { get; set; }

    public QNode()
    {
        Next = null;
    }

    public QNode(object value)
    {
        Next = null;
        Data = value;
    }

}

class QQueue
{
    private int count;
    QNode front, rear;
    public QQueue()
    {
        count = 0;
        front = null;
        rear = null;
    }

    public bool isEmpty()
    {
        if (front == null && rear == null)
            return true;
        return false;
    }

    public void EnQueue(object value)
    {
        QNode node = new QNode(value);
        if (isEmpty())
        {
            front = rear = node;
        }
        else
        {
            rear.Next = node;
            rear = node;
        }
        count++;
    }

    public QNode DeQueue()
    {
        if (isEmpty())
            return null;
        else
        {
            QNode node = front;
            front = front.Next;
            count--;
            return node;
        }
    }

    public QNode Peak()
    {
        if (isEmpty())
            return null;
        return rear;
    }

    public void PrintAll()
    {
        QNode current = front;
        while(current!=null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
    
    }
}