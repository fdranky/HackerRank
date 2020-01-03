<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static SinglyLinkedListNode deleteNode(SinglyLinkedListNode head, int position) {
    if (position == 0) { return head.next; }
    head.next = deleteNode(head.next, position - 1);
    return head;
}