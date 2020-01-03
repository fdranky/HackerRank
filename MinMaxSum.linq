<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static void miniMaxSum(int[] arr) 
{
    int min = arr[0];
    int max = arr[0];
    long sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
        if (max < arr[i]) max = arr[i];
        sum += arr[i];
    }

    Console.WriteLine((sum - max) + " " + (sum - min));
}