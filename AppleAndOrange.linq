<Query Kind="Program" />

void Main()
{
	
}

static void countApplesAndOranges
    (int s, int t, int appleTree, int orangeTree, int[] apples, int[] oranges) 
{
    // Could extract method
    int applesOnHouse = 0;
    for (int i = 0; i < apples.Length; i++)
    {
        int apple = apples[i] + appleTree;
        if (s <= apple && apple <= t) applesOnHouse++;
    }

    int orangesOnHouse = 0;
    for (int j = 0; j < oranges.Length; j++)
    {
        int orange = oranges[j] + orangeTree;
        if (s <= orange && orange <= t) orangesOnHouse++;
    }

    Console.WriteLine(applesOnHouse);
    Console.WriteLine(orangesOnHouse);
}
// Define other methods and classes here
