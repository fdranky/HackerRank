<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static void reversePrint(SinglyLinkedListNode head) 
{
    if (head == null) { return; }
    // Use the call stack.
    reversePrint(head.next);
    Console.WriteLine(head.data);
}