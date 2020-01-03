<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static void printLinkedList(SinglyLinkedListNode head) {
    Console.WriteLine(head.data);
    if (head.next != null) 
    {
        printLinkedList(head.next);
    }
}