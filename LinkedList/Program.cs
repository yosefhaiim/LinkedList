using static System.Runtime.InteropServices.JavaScript.JSType;

public class Node
{
    public int Value;
    public Node Next;
    public  Node(int data, Node next)
    {
        int value = data;
        next = null;
    }


    public void getValue(int data)
    {
       Value = data;
    }
    
    public void getNext(Node data)
    {
        Next = data;
    }
    

    public void setValue(int data)
    {
        Value = data;
    }
        
    public void setNext(Node data)
    {
        Next = data;
    }    
}







public class LinkedList: Node
{
    private Node head;

    public LinkedList()
    {
        head = null;
    }

    public LinkedList(int data)
    {
        Node node = new Node(data);

    }

    // Method to add to  the end of the list
    public void Add(int data)
    {
        if (head == null)
        {
            head = new Node(data);
        }
        Node thisNode = head;
        while(thisNode.next != null)
        {

        }
    }


    public void Display()
    {
        //1-> 2-> 5-> - 5-> 5

    }

    public int Length()
    {
        int count = 0;
        Node thisNode = head;
        while (thisNode.next != null)
        {

        }
        return count;
    }

    // Method to remove the first value
    public void RemoveValue(data)
    {

    }

    // Method to remove the first value
    public void RemoveAllValues(data)
    {

    }

    // Method to remove the value in an index
    public void RemoveIndex(int data)
    {

    }

    // Method to find by value
    public Find(data)
    {

    }

    // Method to get a value by  index
    public Get(data)
    {

    }
}