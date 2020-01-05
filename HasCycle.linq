<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static bool hasCycle(SinglyLinkedListNode head) {
    if (head == null) 
    {
        return false;
    } 

    if (head.data != 0)
    {
        head.data = 0;
        return hasCycle(head.next);
    } 
        
    return true;
}