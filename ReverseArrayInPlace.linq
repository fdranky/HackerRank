<Query Kind="Program" />

void Main()
{
	
}

static int[] reverseArray(int[] a) 
{
    int arrLen = a.Length - 1;
    int half = a.Length / 2;
    for (int i = 0; i < half; i++) 
    {
        int temp = a[arrLen - i];
        a[arrLen - i] = a[i];
        a[i] = temp;
    }

    return a;
}
// Define other methods and classes here
