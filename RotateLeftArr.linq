<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static void RotateLeftArr(int n, int d, int[] a)
{
    var rotateArr = new int[n];
    int rotation = d % n;
    for (int i = 0; i < n; i++)
    {
        rotateArr[i] = a[(i + rotation) % n]; 
    }

    Console.Write(String.Join(" ", rotateArr));
}