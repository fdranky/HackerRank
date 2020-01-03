<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static void reversePrint(SinglyLinkedListNode head) 
{
    var stack = new Stack<int>();
    while (head != null) 
    {
        stack.Push(head.data);
        head = head.next;
    }

    while (stack.Count > 0) 
    {
        Console.WriteLine(stack.Pop());
    }
}