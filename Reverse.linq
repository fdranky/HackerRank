<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static SinglyLinkedListNode reverse(SinglyLinkedListNode head) 
{
    SinglyLinkedListNode reverseNode = null;
    while (head != null)
    {
        var temp = reverseNode;
        reverseNode = new SinglyLinkedListNode(head.data);
        reverseNode.next = temp;
        head = head.next;
    }

    return reverseNode;
}