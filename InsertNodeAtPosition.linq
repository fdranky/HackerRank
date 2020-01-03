<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode head, int data, int position) 
{
    if (position == 0) 
    {
        var first = new SinglyLinkedListNode(data);
        first.next = head;
        return first;
    }

    var node = head;
    while (position > 1)
    {
        node = node.next;
        position--;
    }

    var temp = node.next;
    node.next = new SinglyLinkedListNode(data);
    node.next.next = temp;

    return head;
}