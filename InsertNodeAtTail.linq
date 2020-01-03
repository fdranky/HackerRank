<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data) 
{
    if (head == null)
    {
        return new SinglyLinkedListNode(data);
    }
    
    head.next = insertNodeAtTail(head.next, data);
    return head;
}