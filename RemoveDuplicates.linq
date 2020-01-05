<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static SinglyLinkedListNode removeDuplicates(SinglyLinkedListNode head) {
    while (head.next != null && head.data == head.next.data)
    {
        var current = head.next.next;
        head.next = current;
    }

    if (head != null && head.next != null) 
    {
        removeDuplicates(head.next);
    }
    
    return head;
}