<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static int getNode(SinglyLinkedListNode head, int positionFromTail) 
{
    var current = head;
    int index = 0;
    while (head != null)
    {
        if (index > positionFromTail) 
        {
            current = current.next;
        }

        head = head.next;
        index++;
    }

    return current.data;
}