<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static SinglyLinkedListNode deleteNode(SinglyLinkedListNode head, int position) {
    if (position == 0)
    {
        head = head.next;
        return head;
    }

    var node = head;
    while (position > 1)
    {
        node = node.next;
        position--;
    }

    node.next = node.next.next;
    return head;
}